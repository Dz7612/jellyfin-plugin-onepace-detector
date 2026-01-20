using System;
using System.IO;
using System.Text.RegularExpressions;
using Jellyfin.Plugin.OnePaceDetector.Metadata;
using MediaBrowser.Controller.Entities;
using MediaBrowser.Controller.Entities.TV;
using MediaBrowser.Controller.Library;
using MediaBrowser.Controller.Resolvers;

namespace Jellyfin.Plugin.OnePaceDetector.Resolvers;

public sealed class OnePaceEpisodeResolver : IItemResolver
{
    // Example:
    // [One Pace][23-41] Syrup Village 07 [1080p][En Dub]
    private static readonly Regex FileRegex = new(
        @"^\[One Pace\]\[[^\]]+\]\s*(?<arc>.+?)\s+(?<cut>\d{2})\b",
        RegexOptions.Compiled | RegexOptions.IgnoreCase);

    public ResolverPriority Priority => ResolverPriority.First;

    public BaseItem? ResolvePath(ItemResolveArgs args)
    {
        if (string.IsNullOrWhiteSpace(args.Path))
            return null;

        // Only operate on files (NOT folders)
        if (!File.Exists(args.Path))
            return null;

        // Must be One Pace content
        if (args.Path.IndexOf("One Pace", StringComparison.OrdinalIgnoreCase) < 0)
            return null;

        var fileName = Path.GetFileNameWithoutExtension(args.Path);
        if (string.IsNullOrWhiteSpace(fileName))
            return null;

        var match = FileRegex.Match(fileName);
        if (!match.Success)
            return null;

        var arc = OnePaceHardcodedData.NormalizeArc(match.Groups["arc"].Value);

        if (!int.TryParse(match.Groups["cut"].Value, out var episodeNumber))
            return null;

        // Determine season number (arc ordering)
        if (!OnePaceHardcodedData.ArcToSeason.TryGetValue(arc, out var seasonNumber))
        {
            // Fallback so arcs are NEVER ignored
            seasonNumber = 900;
        }

        return new Episode
        {
            Name = fileName,
            IndexNumber = episodeNumber,
            ParentIndexNumber = seasonNumber
        };
    }
}
