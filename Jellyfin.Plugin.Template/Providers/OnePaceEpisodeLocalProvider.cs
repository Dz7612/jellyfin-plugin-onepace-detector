// FILE: Providers/OnePaceEpisodeLocalProvider.cs
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Jellyfin.Plugin.OnePaceDetector.Services;
using MediaBrowser.Controller.Entities.TV;
using MediaBrowser.Controller.Providers;
using MediaBrowser.Model.Entities;
using Microsoft.Extensions.Logging;

namespace Jellyfin.Plugin.OnePaceDetector.Providers;

public sealed class OnePaceEpisodeLocalProvider : ILocalMetadataProvider<Episode>
{
    private readonly ILogger<OnePaceEpisodeLocalProvider> _logger;
    private readonly OnePaceGoogleSheetService _sheet;

    public OnePaceEpisodeLocalProvider(
        ILogger<OnePaceEpisodeLocalProvider> logger,
        OnePaceGoogleSheetService sheet)
    {
        _logger = logger;
        _sheet = sheet;
    }

    public string Name => "One Pace Episode (Sheet)";

    // Matches: [One Pace][40-41] Syrup Village 07 ...
    private static readonly Regex FileRegex = new(
        @"^\[One Pace\]\[[^\]]+\]\s*(?<arc>.+?)\s+(?<cut>\d{2})\b",
        RegexOptions.Compiled | RegexOptions.IgnoreCase);

    public async Task<MetadataResult<Episode>> GetMetadata(
        ItemInfo info,
        IDirectoryService directoryService,
        CancellationToken cancellationToken)
    {
        var result = new MetadataResult<Episode>();

        if (info.Path is null ||
            info.Path.IndexOf("One Pace", StringComparison.OrdinalIgnoreCase) < 0)
            return result;

        var fileNameNoExt = Path.GetFileNameWithoutExtension(info.Path);
        if (string.IsNullOrWhiteSpace(fileNameNoExt))
            return result;

        if (fileNameNoExt.IndexOf("[One Pace]", StringComparison.OrdinalIgnoreCase) < 0)
            return result;

        var m = FileRegex.Match(fileNameNoExt);
        if (!m.Success)
            return result;

        var arc = OnePaceGoogleSheetService.NormalizeArc(m.Groups["arc"].Value.Trim());
        if (!int.TryParse(m.Groups["cut"].Value, out var cut))
            return result;

        var row = await _sheet.GetEpisodeAsync(arc, cut, cancellationToken).ConfigureAwait(false);
        if (row is null)
            return result;

        var isDub =
            info.Path.IndexOf("En Dub", StringComparison.OrdinalIgnoreCase) >= 0;

        // We set numbers too (helpful), but your resolver is the real source of truth for grouping
        // If you want, you can also map arc -> season in your resolver and keep titles from the sheet here.
        result.Item = new Episode
        {
            Name = string.IsNullOrWhiteSpace(row.Title) ? $"{row.Arc} {row.Part:00}" : row.Title + (isDub ? " (Dub)" : ""),
            Overview = row.Description,
            IndexNumber = row.Part
        };

        result.HasMetadata = true;

        _logger.LogInformation("OnePaceEpisodeProvider(Sheet): {File} -> {Title}",
            fileNameNoExt, result.Item.Name);

        return result;
    }
}
