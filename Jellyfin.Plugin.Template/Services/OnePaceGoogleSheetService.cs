// FILE: Services/OnePaceGoogleSheetService.cs
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Jellyfin.Plugin.OnePaceDetector.Services;

public sealed class OnePaceGoogleSheetService
{
    private const string SpreadsheetId = "1M0Aa2p5x7NioaH9-u8FyHq6rH3t5s6Sccs8GoC6pHAM";

    // Episodes tab (your link is gid=0)
    private const int EpisodeGid = 0;

    // We auto-detect the Arc Descriptions tab gid by probing tabs until headers match.
    private const int ArcGidProbeMax = 50;

    private static string CsvUrl(int gid)
        => $"https://docs.google.com/spreadsheets/d/{SpreadsheetId}/export?format=csv&gid={gid}";

    private readonly ILogger<OnePaceGoogleSheetService> _logger;
    private readonly HttpClient _http = new();

    private readonly SemaphoreSlim _gate = new(1, 1);

    private DateTime _episodesFetchedUtc = DateTime.MinValue;
    private DateTime _arcsFetchedUtc = DateTime.MinValue;

    private Dictionary<string, EpisodeRow> _episodes = new(StringComparer.OrdinalIgnoreCase);
    private Dictionary<string, ArcRow> _arcs = new(StringComparer.OrdinalIgnoreCase);

    private int? _detectedArcGid;

    public OnePaceGoogleSheetService(ILogger<OnePaceGoogleSheetService> logger)
    {
        _logger = logger;
    }

    public async Task<EpisodeRow?> GetEpisodeAsync(string arc, int part, CancellationToken ct)
    {
        await EnsureEpisodesLoadedAsync(ct).ConfigureAwait(false);
        var key = EpisodeKey(arc, part);
        return _episodes.TryGetValue(key, out var row) ? row : null;
    }

    public async Task<ArcRow?> GetArcAsync(string arc, CancellationToken ct)
    {
        await EnsureArcsLoadedAsync(ct).ConfigureAwait(false);
        var key = NormalizeArc(arc);
        return _arcs.TryGetValue(key, out var row) ? row : null;
    }

