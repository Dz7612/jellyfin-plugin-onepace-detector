using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using MediaBrowser.Controller.Entities;
using MediaBrowser.Controller.Entities.TV;
using MediaBrowser.Controller.Library;
using MediaBrowser.Controller.Resolvers;
using Microsoft.Extensions.Logging;

namespace Jellyfin.Plugin.OnePaceDetector.Resolvers;

public sealed class OnePaceEpisodeResolver : IItemResolver
{
    private readonly ILogger<OnePaceEpisodeResolver> _logger;

    public OnePaceEpisodeResolver(ILogger<OnePaceEpisodeResolver> logger)
    {
        _logger = logger;
    }

    // Ensure we run before Jellyfin’s built-in resolvers.
    public ResolverPriority Priority => ResolverPriority.First;

    // Matches: [One Pace][40-41] Syrup Village 07 ...
    private static readonly Regex FileRegex = new(
        @"^\[One Pace\]\[[^\]]+\]\s*(?<arc>.+?)\s+(?<cut>\d{2})\b",
        RegexOptions.Compiled | RegexOptions.IgnoreCase);

    // If arc isn't in filename, try to pull it from folder name like: [23-41] Syrup Village [En Dub][1080p]
    private static readonly Regex FolderArcCleaner = new(
        @"^\s*\[[^\]]+\]\s*",
        RegexOptions.Compiled);

    private static readonly HashSet<string> VideoExts = new(StringComparer.OrdinalIgnoreCase)
    {
        ".mp4", ".mkv", ".avi", ".mov", ".m4v", ".ts"
    };

    // Expand this over time. Start with what you have.
    private static readonly Dictionary<string, int> ArcToSeason = new(StringComparer.OrdinalIgnoreCase)
    {
        ["Romance Dawn"] = 1,
        ["Syrup Village"] = 2,
        ["Gaimon"] = 3,
    };

    public BaseItem? ResolvePath(ItemResolveArgs args)
    {
        // Only resolve files, not folders
        if (args.IsDirectory)
            return null;

        var path = args.Path;
        if (string.IsNullOrWhiteSpace(path))
            return null;

        var ext = Path.GetExtension(path);
        if (string.IsNullOrEmpty(ext) || !VideoExts.Contains(ext))
            return null;

        var fileNameNoExt = Path.GetFileNameWithoutExtension(path);

        // Only One Pace
        if (fileNameNoExt.IndexOf("[One Pace]", StringComparison.OrdinalIgnoreCase) < 0)
            return null;

        // Parse arc + cut
        string? arc = null;
        int? cut = null;

        var m = FileRegex.Match(fileNameNoExt);
        if (m.Success)
        {
            arc = m.Groups["arc"].Value.Trim();
            cut = int.TryParse(m.Groups["cut"].Value, out var c) ? c : null;
        }

        // Fallback arc from parent folder name (strip leading [23-41] etc)
        if (string.IsNullOrWhiteSpace(arc))
        {
            var parentDir = Path.GetFileName(Path.GetDirectoryName(path));
            if (!string.IsNullOrWhiteSpace(parentDir))
            {
                var cleaned = FolderArcCleaner.Replace(parentDir, "").Trim();
                // Also remove trailing tags like [En Dub][1080p] if present
                cleaned = Regex.Replace(cleaned, @"\s*\[[^\]]+\]\s*", " ").Trim();
                arc = cleaned;
            }
        }

        if (string.IsNullOrWhiteSpace(arc) || cut is null)
        {
            _logger.LogInformation("OnePaceResolver: Could not parse arc/cut for: {Path}", path);
            return null; // Let default resolvers handle it (or ignore)
        }

        // Map arc to season; if unknown, put into Season 1 by default (or return null if you prefer)
        if (!ArcToSeason.TryGetValue(arc, out var season))
        {
            _logger.LogInformation("OnePaceResolver: Unknown arc '{Arc}' for: {Path}", arc, path);
            // Default behavior: keep it in a safe season rather than producing crazy numbers
            season = 1;
        }

        var isDub = fileNameNoExt.IndexOf("En Dub", StringComparison.OrdinalIgnoreCase) >= 0
                    || path.IndexOf("En Dub", StringComparison.OrdinalIgnoreCase) >= 0;

        var ep = new Episode
        {
            Path = path,
            Name = $"{arc} {cut.Value:00}" + (isDub ? " (Dub)" : ""),
            IndexNumber = cut.Value,
            ParentIndexNumber = season,
            SeriesName = "One Pace",
            SortName = $"{season:00}{cut.Value:00}",
        };

        _logger.LogInformation("OnePaceResolver: {File} -> One Pace S{S:00}E{E:00} ({Arc})",
            fileNameNoExt, season, cut.Value, arc);

        return ep;
    }
}
