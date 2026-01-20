using System;
using System.Collections.Generic;

namespace Jellyfin.Plugin.OnePaceDetector.Metadata;

public static class OnePaceStaticMetadata
{
    // Arc -> Season number
    public static readonly Dictionary<string, int> ArcToSeason =
        new(StringComparer.OrdinalIgnoreCase)
        {
            ["Romance Dawn"] = 1,
            ["Orange Town"] = 2,
            ["Syrup Village"] = 3,
            ["Gaimon"] = 4,
            ["Baratie"] = 5,
            ["Arlong Park"] = 6,
            ["Loguetown"] = 7,
        };

    // Season number -> Arc display name
    public static readonly Dictionary<int, string> SeasonToArc = new()
    {
        [1] = "Romance Dawn",
        [2] = "Orange Town",
        [3] = "Syrup Village",
        [4] = "Gaimon",
        [5] = "Baratie",
        [6] = "Arlong Park",
        [7] = "Loguetown",
    };

    // Episode metadata
    // Key format: "<Arc>|<Cut>"
    public static readonly Dictionary<string, EpisodeMeta> Episodes = new()
    {
        ["Romance Dawn|1"] = new(
            "Romance Dawn, the Dawn of an Adventure",
            "Influenced by the straw - hat - wearing pirate Red - Haired Shanks, an enthusiastic young boy named Monkey D.Luffy dreams of one day becoming King of the Pirates."
            ),
        ["Romance Dawn|2"] = new(
            "They Call Him \"Straw Hat\" Luffy",
            "While Alvida and her pirates plunder a cruise ship, they come across a barrel containing a strange boy named Monkey D. Luffy. The timid Koby befriends Luffy, and they share their grand dreams with each other."
        ),

        ["Syrup Village|1"] = new(
            "Captain Kuro of the Thousand Plans",
            "The Straw Hats arrive at Syrup Village and meet Usopp."
        ),
        ["Syrup Village|7"] = new(
            "The Usopp Pirates Disband!",
            "Usopp faces the truth about his village and his crew."
        ),

        ["Gaimon|1"] = new(
            "A Strange Creature in a Strange Chest",
            "The crew meets the mysterious Gaimon."
        ),
    };

    public static string Key(string arc, int cut)
        => $"{arc}|{cut}";
}

public readonly record struct EpisodeMeta(string Title, string Overview);