    private async Task EnsureEpisodesLoadedAsync(CancellationToken ct)
    {
        if (_episodes.Count > 0 && (DateTime.UtcNow - _episodesFetchedUtc).TotalHours < 24)
            return;

        await _gate.WaitAsync(ct).ConfigureAwait(false);
        try
        {
            if (_episodes.Count > 0 && (DateTime.UtcNow - _episodesFetchedUtc).TotalHours < 24)
                return;

            var csv = await _http.GetStringAsync(CsvUrl(EpisodeGid), ct).ConfigureAwait(false);
            var rows = Csv.Parse(csv);
            if (rows.Count == 0)
                return;

            var header = Csv.HeaderIndex(rows[0]);

            // Your sheet headers are: arc_title, arc_part, title_en, description_en
            var arcIdx = Csv.GetIndex(header, "arc_title", "Arc", "Arc Title");
            var partIdx = Csv.GetIndex(header, "arc_part", "Part", "Arc Part");
            var titleIdx = Csv.GetIndex(header, "title_en", "Title", "title");
            var descIdx = Csv.GetIndex(header, "description_en", "Description", "overview");

            var dict = new Dictionary<string, EpisodeRow>(StringComparer.OrdinalIgnoreCase);

            for (int i = 1; i < rows.Count; i++)
            {
                var r = rows[i];

                var arc = Csv.Get(r, arcIdx)?.Trim();
                var partStr = Csv.Get(r, partIdx)?.Trim();

                if (string.IsNullOrWhiteSpace(arc) || string.IsNullOrWhiteSpace(partStr))
                    continue;

                if (!int.TryParse(partStr, out var part))
                    continue;

                var title = Csv.Get(r, titleIdx) ?? "";
                var desc = Csv.Get(r, descIdx) ?? "";

                dict[EpisodeKey(arc, part)] = new EpisodeRow(NormalizeArc(arc), part, title, desc);
            }

            _episodes = dict;
            _episodesFetchedUtc = DateTime.UtcNow;

            _logger.LogInformation("OnePaceSheet: Loaded {Count} episode rows", _episodes.Count);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "OnePaceSheet: Failed to load episodes CSV");
        }
        finally
        {
            _gate.Release();
        }
    }

    private async Task EnsureArcsLoadedAsync(CancellationToken ct)
    {
        if (_arcs.Count > 0 && (DateTime.UtcNow - _arcsFetchedUtc).TotalHours < 24)
            return;

        await _gate.WaitAsync(ct).ConfigureAwait(false);
        try
        {
            if (_arcs.Count > 0 && (DateTime.UtcNow - _arcsFetchedUtc).TotalHours < 24)
                return;

            // Detect arc tab gid once (and remember it). If it changes, refresh will re-detect.
            _detectedArcGid ??= await DetectArcGidAsync(ct).ConfigureAwait(false);
            if (_detectedArcGid is null)
            {
                _logger.LogWarning("OnePaceSheet: Could not detect Arc Descriptions tab (no matching headers found).");
                return;
            }

            var csv = await _http.GetStringAsync(CsvUrl(_detectedArcGid.Value), ct).ConfigureAwait(false);
            var rows = Csv.Parse(csv);
            if (rows.Count == 0)
                return;

            var header = Csv.HeaderIndex(rows[0]);

            // Common arc tab columns (we accept several names)
            var arcIdx = Csv.GetIndex(header, "arc_title", "Arc", "Arc Title", "Arc Name", "Name");
            var descIdx = Csv.GetIndex(header, "description_en", "Description", "Overview", "Summary", "arc_description", "arc_description_en");
            var posterIdx = Csv.GetIndex(header, "poster", "Poster", "PosterUrl", "Image", "ImageUrl", "Cover", "cover_url");

            var dict = new Dictionary<string, ArcRow>(StringComparer.OrdinalIgnoreCase);

            for (int i = 1; i < rows.Count; i++)
            {
                var r = rows[i];

                var arc = Csv.Get(r, arcIdx)?.Trim();
                if (string.IsNullOrWhiteSpace(arc))
                    continue;

                var desc = Csv.Get(r, descIdx) ?? "";
                var poster = Csv.Get(r, posterIdx);

                dict[NormalizeArc(arc)] = new ArcRow(
                    Arc: NormalizeArc(arc),
                    Description: desc,
                    PosterUrl: string.IsNullOrWhiteSpace(poster) ? null : poster.Trim());
            }

            _arcs = dict;
            _arcsFetchedUtc = DateTime.UtcNow;

            _logger.LogInformation("OnePaceSheet: Loaded {Count} arc rows from gid={Gid}", _arcs.Count, _detectedArcGid.Value);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "OnePaceSheet: Failed to load arc CSV (auto-detect).");
            _detectedArcGid = null; // force re-detect next time
        }
        finally
        {
            _gate.Release();
        }
    }

    private async Task<int?> DetectArcGidAsync(CancellationToken ct)
    {
        // Probe tabs by gid and look for headers that *aren’t* the episode sheet
        // and include an arc + description column.
        for (int gid = 0; gid <= ArcGidProbeMax; gid++)
        {
            if (gid == EpisodeGid)
                continue;

            try
            {
                var csv = await _http.GetStringAsync(CsvUrl(gid), ct).ConfigureAwait(false);
                var rows = Csv.Parse(csv);
                if (rows.Count == 0)
                    continue;

                var header = Csv.HeaderIndex(rows[0]);

                var hasArc =
                    Csv.HasAny(header, "arc_title", "Arc", "Arc Title", "Arc Name", "Name");

                var hasDesc =
                    Csv.HasAny(header, "description_en", "Description", "Overview", "Summary", "arc_description", "arc_description_en");

                // Make sure it isn't the episode sheet (episode sheet has arc_part)
                var looksLikeEpisodeSheet =
                    Csv.HasAny(header, "arc_part", "Part", "Arc Part");

                if (hasArc && hasDesc && !looksLikeEpisodeSheet)
                {
                    _logger.LogInformation("OnePaceSheet: Detected Arc Descriptions tab at gid={Gid}", gid);
                    return gid;
                }
            }
            catch
            {
                // ignore and continue probing
            }
        }

        return null;
    }

    private static string EpisodeKey(string arc, int part)
        => $"{NormalizeArc(arc)}|{part}";

    public static string NormalizeArc(string arc)
    {
        arc = (arc ?? "").Trim();

        return arc switch
        {
            "Skypeia" => "Skypiea",
            "Fishman Island" => "Fish-Man Island",
            "Post Enies Lobby" => "Post-Enies Lobby",
            "Post War" => "Post-War",
            _ => arc
        };
    }

    private static class Csv
    {
        public static List<List<string>> Parse(string input)
        {
            var rows = new List<List<string>>();
            using var sr = new StringReader(input);

            string? line;
            while ((line = sr.ReadLine()) != null)
            {
                if (line.Length == 0)
                    continue;

                rows.Add(ParseLine(line));
            }

            return rows;
        }

        private static List<string> ParseLine(string line)
        {
            var fields = new List<string>();
            var sb = new StringBuilder();
            bool inQuotes = false;

            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];

                if (inQuotes)
                {
                    if (c == '"')
                    {
                        if (i + 1 < line.Length && line[i + 1] == '"')
                        {
                            sb.Append('"');
                            i++;
                        }
                        else
                        {
                            inQuotes = false;
                        }
                    }
                    else
                    {
                        sb.Append(c);
                    }
                }
                else
                {
                    if (c == ',')
                    {
                        fields.Add(sb.ToString());
                        sb.Clear();
                    }
                    else if (c == '"')
                    {
                        inQuotes = true;
                    }
                    else
                    {
                        sb.Append(c);
                    }
                }
            }

            fields.Add(sb.ToString());
            return fields;
        }

        public static Dictionary<string, int> HeaderIndex(List<string> headerRow)
        {
            var dict = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            for (int i = 0; i < headerRow.Count; i++)
            {
                var name = (headerRow[i] ?? "").Trim();
                if (!string.IsNullOrWhiteSpace(name) && !dict.ContainsKey(name))
                    dict[name] = i;
            }
            return dict;
        }

        public static int GetIndex(Dictionary<string, int> header, params string[] names)
        {
            foreach (var n in names)
            {
                if (header.TryGetValue(n, out var idx))
                    return idx;
            }
            return -1;
        }

        public static bool HasAny(Dictionary<string, int> header, params string[] names)
        {
            foreach (var n in names)
            {
                if (header.ContainsKey(n))
                    return true;
            }
            return false;
        }

        public static string? Get(List<string> row, int idx)
        {
            if (idx < 0 || idx >= row.Count)
                return null;
            return row[idx];
        }
    }
}

public sealed record EpisodeRow(string Arc, int Part, string Title, string Description);
public sealed record ArcRow(string Arc, string Description, string? PosterUrl);
