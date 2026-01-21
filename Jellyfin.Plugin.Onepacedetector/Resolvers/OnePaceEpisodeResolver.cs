using System;
using System.IO;
using System.Text.RegularExpressions;
using Jellyfin.Plugin.OnePaceDetector.Data;
using MediaBrowser.Controller.Entities;
using MediaBrowser.Controller.Entities.TV;
using MediaBrowser.Controller.Library;
using MediaBrowser.Controller.Resolvers;
using Microsoft.Extensions.Logging;

namespace Jellyfin.Plugin.OnePaceDetector.Resolvers;

public sealed class OnePaceEpisodeResolver : IItemResolver
{
    private readonly ILogger<OnePaceEpisodeResolver> _logger;

    // REQUIRED by IItemResolver
    public ResolverPriority Priority => ResolverPriority.First;

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

    public OnePaceEpisodeResolver(ILogger<OnePaceEpisodeResolver> logger)
    {
        _logger = logger;
    }

    public BaseItem? ResolvePath(ItemResolveArgs args)
    {
        if (string.IsNullOrWhiteSpace(args.Path))
            return null;

        // Jellyfin 10.11.x-safe file check
        if (!File.Exists(args.Path))
            return null;

        var fileName = Path.GetFileNameWithoutExtension(args.Path);
        if (string.IsNullOrWhiteSpace(fileName))
            return null;

        _logger.LogDebug("OnePaceResolver: Testing filename: {FileName}", fileName);

        Match? match = null;
        string arcRaw = "";
        string epRaw = "";

        // Try each pattern until one matches
        foreach (var pattern in FilePatterns)
        {
            match = pattern.Match(fileName);
            if (match.Success)
            {
                arcRaw = match.Groups["arc"].Value;
                epRaw = match.Groups["ep"].Value;
                _logger.LogDebug("OnePaceResolver: Matched pattern: {Pattern}", pattern.ToString());
                break;
            }
        }

        if (match == null || !match.Success)
        {
            _logger.LogDebug("OnePaceResolver: No pattern matched for: {Path}", args.Path);
            return null;
        }

        if (!int.TryParse(epRaw, out var episodeNumber))
        {
            _logger.LogWarning("OnePaceResolver: Could not parse episode number '{EpRaw}' from: {Path}",
                epRaw, args.Path);
            return null;
        }

        var arcKey = OnePaceHardcodedData.NormalizeArcTitle(arcRaw);

        if (!OnePaceHardcodedData.ArcsByNormalizedTitle.TryGetValue(arcKey, out var arc))
        {
            _logger.LogInformation(
                "OnePaceResolver: Unknown arc '{Arc}' (normalized: '{ArcKey}') for: {Path}",
                arcRaw, arcKey, args.Path
            );
            return null;
        }

        var episode = new Episode
        {
            Name = arc.ArcTitle,
            IndexNumber = episodeNumber,
            ParentIndexNumber = arc.SeasonNumber,
            Path = args.Path
        };

        _logger.LogInformation(
            "OnePaceResolver: \"{File}\" -> One Pace S{Season:00}E{Episode:00} (\"{Arc}\")",
            fileName,
            arc.SeasonNumber,
            episodeNumber,
            arc.ArcTitle
        );

        return episode;
    }
}
