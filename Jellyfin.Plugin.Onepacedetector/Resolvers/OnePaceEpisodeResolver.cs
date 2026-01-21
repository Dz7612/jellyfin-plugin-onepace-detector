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

    private static readonly Regex FileRegex = new(
        @"^\[One\s*Pace\]\[[^\]]+\]\s*(?<arc>.+?)\s+(?<ep>\d{1,3})\b",
        RegexOptions.IgnoreCase | RegexOptions.Compiled);

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

        var match = FileRegex.Match(fileName);
        if (!match.Success)
            return null;

        var arcRaw = match.Groups["arc"].Value;
        var epRaw = match.Groups["ep"].Value;

        if (!int.TryParse(epRaw, out var episodeNumber))
            return null;

        var arcKey = OnePaceHardcodedData.NormalizeArcTitle(arcRaw);

        if (!OnePaceHardcodedData.ArcsByNormalizedTitle.TryGetValue(arcKey, out var arc))
        {
            _logger.LogInformation(
                "OnePaceResolver: Unknown arc '{Arc}' for: {Path}",
                arcRaw,
                args.Path
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
