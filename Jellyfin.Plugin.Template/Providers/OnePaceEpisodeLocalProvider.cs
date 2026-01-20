using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Jellyfin.Plugin.OnePaceDetector.Metadata;
using MediaBrowser.Controller.Entities.TV;
using MediaBrowser.Controller.Providers;
using MediaBrowser.Model.Entities;
using Microsoft.Extensions.Logging;

namespace Jellyfin.Plugin.OnePaceDetector.Providers;

public sealed class OnePaceEpisodeLocalProvider : ILocalMetadataProvider<Episode>
{
    private readonly ILogger<OnePaceEpisodeLocalProvider> _logger;

    public OnePaceEpisodeLocalProvider(ILogger<OnePaceEpisodeLocalProvider> logger)
    {
        _logger = logger;
    }

    public string Name => "One Pace Episode Metadata";

    // Matches: [One Pace][40-41] Syrup Village 07 ...
    private static readonly Regex FileRegex = new(
        @"^\[One Pace\]\[[^\]]+\]\s*(?<arc>.+?)\s+(?<cut>\d{2})\b",
        RegexOptions.Compiled | RegexOptions.IgnoreCase);

    public Task<MetadataResult<Episode>> GetMetadata(
        ItemInfo info,
        IDirectoryService directoryService,
        CancellationToken cancellationToken)
    {
        var result = new MetadataResult<Episode>();

        // Only act on One Pace library paths
        if (info.Path is null ||
            info.Path.IndexOf("One Pace", StringComparison.OrdinalIgnoreCase) < 0)
            return Task.FromResult(result);

        var fileNameNoExt = Path.GetFileNameWithoutExtension(info.Path);
        if (string.IsNullOrWhiteSpace(fileNameNoExt))
            return Task.FromResult(result);

        if (fileNameNoExt.IndexOf("[One Pace]", StringComparison.OrdinalIgnoreCase) < 0)
            return Task.FromResult(result);

        var m = FileRegex.Match(fileNameNoExt);
        if (!m.Success)
            return Task.FromResult(result);

        var arc = NormalizeArc(m.Groups["arc"].Value.Trim());
        if (!int.TryParse(m.Groups["cut"].Value, out var cut))
            return Task.FromResult(result);

        if (!OnePaceStaticMetadata.ArcToSeason.TryGetValue(arc, out var season))
            return Task.FromResult(result);

        var key = OnePaceStaticMetadata.Key(arc, cut);
        if (!OnePaceStaticMetadata.Episodes.TryGetValue(key, out var meta))
            return Task.FromResult(result);

        var isDub = info.Path.IndexOf("En Dub", StringComparison.OrdinalIgnoreCase) >= 0;

        result.Item = new Episode
        {
            Name = meta.Title + (isDub ? " (Dub)" : ""),
            Overview = meta.Overview,

            // These help Jellyfin display correctly even if it ignores them sometimes.
            ParentIndexNumber = season,
            IndexNumber = cut
        };

        result.HasMetadata = true;

        _logger.LogInformation(
            "OnePaceEpisodeProvider: {File} -> S{S:00}E{E:00} '{Title}'",
            fileNameNoExt, season, cut, meta.Title);

        return Task.FromResult(result);
    }

    private static string NormalizeArc(string arc)
    {
        return arc switch
        {
            "Skypeia" => "Skypiea",
            "Fishman Island" => "Fish-Man Island",
            "Post Enies Lobby" => "Post-Enies Lobby",
            "Post War" => "Post-War",
            _ => arc
        };
    }
}
