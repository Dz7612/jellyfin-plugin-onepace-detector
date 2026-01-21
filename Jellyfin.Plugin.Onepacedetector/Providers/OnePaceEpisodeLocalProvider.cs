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

    // Multiple regex patterns to handle different naming conventions
    private static readonly Regex[] FilePatterns =
    [
        // Pattern 1: Original bracket format [One Pace][X] Arc XX
        new(@"^\[One\s*Pace\]\[[^\]]+\]\s*(?<arc>.+?)\s+(?<ep>\d{1,3})\b",
            RegexOptions.IgnoreCase | RegexOptions.Compiled),
        
        // Pattern 2: [One.Pace] Arc XX
        new(@"^\[One[._\s]*Pace\]\s*(?<arc>.+?)\s+(?<ep>\d{1,3})\b",
            RegexOptions.IgnoreCase | RegexOptions.Compiled),
        
        // Pattern 3: One Pace - Arc XX
        new(@"^One[._\s]*Pace[._\s]*(?:-|–)?[._\s]*(?<arc>.+?)\s+(?<ep>\d{1,3})\b",
            RegexOptions.IgnoreCase | RegexOptions.Compiled),
        
        // Pattern 4: Arc XX [One Pace]
        new(@"(?<arc>.+?)\s+(?<ep>\d{1,3})\s*\[One[._\s]*Pace\]",
            RegexOptions.IgnoreCase | RegexOptions.Compiled),
        
        // Pattern 5: OnePace.Arc.XX
        new(@"One[._\s]*Pace[._\s]*(?<arc>[^.]+?)\.(?<ep>\d{1,3})\b",
            RegexOptions.IgnoreCase | RegexOptions.Compiled),
        
        // Pattern 6: Arc XX - One Pace
        new(@"(?<arc>.+?)\s+(?<ep>\d{1,3})\s*(?:-|–)\s*One[._\s]*Pace",
            RegexOptions.IgnoreCase | RegexOptions.Compiled)
    ];

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

        _logger.LogDebug("OnePaceDetector: Testing filename: {FileName}", fileName);

        Match? m = null;
        string arcRaw = "";
        string epRaw = "";

        // Try each pattern until one matches
        foreach (var pattern in FilePatterns)
        {
            m = pattern.Match(fileName);
            if (m.Success)
            {
                arcRaw = m.Groups["arc"].Value;
                epRaw = m.Groups["ep"].Value;
                _logger.LogDebug("OnePaceDetector: Matched pattern: {Pattern}", pattern.ToString());
                break;
            }
        }

        if (m == null || !m.Success)
        {
            _logger.LogDebug("OnePaceDetector: No pattern matched for: {Path}", info.Path);
            return Task.FromResult(result);
        }

        if (!int.TryParse(epRaw, out var episodeNumber))
        {
            _logger.LogWarning("OnePaceDetector: Could not parse episode number '{EpRaw}' from: {Path}",
                epRaw, info.Path);
            return Task.FromResult(result);
        }

        var arcNorm = OnePaceHardcodedData.NormalizeArcTitle(arcRaw);
        _logger.LogDebug("OnePaceDetector: Raw arc: '{ArcRaw}', Normalized: '{ArcNorm}'", arcRaw, arcNorm);

        if (!OnePaceHardcodedData.ArcsByNormalizedTitle.TryGetValue(arcNorm, out var arcInfo))
        {
            _logger.LogInformation(
                "OnePaceDetector: Unknown arc '{Arc}' (normalized: '{ArcNorm}') for: {Path}",
                arcRaw, arcNorm, info.Path
            );
            return Task.FromResult(result);
        }

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
