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

    // Cleans leading junk like: [23-41] Syrup Village ...
    private static readonly Regex FolderArcLeadingBracketCleaner = new(
        @"^\s*\[[^\]]+\]\s*",
        RegexOptions.Compiled);

    // Removes bracket tags like: [En Dub][1080p]
    private static readonly Regex FolderArcTagStripper = new(
        @"\s*\[[^\]]+\]\s*",
        RegexOptions.Compiled);

    private static readonly HashSet<string> VideoExts = new(StringComparer.OrdinalIgnoreCase)
    {
        ".mp4", ".mkv", ".avi", ".mov", ".m4v", ".ts", ".webm"
    };

    // Arc -> Season mapping (expand as needed)
    private static readonly Dictionary<string, int> ArcToSeason =
        new(StringComparer.OrdinalIgnoreCase)
        {
            // East Blue
            ["Romance Dawn"] = 1,
            ["Orange Town"] = 2,
            ["Syrup Village"] = 3,
            ["Gaimon"] = 4,
            ["Baratie"] = 5,
            ["Arlong Park"] = 6,
            ["Loguetown"] = 7,

            // Alabasta Saga
            ["Reverse Mountain"] = 8,
            ["Whisky Peak"] = 9,
            ["Little Garden"] = 10,
            ["Drum Island"] = 11,
            ["Alabasta"] = 12,

            // Sky Island Saga
            ["Jaya"] = 13,
            ["Skypiea"] = 14,

            // Water 7 Saga
            ["Long Ring Long Land"] = 15,
            ["Water 7"] = 16,
            ["Enies Lobby"] = 17,
            ["Post-Enies Lobby"] = 18,

            // Thriller Bark Saga
            ["Thriller Bark"] = 19,

            // Summit War Saga
            ["Sabaody Archipelago"] = 20,
            ["Amazon Lily"] = 21,
            ["Impel Down"] = 22,
            ["Marineford"] = 23,
            ["Post-War"] = 24,

            // Fish-Man Island Saga
            ["Return to Sabaody"] = 25,
            ["Fish-Man Island"] = 26,

            // Dressrosa Saga
            ["Punk Hazard"] = 27,
            ["Dressrosa"] = 28,

            // Whole Cake Island Saga
            ["Zou"] = 29,
            ["Whole Cake Island"] = 30,

            // Wano Saga
            ["Wano"] = 31,

            // Specials / Misc
            ["Levely"] = 32,
        };

    public BaseItem? ResolvePath(ItemResolveArgs args)
    {
        // Only resolve files, not directories
        if (args.IsDirectory)
            return null;

        var path = args.Path;
        if (string.IsNullOrWhiteSpace(path))
            return null;

        var ext = Path.GetExtension(path);
        if (string.IsNullOrEmpty(ext) || !VideoExts.Contains(ext))
            return null;

        var fileNameNoExt = Path.GetFileNameWithoutExtension(path);
        if (string.IsNullOrWhiteSpace(fileNameNoExt))
            return null;

        // Only target One Pace
        if (fileNameNoExt.IndexOf("[One Pace]", StringComparison.OrdinalIgnoreCase) < 0)
            return null;

        // Parse arc + cut from filename
        string? arc = null;
        int? cut = null;

        var m = FileRegex.Match(fileNameNoExt);
        if (m.Success)
        {
            arc = m.Groups["arc"].Value.Trim();
            cut = int.TryParse(m.Groups["cut"].Value, out var c) ? c : null;
        }

        // Fallback: parse arc from parent folder name like:
        // [23-41] Syrup Village [En Dub][1080p]
        if (string.IsNullOrWhiteSpace(arc))
        {
            var parentDir = Path.GetFileName(Path.GetDirectoryName(path));
            if (!string.IsNullOrWhiteSpace(parentDir))
            {
                var cleaned = FolderArcLeadingBracketCleaner.Replace(parentDir, "").Trim();
                cleaned = FolderArcTagStripper.Replace(cleaned, " ").Trim();
                cleaned = Regex.Replace(cleaned, @"\s+", " ").Trim();
                arc = cleaned;
            }
        }

        if (string.IsNullOrWhiteSpace(arc) || cut is null)
        {
            _logger.LogInformation("OnePaceResolver: Could not parse arc/cut for: {Path}", path);
            return null;
        }

        arc = NormalizeArc(arc);

        // Map arc to season
        if (!ArcToSeason.TryGetValue(arc, out var season))
        {
            _logger.LogInformation("OnePaceResolver: Unknown arc '{Arc}' for: {Path}", arc, path);
            // Safe default: avoid insane seasons; keep grouped
            season = 1;
        }

        var isDub = fileNameNoExt.IndexOf("En Dub", StringComparison.OrdinalIgnoreCase) >= 0
                    || path.IndexOf("En Dub", StringComparison.OrdinalIgnoreCase) >= 0;

        var episodeName = $"{arc} {cut.Value:00}" + (isDub ? " (Dub)" : "");

        var ep = new Episode
        {
            Path = path,

            // This is what you’ll see in Jellyfin
            Name = episodeName,

            // Season/Episode numbers (critical)
            ParentIndexNumber = season,
            IndexNumber = cut.Value,

            // Force a stable series grouping name
            SeriesName = "One Pace",

            // Helps keep ordering stable
            SortName = $"{season:00}{cut.Value:00}",
        };

        _logger.LogInformation(
            "OnePaceResolver: {File} -> One Pace S{S:00}E{E:00} ({Arc})",
            fileNameNoExt, season, cut.Value, arc);

        return ep;
    }

    private static string NormalizeArc(string arc)
    {
        arc = arc.Trim();

        // Common variations
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
