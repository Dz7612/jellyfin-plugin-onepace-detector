using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using MediaBrowser.Controller.Entities.TV;
using MediaBrowser.Controller.Providers;
using MediaBrowser.Model.IO;
using Microsoft.Extensions.Logging;

namespace Jellyfin.Plugin.OnePaceDetector.Providers;

public sealed class OnePaceEpisodeLocalProvider
    : ILocalMetadataProvider<Episode>, IHasOrder
{
    private readonly ILogger<OnePaceEpisodeLocalProvider> _logger;

    // Example filenames:
    // [One Pace][1] Romance Dawn 01 [1080p][En Dub][HASH].mp4
    // [One Pace][23-25] Syrup Village 01 [1080p][En Dub][HASH].mp4
    private static readonly Regex OnePaceRegex = new(
        @"^\[One Pace\].*?\]\s*(?<arc>Romance Dawn|Syrup Village)\s+(?<cut>\d{2})\b",
        RegexOptions.Compiled | RegexOptions.IgnoreCase);

    private static readonly Dictionary<string, int> ArcToSeason =
        new(StringComparer.OrdinalIgnoreCase)
        {
            ["Romance Dawn"] = 1,
            ["Syrup Village"] = 2
        };

    public OnePaceEpisodeLocalProvider(ILogger<OnePaceEpisodeLocalProvider> logger)
    {
        _logger = logger;
    }

    // Required by IMetadataProvider
    public string Name => "One Pace Detector";

    // Run early so we beat online providers
    public int Order => -100;

    public Task<MetadataResult<Episode>> GetMetadata(
        ItemInfo info,
        IDirectoryService directoryService,
        CancellationToken cancellationToken)
    {
        var result = new MetadataResult<Episode>();

        if (string.IsNullOrWhiteSpace(info.Path))
            return Task.FromResult(result);

        var fileName = Path.GetFileNameWithoutExtension(info.Path);

        var match = OnePaceRegex.Match(fileName);
        if (!match.Success)
            return Task.FromResult(result);

        var arc = match.Groups["arc"].Value.Trim();
        var cutText = match.Groups["cut"].Value.Trim();

        if (!ArcToSeason.TryGetValue(arc, out var seasonNumber))
            return Task.FromResult(result);

        if (!int.TryParse(cutText, out var episodeNumber) || episodeNumber <= 0)
            return Task.FromResult(result);

        var episode = new Episode
        {
            Name = $"{arc} {episodeNumber:00}",
            ParentIndexNumber = seasonNumber,
            IndexNumber = episodeNumber
        };

        result.HasMetadata = true;
        result.Item = episode;

        _logger.LogInformation(
            "OnePaceDetector matched: {File} -> S{Season:00}E{Episode:00} ({Title})",
            fileName,
            seasonNumber,
            episodeNumber,
            episode.Name);

        return Task.FromResult(result);
    }
}
