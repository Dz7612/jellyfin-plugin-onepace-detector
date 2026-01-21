using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using Jellyfin.Plugin.OnePaceDetector.Data;
using MediaBrowser.Controller.Entities.TV;
using MediaBrowser.Controller.Providers;
using MediaBrowser.Model.Entities;
using MediaBrowser.Model.Providers;
using Microsoft.Extensions.Logging;

namespace Jellyfin.Plugin.OnePaceDetector.Providers;

public sealed class OnePaceEpisodeLocalProvider : ILocalMetadataProvider<Episode>, IHasOrder, IMetadataProvider
{
    private readonly ILogger<OnePaceEpisodeLocalProvider> _logger;

    private static readonly Regex FileRegex = new(
        @"^\[One\s*Pace\]\[[^\]]+\]\s*(?<arc>.+?)\s+(?<ep>\d{1,3})\b",
        RegexOptions.IgnoreCase | RegexOptions.Compiled);

    public OnePaceEpisodeLocalProvider(ILogger<OnePaceEpisodeLocalProvider> logger)
    {
        _logger = logger;
    }

    public string Name => "One Pace Detector (Local Episode Metadata)";

    // Prefer before remote providers
    public int Order => -10;

    public Task<MetadataResult<Episode>> GetMetadata(ItemInfo info, IDirectoryService directoryService, CancellationToken cancellationToken)
    {
        var result = new MetadataResult<Episode>();

        if (string.IsNullOrWhiteSpace(info.Path) || !File.Exists(info.Path))
            return Task.FromResult(result);

        var fileName = Path.GetFileNameWithoutExtension(info.Path);
        if (string.IsNullOrWhiteSpace(fileName))
            return Task.FromResult(result);

        var m = FileRegex.Match(fileName);
        if (!m.Success)
            return Task.FromResult(result);

        var arcRaw = m.Groups["arc"].Value;
        var epRaw = m.Groups["ep"].Value;

        if (!int.TryParse(epRaw, out var episodeNumber))
            return Task.FromResult(result);

        var arcNorm = OnePaceHardcodedData.NormalizeArcTitle(arcRaw);
        if (!OnePaceHardcodedData.ArcsByNormalizedTitle.TryGetValue(arcNorm, out var arcInfo))
            return Task.FromResult(result);

        // Pull hardcoded metadata
        if (!OnePaceHardcodedData.EpisodesBySeasonEpisode.TryGetValue((arcInfo.SeasonNumber, episodeNumber), out var epInfo))
        {
            // If Excel is missing a row, still name it nicely
            epInfo = new OnePaceHardcodedData.EpisodeInfo(
                arcInfo.SeasonNumber,
                episodeNumber,
                arcInfo.ArcTitle,
                $"{arcInfo.ArcTitle} {episodeNumber:00}",
                string.Empty
            );
        }

        var item = new Episode
        {
            Name = epInfo.EpisodeTitle,
            IndexNumber = epInfo.EpisodeNumber,
            ParentIndexNumber = epInfo.SeasonNumber,
            Overview = string.IsNullOrWhiteSpace(epInfo.Description) ? null : epInfo.Description
        };

        result.HasMetadata = true;
        result.Item = item;
        result.People = null;

        _logger.LogInformation(
            "OnePaceDetector matched: \"{File}\" -> S{Season:00}E{Episode:00} (\"{Title}\")",
            fileName, epInfo.SeasonNumber, epInfo.EpisodeNumber, epInfo.EpisodeTitle);

        return Task.FromResult(result);
    }
}
