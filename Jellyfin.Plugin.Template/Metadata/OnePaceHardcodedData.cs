// Auto-generated from One Pace Episode Descriptions.xlsx on 2026-01-20 11:25 UTC
using System;
using System.Collections.Generic;

namespace Jellyfin.Plugin.OnePaceDetector.Metadata;

public static class OnePaceHardcodedData
{
    // Arc -> Season number (used for ordering)
    public static readonly Dictionary<string, int> ArcToSeason = new(StringComparer.OrdinalIgnoreCase)
    {
        [@"Romance Dawn"] = 1,
        [@"Orange Town"] = 2,
        [@"Syrup Village"] = 3,
        [@"Gaimon"] = 4,
        [@"Baratie"] = 5,
        [@"Arlong Park"] = 6,
        [@"The Adventures of Buggy's Crew"] = 7,
        [@"Loguetown"] = 8,
        [@"Reverse Mountain"] = 9,
        [@"The Trials of Koby-Meppo"] = 10,
        [@"Whisky Peak"] = 11,
        [@"Little Garden"] = 12,
        [@"Drum Island"] = 13,
        [@"Arabasta"] = 14,
        [@"Jaya"] = 15,
        [@"Skypiea"] = 16,
        [@"Long Ring Long Land"] = 17,
        [@"Water Seven"] = 18,
        [@"Enies Lobby"] = 19,
        [@"Post-Enies Lobby"] = 20,
        [@"Thriller Bark"] = 21,
        [@"Sabaody Archipelago"] = 22,
        [@"Amazon Lily"] = 23,
        [@"Impel Down"] = 24,
        [@"If You Could Go Anywhere... The Adventures of the Straw Hats"] = 25,
        [@"Marineford"] = 26,
        [@"Post-War"] = 27,
        [@"Return to Sabaody"] = 28,
        [@"Fish-Man Island"] = 29,
        [@"Punk Hazard"] = 30,
        [@"Dressrosa"] = 31,
        [@"Zou"] = 32,
        [@"Whole Cake Island"] = 33,
        [@"Reverie"] = 34,
        [@"Wano"] = 35,
        [@"Egghead"] = 36,
        [@"One Piece Fan Letter"] = 98,
        [@"Specials"] = 99,
    };

    // Season number -> Arc (display)
    public static readonly Dictionary<int, string> SeasonToArc = new()
    {
        [1] = @"Romance Dawn",
        [2] = @"Orange Town",
        [3] = @"Syrup Village",
        [4] = @"Gaimon",
        [5] = @"Baratie",
        [6] = @"Arlong Park",
        [7] = @"The Adventures of Buggy's Crew",
        [8] = @"Loguetown",
        [9] = @"Reverse Mountain",
        [10] = @"The Trials of Koby-Meppo",
        [11] = @"Whisky Peak",
        [12] = @"Little Garden",
        [13] = @"Drum Island",
        [14] = @"Arabasta",
        [15] = @"Jaya",
        [16] = @"Skypiea",
        [17] = @"Long Ring Long Land",
        [18] = @"Water Seven",
        [19] = @"Enies Lobby",
        [20] = @"Post-Enies Lobby",
        [21] = @"Thriller Bark",
        [22] = @"Sabaody Archipelago",
        [23] = @"Amazon Lily",
        [24] = @"Impel Down",
        [25] = @"If You Could Go Anywhere... The Adventures of the Straw Hats",
        [26] = @"Marineford",
        [27] = @"Post-War",
        [28] = @"Return to Sabaody",
        [29] = @"Fishman Island",
        [30] = @"Punk Hazard",
        [31] = @"Dressrosa",
        [32] = @"Zou",
        [33] = @"Whole Cake Island",
        [34] = @"Reverie",
        [35] = @"Wano",
        [36] = @"Egghead",
        [98] = @"One Piece Fan Letter",
        [99] = @"Specials",
    };

    // Arc overview metadata
    public static readonly Dictionary<string, ArcMeta> Arcs = new(StringComparer.OrdinalIgnoreCase)
    {
        [@"Romance Dawn"] = new ArcMeta(
            Title: @"Romance Dawn",
            Overview: @"Monkey D. Luffy sets out on an adventure to form a crew, find the legendary One Piece, and become the pirate king."),
        [@"Orange Town"] = new ArcMeta(
            Title: @"Orange Town",
            Overview: @"Luffy and Zoro run afoul of a flashy crew of pirates and their captain, Buggy the Clown. They are joined by a young girl named Nami who helps them navigate this predicament."),
        [@"Syrup Village"] = new ArcMeta(
            Title: @"Syrup Village",
            Overview: @"Luffy's fledgling pirate crew arrives at the slopes of Syrup Village. There they find a liar and a conspiracy to steal a young lady's fortune."),
        [@"Gaimon"] = new ArcMeta(
            Title: @"Gaimon",
            Overview: @"With Usopp now on the crew and their new ship, the Going Merry, under their command, the Straw Hats head to an island said to hold a fabled treasure. There they encounter a strange man stuck in a box who has been looking for the same treasure."),
        [@"Baratie"] = new ArcMeta(
            Title: @"Baratie",
            Overview: @"The Straw Hats head to the ocean-going restaurant, Baratie, with the hopes of recruiting one of their cooks. In the meantime, hungry yet powerful forces gather to lay siege to the restaurant — all while a menacing swordsman from the Grand Line steadily approaches."),
        [@"Arlong Park"] = new ArcMeta(
            Title: @"Arlong Park",
            Overview: @"Nami's hometown has long been overrun by Arlong and his band of fishmen from the Grand Line. When the Straw Hats arrive, they find that their prospective navigator has left out a few key details about herself."),
        [@"The Adventures of Buggy's Crew"] = new ArcMeta(
            Title: @"The Adventures of Buggy's Crew",
            Overview: @"Buggy, after being defeated by Luffy, Zoro, and Nami, begins his quest to regain his body parts and his crew, and then he will get his flashy revenge on Luffy."),
        [@"Loguetown"] = new ArcMeta(
            Title: @"Loguetown",
            Overview: @"The final island before entering the Grand Line: Loguetown. Luffy and his crew drop anchor to stock up, sightsee, and pay their respects to the place where Gold Roger drew his last breath."),
        [@"Reverse Mountain"] = new ArcMeta(
            Title: @"Reverse Mountain",
            Overview: @"Reverse Mountain is the entrance to the Grand Line. What await the Straw Hats are impossible water currents, a giant whale, and dubious people going by codenames."),
        [@"The Trials of Koby-Meppo"] = new ArcMeta(
            Title: @"The Trials of Koby-Meppo",
            Overview: @"Koby and Helmeppo are new cabin boys for the marines, but they become unwillingly involved in an escape attempt by Morgan. Their bravery will either earn them the respect of their superiors—as well as Vice Admiral Garp—or it will spell their doom."),
        [@"Whisky Peak"] = new ArcMeta(
            Title: @"Whisky Peak",
            Overview: @"The first island on the Grand Line is surprisingly welcoming to pirates. But as night falls, a deadly plot unravels."),
        [@"Little Garden"] = new ArcMeta(
            Title: @"Little Garden",
            Overview: @"The Straw Hats vow to bring Princess Vivi to Arabasta, and their journey brings them to Little Garden, an island from prehistoria that is home to creatures and people larger than life."),
        [@"Drum Island"] = new ArcMeta(
            Title: @"Drum Island",
            Overview: @"When Nami falls ill, the crew makes a detour from Arabasta to seek medical help. They happen upon a winter island inhabited by a distrusting populace and a single doctor with a mysterious reindeer companion."),
        [@"Arabasta"] = new ArcMeta(
            Title: @"Arabasta",
            Overview: @"Arabasta teeters on the edge of civil war, and it's up to Princess Vivi and the Straw Hats to stem the rebellion, uncover the plot of Baroque Works, and beat the Warlord Crocodile."),
        [@"Jaya"] = new ArcMeta(
            Title: @"Jaya",
            Overview: @"The Straw Hats seek the fabled sky island Skypiea and head to Jaya for information on its whereabouts. Their convictions are tested by the pirates of Mock Town, but not everyone on the island is a hardline skeptic."),
        [@"Skypiea"] = new ArcMeta(
            Title: @"Skypiea",
            Overview: @"Arriving at Skypiea, the Straw Hats are instantly met with unfamiliar sights, objects, and customs. What's more, the god of the sky island deems the Blue Sea dwellers to be trespassing and casts his judgment upon them."),
        [@"Long Ring Long Land"] = new ArcMeta(
            Title: @"Long Ring Long Land",
            Overview: @"On Long Ring Long Land, the Straw Hats are challenged to a Davy Back Fight. As they dive headfirst into a series of games with serious outcomes, the best the Navy has to offer has meanwhile begun to pay closer attention to certain Straw Hat crewmembers."),
        [@"Water Seven"] = new ArcMeta(
            Title: @"Water Seven",
            Overview: @"The Straw Hats make landfall at the glorious city of Water Seven, known worldwide for its unparalleled shipyards. The pirates go to inquire about repairs for their ship, but the city threatens to take their money, their ship, and their crewmates."),
        [@"Enies Lobby"] = new ArcMeta(
            Title: @"Enies Lobby",
            Overview: @"In order to free Nico Robin from the clutches of the World Government, the Straw Hats and their allies must invade the judicial island, Enies Lobby, and take on the government's premiere clandestine unit: CP9."),
        [@"Post-Enies Lobby"] = new ArcMeta(
            Title: @"Post-Enies Lobby",
            Overview: @"The Straw Hats return to Water Seven after the ordeal at Enies Lobby. While there, they are met by a familial vice admiral, and they await news of their new ship."),
        [@"Thriller Bark"] = new ArcMeta(
            Title: @"Thriller Bark",
            Overview: @"The Straw Hats' next destination is Fishman Island, but first they must traverse the dreaded Florian Triangle which is known for many eerie and mysterious things such as disappearing crews, conversational skeletons, and a floating island full of zombies and other horrors."),
        [@"Sabaody Archipelago"] = new ArcMeta(
            Title: @"Sabaody Archipelago",
            Overview: @"The second half of the Grand Line lays just ahead, so the Straw Hats stop at Sabaody Archipelago to plan the way forward. But being so close to the Holy Land and Navy Headquarters, Luffy's crew comes face-to-face with the darkest forces of the World Government."),
        [@"Amazon Lily"] = new ArcMeta(
            Title: @"Amazon Lily",
            Overview: @"Luffy is separated from his crew, and he finds himself on an unfamiliar island in the middle of the Calm Belt... an island inhabited only by women where men are prohibited from entering."),
        [@"Impel Down"] = new ArcMeta(
            Title: @"Impel Down",
            Overview: @"Luffy launches a daring rescue mission to break his big brother Ace from the government prison, Impel Down. It's a race to the prison's lowest levels — a literal journey through hell itself."),
        [@"If You Could Go Anywhere... The Adventures of the Straw Hats"] = new ArcMeta(
            Title: @"If You Could Go Anywhere... The Adventures of the Straw Hats",
            Overview: @"Somewhere in the world... Sanji resists, while Robin meets terrible people. Franky's not himself, and Usopp learns to survive. Chopper avoids becoming food, and Nami reports on the weather. Brook is repaid in underpants, and Zoro... is lost and annoyed."),
        [@"Marineford"] = new ArcMeta(
            Title: @"Marineford",
            Overview: @"Pirate Whitebeard and his allies on one side; the Navy and its Seven Warlords on the other. At the center of it all: Portgas D. Ace and his unspeakable past and heritage. Luffy races to Ace's execution scaffold as a battle between the world's most powerful people unfolds."),
        [@"Post-War"] = new ArcMeta(
            Title: @"Post-War",
            Overview: @"The war has taken its toll on the world, and Luffy reminisces about younger days when he first met Ace and became his brother. To become strong enough to withstand the New World, Luffy must make a critical decision for himself and his crew."),
        [@"Return to Sabaody"] = new ArcMeta(
            Title: @"Return to Sabaody",
            Overview: @"Two years have passed since the Straw Hats were forcibly separated, and they reconvene back at Sabaody stronger and even more committed to the journey ahead."),
        [@"Fish-Man Island"] = new ArcMeta(
            Title: @"Fishman Island",
            Overview: @"The path the to the New World takes the Straw Hats thousands of leagues under the sea to the underwater Fishman Island. However, the island's dark past is reaching a breaking point, and Luffy and his crew are caught in the middle of the conflict."),
        [@"Punk Hazard"] = new ArcMeta(
            Title: @"Punk Hazard",
            Overview: @"The first island of the New World is a strange place covered in flames on one half, and freezing temperatures on the other. What seems at first to be an unlivable place later reveals a laboratory, a maniac scientist, and a certain Warlord of the Sea."),
        [@"Dressrosa"] = new ArcMeta(
            Title: @"Dressrosa",
            Overview: @"Luffy's alliance with Law brings him next to Dressrosa to take down Doflamingo's booming business. But the crazed warlord and self-proclaimed ruler of Dressrosa has control over everyone and everything."),
        [@"Zou"] = new ArcMeta(
            Title: @"Zou",
            Overview: @"Zou cannot be reached by conventional means, nor is it easy to enter once one finds it. Within its secretive walls lie the Mink Tribe, and the Straw Hats soon discover that the people of Zou hold a piece of the puzzle that unlocks the mysteries of the world."),
        [@"Whole Cake Island"] = new ArcMeta(
            Title: @"Whole Cake Island",
            Overview: @"Luffy will not sail the seas without his cook, so he stubbornly goes after Sanji to Whole Cake Island. However, knocking on an emperor's door is easier said than done."),
        [@"Reverie"] = new ArcMeta(
            Title: @"Reverie",
            Overview: @"Every four years, the leaders of the world gather at the Holy Land to discuss a mutually agreed upon path for the government. During this particular Reverie, many parties with their own agendas arrive... and some are uninvited."),
        [@"Wano"] = new ArcMeta(
            Title: @"Wano",
            Overview: @"The Straw Hats finally regroup in Wano to carry out theirs and their allies' ultimate goal: to see to the Emperor Kaido's downfall and restore the Kozuki family to its rightful place of power."),
        [@"Egghead"] = new ArcMeta(
            Title: @"Egghead",
            Overview: @"Futuristic tech, giant alien monsters, battle robots, superhuman clones... Who are all these people calling themselves Dr. Vegapunk, and why is the government after one of their own?"),
        [@"One Piece Fan Letter"] = new ArcMeta(
            Title: @"One Piece Fan Letter",
            Overview: @"As the Straw Hat Pirates reunite on the Sabaody Archipelago, the various members of the island are drawn together like pieces of a puzzle, their love of certain members of the crew driving their actions and emotions."),
        [@"Specials"] = new ArcMeta(
            Title: @"Specials",
            Overview: @"Occasionally, the One Pace team likes to have some extra fun, so we made animated specials. See alternative storylines with twists you might not have expected."),
    };

    // Episode metadata (key: "Arc|Part")
    public static readonly Dictionary<string, EpisodeMeta> Episodes = new(StringComparer.OrdinalIgnoreCase)
    {
        [@"Amazon Lily|1"] = new EpisodeMeta(
            Title: @"Adventure on the Island of Women",
            Overview: @"Luffy finds himself alone, stranded and starving on an unfamiliar island. After a run-in with some exotic mushrooms, he is approached by a team of female warriors who could be friend... or foe."),
        [@"Amazon Lily|2"] = new EpisodeMeta(
            Title: @"Pirate Empress Boa Hancock",
            Overview: @"Luffy storms the village of women in hopes of acquiring a boat. However, a misstep lands him in the personal bath of none other than the Snake Princess. As he peers through the steam rising from its waters, he sees a forbidden secret etched upon her back."),
        [@"Amazon Lily|3"] = new EpisodeMeta(
            Title: @"The Arena",
            Overview: @"Luffy is sentenced to execution by arena combat with Boa Hancock’s serpentine sisters. Luffy soon discovers that the two women have a mysterious ability that allows them to slither through all his attacks unharmed."),
        [@"Amazon Lily|4"] = new EpisodeMeta(
            Title: @"Hancock's Confession",
            Overview: @"Impressed by Luffy’s efforts to protect the secret of the snake sisters, Hancock reveals the story behind the familiar mark on their backs. Their childhood was tragic, suffered at the hands of a corrupt group that Luffy knows all too well."),
        [@"Amazon Lily|5"] = new EpisodeMeta(
            Title: @"No One Can Stop This Now",
            Overview: @"As Luffy prepares to depart Amazon Lily, Hancock suddenly takes ill. Taking heed of the knowledge and wisdom of Elder Nyon, the Snake Princess “recovers,” and a plan to save Ace is quickly hatched."),
        [@"Arabasta|1"] = new EpisodeMeta(
            Title: @"Sir Crocodile, the Pirate",
            Overview: @"In Arabasta, the hero Crocodile appears and puts a decisive end to a pillaging band of pirates. Meanwhile, Mr. 2 Bon Kurei pays a visit to the newly arrived Straw Hats. When he puts his abilities on display, Vivi notices something shocking."),
        [@"Arabasta|2"] = new EpisodeMeta(
            Title: @"Landfall in Alabasta",
            Overview: @"The Merry makes landfall at Arabasta’s port town, and while the rest of the Straw Hats wisely don disguises, Luffy runs afoul of an old foe. However, a chance reunion with a flame-wielding member of Luffy’s family might just be the saving grace he needs!"),
        [@"Arabasta|3"] = new EpisodeMeta(
            Title: @"Adventure in the Kingdom of Sand",
            Overview: @"The Straw Hats finally start their arduous trek across the deserts of Arabasta! Along the way, they encounter martial-arts-loving dugongs, avian con artists, a giant carnivorous reptile, and a camel with very particular tastes in his passengers."),
        [@"Arabasta|4"] = new EpisodeMeta(
            Title: @"Yuba, the Town of Rebels",
            Overview: @"Vivi and co. finally reach Yuba, the last known location of the Rebel Army, but there is nary a soul in sight. Meanwhile, at the behest of their hidden leader, Baroque Works' officer agents begin to gather at the Spiders Cafe."),
        [@"Arabasta|5"] = new EpisodeMeta(
            Title: @"I Love My Country",
            Overview: @"At Rain Dinners, the Baroque Works officer agents are finally let on to Mr. 0's true identity. And just outside Yuba, Luffy confronts a stubborn Vivi to remind her who else is willing to stand with her."),
        [@"Arabasta|6"] = new EpisodeMeta(
            Title: @"Rainbase, the City of Dreams",
            Overview: @"Luffy's band reaches the city of Rainbase but encounter Smoker and Tashigi. As they defend themselves against both the Marines and Baroque Works' millions, Luffy's party storms Crocodile's Rain Dinners Casino."),
        [@"Arabasta|7"] = new EpisodeMeta(
            Title: @"It Begins",
            Overview: @"Luffy leads a daring—but foolish—raid on Crocodile’s casino. His poor planning lands him behind bars with Captain Smoker. But more importantly, these actions leave Vivi alone and unprotected."),
        [@"Arabasta|8"] = new EpisodeMeta(
            Title: @"Rebellion",
            Overview: @"“The king of Arabasta” appears to order Nanohana’s attack. With this, the people's anger explodes! Meanwhile, Vivi frantically looks for Sanji, and as Crocodile leaves the pirates to their fate, he is suddenly contacted by a ""Mr. Prince."""),
        [@"Arabasta|9"] = new EpisodeMeta(
            Title: @"Rush!!",
            Overview: @"Thanks to Sanji's brave actions, the Straw Hats made their escape, and Captain Smoker graciously looks the other way as they flee. However, as they set out toward Alubarna, Crocodile waylays Luffy, and the two begin a vicious duel."),
        [@"Arabasta|10"] = new EpisodeMeta(
            Title: @"Showdown at Alubarna",
            Overview: @"Vivi’s party speeds along toward Alubarna, as does the Rebel Army. While the Supersonic Duck Squad helps Zoro and the others play decoy, Vivi sets out on her own to try and stop Koza and his rebels."),
        [@"Arabasta|11"] = new EpisodeMeta(
            Title: @"Molehill Zone Four",
            Overview: @"Despite his severe injuries, Karoo picks up Vivi to flee the attacks of Mr. 2, and they dash madly through the battlefield. And at the southeast gate: Chopper and Usopp vs. Mr. 4 and Miss Merry Christmas!"),
        [@"Arabasta|12"] = new EpisodeMeta(
            Title: @"Okama Kenpo",
            Overview: @"Usopp and Chopper combine their skills to finish off Mr. 4 and Miss Merry Christmas, and Sanji engages Mr. 2 in a vicious foot-to-foot struggle. Meanwhile, as a last-ditch effort to save her people, Princess Vivi gives Chaka an unprecedented order."),
        [@"Arabasta|13"] = new EpisodeMeta(
            Title: @"She Who Controls the Weather",
            Overview: @"Nami combats Miss Doublefinger, whose Spike-Spike powers quickly turn their brawl into a losing battle. That is, until Usopp's invention, the Climate Baton, gives Nami a fighting chance. And at the palace, Crocodile reveals his ultimate goal."),
        [@"Arabasta|14"] = new EpisodeMeta(
            Title: @"Cutting Steel",
            Overview: @"Crocodile reveals he seeks the mysterious Pluton, Nami has one last chance to stop Miss Doublefinger, and Zoro struggles against Mr. 1. As Zoro confronts certain death, he must remember something his sensei once imparted."),
        [@"Arabasta|15"] = new EpisodeMeta(
            Title: @"The Leaders",
            Overview: @"Vivi reveals Crocodile's heinous plan to Koza. To stop the fighting, Koza raises the white flag but is suddenly shot. To induce even more panic, Crocodile announces that a massive bomb will be launched into the city, and he drops Vivi to her doom."),
        [@"Arabasta|16"] = new EpisodeMeta(
            Title: @"HOPE!!",
            Overview: @"Luffy vs. Crocodile: Round 2! Luffy has discovered Crocodile’s weakness, but the power of the Sand-Sand Fruit is devastating regardless. Meanwhile, the remaining Straw Hats have ten minutes to find a hidden cannoneer before a bomb is launched into the city."),
        [@"Arabasta|17"] = new EpisodeMeta(
            Title: @"Croc-ish",
            Overview: @"Luffy and Crocodile enter the third phase of their duel, and, without water at his disposal, Luffy is forced to improvise. Back on the surface, Vivi uses her knowledge of the city to finally pinpoint the location of the bomb's cannoneer."),
        [@"Arabasta|18"] = new EpisodeMeta(
            Title: @"I Will Defeat You",
            Overview: @"Vivi finds the cannon but realizes the bomb can't be stopped so casually. Then Pell swoops in with a decisive, if tragic, solution. The final battle between Luffy and Crocodile, which has both parties driven to their utmost, reaches its conclusion."),
        [@"Arabasta|19"] = new EpisodeMeta(
            Title: @"Some Justice",
            Overview: @"Igaram appears with proof of Cobra's innocence, and Koza tells the people the truth behind the war. Luffy and his crew are brought into Cobra's palace to rest, and, during this time, Igaram receives word that there are new bounties making the rounds!"),
        [@"Arabasta|20"] = new EpisodeMeta(
            Title: @"Vivi's Adventure",
            Overview: @"As the Straw Hats make their escape from Arabasta, Bon Kurei and his men serve to distract Black Cage Hina of the Marines. Meanwhile, Vivi must make a speech, but, more importantly, she must decide whether to stay with the Straw Hats."),
        [@"Arabasta|21"] = new EpisodeMeta(
            Title: @"Stowaway",
            Overview: @"The Straw Hats have evaded the Marines, but a new development crops up when a certain stowaway makes her presence on the Going Merry known… and she wants to be part of the crew!"),
        [@"Arlong Park|1"] = new EpisodeMeta(
            Title: @"Arlong Park",
            Overview: @"As they depart the Baratie in pursuit of Nami and the Going Merry, Yosaku warns Luffy and Sanji about the vicious Arlong and his fishman underlings. Meanwhile, Usopp, Johnny, and Zoro make landfall where Nami docked the Merry."),
        [@"Arlong Park|2"] = new EpisodeMeta(
            Title: @"Monsters of the Grand Line",
            Overview: @"Usopp, having challenged the fishmen, has been caught. To effectively prove her loyalty to the Arlong Pirates, Nami is left with a morbid choice."),
        [@"Arlong Park|3"] = new EpisodeMeta(
            Title: @"Sea Charts and Fishmen",
            Overview: @"Luffy’s group has reached the island but are met with a shocking revelation. Unmoved by Nami’s apparent actions and her insistence that he leaves, Luffy stubbornly sticks around."),
        [@"Arlong Park|4"] = new EpisodeMeta(
            Title: @"Bell-mère",
            Overview: @"Nojiko goes into detail about Nami's childhood and their adoptive mother Bell-mère, a former Marine. Despite being poor and unrelated by blood, they had a happy life on their tangerine orchard."),
        [@"Arlong Park|5"] = new EpisodeMeta(
            Title: @"Live",
            Overview: @"When a Marine officer under Arlong's pay confiscates all the money Nami accumulated over the years, it becomes clear where Arlong stands on his promise."),
        [@"Arlong Park|6"] = new EpisodeMeta(
            Title: @"OK, LET'S STAND UP",
            Overview: @"Nami's audible sorrows have reached the ears of a certain Straw Hat captain, and he and his crew rise to action. The villagers look on in awe as the Straw Hats boldly enter Arlong Park to face the fishmen."),
        [@"Arlong Park|7"] = new EpisodeMeta(
            Title: @"Chivalry vs. Fishman Karate",
            Overview: @"Luffy’s newest move leaves him incapacitated and at the mercy of the sea while Zoro, Sanji, and Usopp desperately fight off Arlong’s top officers."),
        [@"Arlong Park|8"] = new EpisodeMeta(
            Title: @"My Turn",
            Overview: @"The top officers are defeated, but as they currently are, Sanji and Zoro prove to be no match for Arlong. However, with Luffy finally free, he just may just be able to pull it off. Meanwhile, Nami finally gathers the courage to face Arlong."),
        [@"Arlong Park|9"] = new EpisodeMeta(
            Title: @"Happiness",
            Overview: @"Luffy springs into action against Arlong, and their intense struggle commences! Luffy becomes enraged when he discovers how exactly Arlong had been using Nami, and he comes to a quick decision on how to finally free her of her shackles."),
        [@"Arlong Park|10"] = new EpisodeMeta(
            Title: @"Spin, Pinwheel, Spin",
            Overview: @"Arlong's reign of terror is over, so the island throws a party to celebrate their freedom and to honor their pirate saviors. During the festivities, Nami makes her decision to officially join the Straw Hat Pirates."),
        [@"Baratie|1"] = new EpisodeMeta(
            Title: @"Enter: Sanji",
            Overview: @"The Straw Hats happen across Zoro's former partners, Yosaku and Johnny, whose dietary dilemma reminds the pirates they still need a cook on their ship. Thus, they set sail for the sea restaurant Baratie, hoping to snag a chef."),
        [@"Baratie|2"] = new EpisodeMeta(
            Title: @"Pirate Commodore Don Krieg",
            Overview: @"Luffy is on hiatus from pirating to work as a cabin boy to pay off the damage done to the Baratie. While he tries to convince Sanji to join his crew, the pirate Gin brings the infamous Don Krieg and his starving forces to the sea restaurant."),
        [@"Baratie|3"] = new EpisodeMeta(
            Title: @"The Oath",
            Overview: @"As Nami steals the Going Merry, Hawk-Eye Mihawk, known far and wide as the world's greatest swordsman, arrives all the way from the Grand Line to finish off Don Krieg. However, Zoro challenges the deadly Mihawk to a duel in order to achieve his dream."),
        [@"Baratie|4"] = new EpisodeMeta(
            Title: @"Pearl",
            Overview: @"Mihawk departs after defeating Zoro, and Krieg continues his assault on the Baratie. Pearl, one of Krieg's strongest men, goes on the offensive with fiery attacks and multiple shields at his disposal, so Sanji reveals his unique fighting style."),
        [@"Baratie|5"] = new EpisodeMeta(
            Title: @"Because of a Dream",
            Overview: @"Sanji continues to battle Pearl, but Gin cleverly holds Chef Zeff hostage, forcing Sanji an impossible situation. Sanji's childhood memories flood his mind, and he reflects on why Zeff means so much to him."),
        [@"Baratie|6"] = new EpisodeMeta(
            Title: @"MH5",
            Overview: @"In a surprising twist, Gin finishes Pearl off himself, claiming Sanji as his own target. Though still wounded, Sanji rises to the challenge and faces off with Gin. As the battle draws to a close, Don Krieg unleashes a deadly toxin into the air."),
        [@"Baratie|7"] = new EpisodeMeta(
            Title: @"The Stalwart War Spear",
            Overview: @"The struggle with Krieg nears its end. Luffy's fighting spirit is unwavering, even after taking several hits from Krieg's Stalwart War Spear. Straw Hat’s strategy shifts to smashing through Krieg’s defenses and attacking the spear head-on."),
        [@"Baratie|8"] = new EpisodeMeta(
            Title: @"The Fourth",
            Overview: @"As the dust of battle settles, the still poisoned Gin decides to go back to the Grand Line with Krieg, and Sanji makes the difficult decision to join Luffy's crew. Suddenly, Yosaku returns with news of where Nami took the Going Merry."),
        [@"Dressrosa|1"] = new EpisodeMeta(
            Title: @"Arriving at Dressrosa! The Country of Passion, Love, and Toys!",
            Overview: @"Dressrosa! The Straw Hats split up and set about their business on this passionate, enchanting island! But here, in the heart of enemy territory, danger lurks around every corner. Luffy’s group encounters an intriguing blind man whose luck has run dry."),
        [@"Dressrosa|2"] = new EpisodeMeta(
            Title: @"Corrida Colosseum! The Great Tournament",
            Overview: @"Zoro and co. strike off in search of the thieving fairy who has taken Zoro's sword, but Sanji gets distracted by the alluring dancing of a gorgeous Dressrosan. Meanwhile, the prize of the late Ace’s devil fruit draws Luffy and Franky to the colosseum."),
        [@"Dressrosa|3"] = new EpisodeMeta(
            Title: @"The Colosseum of Many New Faces and Maynard the Pursuer!",
            Overview: @"Luffy enters the tournament at Corrida Colosseum to compete for Ace's fruit, but with the mightiest warriors of the New World assembled and standing in his way, the competition will not be easy. The first stage of the competition is a battle royal!"),
        [@"Dressrosa|4"] = new EpisodeMeta(
            Title: @"Bellamy's Changed Motivations and B Block's Start!",
            Overview: @"When Block A concludes, the crowds are shocked to discover the secret identity of the winner. Block B commences, and the widely despised Bartolomeo takes the ring, but he will have to contend with Dressrosa's own local favorite, Bellamy!"),
        [@"Dressrosa|5"] = new EpisodeMeta(
            Title: @"B Block on Fire! Outlandish Competitors and King Punch!",
            Overview: @"The battle in Block B hits a crescendo as the Fighting King Elizabello II prepares his devastating King Punch! But as the powerful attack becomes imminent, the Kingdom of Prodence faction unravels!"),
        [@"Dressrosa|6"] = new EpisodeMeta(
            Title: @"To Green Bit! The Adventure in the Land of Dwarves!",
            Overview: @"The Caesar Transfer Team is on approach to Green Bit, but the colossal coastal fish of Dressrosa are biting, and the connecting bridge has collapsed! The team gathers their wits to make it across, but they soon discover they are not alone on the island."),
        [@"Dressrosa|7"] = new EpisodeMeta(
            Title: @"Doflamingo Arrives! The Ultimate Schemer!",
            Overview: @"All but done for, Sanji is trapped by Violet and her crew when she suddenly changes her mind and mysteriously turns on her own men! Sanji gets in touch with Law to share a shocking secret that could unsettle all their plans in Dressrosa."),
        [@"Dressrosa|8"] = new EpisodeMeta(
            Title: @"Closely Contested Block C! Lucy and Ucy!",
            Overview: @"The Sunny is mysteriously deformed by Giolla’s strange powers! Meanwhile, the battle for Block C is under way, but Luffy suffers a staggering setback. He eventually knocks down the giant Hajrudin, but Chinjao has his sights set on Garp’s grandson!"),
        [@"Dressrosa|9"] = new EpisodeMeta(
            Title: @"C Block's Blazing Battle and the Forgotten of Dressrosa!",
            Overview: @"In the colosseum, Chinjao finally faces Luffy and reveals the old grudge he bears against Garp! Meanwhile, Usopp and Robin get swept up in the Tontattas' raid against the royal family, and Franky learns the eerie secret of Dressrosa’s living toys."),
        [@"Dressrosa|10"] = new EpisodeMeta(
            Title: @"The Tontatta Rebellion and the C Block Finale!",
            Overview: @"The Tontattas gear up for their all-out assault on the Doflamingo Family, and Usopp and Robin are caught up in the war effort! Meanwhile, Luffy concludes his earth-shattering fight to the death with Don Chinjao."),
        [@"Dressrosa|11"] = new EpisodeMeta(
            Title: @"A Sad Past! Rebecca and Soldier-san",
            Overview: @"A voice from the past unsettles Luffy and sends him into a rage! Also, it's discovered that Rebecca's eternal bond with the one-legged toy soldier is linked to the violent overthrow of the old regime, perpetrated by none other than Doflamingo!"),
        [@"Dressrosa|12"] = new EpisodeMeta(
            Title: @"D Block's Fiery Start and the Heavenly Demon's Revelation!",
            Overview: @"As Rebecca enters the ring for the battle for Block D, the crowd shows its contempt for her heritage and vicious contenders set their sights on her. Meanwhile, Law is pinned by Fujitora, and Doflamingo has the upper hand."),
        [@"Dressrosa|13"] = new EpisodeMeta(
            Title: @"Law's New Strategy and the Colosseum's Underground Nightmare!",
            Overview: @"Law must put himself in harm's way to defend the Sunny and the Straw Hats from Doflamingo's all-out assault. Meanwhile, Bartolomeo searches the colosseum for Luffy and discovers something strange about the medical center for the defeated."),
        [@"Dressrosa|14"] = new EpisodeMeta(
            Title: @"The Plight of the Riku Clan! The Lurking Hero Awaits in the Shadows!",
            Overview: @"The losers of the colosseum who are being held below the infirmary have an unexpected addition to their numbers. Meanwhile, the history of Tontatta is made clear, as is the shocking identity of the toy soldier!"),
        [@"Dressrosa|15"] = new EpisodeMeta(
            Title: @"Doflamingo's Relentless Pursuit",
            Overview: @"Revealed is the sad fate of King Riku, his army, and his daughter, Princess Viola, as well as how the people of Dressrosa fell into the hands of Doflamingo. Not to mention, all the toys in the country share a mysterious secret."),
        [@"Dressrosa|16"] = new EpisodeMeta(
            Title: @"SOP Strategy",
            Overview: @"Zoro and Kin'emon make a mad dash to save Law, but Admiral Fujitora stands in their way, bringing his full power against them. The toy soldier lays out the plan to liberate the Tontattas and bring down the Doflamingo Family: Operation SOP."),
        [@"Dressrosa|17"] = new EpisodeMeta(
            Title: @"The Underground World",
            Overview: @"Usopp and Robin travel via an underground tunnel dug by the tiny people of the Tontatta Tribe. On the surface, Franky makes his way to the Toys House to cause a distraction to help his crewmates, but standing in his way is quite the guy!"),
        [@"Dressrosa|18"] = new EpisodeMeta(
            Title: @"Fujitora's Outlook",
            Overview: @"Viola, once a princess of the Dressrosan royal family, shows Luffy and the others a secret entrance into the palace. In the meantime, Admiral Fujitora reveals his audacious plans for the Seven Warlords of the Sea!"),
        [@"Dressrosa|19"] = new EpisodeMeta(
            Title: @"Diamante and Pica",
            Overview: @"The final round at Corrida Colosseum kicks off, and Diamante joins the combatants in an all-out struggle to win the prize! Meanwhile, Luffy and co., en route to Doflamingo, are faced with an immovable member of the Donquixote Family."),
        [@"Dressrosa|20"] = new EpisodeMeta(
            Title: @"Captain",
            Overview: @"With Operation SOP in its final stage, the Tontattas are devastated by Trebol’s furious attack, but as Usopp tries to convince Leo to abort the operation, Leo tells him about their commander’s stunning true identity."),
        [@"Dressrosa|21"] = new EpisodeMeta(
            Title: @"Usoland the Liar",
            Overview: @"With the Tontattas beaten, Robin turned into a toy, and Luffy, Franky, and the others busy elsewhere, Usopp is the last hope for Operation SOP! Among the cries of the Tontattas, Usopp has a difficult decision to make."),
        [@"Dressrosa|22"] = new EpisodeMeta(
            Title: @"Dressrosa in Turmoil",
            Overview: @"Usopp creates a miracle! Toys across Dressrosa regain their true forms, a flood of lost memories return, and a forgotten hero launches a long overdue attack on the villainous tyrant Doflamingo!"),
        [@"Dressrosa|23"] = new EpisodeMeta(
            Title: @"Bird Cage",
            Overview: @"Sabo makes a risky move to end the championship battle, and Luffy hurries to free Law. Doflamingo's apparent defeat has thrown Dressrosa into chaos, but he may have a trick or two left up his sleeve."),
        [@"Dressrosa|24"] = new EpisodeMeta(
            Title: @"Executive Officer Pica",
            Overview: @"Doflamingo announces the rules for his deadly game with the highest bounty reserved for… Usopp! As Luffy and co. head toward the palace, Fujitora stands in their way, and Pica emerges in town to change the stakes of the game."),
        [@"Dressrosa|25"] = new EpisodeMeta(
            Title: @"Onward!! Army of Rogues",
            Overview: @"The game is afoot, and Luffy finds that the dastardly Warlord has more enemies than he might realize! Strangely, an argument breaks out to decide who gets the honor of taking down Doflamingo once and for all!"),
        [@"Dressrosa|26"] = new EpisodeMeta(
            Title: @"The State of the War",
            Overview: @"Law's reason for despising Doflamingo is revealed! Luffy heads toward Doflamingo's refuge, making his way through the guards, while down below Admiral Fujitora faces off against Sabo, who is now armed with a familiar fiery power!"),
        [@"Dressrosa|27"] = new EpisodeMeta(
            Title: @"Battle",
            Overview: @"Heavy hitters from the colosseum turn from wringing each other's necks toward a unified plan, which might be just enough to give Luffy the chance he needs to make it to a final showdown with Doflamingo."),
        [@"Dressrosa|28"] = new EpisodeMeta(
            Title: @"A Man's World",
            Overview: @"Cavendish shares his fears that the ""Birdcage"" game Doflamingo is playing has been rigged all along! Meanwhile, the Tontattas are in full revolt, Zoro finally gains the upper hand against Pica, and Franky finds a way to deal with Senor Pink."),
        [@"Dressrosa|29"] = new EpisodeMeta(
            Title: @"Trump Card",
            Overview: @"Gladius' exploding spheres send Robin and Bartolomeo hurtling directly into Luffy and co.’s battle with some creepy dolls. Rebecca makes it to the Flower Field alone, and Sabo tastes Fujitora's full might!"),
        [@"Dressrosa|30"] = new EpisodeMeta(
            Title: @"Secret Plan",
            Overview: @"Luffy and Law finally surmount incredible odds to land themselves in striking distance of Doflamingo. However, Sugar stands in their way, so Usopp uses Viola's clairvoyance to prepare his ammunition to take her out."),
        [@"Dressrosa|31"] = new EpisodeMeta(
            Title: @"The Operation Fruit",
            Overview: @"All hopes rest on Luffy and Law being able to take down Doflamingo; however, the Warlord has other plans in mind as he gives the two the fight of their lives, and he reveals his true, shocking history! Meanwhile, Sabo finds out Fujitora’s true intention."),
        [@"Dressrosa|32"] = new EpisodeMeta(
            Title: @"White Town",
            Overview: @"A rage born from the lies of the World Government created a child who had the will to try and kill Corazón! Law was accepted into the Doflamingo Family, but Corazón's mysterious silence hid a fact that just may have saved Law's life."),
        [@"Dressrosa|33"] = new EpisodeMeta(
            Title: @"The Island of Fate: Minion",
            Overview: @"Things grew stranger for Law when he learned the secret behind why Corazón feigned being mute. But the mysterious Corazón’s actions were only beginning to baffle Law when he took him on a journey to cure the youth’s disease."),
        [@"Dressrosa|34"] = new EpisodeMeta(
            Title: @"Cora",
            Overview: @"Corazón had finally obtained the Op Op Fruit! Doflamingo and his Family were zeroing in on Corazón and Law's whereabouts, so Corazón hid Law long enough to let him escape, even at the risk of his own life."),
        [@"Dressrosa|35"] = new EpisodeMeta(
            Title: @"Bellamy the Pirate",
            Overview: @"Luffy continues to fight the Doflamingo doppelganger but keeps accidentally attacking Bellamy instead. Meanwhile, the tide of battle turns against Law as painful scars from the past resurface, and Zoro gets unexpected help in his battle with Pica."),
        [@"Dressrosa|36"] = new EpisodeMeta(
            Title: @"The Spear of Elbaph and Don Sai",
            Overview: @"Hajrudin has been beaten down, but a fire still burns within him to pay back the favor he owes! Lao G and Don Chinjao bring their most devastating attacks to bear, but a misunderstanding caused by Baby 5 has Sai and Don Chinjao distracted."),
        [@"Dressrosa|37"] = new EpisodeMeta(
            Title: @"Cabbage and Lomeo",
            Overview: @"A mysterious force that resembles Cavendish menaces the battlefield! While it appears to help Bartolomeo and co. at first, it soon sets its sights on Robin! As he continues to battle Gladius, Bartolomeo is faced with an impossible dilemma."),
        [@"Dressrosa|38"] = new EpisodeMeta(
            Title: @"To Russian, with Love",
            Overview: @"Senor Pink and Franky continue their knock-down, drag-out, manly fight. As both are pushed to their limits, Senor Pink's tragic past is revealed! Meanwhile, Princess Mansherry's rescue hits a snag as she stubbornly refuses to leave!"),
        [@"Dressrosa|39"] = new EpisodeMeta(
            Title: @"Zoro vs. Pica",
            Overview: @"Pica loses his temper and becomes a terrible and true force of nature. With the lives of King Riku, Usopp, and the others in the balance, Zoro must dig deep and discover a powerful technique to counter Pica's near-unstoppable onslaught."),
        [@"Dressrosa|40"] = new EpisodeMeta(
            Title: @"The Curse of Heart",
            Overview: @"The Tontattas finish demolishing the SMILE Factory and taking down Bellamy only enrages Luffy in his fight against Doflamingo, his anger multiplying when he finds Law's lifeless body! Meanwhile, the birdcage draws ever tighter around Dressrosa."),
        [@"Dressrosa|41"] = new EpisodeMeta(
            Title: @"In My Way",
            Overview: @"Law summons enough energy to speak, denouncing the Doflamingo Family executives as pawns in Doflamingo's game. Meanwhile, neither Gear Second nor Gear Third attacks are working against Doflamingo, so Luffy decides to use something stronger!"),
        [@"Dressrosa|42"] = new EpisodeMeta(
            Title: @"Gear Fourth",
            Overview: @"The birdcage tightens its grip on Dressrosa, so Zoro sets off with a plan to stop it from slicing apart the country. Meanwhile, Luffy digs deep into his training to provide an answer born of rubber and haki to combat Doflamingo’s might."),
        [@"Dressrosa|43"] = new EpisodeMeta(
            Title: @"Gatz",
            Overview: @"Using Boundman drains Luffy of his haki, leaving him in need of a rest. Luckily, the colosseum combatants run interference while he recharges, and Sabo steps in at a crucial moment to defend his brother."),
        [@"Dressrosa|44"] = new EpisodeMeta(
            Title: @"Heaven and Earth",
            Overview: @"With just over a minute to spare, everyone in Dressrosa turns their efforts toward slowing the birdcage. Meanwhile, Rebecca, under the control of Doflamingo, advances to attack Viola, and a hero’s recovery cannot come soon enough!"),
        [@"Dressrosa|45"] = new EpisodeMeta(
            Title: @"Prostration",
            Overview: @"The people of Dressrosa shed tears of joy as they remember the hardships endured and the actions taken to free them. As they beg King Riku to resume the crown, Admiral Fujitora shocks onlookers with an unexpected display of humility."),
        [@"Dressrosa|46"] = new EpisodeMeta(
            Title: @"Sabo's Adventure",
            Overview: @"The combatants in the battle for Dressrosa can finally begin to recoup, but those who stay awake are treated to the story of how Sabo joined the Revolutionary Army and how he reunited with his brother Luffy at the colosseum."),
        [@"Dressrosa|47"] = new EpisodeMeta(
            Title: @"Soldier's Conviction",
            Overview: @"Major players in the Marines arrive to search Dressrosa for the Straw Hats, and Rebecca's history is whitewashed with a cover story. Luffy and the others make a mad dash for the east port, but not before finishing up a piece of business."),
        [@"Dressrosa|48"] = new EpisodeMeta(
            Title: @"Father and Sons",
            Overview: @"Law and Sengoku share memories of Corazón and the secret of Trafalgar Law's name. Luffy and the others finally make their break from the island; however, an unbelievable new chapter opens in the story of the Straw Hat Pirates!"),
        [@"Drum Island|1"] = new EpisodeMeta(
            Title: @"Tin Plate Wapol",
            Overview: @"En route to Arabasta, Nami falls ill. Without a doctor aboard the Going Merry, the Straw Hats must decide whether to stay the course or find more immediate help. As their ship crosses into a frigid area, a figure is seen standing on the water's surface."),
        [@"Drum Island|2"] = new EpisodeMeta(
            Title: @"Adventure in a Nameless Country",
            Overview: @"If the Straw Hats have any chance of saving Nami, they must carry her up a mountain to see the sole doctor of a nameless, winter island. While Sanji and Luffy fight off the wilderness, a despicable king makes an unwanted return."),
        [@"Drum Island|3"] = new EpisodeMeta(
            Title: @"The Summit",
            Overview: @"A devastating avalanche sweeps Drum Island and puts everyone at risk, but Luffy—step-by-step, hand-over-hand—continues his death-defying ascent up the mountain. Meanwhile, Vivi, Usopp, and Zoro reunite in the wake of the disaster."),
        [@"Drum Island|4"] = new EpisodeMeta(
            Title: @"Enter: Tony Tony Chopper",
            Overview: @"Enter Chopper: a talking, transforming blue-nosed reindeer who was trained by Dr. Kureha in medicine. The Straw Hats immediately see the positives and want him on their crew, but Chopper must first deal with the monstrous pain in his heart."),
        [@"Drum Island|5"] = new EpisodeMeta(
            Title: @"Quack Doctor",
            Overview: @"Chopper began life as an ordinary reindeer but was shunned by his own kind because of his unusual blue nose. Even after eating the Human-Human Devil Fruit, the islanders wanted nothing to do with him. That is, until Chopper met a certain quack doctor."),
        [@"Drum Island|6"] = new EpisodeMeta(
            Title: @"Unbreakable",
            Overview: @"Wapol and his comrades reach the mountaintop castle to wrest control of it back from Dr. Kureha and Chopper. Luffy, Sanji, and Chopper go head-to-head against his Munch-Munch powers, vowing to keep Wapol and his men from bringing down Hiriluk's flag."),
        [@"Drum Island|7"] = new EpisodeMeta(
            Title: @"The Skies of Drum",
            Overview: @"Chopper counters the combined Chessmarimo with an item that expands his zoan fruit abilities. Wapol slips away into his old castle, but Luffy runs after him to force a final showdown."),
        [@"Drum Island|8"] = new EpisodeMeta(
            Title: @"Hiriluk's Cherry Blossoms",
            Overview: @"Finally convinced to join the Straw Hat Pirates, Chopper announces his intentions to Dr. Kureha. While she doesn’t receive the news well at first, she decides to give the Straw Hats a fond parting gift while they exit the island."),
        [@"Egghead|1"] = new EpisodeMeta(
            Title: @"New Emperors",
            Overview: @"The Straw Hats rave over new bounties, and Crocodile and Mihawk pay Buggy a visit. Elsewhere, Dragon and his revolutionaries are shocked when they read about Sabo in the news, and an old comrade returns, a shell of his former self."),
        [@"Egghead|2"] = new EpisodeMeta(
            Title: @"The Matter Involving Captain Koby",
            Overview: @"The three-way struggle between the Marines, the Blackbeard Pirates, and the Kuja Pirates comes to an end when an unexpected figure shows up. On the Sunny, the Straw Hats talk about the recent incidents around the world and Luffy’s words surprise everyone."),
        [@"Egghead|3"] = new EpisodeMeta(
            Title: @"Future Island Egghead",
            Overview: @"Sabo contacts his comrades, which prompts a certain eavesdropper to take action against an entire island nation! Meanwhile, Luffy, Chopper, and Jinbe alongside a mysterious girl become separated from the rest of the Straw Hats when a giant shark attacks."),
        [@"Egghead|4"] = new EpisodeMeta(
            Title: @"Adventure in the Land of Science",
            Overview: @"Franky and Luffy's groups are split up, but each encounter a person claiming to be Dr. Vegapunk. On the island, Luffy and co. find convenient food and futuristic clothing, but when a pacifista shows up, Bonney reveals her shocking relationship with Kuma."),
        [@"Egghead|5"] = new EpisodeMeta(
            Title: @"The Six Vegapunks",
            Overview: @"Lilith takes the Sunny and its remaining crew to the laboratory in the clouds, where a new threat lurking within its corridors attacks unexpectedly. As the battle ensues, Vegapunk's satellites look on with excitement."),
        [@"Egghead|6"] = new EpisodeMeta(
            Title: @"The Will of Ohara",
            Overview: @"Vegapunk Shaka shares his theory about an ancient kingdom and the Void Century. He also reminisces about the foundation of Dragon's Revolutionary Army. Meanwhile, Luffy and Chopper try to activate the giant robot when something surprising happens."),
        [@"Egghead|7"] = new EpisodeMeta(
            Title: @"Punk Records",
            Overview: @"After Vegapunk shares his dream with Luffy's group, he asks the Straw Hat captain for a big favor. Meanwhile, CP0 ignores their lack of invitation to Egghead and get around the island defenses to make landfall."),
        [@"Egghead|8"] = new EpisodeMeta(
            Title: @"The Strongest Form of Humanity",
            Overview: @"As the rematch between Luffy and Lucci kicks off, Dr. Vegapunk notices something very fascinating about the Straw Hat captain's new abilities. Meanwhile, Sentomaru arrives with the latest pacifista models as a very unlikely ally to the pirates!"),
        [@"Egghead|9"] = new EpisodeMeta(
            Title: @"The Weight of Memory",
            Overview: @"To avenge her father, Bonney chases Dr. Vegapunk through the lab, but a familiar symbol catches her eye. As she investigates, the satellites call in an unexpected favor to finally deal with CP0's rampage outside the lab."),
        [@"Egghead|10"] = new EpisodeMeta(
            Title: @"Miss Buckingham Stussy",
            Overview: @"Upon mysterious orders, Stussy betrays Lucci and Kaku. Lilith and Edison also hurry outside the lab to stop the rampaging seraphim. Meanwhile, the main Dr. Vegapunk goes missing, and Admiral Kizaru escorts a powerful and commanding entity toward Egghead."),
        [@"Egghead|11"] = new EpisodeMeta(
            Title: @"Labophase Death Game",
            Overview: @"The search for Dr. Vegapunk's main body is threatened by the deadly seraphim, only this time the satellites' orders are unable to pacify them. Faced with a tough decision, Luffy and Zoro must team up with the most unlikely of allies."),
        [@"Egghead|12"] = new EpisodeMeta(
            Title: @"Escape Limit",
            Overview: @"Luffy, Zoro, Lucci, and Kaku combine their might, and a chivalrous cook rescues Nami from near defeat. Meanwhile, Lilith, Usopp, and Franky are stopped in their tracks by someone very deadly, yet very cute."),
        [@"Egghead|13"] = new EpisodeMeta(
            Title: @"The Emperor's Crew, The Red Hair Pirates",
            Overview: @"Eustass ""Captain"" Kid sails in, guns blazing against Elbaph while Shanks of the Red Hair Pirates defends his crew and friends... without an ounce of mercy."),
        [@"Egghead|14"] = new EpisodeMeta(
            Title: @"The Legendary Hero",
            Overview: @"While Koby desperately attempts to flee Beehive, Cross Guild's bounty entices the hundreds of pirates there to hunt him down. But before they can seal his fate and claim the prize, a familiar Marine warship descends from the sky!"),
        [@"Egghead|15"] = new EpisodeMeta(
            Title: @"Let's Go and Take It!!",
            Overview: @"While Cross Guild grows into a serious concern for the Marines, Buggy makes an impassioned speech to spur his crew into a zealous fervor. Additionally, Sabo returns to his comrades and begins his report on the events that happened at the Reverie."),
        [@"Egghead|16"] = new EpisodeMeta(
            Title: @"The Attempted Murder of a Celestial Dragon",
            Overview: @"During the Reverie, Sabo and Bonney met and worked together toward the same goal. King Cobra also met with the Five Elders to ask some hard questions, in the process learning the dark truth of the world."),
        [@"Egghead|17"] = new EpisodeMeta(
            Title: @"The Five Elders",
            Overview: @"At the time of the Reverie, Wapol overheard something he shouldn't have and fled the Holy Land with an unlikely partner. On the heels of these events, Imu ordered the Five Elders to test a devastating weapon engineered by Dr. Vegapunk!"),
        [@"Egghead|18"] = new EpisodeMeta(
            Title: @"The Final Lesson",
            Overview: @"At Pirate Island, Vice Admiral Garp continues the Koby extraction mission, but Avalo Pizarro's devil fruit powers threaten to sink the rescue ship. Garp, weakened from an attack by Shiryu, entrusts the operation's success to the next generation."),
        [@"Egghead|19"] = new EpisodeMeta(
            Title: @"Hostage Situation",
            Overview: @"In the Labophase on Egghead, which is completely surrounded by the Marines, Luffy and the others devise a plan to escape the island. However, the Frontier Dome, the laser defense system, cannot be deactivated without York’s secret passcode."),
        [@"Egghead|20"] = new EpisodeMeta(
            Title: @"Sentomaru",
            Overview: @"Admiral Kizaru finally makes landfall, but Sentomaru stands in his way while the Straw Hats attempt to move the Sunny to the back side of the island. And back at Mary Geoise, Fleet Admiral Akainu stands in the way of the ever-advancing Kuma."),
        [@"Egghead|21"] = new EpisodeMeta(
            Title: @"Luffy vs. Kizaru",
            Overview: @"Luffy faces off in a spectacular aerial battle against Admiral Kizaru, but this time, Straw Hat is 100 times stronger than before. Unbeknownst to those on Egghead, something ominous is about to make an appearance on the island..."),
        [@"Egghead|22"] = new EpisodeMeta(
            Title: @"Kumachi",
            Overview: @"Born with the rare blood of the Buccaneer people, young Kuma was fated to lead a life of persecution at the hands of the Celestial Dragons, but his father instilled hope within him through the legend of Nika and the Drums of Liberation."),
        [@"Egghead|23"] = new EpisodeMeta(
            Title: @"Ginny",
            Overview: @"Kuma lived with Ginny in his old village until the injustices of the world pushed them to join Iva and Dragon as revolutionaries. However, when tragedy befell Ginny, Kuma found a new purpose in life in the newborn she left behind."),
        [@"Enies Lobby|1"] = new EpisodeMeta(
            Title: @"The Superhumans of Enies Lobby",
            Overview: @"As the Straw Hats and their allies approach Enies Lobby on Rocketman, they hatch a plan to save Robin before she passes through the Gates of Justice. Meanwhile, Spandam holds a meeting with CP9 where they await Lucci's return in the Tower of Justice."),
        [@"Enies Lobby|2"] = new EpisodeMeta(
            Title: @"The Big Showdown on the Judiciary Island!!",
            Overview: @"Luffy launches a one-man assault on Enies Lobby, and the rest of his allies work to break the first gate's defenses. What awaits Galley-La and the Franky Family at the second gate is a showdown of massive proportions!"),
        [@"Enies Lobby|3"] = new EpisodeMeta(
            Title: @"Express to the Main Island of Enies Lobby",
            Overview: @"Robin and Franky are finally brought before Spandam while Luffy continues to blast through waves of marines. Galley-La and the Franky Family still have one giant to deal with, and the main gate closes to halt Rocketman's entry."),
        [@"Enies Lobby|4"] = new EpisodeMeta(
            Title: @"Fired",
            Overview: @"The Straw Hats struggle to catch up to Luffy, who is already on the main island wreaking havoc for the Marines. Meanwhile, Robin learns from Spandam that the terms of their deal have changed, and he somehow has rights to a buster call."),
        [@"Enies Lobby|5"] = new EpisodeMeta(
            Title: @"Raise the Counterattack Signal",
            Overview: @"Luffy makes it just outside the courthouse when Blueno of CP9 appears before him, and on the main road, the Straw Hats near the courthouse plaza aboard Sodom and Gomorrah. Meanwhile, Sogeking comes across a dejected Oimo."),
        [@"Enies Lobby|6"] = new EpisodeMeta(
            Title: @"Unprecedented",
            Overview: @"Kaku and Kalifa of CP9 are offered a rare chance for new powers and are each served a devil fruit. The Straw Hats finally arrive at the courthouse plaza when Spandam receives an urgent call, and he realizes things are much worse than previously reported."),
        [@"Enies Lobby|7"] = new EpisodeMeta(
            Title: @"Gear Second",
            Overview: @"The Straw Hats storm the courthouse where the three-headed judge Baskerville awaits to enact violent judgment upon them. On the roof, Luffy thanks CP9's Blueno for the strength of his opponents, and he activates a new ability."),
        [@"Enies Lobby|8"] = new EpisodeMeta(
            Title: @"The Girl They Called a Devil",
            Overview: @"Twenty years ago, Nico Robin grew up on Ohara in the West Blue, striving to become an archaeologist like her mother. When Robin met Saul, a giant who washed onto the shores of Ohara, her life would forever be changed."),
        [@"Enies Lobby|9"] = new EpisodeMeta(
            Title: @"Ohara vs. The World Government",
            Overview: @"Robin's mother Olvia was on the run from the World Government, and tragedy was unavoidable from the moment Professor Clover and his colleagues decided to continue their research. No one on Ohara was safe."),
        [@"Enies Lobby|10"] = new EpisodeMeta(
            Title: @"Declaration of War",
            Overview: @"To prove his undying loyalty to Robin, Luffy makes a defiant statement to the World Government."),
        [@"Enies Lobby|11"] = new EpisodeMeta(
            Title: @"Jump into the Waterfall!!",
            Overview: @"Franky stages his own rebellious act against Spandam while Luffy's crew makes a daring leap of faith to hopefully gain entrance to the Tower of Justice."),
        [@"Enies Lobby|12"] = new EpisodeMeta(
            Title: @"Pirates vs. CP9",
            Overview: @"The Straw Hats split up to find the correct key before Robin’s fate is sealed. Zoro finds and engages Kaku in battle, and Sogeking attempts to steal a key from the sleeping Jabra."),
        [@"Enies Lobby|13"] = new EpisodeMeta(
            Title: @"Mr. Chivalry",
            Overview: @"Sanji faces his greatest weakness: fighting a beautiful woman! Meanwhile, Franky begins to run low on cola energy, but he must battle the peculiar Fukuro to obtain more of his refreshing fuel from the kitchen."),
        [@"Enies Lobby|14"] = new EpisodeMeta(
            Title: @"Vitality Response",
            Overview: @"Refreshed and refueled, Franky turns the tide in his battle with Fukuro. Meanwhile, Zoro and Sogeking must find a way to compensate for their self-imposed handicap, and Chopper unfortunately comes face-to-face with Kumadori."),
        [@"Enies Lobby|15"] = new EpisodeMeta(
            Title: @"Monster",
            Overview: @"Chopper's abuse of his rumble balls results in a monstrous side effect. In the meantime, Nami learns how Kalifa's new devil fruit powers sapped Sanji of his strength, and a determined Luffy finally catches up to Spandam, Lucci and Robin."),
        [@"Enies Lobby|16"] = new EpisodeMeta(
            Title: @"The Terrifying Emergency Broadcast",
            Overview: @"As the Marines eke out a comeback against the Straw Hats’ allies, Spandam makes the call Robin most dreaded. In the meantime, Lucci and Luffy begin their mutually anticipated duel, while Nami and Kalifa's fight enters the next phase."),
        [@"Enies Lobby|17"] = new EpisodeMeta(
            Title: @"The Hunter",
            Overview: @"Kalifa attempts to counter Nami’s mirages, and something must be done to save Chopper, still on a monstrous rampage. Zoro, now uncuffed, resumes his duel with Kaku. As Sogeking reaches his limit against Jabra, Sanji reappears, and he is hunting wolves."),
        [@"Enies Lobby|18"] = new EpisodeMeta(
            Title: @"Sanji vs. Jabra",
            Overview: @"As Nami drags the wounded Sogeking from the fight to go find Robin, he suddenly counters with a better idea. In the meantime, Sanji faces off against Jabra's Iron Body Kenpo, and, to break the latter's defenses, Sanji unveils his latest technique."),
        [@"Enies Lobby|19"] = new EpisodeMeta(
            Title: @"Zoro vs. Kaku",
            Overview: @"Spandam drags Robin along the Bridge of Hesitation and finally arrives at the Gates of Justice. Meanwhile, Zoro continues his clash with Kaku, and as things become more desperate, Zoro's rage begins to manifest as a dark aura."),
        [@"Enies Lobby|20"] = new EpisodeMeta(
            Title: @"Buster Call",
            Overview: @"Luffy gives Franky the opening he needs to head for Robin. The cyborg runs into trouble at the start of the bridge, but all is not lost as a lone sniper appears atop the Tower of Justice. Despite these minor victories, the buster call commences."),
        [@"Enies Lobby|21"] = new EpisodeMeta(
            Title: @"Rob Lucci",
            Overview: @"With time running out, Luffy activates another special ability. The vice admirals of the buster call are shocked to see Luffy taking on Rob Lucci and recall how the CP9 enforcer, even in his youth, held strongly to a dark sense of justice."),
        [@"Enies Lobby|22"] = new EpisodeMeta(
            Title: @"The Legend of the Mermaid",
            Overview: @"Lucci corners Luffy, weakened by his new ability’s aftereffects. Back on the bridge, Spandam makes an attempt on Robin's life, so Franky jumps into action. Meanwhile, the rest of the gang is about to drown in the flooded passageway."),
        [@"Enies Lobby|23"] = new EpisodeMeta(
            Title: @"We're Not in Hell",
            Overview: @"The Straw Hats watch as Enies Lobby burns, and Franky fears for his men when he hears of a successful attack against them. Luffy resumes his fight against Lucci while 200 Marine captains bear down on his crewmates."),
        [@"Enies Lobby|24"] = new EpisodeMeta(
            Title: @"Utter Defeat",
            Overview: @"Luffy has finally defeated Rob Lucci, and good news arrives that the Franky Family and Galley-La foremen are all alive and well. As the Straw Hats scramble to escape the Marines, they hear a voice telling them to jump into the sea."),
        [@"Enies Lobby|25"] = new EpisodeMeta(
            Title: @"A Gentle Snowfall of Remembrance",
            Overview: @"Enies Lobby and the buster call fleet are out of sight, but the Going Merry begins to break apart. The Straw Hats are intercepted by Iceburg aboard his company ship and discover how the Merry found her way back to them one last time."),
        [@"Fish-Man Island|1"] = new EpisodeMeta(
            Title: @"Into the Depths! The Kraken and the Caribou Pirates",
            Overview: @"Encased in a protective bubble, the Sunny departs for Fishman Island far under the sea. As the Straw Hats marvel at the sights, Franky tells the crew about their greatest ally in their time apart. But suddenly, a mysterious shadow closes in on the ship."),
        [@"Fish-Man Island|2"] = new EpisodeMeta(
            Title: @"Adventure in the Ocean Depths! 10 Kilometers Below the Surface!",
            Overview: @"Luffy, Zoro, and Sanji leave the relative safety of the Sunny to face the Kraken in its own territory. Putting their powerful new skills to work, they survive the encounter but are swept away by a downward current and become lost in the murky depths."),
        [@"Fish-Man Island|3"] = new EpisodeMeta(
            Title: @"Landing on Fishman Island! The Mermaid Cove and Gyoverly Hills!",
            Overview: @"After a near miss with a creepy undersea ship and Fishman Island in sight, Luffy’s crew is halted by a group of fishmen riding atop sea kings. But time is of the essence, so the Straw Hats attempt a desperate maneuver."),
        [@"Fish-Man Island|4"] = new EpisodeMeta(
            Title: @"Arrival at Coral Hill! The Nosebleed and the Devastating Prediction!",
            Overview: @"The mermaids of Fishman Island give the Straw Hats a warm welcome, but Sanji is struck with a sudden medical emergency! Luffy and co. take their anemic friend to the Mermaid Cafe to rest, where they are introduced to its soothsaying owner."),
        [@"Fish-Man Island|5"] = new EpisodeMeta(
            Title: @"The King of Fishman Island Invited to Ryugu Palace!",
            Overview: @"The pirates receive an unexpected invitation to Ryugu Palace from Neptune himself, king of Fishman Island. Tempted by the smell of food, Luffy wanders the palace and soon finds an enormous tower with a sturdy yet battle-worn door."),
        [@"Fish-Man Island|6"] = new EpisodeMeta(
            Title: @"The Mermaid Princess in Hard-Shell Tower! Shirahoshi of the Neptune Family!",
            Overview: @"Plagued by the unwanted advances of a lunatic fishman with a dangerous power, Mermaid Princess Shirahoshi has been hidden away in a lonely tower for years. Meanwhile in the palace, things take a sour turn for the Straw Hats."),
        [@"Fish-Man Island|7"] = new EpisodeMeta(
            Title: @"The Shirahoshi Kidnapping Incident and the Curse of the Mato Mato!",
            Overview: @"Ryugu Palace falls into chaos. While Luffy escapes with Shirahoshi, the pirates who infiltrated its walls attack with a strange desperation. After a scuffle of their own, Sanji and Chopper come across an old friend with troubling injuries."),
        [@"Fish-Man Island|8"] = new EpisodeMeta(
            Title: @"The Beginning of the Vengeful Plan! Zoro vs. Hody!",
            Overview: @"Hody’s plan for revenge is set in motion, and the Straw Hats who have unwittingly taken control of the palace must now defend it against the New Fishman Pirates. Outside, Luffy’s excursion with Shirahoshi is rudely interrupted."),
        [@"Fish-Man Island|9"] = new EpisodeMeta(
            Title: @"At the Sea Forest! Arlong and Hody",
            Overview: @"Jinbe reunites with Luffy in the undersea forest and reveals a shocking connection to an old foe. The former Warlord begins a tale of when two famous figures fought to undo the animosity that existed between humans and fishmen."),
        [@"Fish-Man Island|10"] = new EpisodeMeta(
            Title: @"Otohime, Fisher Tiger, and the Sun Pirates! The Fateful Encounter!",
            Overview: @"Queen Otohime tried to lead the Ryugu Kingdom into an era of coexistence between humans and fishmen. At the same time, the heroic Fisher Tiger battled humans to free their slaves from captivity."),
        [@"Fish-Man Island|11"] = new EpisodeMeta(
            Title: @"The Shocking Truth of Tiger! The End of the Sun Pirates",
            Overview: @"Fisher Tiger’s past quickly caught up to him, and he left his crew with a sobering, final command. While Jinbe vowed to uphold Tiger’s and Otohime’s ideals, Arlong’s resentment only grew, and soon, the Sun Pirates faced a crisis of identity."),
        [@"Fish-Man Island|12"] = new EpisodeMeta(
            Title: @"The Shipwrecked Celestial Dragon! A Bullet That Seals the Future",
            Overview: @"The sudden appearance of a Celestial Dragon almost imperiled Fishman Island, but Queen Otohime’s ability to end hostilities provided a ray of hope for everyone. Just when the path to the future seemed bright, a shot echoed through the plaza."),
        [@"Fish-Man Island|13"] = new EpisodeMeta(
            Title: @"Shaking of the Kingdom! Luffy vs. Jinbe!",
            Overview: @"After completing his tale, Jinbe begs Nami for forgiveness. Soon after, Hody broadcasts across all of Fishman Island, and all watch in horror as he conducts his hostile takeover. Luffy is ready to fight, but Jinbe has something else in mind."),
        [@"Fish-Man Island|14"] = new EpisodeMeta(
            Title: @"Gyoncorde Plaza Gathering! The Evil Drug's True Power",
            Overview: @"Hody experiences a strange side effect of the energy steroids, and his body undergoes a horrifying transformation! The three princes of the Ryugu Kingdom rush to the scene, but Hody's crewmates have a dirty trick up their sleeves."),
        [@"Fish-Man Island|15"] = new EpisodeMeta(
            Title: @"Hody's Dark Secret! The Straw Hats' Arrival",
            Overview: @"Shirahoshi and Jinbe hurry to free King Neptune but run headlong into a trap. There, Hody reveals a shocking truth about the history of his revolution, but even in the face of Hody’s cruelty, Shirahoshi holds true to her mother’s dying wish."),
        [@"Fish-Man Island|16"] = new EpisodeMeta(
            Title: @"100,000 vs. 10! The Straw Hats' Explosive Moves",
            Overview: @"The Straw Hats have reassembled at last, an army of New Fishman Pirates standing before them. With the last two years still fresh in their minds, the Straw Hats’ training is put to the test, and they unleash a flurry of new techniques."),
        [@"Fish-Man Island|17"] = new EpisodeMeta(
            Title: @"The General from the Future Land and the Crisis of Fishman Island's Destruction",
            Overview: @"Franky’s mechanical masterpieces have transformations in store that can only be described as ""super!"" However, onlookers curb their enthusiasm when a foreboding shadow is cast upon the plaza by a giant ship hurtling toward the island!"),
        [@"Fish-Man Island|18"] = new EpisodeMeta(
            Title: @"I'll Protect Everything",
            Overview: @"Shirahoshi flees into the open sea, hoping to draw the Noah away from Fishman Island. Luffy follows her, but he must contend with Hody Jones along the way. Luckily, the appearance of a new ally gives Luffy a chance to protect Shirahoshi."),
        [@"Fish-Man Island|19"] = new EpisodeMeta(
            Title: @"What Are You?",
            Overview: @"The Straw Hats hold their own against the powerful officers from Hody’s crew. But their struggle will be in vain if Luffy cannot stop the Noah. Meanwhile, Hody becomes stronger than ever."),
        [@"Fish-Man Island|20"] = new EpisodeMeta(
            Title: @"Phantom",
            Overview: @"Neptune’s army aids the Straw Hats against the New Fishman Pirates, finally accepting the crew as allies. As the fight continues, Fukaboshi’s transponder snail reveals the bone chilling truth behind Hody's motivations."),
        [@"Fish-Man Island|21"] = new EpisodeMeta(
            Title: @"Death Is Also Revenge",
            Overview: @"Luffy has a fist of fire with Hody’s name on it, and the rest of the Straw Hats push forward with all their might. Hody takes even more energy steroids, and a gravely injured Luffy struggles to overcome the fishman's unbelievable stamina."),
        [@"Fish-Man Island|22"] = new EpisodeMeta(
            Title: @"The Path Toward the Sun",
            Overview: @"Hody is vanquished, the Noah is stopped, and Fishman Island is saved! Unfortunately, Luffy was gravely injured in the process. With no time to spare, a true friend steps forward to tear down the walls of the island's history."),
        [@"Fish-Man Island|23"] = new EpisodeMeta(
            Title: @"The Voice from the New World",
            Overview: @"When pirates working for Big Mom appear, Fishman Island falls under threat from an adversary even stronger than Hody. Luffy steps up to save the fishmen once again but may doom himself by antagonizing one of the strongest pirates in the New World."),
        [@"Fish-Man Island|24"] = new EpisodeMeta(
            Title: @"The Hero's Hat",
            Overview: @"Filled with both excitement and trepidation, the crew finally sets sail for the New World. After bidding their fond farewells, the Straw Hats leave with a new log pose in hand. Overcoming trials and tragedies, Luffy's dream is on course once again!"),
        [@"Gaimon|1"] = new EpisodeMeta(
            Title: @"You're the Rare Breed",
            Overview: @"With Usopp now on the crew and their new ship, the Going Merry, under their command, the Straw Hats head to an island said to hold a fabled treasure. There they encounter a strange man stuck in a box who has been looking for the same treasure."),
        [@"If You Could Go Anywhere... The Adventures of the Straw Hats|1"] = new EpisodeMeta(
            Title: @"If You Could Go Anywhere... The Adventures of the Straw Hats",
            Overview: @"Somewhere in the world... Sanji resists, while Robin meets terrible people. Franky's not himself, and Usopp learns to survive. Chopper avoids becoming food, and Nami reports on the weather. Brook is repaid in underpants, and Zoro... is lost and annoyed."),
        [@"Impel Down|1"] = new EpisodeMeta(
            Title: @"The Underwater Prison, Impel Down",
            Overview: @"To rescue his brother Ace, Luffy must infiltrate the well-guarded prison Impel Down. He eludes the watchful eyes of security for a time, and then, for better or worse, a certain red-nosed criminal appears."),
        [@"Impel Down|2"] = new EpisodeMeta(
            Title: @"First Son of the Sea",
            Overview: @"After forming an unlikely alliance, Luffy rushes through Impel Down aided by Buggy's powers. Meanwhile, Ace finds himself with an unlikely companion as well when he exchanges words with a powerful pirate prisoner."),
        [@"Impel Down|3"] = new EpisodeMeta(
            Title: @"From One Hell to Another",
            Overview: @"Luffy and his dubious companions face off against the mythical beasts of Level 2. Impel Down is put on lockdown, its only exit sealed, but Luffy, unaware and unafraid, continues to Ace's floor, only to have another unexpected reunion."),
        [@"Impel Down|4"] = new EpisodeMeta(
            Title: @"Inferno Hell",
            Overview: @"Luffy and his deranged team pummel everything from Level 3 to Level 4 that dares to stand in their path. However, the powerful guard Minotaurus is ready to do some pummeling of his own while a boiling bath of blood awaits below."),
        [@"Impel Down|5"] = new EpisodeMeta(
            Title: @"Friend",
            Overview: @"With nowhere to run, Luffy's desperation to save Ace forces him to make a very grim sacrifice against his venomous adversary. Down in the frozen depths of Level 5, Bon Kurei rushes to his friend's aid, betting on a distant hope."),
        [@"Impel Down|6"] = new EpisodeMeta(
            Title: @"A Ray of Hope",
            Overview: @"Bon Kurei wanders through Level 5 in search of a mysterious missing prisoner. However, the fearsome wolves and bitter cold eventually take their toll, and he collapses in the Freezing Hell all while Luffy's life continues to dwindle away."),
        [@"Impel Down|7"] = new EpisodeMeta(
            Title: @"Infinite Hell",
            Overview: @"Luffy is back in action, and he prepares to set off, now with even more powerful allies who have ties to his old man. When they reach the lowest level of Impel Down, the legendary Level 6, they are in for a few new surprises."),
        [@"Impel Down|8"] = new EpisodeMeta(
            Title: @"Yet Another Epic Incident",
            Overview: @"A veritable all-star team on his side, Luffy and co. battle their way back up to Level 4. On Level 2, a massive riot erupts, plunging the prison into chaos. To further complicate matters, another infamous pirate breaks into Impel Down."),
        [@"Impel Down|9"] = new EpisodeMeta(
            Title: @"To Sunshine and Freedom",
            Overview: @"It is utter chaos in Impel Down, and between the sudden appearance of Blackbeard, the vice warden’s interference, and Magellan’s dogged attempts to restore order, the escape team just might see daylight yet!"),
        [@"Impel Down|10"] = new EpisodeMeta(
            Title: @"Thank You",
            Overview: @"Thanks to Jinbe’s quick thinking, Luffy and co. narrowly escape Impel Down. However, the Gates of Justice remain closed, and a horde of Marine ships is gaining on them. Then, just when all hope seems lost, a dear friend makes an all-or-nothing gamble."),
        [@"Jaya|1"] = new EpisodeMeta(
            Title: @"Why the Log Pose Is Spherical",
            Overview: @"When a galleon-size ship falls from the sky and Nami's log pose begins to point straight up, the Straw Hats sense a new adventure on the horizon. Right after a mysterious map is pulled from the wreckage, a group of salvagers come to claim the fallen ship."),
        [@"Jaya|2"] = new EpisodeMeta(
            Title: @"Never Dream",
            Overview: @"Mock Town on western Jaya openly welcomes pirates, but that fact is accompanied by constant danger. While asking about the sky island, Luffy and Zoro have a run-in with the loud pirate Bellamy the Hyena who ridicules their dreams."),
        [@"Jaya|3"] = new EpisodeMeta(
            Title: @"People's Dreams",
            Overview: @"After a one-sided brawl with Bellamy, the Straw Hats meet a black-haired pirate outside the bar who reaffirms their dreams and insists the sky island is real. As they depart for the other side of Jaya, another salvager of the Saruyama Alliance appears."),
        [@"Jaya|4"] = new EpisodeMeta(
            Title: @"Noland the Liar",
            Overview: @"The Straw Hats meet Montblanc Cricket, whose descendant was none other than Montblanc Noland, an infamous ""liar"" who told of a city of gold on Jaya. Cast out for looking for artifacts from the fabled city, he may just know a way to get to Skypiea."),
        [@"Jaya|5"] = new EpisodeMeta(
            Title: @"Let's Eat",
            Overview: @"Cricket explains how the Straw Hats can ride a dangerous vertical sea current to get to Skypiea. However, they must first catch a south bird to steer them toward the point where the stream will erupt from the ocean."),
        [@"Jaya|6"] = new EpisodeMeta(
            Title: @"The Hundred Million Man",
            Overview: @"While the Straw Hats are in the forest attempting to catch a south bird, Bellamy and his crew attack Masira, Shoujou, and Cricket and steal every gold artifact they had collected over the years from the salvage work of the Saruyama Alliance."),
        [@"Jaya|7"] = new EpisodeMeta(
            Title: @"The Highest Authority in the World",
            Overview: @"The duel between Bellamy and Luffy shocks all who look on. More shocking are the movements of fearsome pirates on the Grand Line and the machinations of the Blackbeard Pirates, as their captain vies for a position as a Warlord."),
        [@"Jaya|8"] = new EpisodeMeta(
            Title: @"The Knock-Up Stream",
            Overview: @"Luffy returns victorious from his showdown with Bellamy, and the Going Merry has been refit by the Saruyama Alliance to handle its upcoming upward flight. The Straw Hats follow their captive south bird and steel themselves for their journey to the sky."),
        [@"Little Garden|1"] = new EpisodeMeta(
            Title: @"Adventure on Little Garden",
            Overview: @"The Straw Hats arrive at their destination and discover that the island is home to enormous creatures... and people. Meanwhile, the Baroque Works agents Mr. 3 and his partner Miss Golden Week receive new orders."),
        [@"Little Garden|2"] = new EpisodeMeta(
            Title: @"Dorry and Brogy",
            Overview: @"Usopp, immensely impressed with the giants of Elbaph, names Brogy his master. To commemorate their duel, the giants imbibe two barrels of booze from Nami, but, unbeknownst to anyone, a saboteur has tampered with one of them!"),
        [@"Little Garden|3"] = new EpisodeMeta(
            Title: @"Foul Play",
            Overview: @"Despite his internal injuries and Luffy's warnings, the prideful giant Dorry insists on continuing his duel with Brogy. Meanwhile, the Baroque Works officer agents begin to make their move on the island with the Straw Hats as their next targets."),
        [@"Little Garden|4"] = new EpisodeMeta(
            Title: @"Luffy vs. Mr. 3",
            Overview: @"Luffy, Usopp, and Karoo launch headlong into rescuing their friends, but Miss Golden Week runs a colorful interference. Mr. 3 is forced to take matters into his own conniving hands, and Usopp brainstorms how he will finally free his friends."),
        [@"Little Garden|5"] = new EpisodeMeta(
            Title: @"Straight Ahead!!",
            Overview: @"Sanji, pretending to be Mr. 3, convinces Crocodile he has eliminated Vivi and co., prompting the Unluckies to arrive and deliver a way off Little Garden. With a clear path straight ahead—or so it seems—the Straw Hats set sail."),
        [@"Loguetown|1"] = new EpisodeMeta(
            Title: @"The Town of Beginnings and Endings",
            Overview: @"Touting a fresh bounty issued by Marine HQ, Luffy and co. make landfall at Loguetown, the place where Gold Roger was both born and executed. Being the last stop before the Grand Line, the crew stocks up on supplies and sightsees."),
        [@"Loguetown|2"] = new EpisodeMeta(
            Title: @"Parallels",
            Overview: @"Usopp manages to anger the brat daughter of bounty hunter Daddy the Father and finds his own life at stake. When Daddy discovers that Usopp is the son of Red Hair Pirate Yasopp, the only man to beat him, he offers him a risky way out."),
        [@"Loguetown|3"] = new EpisodeMeta(
            Title: @"The Legend Has Begun",
            Overview: @"Luffy arrives at the execution platform, only to be caught in Buggy and Alvida's trap. Sanji and Zoro rush to stop Buggy from poetically—and flashily—executing Luffy where Roger died."),
        [@"Long Ring Long Land|1"] = new EpisodeMeta(
            Title: @"Adventure on a Long Island",
            Overview: @"As they continue to traverse the Grand Line, the Straw Hats pass a ship with no sails, no Jolly Roger, and no captain. After an encounter with giant sea monkeys, they come upon an island where everything is much longer than usual."),
        [@"Long Ring Long Land|2"] = new EpisodeMeta(
            Title: @"Donut Race!!",
            Overview: @"Luffy accepts Foxy’s challenge to a Davy Back Fight, a pirate contest in which the stakes are the crews themselves! Round #1 is the Donut Race, where each team races around the island in tiny boats made from just the scraps of three barrels."),
        [@"Long Ring Long Land|3"] = new EpisodeMeta(
            Title: @"Groggy Ring!!",
            Overview: @"Unexpected interference from Foxy himself cost the Straw Hats more than they bargained for. Now, in a struggle against literal monsters, the unlikely duo of Sanji and Zoro must win round #2, the Groggy Ring."),
        [@"Long Ring Long Land|4"] = new EpisodeMeta(
            Title: @"Combat",
            Overview: @"The two captains face off in a final game: a battle of brawn aboard Foxy's ship in round #3, Combat! Luffy, sporting a killer afro and an attitude to match, steps into the boxing ring to put the hurt on Foxy."),
        [@"Long Ring Long Land|5"] = new EpisodeMeta(
            Title: @"K.O.",
            Overview: @"The final round of the Davy Back Fight rages on, and atop the deck of Foxy's ship, the epic battle nears its climax. During the fight, Luffy makes a surprise discovery about Foxy's powers that he keeps strategically hidden."),
        [@"Long Ring Long Land|6"] = new EpisodeMeta(
            Title: @"Marine HQ Admiral Aokiji",
            Overview: @"Only three officers in all the Marines hold the position of admiral, literal powerhouses of the World Government. The icy Aokiji, one such admiral, catches up with the Straw Hats, but Luffy is not the one he is after."),
        [@"Marineford|1"] = new EpisodeMeta(
            Title: @"Marine Headquarters",
            Overview: @"Fifty warships, 100,000 Marines, the Seven Warlords, and three admirals: Akainu, Aokiji, and Kizaru. The stage is set, and, as a battle with Whitebeard looms, Fleet Admiral Sengoku reveals a shocking truth about Ace."),
        [@"Marineford|2"] = new EpisodeMeta(
            Title: @"Ace and Whitebeard",
            Overview: @"To the surprise of all, the Moby Dick surfaces in the middle of Marineford! On the deck stands Whitebeard, the man who Ace calls father, and his fourteen commanders, the pirates he calls family, who share Luffy’s determination to stop the execution."),
        [@"Marineford|3"] = new EpisodeMeta(
            Title: @"Conflict at the Summit",
            Overview: @"The players have assembled at last! Whitebeard unleashes a tsunami that is set to swallow every marine and turn Marine HQ upside down. The fight has just begun, as Marine admirals and pirate commanders alike showcase their incredible abilities."),
        [@"Marineford|4"] = new EpisodeMeta(
            Title: @"Justice Will Prevail!!",
            Overview: @"A larger-than-life ally risks his life to pave the way forward, and the Whitebeard Pirates rush toward Ace. However, just as their rescue mission picks up momentum, Sengoku employs a surprise tactic that turns the tide yet again."),
        [@"Marineford|5"] = new EpisodeMeta(
            Title: @"Luffy and Whitebeard",
            Overview: @"Luffy leaps into the fray! Battling against familiar faces and new foes alike, he races toward the scaffold like a whirlwind of destruction, and, as his brother begs for him to turn back, Luffy shares some powerful words of his own."),
        [@"Marineford|6"] = new EpisodeMeta(
            Title: @"The Prisoners of Impel Down",
            Overview: @"Facing Kuma on the battlefield, Ivankov reveals their shared past, but his pleas to his old companion fall on deaf ears as Kuma continues his attacks. In a sea of confusion, only Doflamingo seems to know the truth."),
        [@"Marineford|7"] = new EpisodeMeta(
            Title: @"The Whirl Spider",
            Overview: @"Luffy’s progress is halted by Mihawk, but the Whitebeard Pirates counter with a swordsman of their own. Then, when an army of human weapons encircle the battlefield, Luffy and his allies find themselves overwhelmed by their explosive attacks."),
        [@"Marineford|8"] = new EpisodeMeta(
            Title: @"The Man Who Shook the World",
            Overview: @"Squard’s betrayal of Whitebeard sends ripples of distrust and uncertainty throughout the pirate alliance. And yet, Whitebeard’s faith will not be shattered, and it soon becomes clear that his allies are falling into a clever setup launched by the Marines."),
        [@"Marineford|9"] = new EpisodeMeta(
            Title: @"Assault",
            Overview: @"The pirates are trapped in the bay, held there by Akainu’s magma. Amid the chaos, the order for Ace’s execution is given, and Luffy makes a drastic decision that puts him face-to-face with the Marines' most powerful men."),
        [@"Marineford|10"] = new EpisodeMeta(
            Title: @"Oris Plaza",
            Overview: @"His adopted son within reach, Whitebeard charges forth, undeterred by the strongest the Marines have to offer. With both sides swinging between victory and defeat, the battlefield plunges into chaos. Then Marco takes to the sky and soars to Ace’s side!"),
        [@"Marineford|11"] = new EpisodeMeta(
            Title: @"The White Monster",
            Overview: @"Faced with the might of the admirals, even Whitebeard's commanders falter. Refusing to relent, Luffy begs Ivankov for a final chance at victory. Amid a bevy of Marines, an old friend of Luffy’s appears for a much too premature reunion."),
        [@"Marineford|12"] = new EpisodeMeta(
            Title: @"The Execution Platform",
            Overview: @"Having borne witness to Luffy’s latent powers, the Marines send everything they have at him. But thanks to Ivankov’s quick thinking, Luffy ascends toward Ace. Garp, unable to watch any longer, leaps into Luffy’s path."),
        [@"Marineford|13"] = new EpisodeMeta(
            Title: @"The Times They Are A-Changin'",
            Overview: @"Ace is free at last, and the pair of brothers are unstoppable! Although the Whitebeard Pirates are emboldened by their teamwork, their captain is not convinced that their escape will come so easily, and Whitebeard makes a difficult decision."),
        [@"Marineford|14"] = new EpisodeMeta(
            Title: @"Thank You for Loving Me",
            Overview: @"Ace protects his brother from Akainu but suffers a mortal blow in the process. Jinbe and the Whitebeard Pirates rush to his aid but soon realize he is far beyond help. As Ace takes his final breaths, he imparts a heartfelt message."),
        [@"Marineford|15"] = new EpisodeMeta(
            Title: @"Edward Newgate",
            Overview: @"Blackbeard appears, Thatch’s murder and Ace’s capture all part of a terrifying plan that no one could have imagined! With the war in its final stage, Whitebeard fights to avenge his fallen sons and to punish the traitor who plotted his undoing."),
        [@"Marineford|16"] = new EpisodeMeta(
            Title: @"A Gift to a New Era",
            Overview: @"Though Ace and Whitebeard have been killed, the Marines seek to wipe out every last pirate, even as they retreat. In the confusion, Akainu sets his eyes on the unconscious Luffy. Meanwhile, Blackbeard reveals his true scheme and a terrifying new power!"),
        [@"Marineford|17"] = new EpisodeMeta(
            Title: @"The War's Conclusion",
            Overview: @"Senseless violence dyes the battlefield red with blood. Luffy’s allies struggle to save him as the admirals maintain their assault. Suddenly, the Red Hair Pirates appear! Narrowly missing a reunion with Luffy, Shanks utters a speech on the battlefield."),
        [@"One Piece Fan Letter|1"] = new EpisodeMeta(
            Title: @"One Piece Fan Letter",
            Overview: @"As the Straw Hat Pirates reunite on the Sabaody Archipelago, the various members of the island are drawn together like pieces of a puzzle, their love of certain members of the crew driving their actions and emotions."),
        [@"Orange Town|1"] = new EpisodeMeta(
            Title: @"Enter: Nami",
            Overview: @"Nami, a street-smart girl who loves money and tangerines, makes Luffy's acquaintance. To save herself and steal a map to the Grand Line, she tricks Luffy into allowing her to turn him over to the infamous pirate Buggy the Clown."),
        [@"Orange Town|2"] = new EpisodeMeta(
            Title: @"Treasure",
            Overview: @"Luffy meets a small dog guarding his late master’s store. Meanwhile, Beast Tamer Mohji, Cabaji the Acrobat, and the lion Richie show up in the streets of Orange Town to get revenge for Captain Buggy's humiliating loss."),
        [@"Orange Town|3"] = new EpisodeMeta(
            Title: @"Pirate Buggy ""the Clown""",
            Overview: @"Shockingly, it turns out Captain Buggy and Red-Haired Shanks share a common history. When the bombastic clown rips Shanks' straw hat, Luffy's rage knows no bounds."),
        [@"Post-Enies Lobby|1"] = new EpisodeMeta(
            Title: @"The Strongest Family Lineage?! The Vice-Admiral and The Revolutionary!",
            Overview: @"Two days later in Water Seven, Franky hears that the item for he purchased with the Straw Hats' stolen money has arrived. While the pirates recover from the events at Enies Lobby, a Marine vice admiral arrives to pay Luffy an unexpected visit."),
        [@"Post-Enies Lobby|2"] = new EpisodeMeta(
            Title: @"The Extent of the Grand Line and The 600,000,000 Crew!",
            Overview: @"In the New World, not even the Marines' best can keep Red-Haired Shanks from meeting Whitebeard with an especially important request. Meanwhile, at Water Seven, the Franky Family comes to the Straw Hats with some ""bad"" news."),
        [@"Post-Enies Lobby|3"] = new EpisodeMeta(
            Title: @"Forgive Yourself! Franky Departs!",
            Overview: @"The Straw Hats have barely had time to marvel at their new bounties when a new surprise awaits them: the unveiling of their magnificent new ship. The next step is bringing a shipwright into their ranks, and there is only one man for the job."),
        [@"Post-Enies Lobby|4"] = new EpisodeMeta(
            Title: @"The Astonishing Thousand Sunny and Usopp's Tearful Apology!",
            Overview: @"The Straw Hats set sail, but Usopp is conspicuously missing. Zoro soberly reminds Luffy that Usopp's return should not be granted so casually. More immediately, the pirates need to avoid Garp’s barrage of cannon balls!"),
        [@"Post-Enies Lobby|5"] = new EpisodeMeta(
            Title: @"The Circling Bounties and The Duel on Banaro Island!",
            Overview: @"The Straw Hats’ new wanted posters begin circulating around the world, but three days earlier, Blackbeard began plotting their pursuit. However, one obstacle stood in his way; Ace had finally caught up to his estranged crewmate!"),
        [@"Post-War|1"] = new EpisodeMeta(
            Title: @"Creeping Future",
            Overview: @"The Summit War has thrown the entire world into chaos. Emboldened by Whitebeard's final words, pirates once again envision a wave they can ride into a new era. At Hancock’s order, Luffy is taken to Amazon Lily to hide from the Marines while he recovers."),
        [@"Post-War|2"] = new EpisodeMeta(
            Title: @"Gray Terminal",
            Overview: @"Before they were brothers, Ace and Luffy lived in the mountains, dreaming of the day when they would take to the sea. In the criminal-infested junkyard known as Gray Terminal, Ace and his partner-in-crime Sabo robbed the thieves and scavengers."),
        [@"Post-War|3"] = new EpisodeMeta(
            Title: @"Oath of Brotherhood",
            Overview: @"Ace, Sabo, and Luffy made a promise to one another over cups of sake that would shape their futures. Yet while the brothers' adventures continue, Sabo's unfortunate past catches up with him. Meanwhile, a horrific plot unfolds."),
        [@"Post-War|4"] = new EpisodeMeta(
            Title: @"Sabo's Sea",
            Overview: @"Even as the fires in Gray Terminal threatened to consume them, Ace and Luffy fought Bluejam with all their might! In the wake of the tragedy, Sabo seized freedom in his hands and took to the sea, just as a Celestial Dragon arrived in High Town."),
        [@"Post-War|5"] = new EpisodeMeta(
            Title: @"Will of the Winds",
            Overview: @"Luffy and Ace buried their sorrow and grew stronger day by day as they trained to be pirates. Time marched on, and they eventually bade farewell to their childhood home and took to the sea, hoping to achieve the dream that Sabo could not."),
        [@"Post-War|6"] = new EpisodeMeta(
            Title: @"Cheer",
            Overview: @"Determined to return to Sabaody and keep his promise to his crew, Luffy prepares for departure. However, when Dark King Rayleigh appears and makes him a surprising offer, Luffy is forced to make a decision that could alter the fate of his entire journey."),
        [@"Post-War|7"] = new EpisodeMeta(
            Title: @"NEWS",
            Overview: @"Although Marine HQ is in ruins after the Summit War, Marines and reporters still stalk its grounds. Luffy, Rayleigh, and Jinbe return to where Ace died to carry out a mysterious plan. If all goes well, Luffy’s crew will understand his actions."),
        [@"Post-War|8"] = new EpisodeMeta(
            Title: @"3D2Y",
            Overview: @"The Straw Hat Pirates have interpreted their captain's message to meet up again in two years. During this time, they will prepare themselves for the New World! In the Calm Belt, Luffy arrives in Luscaina to begin training under Rayleigh."),
        [@"Punk Hazard|1"] = new EpisodeMeta(
            Title: @"Punk Hazard",
            Overview: @"Fresh off the adventure at Fishman Island, the Sunny is caught in a massive whirlpool and dragged off course. A desperate cry for help leads the Straw Hats to Punk Hazard, an island engulfed in flames and inhabited by a mythic beast."),
        [@"Punk Hazard|2"] = new EpisodeMeta(
            Title: @"Adventure on the Burning Island",
            Overview: @"Luffy, Robin, Usopp, and Zoro face a powerful dragon, and Luffy gets up close and personal with a torso-less figure. Elsewhere, Nami, Sanji, Chopper, and Franky find themselves imprisoned with the pieces of a human face!"),
        [@"Punk Hazard|3"] = new EpisodeMeta(
            Title: @"About My Torso",
            Overview: @"Luffy’s group finds themselves up against a gang of centaurs, Brook battles an aggressive mysterious torso, and Vice Admiral Smoker encounters someone highly unexpected! Meanwhile, Nami and Chopper seek a safe exit for a group of children."),
        [@"Punk Hazard|4"] = new EpisodeMeta(
            Title: @"The Lake of Bandits",
            Overview: @"Luffy’s group takes a deadly plunge into icy waters, and Trafalgar Law uses his unique abilities to rearrange Nami’s group and place the Straw Hats into a state of chaos! Then, things heat up when G-5 squares off with Law."),
        [@"Punk Hazard|5"] = new EpisodeMeta(
            Title: @"CC",
            Overview: @"Luffy is excited to once again cross paths with Trafalgar Law. While Vice Admiral Smoker determines his next move, an exceptionally large pirate with alligator legs tells Luffy and the Straw Hats the true story of Punk Hazard’s mysterious transformation!"),
        [@"Punk Hazard|6"] = new EpisodeMeta(
            Title: @"Yeti Cool Brothers",
            Overview: @"The giant children fly into a mysterious rage, and Chopper discovers the true reason for their unusual condition! Meanwhile, Zoro, Brook, and Sanji cross paths with a dangerous duo, and the story of how Trafalgar Law arrived at Punk Hazard is revealed."),
        [@"Punk Hazard|7"] = new EpisodeMeta(
            Title: @"Pirate Alliance",
            Overview: @"Luffy agrees to an unexpected alliance with Trafalgar Law, but the Straw Hats refuse to leave the island until the children are safe. Meanwhile, the gaseous master of the island unleashes something extremely deadly!"),
        [@"Punk Hazard|8"] = new EpisodeMeta(
            Title: @"Blizzard with a Chance of Slime",
            Overview: @"Zoro, Sanji, and Brook continue their search for the samurai, and Law tries to sneak Chopper into the laboratory! And then, Luffy’s battle with his old nemesis Smoker is interrupted by the arrival of a terrifying toxic blob."),
        [@"Punk Hazard|9"] = new EpisodeMeta(
            Title: @"My Name Is Kin'emon!!",
            Overview: @"Law's plan to infiltrate Caesar’s facility hits a snag when an unexpected guest complicates things. Meanwhile, Chopper investigates the Master’s lab, and the mysterious samurai shows what he can do with a full body!"),
        [@"Punk Hazard|10"] = new EpisodeMeta(
            Title: @"Vergo and Joker! The Beginning of Caesar's Masterplan!",
            Overview: @"Caesar gathers his young test subjects, shocking secret identities are revealed, and the poisonous purple blob continues its march across the island! Meanwhile, Nami and Usopp get an unexpected helping hand in their fight to save the children."),
        [@"Punk Hazard|11"] = new EpisodeMeta(
            Title: @"The Experiment Begins! Shinokuni Unleashed!",
            Overview: @"A candy addiction leads the children to return, and Caesar plans to show the world his new and improved Smiley! Luffy and the Straw Hats next find themselves pursued by a deadly cloud of gas that turns living things into statues of ash!"),
        [@"Punk Hazard|12"] = new EpisodeMeta(
            Title: @"The Counterattack Begins!",
            Overview: @"Law has a trick up his sleeve that turns the tide in the alliance’s favor, to include an on-the-spot partnership with former foes. Zoro and company reunite with Nami and Sanji, and it is all Luffy’s group can do to ensure everyone’s safety in the lab."),
        [@"Punk Hazard|13"] = new EpisodeMeta(
            Title: @"G-5's Sacrifice and the Betrayal of the Vice Admiral!",
            Overview: @"Caesar hatches a plan to forever silence his enemies, and Tashigi’s men make the ultimate sacrifice! Luffy races toward Caesar to deliver on his promise to beat and capture him, and Chopper does all he can to keep the children from consuming more candy."),
        [@"Punk Hazard|14"] = new EpisodeMeta(
            Title: @"The Mastermind in the Shadows and the Battle Between Gas and Rubber!",
            Overview: @"Law finds the room that could ruin the New World, and Luffy hopes to bring Caesar’s reign of terror to a brutal end! With Law's true ambitions revealed, Doflamingo flies into action to protect his criminal operation!"),
        [@"Punk Hazard|15"] = new EpisodeMeta(
            Title: @"Vice Admiral vs. Vice Admiral and the Truth Behind Punk Hazard's Destruction!",
            Overview: @"Smoker attacks the estranged Vice Admiral Vergo for assaulting his men, and in the trash heap, Luffy meets something strange. Meanwhile, Caesar’s bloated words to his men about the island’s history do not match what occurred."),
        [@"Punk Hazard|16"] = new EpisodeMeta(
            Title: @"The Dragon Named Momonosuke and the Menacing Snow Fruit User!",
            Overview: @"Luffy befriends a dragon that used to be a human boy, and Vice Admiral Smoker continues his brutal battle with the villainous Vergo. Mocha tries to keep the Master’s candy away from her friends, and Zoro pits his steel against snow in a battle with Monet."),
        [@"Punk Hazard|17"] = new EpisodeMeta(
            Title: @"Zoro's Strongest One-Sword Style and Mocha's Plight!",
            Overview: @"Zoro vs. Monet: a duel to the bitter end. But when Tashigi comes to lend a hand, she will need her full might to compensate for Zoro's weakness. Meanwhile, Mocha is running out of options for keeping the candy away from the children."),
        [@"Punk Hazard|18"] = new EpisodeMeta(
            Title: @"Luffy and Law's All-out Attack! The Takeover of the New Era!",
            Overview: @"Brownbeard heroically attempts to expose Caesar as a villain, and the horrific truth about Punk Hazard is finally revealed! Luffy makes Caesar pay for his crimes against the children, and Smoker risks his life for a chance to see Vergo fall in battle!"),
        [@"Punk Hazard|19"] = new EpisodeMeta(
            Title: @"The Strongest Grizzly Magnum and the Assassins from Dressrosa!",
            Overview: @"Law concludes his epic battle with Vergo, and Luffy looks to land a devastating blow on the murderous gasbag mastermind. Meanwhile, word of Luffy and Law’s alliance spreads throughout the world, and Joker sends a team to rescue Caesar."),
        [@"Punk Hazard|20"] = new EpisodeMeta(
            Title: @"Die for Me! The Dangerous Man Makes His Move!",
            Overview: @"As the Straw Hats and co. flee the crumbling laboratory, Caesar’s desperate act of vengeance thwarts Joker’s plan to forever silence his enemies. Franky continues his battle with Buffalo and Baby 5, and Usopp takes a shot at capturing Caesar."),
        [@"Punk Hazard|21"] = new EpisodeMeta(
            Title: @"The Alliance's Target and the Departure!",
            Overview: @"Bitter enemies set aside their differences to enjoy a well-deserved feast. The weary Marines and the rescued children get teary-eyed as they say goodbye to the Straw Hats. Meanwhile, Law enters into treacherous negotiations with Joker."),
        [@"Punk Hazard|22"] = new EpisodeMeta(
            Title: @"The Arrival of the Mysterious Man and the News Coo!",
            Overview: @"Doflamingo—a.k.a. Joker—arrives on the scene and wreaks havoc! Only an icy intercession can save Smoker and send Joker off to rethink his strategy. Meanwhile, the Sunny sails through the rough seas of the New World where even a bit of hail portends doom!"),
        [@"Return to Sabaody|1"] = new EpisodeMeta(
            Title: @"Two Years Later",
            Overview: @"Two years after the Summit War, the Straw Hat crew finally returns to Sabaody. However, the archipelago has changed, and with dangerous pirates lurking around in droves, their departure to the New World may not go as smoothly as hoped."),
        [@"Return to Sabaody|2"] = new EpisodeMeta(
            Title: @"Island of New Beginnings",
            Overview: @"Luffy, in disguise, crosses paths with the fake Luffy, and the imposter finds himself on the receiving end of a mysterious power. Meanwhile, Sentomaru and the Marines have yet again amassed a team of Pacifistas."),
        [@"Return to Sabaody|3"] = new EpisodeMeta(
            Title: @"Dive, Dive, Dive!",
            Overview: @"After two long years and one chaotic afternoon, the Straw Hats are finally ready to renew their voyage. However, before they can set off to Fishman Island, they must contend with a massive Marine force determined to stop them."),
        [@"Reverie|1"] = new EpisodeMeta(
            Title: @"The Fifth Emperor",
            Overview: @"Luffy’s reputation grows as all eyes look toward the Straw Hats’ next move. Meanwhile, the royals of the world make their way to the Reverie, but their absence welcomes a raid by a vicious band of pirates on the Kingdom of Lulusia."),
        [@"Reverie|2"] = new EpisodeMeta(
            Title: @"A Beautiful World",
            Overview: @"At New Marineford, Fleet Admiral Sakazuki hears the news about Luffy while nobles from around the world gather for the Reverie! At the Red Line, Garp is escorting King Neptune’s family when Shirahoshi sees the surface world for the first time."),
        [@"Reverie|3"] = new EpisodeMeta(
            Title: @"The Empty Throne",
            Overview: @"As the Reverie commences, Emperors Big Mom and Kaido both set their sights on Luffy! Meanwhile, a mysterious outsider visits the highest authority in the world, and the Revolutionary Army confirms its desire to save Kuma."),
        [@"Reverse Mountain|1"] = new EpisodeMeta(
            Title: @"Reverse Mountain",
            Overview: @"Following a near disaster in the Calm Belt, the Straw Hats take a wild ride up and down a mountain… and are promptly swallowed by a giant whale!"),
        [@"Reverse Mountain|2"] = new EpisodeMeta(
            Title: @"Cape Promise",
            Overview: @"After learning of Laboon the whale's plight, Luffy comes up with a solution befitting his style. As thanks, Crocus reveals that navigating the Grand Line will not be as simple as following a compass or relying on currents and wind."),
        [@"Romance Dawn|1"] = new EpisodeMeta(
            Title: @"Romance Dawn, the Dawn of an Adventure",
            Overview: @"Influenced by the straw-hat-wearing pirate Red-Haired Shanks, an enthusiastic young boy named Monkey D. Luffy dreams of one day becoming King of the Pirates."),
        [@"Romance Dawn|2"] = new EpisodeMeta(
            Title: @"They Call Him ""Straw Hat"" Luffy",
            Overview: @"While Alvida and her pirates plunder a cruise ship, they come across a barrel containing a strange boy named Monkey D. Luffy. The timid Koby befriends Luffy, and they share their grand dreams with each other."),
        [@"Romance Dawn|3"] = new EpisodeMeta(
            Title: @"The Pirate King and the Master Swordsman",
            Overview: @"In search of members for his pirate crew, Luffy with his new friend Koby arrive at Shells Town. There, they track down the renowned Pirate Hunter Zoro but run afoul of Helmeppo, son of the infamous Captain Morgan."),
        [@"Romance Dawn|4"] = new EpisodeMeta(
            Title: @"The First",
            Overview: @"Luffy convinces the captive Zoro to join his pirate crew, but they must first defeat the tyrannical Captain Morgan."),
        [@"Sabaody Archipelago|1"] = new EpisodeMeta(
            Title: @"Flying Fish Riders",
            Overview: @"As the Straw Hats journey to Fishman Island, they reach the Red Line, the halfway point along the Grand Line. When a sea king appears, Luffy easily dispatches it, but it spits up a mermaid and a talking starfish onto the deck of the Sunny."),
        [@"Sabaody Archipelago|2"] = new EpisodeMeta(
            Title: @"Iron Mask Duval",
            Overview: @"The Straw Hats arrive at Duval's (eerily quiet) base and manage to locate Camie's captured friend. Realizing the captive’s identity, the Straw Hats reluctantly agree to rescue him, and only in exchange for directions to Fishman Island."),
        [@"Sabaody Archipelago|3"] = new EpisodeMeta(
            Title: @"Duval's Tragedy",
            Overview: @"Blaming Sanji for his misfortunes, Duval swears vengeance on the Straw Hats. Meanwhile, the Flying Fish Riders attempt to sink the Sunny, but the ship is far from vulnerable. Finally, Sanji himself faces Duval in a bid to end things."),
        [@"Sabaody Archipelago|4"] = new EpisodeMeta(
            Title: @"Adventure on the Archipelago of Dancing Soap Bubbles",
            Overview: @"The Straw Hats make their way to Sabaody Archipelago to prepare the Sunny for its undersea voyage to Fishman Island. During their search for a coating mechanic, the Straw Hats encounter the Celestial Dragons, the cruel rulers of the World Government."),
        [@"Sabaody Archipelago|5"] = new EpisodeMeta(
            Title: @"The Embers of History",
            Overview: @"While at Shakky’s Rip-off Bar, the Straw Hats learn that Luffy, Zoro and nine other rookie pirates on Sabaody have reached a certain level of infamy. Later, Zoro has a close call with an insufferable and sadistic Celestial Dragon."),
        [@"Sabaody Archipelago|6"] = new EpisodeMeta(
            Title: @"The Auction House Incident",
            Overview: @"Nami's group arrives at the Grove 1 auction house where Camie will be sold to the highest bidder. With 200 million berries in hand, Nami is determined to win back their friend. The auction wears on as Luffy and co. race to the grove."),
        [@"Sabaody Archipelago|7"] = new EpisodeMeta(
            Title: @"An Island in Chaos",
            Overview: @"As chaos erupts inside the auction house, a mysterious man with an equally mysterious power emerges from backstage. But now, due to Luffy’s insolent actions, a Marine admiral is on his way to Sabaody."),
        [@"Sabaody Archipelago|8"] = new EpisodeMeta(
            Title: @"Roger and Rayleigh",
            Overview: @"The Marines surround the auction house, and super rookies Monkey D. Luffy, Eustass Kid, and Trafalgar Law all want a piece of the action. Later, Rayleigh reveals his shocking past to the Straw Hats."),
        [@"Sabaody Archipelago|9"] = new EpisodeMeta(
            Title: @"Kizaru Arrives",
            Overview: @"Luffy and his crew decide to lay low in town while Rayleigh coats the Sunny. Meanwhile, Admiral Kizaru from Marine HQ arrives on the archipelago in search of those responsible for threatening the Celestial Dragons."),
        [@"Sabaody Archipelago|10"] = new EpisodeMeta(
            Title: @"Kizaru vs. the Four Captains",
            Overview: @"While four super rookies square off against Kizaru, the Straw Hats combine their strongest attacks to defeat the pacifista menacing them. The battle is barely won when yet another, deadlier foe comes to take its place."),
        [@"Sabaody Archipelago|11"] = new EpisodeMeta(
            Title: @"I Couldn't Save Them!!!",
            Overview: @"In the face of overwhelming danger, Luffy orders a full retreat. However, Warlord Kuma cuts off their frenzied escape and uses a harrowing touch of his devil fruit powers against Luffy’s crewmates, one by one."),
        [@"Skypiea|1"] = new EpisodeMeta(
            Title: @"Heaven's Gate",
            Overview: @"The Straw Hats, having used the Knock-Up Stream to fly into the sky, arrive on a white ocean above the clouds. While they marvel at the otherworldly sights, they are attacked by a powerful masked figure, and a mysterious flying knight comes to their aid."),
        [@"Skypiea|2"] = new EpisodeMeta(
            Title: @"Angel Beach",
            Overview: @"After bidding farewell to Gan Fall and passing through the gate to Skypiea, the pirates encounter a family of Skypieans: Conis and her father, Pagaya. The two explain the workings of life in the sky and introduce the crew to the different dials."),
        [@"Skypiea|3"] = new EpisodeMeta(
            Title: @"Divine Reckoning",
            Overview: @"Nami takes the waver out for a test ride and discovers the forbidden Upper Yard. Meanwhile, law enforcement arrives and rudely harasses the rest of the gang."),
        [@"Skypiea|4"] = new EpisodeMeta(
            Title: @"Ordeal",
            Overview: @"The pirates are fed up and ready to leave Skypiea, but Nami, Zoro, Robin, and Chopper are whisked away aboard the Merry. The remaining Straw Hat Pirates must face Enel’s challenge, so Conis shows them the way to Upper Yard."),
        [@"Skypiea|5"] = new EpisodeMeta(
            Title: @"Adventure on God's Island",
            Overview: @"Aboard the Little Crow, Luffy, Usopp, and Sanji enter Upper Yard and must choose an ordeal. Meanwhile, Zoro and co. have their own troubles at the Sacrificial Altar. When they leave to explore the forest, Chopper is left to repair the Merry."),
        [@"Skypiea|6"] = new EpisodeMeta(
            Title: @"The Village Hidden in the Clouds",
            Overview: @"Luffy, Sanji, and Usopp are locked in a life-or-death struggle against the Priest Satori. It's all they can do to withstand the random attributes of Satori's strange spheres and to overcome the power of mantra, which can seemingly predict their movements."),
        [@"Skypiea|7"] = new EpisodeMeta(
            Title: @"Overture",
            Overview: @"Gan Fall is severely burned during his battle with Shura, and Chopper musters the courage for a leap of faith. Elsewhere, Luffy and co. finally discover a way to defeat the mantra-wielding Satori, and the Shandians prepare for an all-out attack on God!"),
        [@"Skypiea|8"] = new EpisodeMeta(
            Title: @"Vearth",
            Overview: @"The Shandians’ attack on Upper Yard commences! At the Sacrificial Altar, the crew is finally reunited, and everyone recounts what has happened. Chopper looks after the injured Gan Fall, and the pirates devise a plan to steal the gold on the island."),
        [@"Skypiea|9"] = new EpisodeMeta(
            Title: @"Dial Battle",
            Overview: @"The crew splits up into Nami's escape team and Luffy's exploration team. Unfortunately, a giant snake attacks and separates Luffy's team. To top it all off, the Priests have set up their ordeals across the whole island."),
        [@"Skypiea|10"] = new EpisodeMeta(
            Title: @"Pirate Luffy vs. Berserker Wyper",
            Overview: @"Only 80 remain in the Upper Yard survival game. Zoro finds himself face-to-face with the Shandian Braham, Luffy takes on Wyper and his burning bazooka, and Nami’s group on the Merry has the deadliest encounter of all!"),
        [@"Skypiea|11"] = new EpisodeMeta(
            Title: @"Pirate Chopper vs. Priest Gedatsu",
            Overview: @"Luffy's fight with Wyper lands him in a dark cavern filled with ruins, Enel leaves a deadly pair of new enemies to deal with Nami and Gan Fall, and Chopper comes face to face with Sky Punk Gedatsu."),
        [@"Skypiea|12"] = new EpisodeMeta(
            Title: @"Pirate Robin vs. Commander Yama",
            Overview: @"Enel wipes out several fighters regardless of their allegiance. An hour remains until God's deadline, and only twenty-four survivors remain. Meanwhile, after a deadly struggle with the rotund Yama, Robin makes the discovery of a lifetime."),
        [@"Skypiea|13"] = new EpisodeMeta(
            Title: @"Concerto",
            Overview: @"While Luffy remains lost in a strange, dark cavern, at the Upper Ruins, Priest Ohm confronts Zoro, Gan Fall, and Wyper with his Ordeal of Iron. As the fight wears on, Shandian warriors, Nami, and Aisa make a sudden appearance."),
        [@"Skypiea|14"] = new EpisodeMeta(
            Title: @"Pirate Zoro vs. Priest Ohm",
            Overview: @"After being swallowed by the giant snake, Nami, Gan Fall, and Aisa meet someone they never expected would be in the serpent's stomach. As Priest Ohm’s Ordeal of Iron comes to a close in the Upper Ruins, Zoro unleashes a powerful new technique."),
        [@"Skypiea|15"] = new EpisodeMeta(
            Title: @"Quintet",
            Overview: @"The lost ruins of Shandora are revealed in a spectacle of lightning, and the remaining survivors of Enel's twisted game begin their showdown with the self-styled deity. As the group faces him, ""God"" reveals his ultimate goal..."),
        [@"Skypiea|16"] = new EpisodeMeta(
            Title: @"Conis",
            Overview: @"God Enel reveals his grand masterpiece to the sole survivor of his deadly game, and a certain rubber man finally frees himself of the snake's stomach! Meanwhile, Conis makes a desperate dash to Angel Island to warn its residents of their impending doom."),
        [@"Skypiea|17"] = new EpisodeMeta(
            Title: @"Deathpiea",
            Overview: @"As the citizens of the sky run for their lives, Enel activates Deathpiea! Luffy must discover a way to lay hands on the heinous holy man before he's sent overboard, and Sanji and Usopp mount a midair rescue mission."),
        [@"Skypiea|18"] = new EpisodeMeta(
            Title: @"On the Front Line of Love's Salvation",
            Overview: @"Usopp arrives just in time to save Nami from a lethal thunderbolt, and Sanji stealthily searches for a way to sabotage the ark. Despite being slowed by an arm encased in gold, Luffy races up Giant Jack on a mission to settle the score!"),
        [@"Skypiea|19"] = new EpisodeMeta(
            Title: @"Godkiller",
            Overview: @"As Enel rains destruction upon Skypiea, Wyper remembers the tales passed down by the village elder about when his ancestor the warrior Kalgara met the explorer Mont Blanc Noland."),
        [@"Skypiea|20"] = new EpisodeMeta(
            Title: @"The Light of Shandora",
            Overview: @"The flashback of the legend of Mont Blanc Noland and Kalgara the warrior continues with the story of how these two very different men suddenly found friendship... and then lost it just as quickly!"),
        [@"Skypiea|21"] = new EpisodeMeta(
            Title: @"Raigō",
            Overview: @"Mont Blanc Noland's tale ends in tragedy and misunderstanding. In the present, Enel strikes Angel Island with a devastating lightning bolt, and Luffy refuses to halt his climb up the beanstalk until he rings the golden bell!"),
        [@"Skypiea|22"] = new EpisodeMeta(
            Title: @"Love Song",
            Overview: @"While Enel continues his thunderous barrage, Nami hatches a plan to give Luffy one more shot at a grudge match with God. With a nudge from Zoro, Wyper, and a snake, Straw Hat launches himself into the center of a sinister storm!"),
        [@"Skypiea|23"] = new EpisodeMeta(
            Title: @"Fantasia",
            Overview: @"In the aftermath of Luffy's epic battle with Enel, sunny skies chase away the storms, and the cloud-dwelling citizens of Angel Island turn their attention to rebuilding their homeland."),
        [@"Skypiea|24"] = new EpisodeMeta(
            Title: @"I Made It Here",
            Overview: @"Robin deciphers the message of the poneglyph, ending the Shandians' centuries-long task of guarding the golden bell. Before leaving Skypiea, the Straw Hats embark on their promised gold heist, and the people of the sky see them off on their journey."),
        [@"Skypiea|25"] = new EpisodeMeta(
            Title: @"Finale",
            Overview: @"With a little help from their new friends—and a giant octopus—the Straw Hats bid farewell to Skypiea and begin their descent back to the Blue Sea. Then as night falls, a certain Warlord makes an appearance at Jaya..."),
        [@"Specials|1"] = new EpisodeMeta(
            Title: @"Strong World",
            Overview: @""),
        [@"Specials|2"] = new EpisodeMeta(
            Title: @"Straw Hat Theatre",
            Overview: @""),
        [@"Specials|3"] = new EpisodeMeta(
            Title: @"Romance Dawn, Version 2",
            Overview: @""),
        [@"Specials|4"] = new EpisodeMeta(
            Title: @"Wapol's Omnivorous Hurrah",
            Overview: @""),
        [@"Specials|5"] = new EpisodeMeta(
            Title: @"Whole Cake Island 01 (April Fools 2017)",
            Overview: @""),
        [@"Specials|6"] = new EpisodeMeta(
            Title: @"Whole Cake Island 39 (April Fools 2019)",
            Overview: @"After the Straw Hats die, Tommy Wiseau picks up the pieces and explores a story of love, betrayal, and doggies."),
        [@"Specials|7"] = new EpisodeMeta(
            Title: @"Gaimon 01 (April Fools 2021)",
            Overview: @"The Straw Hats venture to the fabled ""Treasure Island"" to discover riches, adventure, and... strange creatures. Oh, and everything is in Klingon for some reason."),
        [@"Specials|8"] = new EpisodeMeta(
            Title: @"Tournament of Power",
            Overview: @"The stage is set for an epic battle as the greatest warriors from different universes to fight for their survival. Get ready for an unforgettable fight like no other, as this episode will have you holding your breath until the very end."),
        [@"Specials|9"] = new EpisodeMeta(
            Title: @"The Desert Doo Doo Hits the Fan (April Fools 2024)",
            Overview: @"When Crocodile yells ""Oh no! Water!"" it's game over! Join Monkey D. Luffy and his courageous crew—Nami, Usopp, Chopper (who does doctoring), Sanji, and Zolo—as they save Alabasta from the crooked clutches of Baroque Works!"),
        [@"Specials|10"] = new EpisodeMeta(
            Title: @"Warship Island 01 (April Fools 2025)",
            Overview: @""),
        [@"Syrup Village|1"] = new EpisodeMeta(
            Title: @"Captain Usopp",
            Overview: @"With Nami joining as Luffy's navigator (though not as an actual member of the crew), they arrive at Syrup Village in search of a proper ship. There they meet a man claiming to be a pirate captain who also seems to have ties to Red-Haired Shanks."),
        [@"Syrup Village|2"] = new EpisodeMeta(
            Title: @"Captain Kuro",
            Overview: @"After uncovering a devious plot, Usopp warns the village and Kaya, but finds his years of lying make it difficult to convince people of the truth."),
        [@"Syrup Village|3"] = new EpisodeMeta(
            Title: @"The Slope",
            Overview: @"Usopp resolves that if he is to keep the peace, the town must continue to believe he is a liar, which means he cannot let Captain Kuro’s men up the slope to the village! Luffy, Zoro, and Nami aid Usopp in his plan to keep the Black Cat Pirates at bay."),
        [@"Syrup Village|4"] = new EpisodeMeta(
            Title: @"The Silent Man",
            Overview: @"Captain Kuro makes his appearance, and with Zoro too injured to fight, Luffy incapacitated, and Usopp and Nami too weak to make a stand, the situation is desperate. However, Kaya herself arrives, intent on bargaining with Kuro."),
        [@"Syrup Village|5"] = new EpisodeMeta(
            Title: @"The Pirate ""Kuro of a Hundred Plans""",
            Overview: @"While the fight between Luffy and Kuro continues, Jango works to force Kaya to bequeath her family's money to the Black Cat captain. Despite the Usopp Pirates' efforts to stop the hypnotist, it seems as if the transaction is all but inevitable."),
        [@"Syrup Village|6"] = new EpisodeMeta(
            Title: @"For Whom the Bell Tolls",
            Overview: @"Kuro's ultimate move attacks everything in the area, friend nor foe notwithstanding, and Luffy becomes enraged by Kuro's lack of regard for his crew."),
        [@"Syrup Village|7"] = new EpisodeMeta(
            Title: @"To the Sea",
            Overview: @"The island is saved without any villagers ever knowing what almost befell their home. Kaya, grateful to the Straw Hats for what they did, gifts them something invaluable for sailing the high seas. Meanwhile, one more person joins Luffy's crew."),
        [@"The Adventures of Buggy's Crew|1"] = new EpisodeMeta(
            Title: @"The Adventures of Buggy's Crew",
            Overview: @"Buggy, after being defeated by Luffy, Zoro, and Nami, begins his quest to regain his body parts and his crew, and then he will get his flashy revenge on Luffy."),
        [@"The Trials of Koby-Meppo|1"] = new EpisodeMeta(
            Title: @"The Trials of Koby-Meppo",
            Overview: @"Koby and Helmeppo are new cabin boys for the Marines, but they become unwillingly involved in an escape attempt by Morgan. Their bravery will either earn them the respect of their superiors—as well as Vice Admiral Garp—or it will spell their doom."),
        [@"Thriller Bark|1"] = new EpisodeMeta(
            Title: @"The Mysterious Sea and The Skeleton Brook!",
            Overview: @"The Thousand Sunny gets flung into the foggy Florian Triangle and the Straw Hats encounter a ruined ship. Speculating as to whether there are ghosts aboard, it turns out the pirates are not far from the truth."),
        [@"Thriller Bark|2"] = new EpisodeMeta(
            Title: @"Adventure on the Ghost Island and the Famous Doctor Hogback!",
            Overview: @"Brook bids the Straw Hats farewell, and they decide to explore the nearby ghost island Thriller Bark. Freakish danger awaits the landing party the moment they arrive, and, back on the Sunny, the rest of the crew is harassed by an unseen foe."),
        [@"Thriller Bark|3"] = new EpisodeMeta(
            Title: @"The Invisible Man and the Secret of the Mansion!",
            Overview: @"While staying at Hogback's eerie mansion, Nami is assaulted by an invisible figure in the shower. It does not end there as Usopp battles haunted paintings with a handful of candles. Meanwhile, the rest of the Straw Hats finally make landfall."),
        [@"Thriller Bark|4"] = new EpisodeMeta(
            Title: @"General Zombie Night! Thriller Bark's Mysterious Four",
            Overview: @"The Straw Hats learn that the head honcho on the island is one of the Seven Warlords, and he has concocted a shadowy scheme. As Absalom rallies the zombies, the master of Thriller Bark awakens."),
        [@"Thriller Bark|5"] = new EpisodeMeta(
            Title: @"Perona's Wonder Garden and the Charge of the General Zombies!",
            Overview: @"Nami, Usopp, and Chopper manage to escape their coffin but find themselves in a garden surrounded by animal zombies, including one acting remarkably like Sanji. It also seems that one by one, the Straw Hats are disappearing."),
        [@"Thriller Bark|6"] = new EpisodeMeta(
            Title: @"Number 900?! Lola's Pursuit and the Humming Swordsman",
            Overview: @"Lola attacks Nami out of ignorant jealousy, but the Sanji-esque zombie plays interference. Meanwhile, with Luffy captured, and Franky and Robin left to face a massive spider monkey, a familiar bony figure falls from the sky."),
        [@"Thriller Bark|7"] = new EpisodeMeta(
            Title: @"The Fearsome Ability of the Shadow Fruit! The Ultimate Number 900!",
            Overview: @"Gecko Moria takes his next step toward his goal of eventually becoming king of the pirates by creating the ultimate zombie. Luffy's shadow in hand, Moria begins the revival of the much-anticipated number 900."),
        [@"Thriller Bark|8"] = new EpisodeMeta(
            Title: @"Oars' Awakening and Brook vs. Ryuma!",
            Overview: @"Dead for 500 years and left in a deep freeze since, Oars awakens, fueled by Luffy's shadow. Soon after, Nami, Usopp, and Chopper are discovered hiding inside Perona's pet bear, and Absalom abducts Nami for his demented marriage ceremony."),
        [@"Thriller Bark|9"] = new EpisodeMeta(
            Title: @"The Hope and Despair of the Skeleton and the Straw Hats' Counterattack!",
            Overview: @"The Straw Hats regroup on the Sunny in a pitiable state, but not before Brook leaves Franky with some valuable information. In addition, they now know of the promise Brook made to a certain friend fifty years ago, someone the Straw Hats know well."),
        [@"Thriller Bark|10"] = new EpisodeMeta(
            Title: @"Already Negative! Usopp's Courageous Stand!",
            Overview: @"Oars' entry into the fight suddenly changes everything! Then, when Perona attacks, only one of the pirates seems to be immune to her negative powers. Due to his glass-half-empty personality, Usopp might have what it takes to defeat the Ghost Princess."),
        [@"Thriller Bark|11"] = new EpisodeMeta(
            Title: @"A Stolen Dream! Sanji vs. Absalom",
            Overview: @"Sanji crashes Absalom's sham of a wedding, the fire in his heart burning brightly as he rescues Nami. A curious connection between Sanji and the Clear-Clear Fruit is revealed, and he vows to defeat Absalom for ruining his lifelong dream."),
        [@"Thriller Bark|12"] = new EpisodeMeta(
            Title: @"Perona's Terror! Usopp vs. the Ghost Princess!",
            Overview: @"After getting the stuffing beat out of him by a zombie teddy bear, Usopp summons his sharp-shooting alter ego to help him discover the secret to defeating Perona! He reaches deep into his devious bag of tricks to even the odds in this spooky battle."),
        [@"Thriller Bark|13"] = new EpisodeMeta(
            Title: @"Zoro vs. Ryuuma and Chopper's Rage!",
            Overview: @"Zoro stands in for Brook and duels Ryuma, the swordsman zombie from faraway Wano. In the mansion, Chopper's former respect for Dr. Hogback is completely erased after coming to realize the man's twisted views on life."),
        [@"Thriller Bark|14"] = new EpisodeMeta(
            Title: @"Show Yourselves, Straw Hat Pirates! The Crew's Hopeless Counterattack!",
            Overview: @"With Oars now a fully obedient zombie, Gecko Moria takes his leave while instructing the giant to hunt down the pirates, whose wanted posters are sewn onto his arm. One by one, the Straw Hats' battles are interrupted by Oars' march around Thriller Bark."),
        [@"Thriller Bark|15"] = new EpisodeMeta(
            Title: @"Clash! The Titanic Battle Against Zombie 900!",
            Overview: @"The Straw Hats sans Luffy are faced with the insurmountable task of taking out Oars. To knock him down, Franky decides they will need to use his newly developed tactic. But as they begin ""docking"" onto one another, a slight problem arises."),
        [@"Thriller Bark|16"] = new EpisodeMeta(
            Title: @"The Mysterious Visitor! The Two Warlords Meet!",
            Overview: @"While the Straw Hats continue to wear away at Oars, Nami confronts Perona attempting to escape on board the Thousand Sunny, but the sudden appearance of a large, mysterious figure soon makes her efforts moot."),
        [@"Thriller Bark|17"] = new EpisodeMeta(
            Title: @"Combination of Brains and Brawn! Oars and Moriah vs. the Straw Hats!",
            Overview: @"To give Luffy a fighting chance against Moria, Lola and her pirate crew propose a plan to fight shadow with shadow. Meanwhile, Gecko Moria uses his abilities to enhance and manipulate Oars’ massive body."),
        [@"Thriller Bark|18"] = new EpisodeMeta(
            Title: @"The Crew's Annihilation! Oars vs. Nightmare Luffy",
            Overview: @"Moria’s strange combination with Oars defeats the Straw Hats one after the other. They are at their breaking point when a powerful figure swoops in and takes up the fight in their stead. The hellish creation: Nightmare Luffy!"),
        [@"Thriller Bark|19"] = new EpisodeMeta(
            Title: @"Morning Comes! The Straw Hats' Ultimate Attack!",
            Overview: @"Oars recovers from Nightmare Luffy's assault, but the Straw Hats all get back on their feet and launch a final devastating attack on Oars. Morning fast approaches, and Moria is far from finished, ready to use his ultimate technique."),
        [@"Thriller Bark|20"] = new EpisodeMeta(
            Title: @"The Power That Can Deflect Anything?! Zoro Fights Prepared to Die!",
            Overview: @"Moria’s defeat returns the shadows of all his victims. However, one Warlord remains on the island, and he has orders to terminate the Straw Hats and everyone else in the area. A lone Zoro faces Kuma in vain and is presented with a deadly choice."),
        [@"Thriller Bark|21"] = new EpisodeMeta(
            Title: @"Brook's Past! The Rumbar Pirates and Laboon!",
            Overview: @"Brook recalls his past, thinking back on the time when the small whale Laboon started following his pirate ship and befriended the crew."),
        [@"Thriller Bark|22"] = new EpisodeMeta(
            Title: @"Brook's Promise! The Eighth Member",
            Overview: @"At death's door, the Rumbar Pirates sang ""Binks' Brew"" one last time and recorded it in a tone dial, hoping to one day deliver it to Laboon. With their new crewmate and musician Brook on board, the Straw Hats bid farewell to Lola’s crew."),
        [@"Wano|1"] = new EpisodeMeta(
            Title: @"Onward to Wano",
            Overview: @"Luffy and the others see familiar faces in a newspaper article about the Reverie right as they approach Wano. However, this dangerous and foreboding land is as inaccessible as it is mysterious, with the sea itself acting as a barrier!"),
        [@"Wano|2"] = new EpisodeMeta(
            Title: @"Seppuku",
            Overview: @"A mysterious country, a rampaging slasher, an ancient samurai ritual of seppuku—and Zoro in the crosshairs! Stranded alone on the beach, Luffy tries to gather his bearings only to be confronted by some dangerous local fauna."),
        [@"Wano|3"] = new EpisodeMeta(
            Title: @"Amigasa Village",
            Overview: @"Otama recounts her promise to Ace while Luffy rushes her to medical attention. But just as they reach the wasteland, a familiar face comes into view, and Kaido's underlings show up, too!"),
        [@"Wano|4"] = new EpisodeMeta(
            Title: @"Tsuru Returns the Favor",
            Overview: @"Luffy and Zoro are stalled by Hawkins, but their fortune looks bright when a woman guides them to a teahouse. There, they find an herbal remedy for the river poison that Otama drank, while old acquaintances look on from a distance."),
        [@"Wano|5"] = new EpisodeMeta(
            Title: @"Okobore Town",
            Overview: @"Otama is kidnapped by Kaido’s gifters and taken to a flourishing settlement called Bakura Town where a creepy-looking headliner was expecting her. Luffy, Zoro, and the samurai Okiku rush to her rescue."),
        [@"Wano|6"] = new EpisodeMeta(
            Title: @"Wano's Grand Sumo Tournament",
            Overview: @"Luffy challenges Urashima, the strongest yokozuna in Wano, to a sumo match! However, Urashima is willing to resort to illegal moves. Meanwhile, Holdem tells Otama that he must punish her for a crime she committed."),
        [@"Wano|7"] = new EpisodeMeta(
            Title: @"The Provisions Ship",
            Overview: @"Luffy and co. finally find Otama hanging from the mouth of a lion in Holdem’s stomach. Luffy prepares to save Otama from Kaido’s lackey, and elsewhere, a mysterious figure confronts Basil Hawkins."),
        [@"Wano|8"] = new EpisodeMeta(
            Title: @"The Ruins of Oden Castle",
            Overview: @"Zoro and the others dash out of Bakura Town on the treasure ship filled with food! Luffy catches up to them, and together, they distribute food and water to the people of Okobore Town. Later, Law takes them to the ruins of a hilltop castle."),
        [@"Wano|9"] = new EpisodeMeta(
            Title: @"I Love Oden",
            Overview: @"Kin’emon tells Luffy and the others about how Kozuki Oden brought peace to Kuri and became its daimyo. However, he was set up by Kaido and Orochi. When Kin’emon ran to save Oden’s wife, she revealed a shocking truth."),
        [@"Wano|10"] = new EpisodeMeta(
            Title: @"Shutenmaru",
            Overview: @"Ashura Doji, a.k.a Shutenmaru, is one of the allies Kin’emon wants to search for, and he leads a raid on Okobore Town to steal the food that Luffy brought. This unrest prompts the drunken Kaido to fly above Okobore Town in his dragon form."),
        [@"Wano|11"] = new EpisodeMeta(
            Title: @"Emperor Kaido vs. Luffy",
            Overview: @"Infuriated by Kaido’s violence toward his allies, Luffy lands blow after blow on the drunken Emperor. When he activates Gear Fourth and launches even more powerful attacks, Kaido fights back. Law tries to rescue Luffy but is interrupted by Hawkins."),
        [@"Wano|12"] = new EpisodeMeta(
            Title: @"Hah",
            Overview: @"Luffy is sent to a great mine where prisoners must endure harsh, forced labor. There, he has an unexpected reunion. Meanwhile, Okiku rushes to the ruins of Oden Castle to confirm the safety of the Straw Hats and the others."),
        [@"Wano|13"] = new EpisodeMeta(
            Title: @"Void",
            Overview: @"Perona prepares to leave Gloom Island after she finds out that her captain, Gecko Moria, is still alive. Meanwhile, Moria raids the infamous Pirate Island with his zombie army to retrieve his old friend from Blackbeard."),
        [@"Wano|14"] = new EpisodeMeta(
            Title: @"Otoko the Kamuro",
            Overview: @"In the Prisoner Mining Camp, Luffy’s and Kid’s competition garners the wrong kind of attention. Meanwhile, Sanji’s soba becomes immensely popular, but gang members disturb his business and knock over a customer’s bowl."),
        [@"Wano|15"] = new EpisodeMeta(
            Title: @"Oiran Komurasaki Arrives",
            Overview: @"Wano’s top courtesan—the oiran Komurasaki—is in procession and slowly makes her way to Orochi Palace. While everyone is fascinated by the oiran, some seeking vengeance get in her way."),
        [@"Wano|16"] = new EpisodeMeta(
            Title: @"Soba Mask",
            Overview: @"In the Flower Capital, a member of the Beast Pirates, Page One, attacks every soba restaurant in search of Sanji. The Straw Hat’s cook faces Kaido’s headliner while using Germa’s device for the first time to hide his identity."),
        [@"Wano|17"] = new EpisodeMeta(
            Title: @"The Shogun and the Oiran",
            Overview: @"At the shogun’s banquet, the oiran’s child attendant Otoko bursts with laughter and cannot stop. The enraged Shogun Orochi attacks her, but an unexpected person stands in his way. To end the to-do, Kyoshiro takes matters into his own hands."),
        [@"Wano|18"] = new EpisodeMeta(
            Title: @"Hyogoro the Flower",
            Overview: @"Chopper’s group is off to rescue Luffy from the Prisoner Mining Camp, but the Straw Hat captain is in a bit of a bind. While Luffy tries to save old man Hyo from execution, Queen the Plague comes to visit the prison."),
        [@"Wano|19"] = new EpisodeMeta(
            Title: @"Gyukimaru of Bandit's Bridge",
            Overview: @"Luffy fights in an endless sumo match to protect old man Hyo, and Nami, Robin, and Shinobu are cornered as Hawkins raids the bathhouse. Elsewhere, Zoro faces a samurai who accuses him of stealing Shusui, but their duel is interrupted by a woman’s scream."),
        [@"Wano|20"] = new EpisodeMeta(
            Title: @"A Woman's Secret",
            Overview: @"The wounded Zoro wakes up to find out the shocking identity of the woman he saved and is told the unbelievable tale of twenty years earlier. Meanwhile, Luffy’s “training” is not getting anywhere, but a surprising person gives him his first lesson."),
        [@"Wano|21"] = new EpisodeMeta(
            Title: @"Sparks of Rebellion",
            Overview: @"The smiling man Tonoyasu leaves all who met him mystified, what with his familiar terms of address and his shocking knowledge of the rebellion. In Udon prison, Luffy continues his new haki training, and during a brief respite, Raizo appears before him."),
        [@"Wano|22"] = new EpisodeMeta(
            Title: @"Shimotsuki Yasuie, the Daimyo of Hakumai",
            Overview: @"Tonoyasu has been strung up and awaits his inevitable execution while all of Wano is shocked to find out who he really is. The citizens cry out in outrage, and the doomed man raises his voice in a final act of rebellion against Shogun Orochi."),
        [@"Wano|23"] = new EpisodeMeta(
            Title: @"SMILE",
            Overview: @"The truth behind the smiles of the Ebisu villagers finally comes to light, the Shogun and Kaido’s plan revealed! And in Udon Luffy and Hyo are shocked to see Captain Kid return in chains alongside a smiling newcomer."),
        [@"Wano|24"] = new EpisodeMeta(
            Title: @"Olin",
            Overview: @"A very big and hungry visitor arrives at Udon looking for Superstar Queen’s sweet red bean oshiruko, and Rasetsu town is in a full-blown riot with the Straw Hats at the center!"),
        [@"Wano|25"] = new EpisodeMeta(
            Title: @"Queen vs. Olin",
            Overview: @"To Chopper’s surprise, the kind and sweet Olin—a.k.a. Emperor Big Mom—has proven her power to be just as devastating as ever. Olin’s hunger pangs just about reach their limit, and Luffy must act quickly before his mechanical collar executes him."),
        [@"Wano|26"] = new EpisodeMeta(
            Title: @"Mummy",
            Overview: @"Babanuki unleashes an unthinkable weapon, and a mysterious figure emerges from a forbidden cell to save Luffy. Then, Old Man Hyo emboldens Raizo and Kiku to reveal their true identities and give the desperate prisoners some much-needed hope."),
        [@"Wano|27"] = new EpisodeMeta(
            Title: @"A Soldier's Dream",
            Overview: @"In Udon, an unexpected person stands up to bring the prisoners renewed hope! Elsewhere, Zoro and Hiyori are pursued by ninja, Orochi is told of Trafalgar Law’s capture, and the people of the Flower Capital prepare for the upcoming Fire Festival."),
        [@"Wano|28"] = new EpisodeMeta(
            Title: @"RAMPAGE",
            Overview: @"Kanjuro takes Yasuie’s body to bury him with Oden, and Robin, Usopp, and Brook cleverly pass a checkpoint. While Big Mom and Kaido clash at Onigashima, Old Man Hyo finds his former allies in Udon. And in Ringo, Zoro faces Gyukimaru once more."),
        [@"Wano|29"] = new EpisodeMeta(
            Title: @"Once a Fox",
            Overview: @"Zoro runs after the warrior-monk who took Shusui, and Kawamatsu shares his memory of a fox that was guarding the graves in Ringo. Soon, they find a room filled with swords, and Hiyori tells Zoro to give Shusui back to the land of Wano."),
        [@"Wano|30"] = new EpisodeMeta(
            Title: @"Enma",
            Overview: @"As the day of the raid approaches, Kin’emon discusses the plan, and at Onigashima, Kaido and Big Mom make a surprising declaration! In the meantime, Zoro is stunned by Enma’s demonic power and its ties to him."),
        [@"Wano|31"] = new EpisodeMeta(
            Title: @"Big News",
            Overview: @"The resolution that passed during the Reverie and the incidents surrounding the conference stun people all over the world and corner the Seven Warlords of the Sea. Meanwhile, Captain Koby secretly contacts someone currently in Wano."),
        [@"Wano|32"] = new EpisodeMeta(
            Title: @"Ultimate",
            Overview: @"Admiral Issho and Fleet Admiral Sakazuki argue over the abolition of the Seven Warlord system and the alliance between two Emperors. Meanwhile, ex-Fleet Admiral Sengoku teaches the young Marines about the legendary Rocks Pirates."),
        [@"Wano|33"] = new EpisodeMeta(
            Title: @"The Designated Port",
            Overview: @"On the day of the Fire Festival, Orochi heads for Onigashima where a big banquet is being held, and the Red Scabbards meet at the Tokage Port rendezvous point. However, Kin'emon and his compatriots are stunned that none of their allies are there."),
        [@"Wano|34"] = new EpisodeMeta(
            Title: @"The Day of the Mountain God",
            Overview: @"Forty-one years ago, Oden had not yet earned the respect of everyone, but when the angry mountain god almost killed Kin’emon, Oden stepped in. Still, disavowed by his father, Oden journeyed around the country, gathering followers as he went."),
        [@"Wano|35"] = new EpisodeMeta(
            Title: @"Daimyo and Retainers",
            Overview: @"Oden transformed Kuri and was made Daimyo over it. He also met a kappa fishman and two minks, who soon became his followers. Kin’emon and the other vassals took Yasuie's strong words to heart and began transforming themselves for their lord."),
        [@"Wano|36"] = new EpisodeMeta(
            Title: @"Oden's Adventure",
            Overview: @"As Oden began his voyage, he was in awe of all the things that he had never seen before, and for the first time in his life, he became a wanted person and made the headlines, catching the eye of a high-profile figure."),
        [@"Wano|37"] = new EpisodeMeta(
            Title: @"Roger and Whitebeard",
            Overview: @"Back in Wano, the Shogun Sukiyaki seemed to fall critically ill and named Orochi proxy Shogun. Meanwhile, Whitebeard's crew made landfall where the Roger Pirates were fighting against the Marines on the other side of the island."),
        [@"Wano|38"] = new EpisodeMeta(
            Title: @"Roger's Adventure",
            Overview: @"Oden visits Wano and sees his retainers for the first time in years, but he immediately returns to the sea and leaves his family behind in their care. After stopping at Zou for the final red poneglyph, the Roger Pirates finally make it to the last island."),
        [@"Wano|39"] = new EpisodeMeta(
            Title: @"Fool of a Lord",
            Overview: @"The Roger Pirates have completed their grand adventure, and the King of the Pirates is born! Gol D. Roger disbands his merry crew and Oden returns triumphant to his homeland of Wano. However, a sinister surprise awaits him upon his rightful throne."),
        [@"Wano|40"] = new EpisodeMeta(
            Title: @"Oden Was Meant to Boil",
            Overview: @"Oden and his retainers are sentenced to death by boiling in a pot. Oden asks for a chance to survive, and an amused Kaido accepts. Meanwhile, Shinobu reveals to surprised citizens what Oden had been doing to save the country."),
        [@"Wano|41"] = new EpisodeMeta(
            Title: @"The Kozuki Clan",
            Overview: @"After Kaido attacks Oden's family in their castle, Toki uses her power one last time and makes a prophecy to the people of Wano. Twenty years later, the raid on Onigashima is imminent, but the sting of betrayal hits hardest on the eve of triumph!"),
        [@"Wano|42"] = new EpisodeMeta(
            Title: @"Kin'emon's Clever Ruse",
            Overview: @"As the Scabbards and their comrades struggle to rescue the kidnapped Momo, two unforseen allies join the fight: one thought long gone 20 years ago and another pledging his loyalty to Luffy."),
        [@"Wano|43"] = new EpisodeMeta(
            Title: @"The Party's Off!!!",
            Overview: @"The triumphant return of Jinbe sees him officially join the Straw Hats as their helmsman. As the Ninja-Pirate-Mink-Samurai Alliance plans the first steps of the raid on Onigashima, the Straw Hats look for a way to celebrate their new crewmate."),
        [@"Wano|44"] = new EpisodeMeta(
            Title: @"A Family Matter",
            Overview: @"The raid on Onigashima kicks off with Law's group sneaking around the back and Luffy's group moving straight through the front door, cleverly disguised as the enemy itself! Meanwhile, Kaido holds an audience with the Soaring Six."),
        [@"Wano|45"] = new EpisodeMeta(
            Title: @"Fighting Music",
            Overview: @"Luffy and Zoro are outed by Scratchman Apoo, and Queen announces that anyone who catches them will get a coveted promotion. Elsewhere, Kin’emon's infiltration strategy evolves while Big Mom's children are greeted by a surprise party crasher."),
        [@"Wano|46"] = new EpisodeMeta(
            Title: @"Thunder",
            Overview: @"Kanjuro arrives before Orochi and Kaido with Momonosuke in tow and Big Mom chases Chopper and Usopp. Meanwhile, Luffy butts heads with Page One's doting sister Ulti, but unbeknownst to Straw Hat, he's also about to meet Kaido's runaway son..."),
        [@"Wano|47"] = new EpisodeMeta(
            Title: @"My Bible",
            Overview: @"Yamato notices something in Luffy that reminds him of someone from long ago. When Orochi declares he will execute Momonosuke, Kaido adds to the excitement with a big announcement, and at the rear of the mansion, the Red Scabbards reunite!"),
        [@"Wano|48"] = new EpisodeMeta(
            Title: @"Retainers of Glory",
            Overview: @"The stage is set, the curtain is drawn, and the Red Scabbards approach their target of 20 years. Luffy and Yamato burst onto the Performance Floor with a bang, and Wano's samurai make the opening attack for the long-anticipated battle."),
        [@"Wano|49"] = new EpisodeMeta(
            Title: @"I Can't Imagine Losing",
            Overview: @"Momonosuke is finally freed, and King and Queen must contend with the incursion of samurai and pirates on the Performance Floor. Big Mom is swiftly removed from the situation, and the Straw Hat pirates gather once more as the assualt kicks off!"),
        [@"Wano|50"] = new EpisodeMeta(
            Title: @"Army of One",
            Overview: @"Luffy invokes memories of the Straw Hats pirates' battle against Oars as he topples one of the gargantuan Numbers... with the help of an unforeseen ally! Meanwhile, Queen readies a demonic secret weapon that will ice over the samurai invasion."),
        [@"Wano|51"] = new EpisodeMeta(
            Title: @"Remnants",
            Overview: @"Yamato continues to pursue Momonosuke as Shinobu scurries with him through the halls of Onigashima. Meanwhile, the battle on the roof intensifies as the Scabbards fight with honor to prove they are not just cheap imitations of the great Kozuki Oden."),
        [@"Wano|52"] = new EpisodeMeta(
            Title: @"A Kunoichi's Oath",
            Overview: @"Friend and foe alike fall victim to Queen's chilling virus, and Apoo is playing keep-away with the vial of antibodies. Perospero and Marco's brief alliance is shattered, and so are Nami and Usopp's skulls as they face down Ulti and Page One."),
        [@"Wano|53"] = new EpisodeMeta(
            Title: @"Flame Clouds",
            Overview: @"In the midst of the chaos on the Performance Floor, Chopper learns the secret behind Queen's latest plague. Meanwhile, Big Mom reaches the roof, Sanji hurries in the name of love, and Zoro watches as something falls from the hole in the ceiling."),
        [@"Wano|54"] = new EpisodeMeta(
            Title: @"The Sake I Brewed to Drink With You",
            Overview: @"Sanji gets himself caught in Black Maria's web, Jinbe faces Who's-Who, and Yamato tells of the time Ace visited Onigashima. Elsewhere, Marco joins the fray on the Performance Floor to help soothe the infected and to offer Zoro a ride."),
        [@"Wano|55"] = new EpisodeMeta(
            Title: @"Straw Hat Luffy",
            Overview: @"Yamato recalls learning the sad truth about Ace, but remembers what he said about his brother, Straw Hat Luffy. As Kaido and Big Mom join forces on the roof of Onigashima, they are faced with the biggest names of the Worst Generation..."),
        [@"Wano|56"] = new EpisodeMeta(
            Title: @"The Battle of Monsters on Onigashima",
            Overview: @"It's a fight to remember! Five members from the Worst Generation—Monkey D. Luffy, Eustass ""Captain"" Kid, Trafalgar Law, Roronoa Zoro, and Killer—facing off against two Emperors—Kaido, ""King of the Beasts,"" and Charlotte Linlin, a.k.a. Big Mom!"),
        [@"Wano|57"] = new EpisodeMeta(
            Title: @"Millet Dumplings",
            Overview: @"Luffy momentarily topples Kaido with Gear Fourth, but the effort depletes his haki. Inside Onigashima, Tama's plan to rid the country of Kaido and Orochi unfolds as she feeds the gifters her special millet dumplings and turns the tide of battle!"),
        [@"Water Seven|1"] = new EpisodeMeta(
            Title: @"The City of Water, Water Seven",
            Overview: @"The keepers of Shift Station, Kokoro and her granddaughter Chimney, point the Straw Hats in the direction of the metropolitan Water Seven. The nearby city is regarded as the best place to find a decent shipwright for the Going Merry."),
        [@"Water Seven|2"] = new EpisodeMeta(
            Title: @"Mr. Iceburg",
            Overview: @"The Straw Hats cash in their Skypiean gold and meet up with Iceburg, the celebrity mayor of Water Seven, to see about an appraisal for their ship's repairs. While the foreman Kaku checks the Merry, dubious people eye the pirates' money."),
        [@"Water Seven|3"] = new EpisodeMeta(
            Title: @"The Case of the Kidnapped Pirate",
            Overview: @"Kalifa shows Luffy and co. around Dock One and tells them about Iceburg and Galley-La Company. During the tour, Kaku returns with some bad news, and a long-nosed Straw Hat goes missing… along with the money he was watching!"),
        [@"Water Seven|4"] = new EpisodeMeta(
            Title: @"Impasse",
            Overview: @"The Straw Hats raid the Franky House, but they soon find that their real target, Franky, is long gone with the stolen money. When the battered Usopp awakens, nothing can prepare him to hear what Luffy has decided about the Merry."),
        [@"Water Seven|5"] = new EpisodeMeta(
            Title: @"Luffy vs. Usopp",
            Overview: @"Usopp is unwilling to say farewell to the Going Merry… not without a fight, that is! He challenges his former captain to a duel between men, so Luffy honors the pride of his former crewmate and faces him in battle."),
        [@"Water Seven|6"] = new EpisodeMeta(
            Title: @"Warning",
            Overview: @"Iceburg has been shot! When Luffy and Nami decide to go check on him, the fire-breathing, half-mechanical Franky challenges the Straw Hats’ captain. Before their fight gets too heated, Galley-La swoops in with an unexpected accusation!"),
        [@"Water Seven|7"] = new EpisodeMeta(
            Title: @"Rumors",
            Overview: @"Things are hectic enough with Franky going after Luffy, but now the Straw Hats are being framed for a crime seemingly committed by Nico Robin. As if to put the proverbial icing on the cake, the annual storm Aqua Laguna is on its way toward Water Seven."),
        [@"Water Seven|8"] = new EpisodeMeta(
            Title: @"Devil",
            Overview: @"Nico Robin appears to be working alongside a World Government shadow organization called CP9. When the Straw Hats learn about Robin's current affiliation, Luffy decides that in order to know the full truth, they must catch Robin and make her talk."),
        [@"Water Seven|9"] = new EpisodeMeta(
            Title: @"Cipher Pol No. 9",
            Overview: @"Robin and her tall, mysterious, masked companion arrive at Iceburg's room, and she learns that he possesses blueprints to the ancient weapon Pluton, spoken of in the poneglyphs. Then, shockingly, the members of CP9 unmask themselves."),
        [@"Water Seven|10"] = new EpisodeMeta(
            Title: @"Six Powers",
            Overview: @"Luffy's group finally catches up to Robin, but they are greeted by disappointment—Robin opts to stay with CP9 and leave the Straw Hats. As Robin turns away from Luffy, the members of CP9 confronts the pirates."),
        [@"Water Seven|11"] = new EpisodeMeta(
            Title: @"Klabautermann",
            Overview: @"As Usopp works to repair the Going Merry, he contends with Franky's insistence on dismantling it. During this time, Usopp reflects on who it was that conducted the ship's repairs while in Skypiea, and Franky confirms his suspicions."),
        [@"Water Seven|12"] = new EpisodeMeta(
            Title: @"The Legendary Shipwright",
            Overview: @"In the past, Franky—a.k.a. Cutty Flam—was part of the legendary Tom's Workers, and he and Iceburg helped create the sea train. Spandam, a member of CP5, was determined to get Tom's blueprints for Pluton by any means necessary."),
        [@"Water Seven|13"] = new EpisodeMeta(
            Title: @"Mr. Tom",
            Overview: @"The old fishman Tom was framed by CP5 for the crime of attacking the Marines with Franky's battleships. As the World Government hauled Tom off to Enies Lobby, Franky received a lasting reminder to take pride in the ships he builds."),
        [@"Water Seven|14"] = new EpisodeMeta(
            Title: @"Bingo",
            Overview: @"CP9 hauls away Franky and Usopp, but not before giving a coldhearted farewell to the Merry. At Galley-La’s HQ, Nami learns from Iceburg the truth behind Robin's betrayal and the difficult choice she had to make to save the lives of the Straw Hats."),
        [@"Water Seven|15"] = new EpisodeMeta(
            Title: @"Departing Shortly",
            Overview: @"While the members of Galley-La help Chopper search for Luffy and Zoro, Nami rushes to the departing sea train to keep Robin from sacrificing her freedom. At the station, a man finds Nami and hands her a letter from Sanji."),
        [@"Water Seven|16"] = new EpisodeMeta(
            Title: @"Aqua Laguna",
            Overview: @"Sanji coolly fights his way through the sea train and locates Usopp and Franky. Back in Water Seven, Kokoro sees how determined Luffy is to save Robin, so she and Iceburg lend the Straw Hat crew an unexpected helping hand."),
        [@"Water Seven|17"] = new EpisodeMeta(
            Title: @"Sogeking",
            Overview: @"Rocketman blasts out of Water Seven and connects with the sea tracks, and old foes become allies for the coming struggle. Aqua Laguna swells, and it's up to Luffy and Zoro to combine their might and create safe passage for all aboard."),
        [@"Water Seven|18"] = new EpisodeMeta(
            Title: @"Ramen Kenpo",
            Overview: @"Sogeking appears in grand fashion! Wanze threatens Sanji's group with his ramen kenpo, so the Straw Hat cook urges the others ahead. Franky takes on CP9's newest recruit “Sea Weasel” Nero, and Sogeking moves forward to meet up with Robin."),
        [@"Water Seven|19"] = new EpisodeMeta(
            Title: @"The Honorable Captain T-Bone",
            Overview: @"In his battle against Wanze and his strange Ramen Kenpo, Sanji makes an exception to his rule of never using his hands. Meanwhile, Franky and Nero are baffled by each other’s abilities, and back on Rocketman, Zoro clashes with “Ship-Slasher” T-Bone."),
        [@"Water Seven|20"] = new EpisodeMeta(
            Title: @"Necessary Evil",
            Overview: @"Sanji and Franky conclude their fights and enter the train car where CP9’s agents lie in wait. When Sogeking sees the danger of the situation, it falls to him to formulate a plan for escape. However, CP9 is far from being thwarted!"),
        [@"Whisky Peak|1"] = new EpisodeMeta(
            Title: @"The Town of Celebration",
            Overview: @"As the Straw Hat Pirates travel from Reverse Mountain to Whisky Peak, Nami adjusts to having to watch the log pose constantly. When they arrive at their destination, the townspeople greet them warmly, despite the sight of their Jolly Roger."),
        [@"Whisky Peak|1"] = new EpisodeMeta(
            Title: @"The Town of Welcome",
            Overview: @"As the Straw Hat Pirates travel from Reverse Mountain to Whisky Peak, Nami adjusts to having to watch the log pose constantly. When they arrive at their destination, the townspeople greet them warmly, despite the sight of their Jolly Roger."),
        [@"Whisky Peak|2"] = new EpisodeMeta(
            Title: @"The Secret Criminal Organization",
            Overview: @"As Mr. 5 and Miss Valentine chase after the fleeing princess Vivi, Igaram begs Zoro to save her. But just when Zoro is about to take on Vivi's assailants, an enraged Luffy confronts him under a massive misunderstanding of the swordsman's latest actions."),
        [@"Whisky Peak|2"] = new EpisodeMeta(
            Title: @"The Secret Criminal Organization",
            Overview: @"As Mr. 5 and Miss Valentine chase after the fleeing princess Vivi, Igaram begs Zoro to save her. But just when Zoro is about to take on Vivi's assailants, an enraged Luffy confronts him under a massive misunderstanding of the swordsman's latest actions."),
        [@"Whisky Peak|3"] = new EpisodeMeta(
            Title: @"The Course",
            Overview: @"With Vivi aboard the Going Merry, the Straw Hats are now targets of Crocodile, one of the Seven Warlords of the Sea and leader of Baroque Works. En route to their next destination, Miss All-Sunday pays the pirates a visit to give a few words of advice."),
        [@"Whole Cake Island|1"] = new EpisodeMeta(
            Title: @"A World Abuzz",
            Overview: @"Luffy's team—plus a stowaway—sets out from Zou on their way to win back Sanji. Meanwhile, the leading families and leaders of the world make their way to the Holy Land, Mary Geoise, for a pivotal round table conference."),
        [@"Whole Cake Island|2"] = new EpisodeMeta(
            Title: @"0 and 4",
            Overview: @"Without Sanji to properly identify safe and edible food, Luffy gets a stomach full of poisonous fish! With no antidotes on board, the Straw Hats must rely on a couple of mysterious—yet somehow familiar—passersby for help."),
        [@"Whole Cake Island|3"] = new EpisodeMeta(
            Title: @"Totto Land",
            Overview: @"Arriving on Cacao Island, Luffy and Chopper are in heaven as everything before their eyes is edible. There, the Straw Hats encounter Sanji’s betrothed, Pudding, but when they challenge her for Sanji's heart, her answer is truly shocking."),
        [@"Whole Cake Island|4"] = new EpisodeMeta(
            Title: @"Pirate Emperor, Charlotte Linlin",
            Overview: @"Big Mom ravages Whole Cake Island in search of sweets, and while a familiar face across the waters has just what she needs, he also brings ill tidings. As the Straw Hats draw closer to the island, Pedro shares his sordid past in Big Mom’s territory."),
        [@"Whole Cake Island|5"] = new EpisodeMeta(
            Title: @"Adventure in the Mysterious Forest",
            Overview: @"Luffy’s group makes its way toward Sanji, only to be distracted by the endless supply of sweets and a second Luffy. Before they realize it, they are lost in the Seducing Woods! Meanwhile, Sanji confronts his older brother."),
        [@"Whole Cake Island|6"] = new EpisodeMeta(
            Title: @"Vinsmoke Judge",
            Overview: @"Sanji faces his father in a duel as the wounds of his childhood are laid bare! Meanwhile, Luffy falls for the illusions of the forest, and Big Mom has Caesar at her whims, ready to use him to continue her maniacal pursuits."),
        [@"Whole Cake Island|7"] = new EpisodeMeta(
            Title: @"Lola's Vivre Card",
            Overview: @"The mysterious half-buried man comes clean about his identity, but this must all be put aside when one of Big Mom's most powerful commanders comes calling. Nami's past exploits, however, hold the key to keeping the baddies at bay."),
        [@"Whole Cake Island|8"] = new EpisodeMeta(
            Title: @"Luffy vs. Commander Cracker",
            Overview: @"Luffy squares off against a commander of Big Mom, Charlotte Cracker, whose powers may prove more troublesome than they appear. Meanwhile, Brook and Pedro infiltrate Whole Cake Island and work out a plan to avoid getting caught."),
        [@"Whole Cake Island|9"] = new EpisodeMeta(
            Title: @"The Iron Mask",
            Overview: @"Sanji challenges his entire family, but they have effectively ensured he follows their wedding scheme. The truth of Germa's power and Vinsmoke Judge’s dark history is also revealed. Meanwhile, Nami has recruited the homies and challenges Cracker!"),
        [@"Whole Cake Island|10"] = new EpisodeMeta(
            Title: @"To the East Blue",
            Overview: @"Sanji’s tragic history included a rare moment of compassion that was his only chance at escape, but even then, his father’s cruelty haunted him. In the present, Reiju helps Sanji straighten himself out before he meets with his fiancée."),
        [@"Whole Cake Island|11"] = new EpisodeMeta(
            Title: @"Luffy vs. Sanji",
            Overview: @"Luffy finishes off Cracker and finally catches up with Sanji, but the Straw Hats’ cook seems far from thrilled about the reunion. A heartbreaking duel commences, but a steadfast Luffy makes a solemn vow to his friend and crewmate."),
        [@"Whole Cake Island|12"] = new EpisodeMeta(
            Title: @"Forces of Rage",
            Overview: @"Luffy stands his ground and waits for Sanji to return, but as the vengeful army washes over him, only a true friend can step in to help. At Big Mom’s castle, Sanji and Pudding discuss their marriage and come to a startling conclusion!"),
        [@"Whole Cake Island|13"] = new EpisodeMeta(
            Title: @"Luffy and Big Mom",
            Overview: @"Pedro creates a diversion for Brook to put his soulful plan into action. Meanwhile, the captured Luffy continues to goad Big Mom, and Pudding has the beginnings of rebellion stirring up inside her."),
        [@"Whole Cake Island|14"] = new EpisodeMeta(
            Title: @"A Ray of Light",
            Overview: @"When Pudding arrives to meet the captured Luffy and Nami, their hopefulness suddenly turns to shock! To make matters worse, Brook comes face to face with Big Mom herself! At the risk of his own well-being, Luffy desperately tries to free himself."),
        [@"Whole Cake Island|15"] = new EpisodeMeta(
            Title: @"Germa's Failure",
            Overview: @"Things are looking grim for Luffy and Nami until an unexpected ally appears. Elsewhere, Sanji confronts his sister about what Pudding plans to do and learns the powerful secret of their mother's undying love."),
        [@"Whole Cake Island|16"] = new EpisodeMeta(
            Title: @"Not Here",
            Overview: @"Luffy fights through more obstacles in search of Sanji, and Brook hears Big Mom's plan firsthand as she shares her intentions with Pudding. While Big Mom's agents believe most of the Straw Hats to be under their control, Mont d'Or has his doubts."),
        [@"Whole Cake Island|17"] = new EpisodeMeta(
            Title: @"Liar",
            Overview: @"Nami and co. finally locate Brook using the Mirro-world, but he is in the most inopportune of places! Meanwhile, Luffy is waylaid on his way back to the rendezvous, and Jinbe shares the awful truth about the wedding with the other Straw Hat pirates."),
        [@"Whole Cake Island|18"] = new EpisodeMeta(
            Title: @"Rook",
            Overview: @"Jinbe tells the Straw Hats about Capone “Gang” Bege and proposes a shocking plan to take down Big Mom! But before they are granted an audience with Bege, they must make themselves presentable."),
        [@"Whole Cake Island|19"] = new EpisodeMeta(
            Title: @"Emperor Assassination Plan",
            Overview: @"The plan for Big Mom’s assassination is all set. Sanji heads back to his room to avoid suspicion, but Mont d’Or is hot on his trail. The day arrives, and guests from the criminal underground pour in in droves, some with their own agendas to settle."),
        [@"Whole Cake Island|20"] = new EpisodeMeta(
            Title: @"Veteran Actor",
            Overview: @"Final preparations abound, plans come together, and Sanji meets his bride on the altar. As the veil is lifted off Pudding's face, emotions run high, and the chaos begins! As the proverbial icing on the cake, all hell breaks loose as Luffy charges in!"),
        [@"Whole Cake Island|21"] = new EpisodeMeta(
            Title: @"The Honorable",
            Overview: @"The wedding and the precious cake crumble to pieces around Big Mom as a slew of Luffys wreak havoc. The chaos pushes Big Mom past the edge of sanity, so her children make a move against Germa while Pudding takes aim at Sanji."),
        [@"Whole Cake Island|22"] = new EpisodeMeta(
            Title: @"Hey, Mother",
            Overview: @"Luffy dashes toward Big Mom to show her the broken portrait again, and Sanji attempts to free his family. Here, Big Mom’s tragic and sad history is revealed: from the very beginning, Big Mom's voracious hunger has brought her into conflict with others."),
        [@"Whole Cake Island|23"] = new EpisodeMeta(
            Title: @"HAPPY BIRTHDAY",
            Overview: @"A young Linlin managed to enrage the giants of Elbaph, but Mother Carmel begged for clemency on her behalf. After Carmel’s mysterious disappearance, Linlin fell in with a new cohort and found her reason to go on living."),
        [@"Whole Cake Island|24"] = new EpisodeMeta(
            Title: @"Under Siege",
            Overview: @"The Straw Hats and Germa 66 become cornered in Bege's stronghold, and the full might of the Big Mom Pirates is pinning them down! It is only a matter of time before their defenses crack, so they take the only way out and make a break for it."),
        [@"Whole Cake Island|25"] = new EpisodeMeta(
            Title: @"You Can Do It, Caesar!!",
            Overview: @"Caesar flies the entire alliance, still inside Bege, out of the venue! However, the full might of the Big Mom Pirates proves too much. The alliance’s annihilation is imminent, but something shakes the playing field."),
        [@"Whole Cake Island|26"] = new EpisodeMeta(
            Title: @"Become My Servant",
            Overview: @"The Straw Hats continue their mad dash to the Sunny, and Pudding puts her plan to rebuild the cake into action. As Zeus pursues the Straw Hats, Nami keeps him occupied with a shocking surprise that might stop Big Mom in her tracks!"),
        [@"Whole Cake Island|27"] = new EpisodeMeta(
            Title: @"A Woman's Honor",
            Overview: @"Big Mom is relentless in her pursuit of the Straw Hats. Elsewhere, the plan to recreate the wedding cake progresses while Pudding’s unpredictable heart confuses everyone, including herself."),
        [@"Whole Cake Island|28"] = new EpisodeMeta(
            Title: @"Mink Pedro, Captain of the Guardians",
            Overview: @"Sandwiched between Big Mom and her advancing fleet, the only hope left to the Sunny is to blast right through it all. Meanwhile, Pedro comes face-to-face with his past and does what he must to ensure the success of his friends."),
        [@"Whole Cake Island|29"] = new EpisodeMeta(
            Title: @"Zero Escape",
            Overview: @"In the Mirro-world, Luffy confronts the formidable Charlotte Katakuri, Big Mom’s strongest child. Meanwhile, Pudding and Sanji arrive at Cacao Island to remake the cake, but they bicker like a married couple the whole time."),
        [@"Whole Cake Island|30"] = new EpisodeMeta(
            Title: @"Wave Room",
            Overview: @"Nami and Luffy discuss a rendezvous point while the others break the mirrors on the Sunny. Little do they know their plan is overheard, and Luffy’s grueling battle against Katakuri—haki vs. haki, rubber vs. mochi—intensifies."),
        [@"Whole Cake Island|31"] = new EpisodeMeta(
            Title: @"Merienda",
            Overview: @"Katakuri retires to his sanctuary to enjoy a merienda—a sweet chance to replenish his haki! But he is not the only one munching away. A mochi mountain has crushed Luffy, and he has found a delectable way to escape."),
        [@"Whole Cake Island|32"] = new EpisodeMeta(
            Title: @"Way of Life",
            Overview: @"When Chiffon comes under attack, Sanji must choose between defending her or revealing his whereabouts to his enemies. Elsewhere, Luffy uses Charlotte Brûlée as a human shield to avoid the wrath of Big Mom."),
        [@"Whole Cake Island|33"] = new EpisodeMeta(
            Title: @"Lion",
            Overview: @"Sanji and Bege contend with Charlotte Oven, who boils the sea itself! Meanwhile, a vicious pincer attack bears down on the Straw Hats, but Carrot draws on a deep power within and springs to action under the light of the full moon."),
        [@"Whole Cake Island|34"] = new EpisodeMeta(
            Title: @"Unknown Mama",
            Overview: @"Wielding Napoleon and backed by Zeus and Prometheus, Big Mom wreaks havoc on the Sunny. As the Straw Hats try to kick out the Emperor, their ship catches fire! But then, Jinbe steps up to the plate to take a swing."),
        [@"Whole Cake Island|35"] = new EpisodeMeta(
            Title: @"They Believe in Me",
            Overview: @"The cake is finally brought before Big Mom. With the end of her vicious rampage in sight, the Straw Hats may just get their chance to flee! Big Mom's crew is forced to decide who to attack, and Luffy grows ever closer to mastering his haki."),
        [@"Whole Cake Island|36"] = new EpisodeMeta(
            Title: @"Pirate Luffy vs. Commander Katakuri",
            Overview: @"Desiring revenge after complete embarrassment, Big Mom’s children band together to smash the Straw Hats. Meanwhile, Luffy and Katakuri are locked in a duel to end all duels, where each blow could be the last."),
        [@"Whole Cake Island|37"] = new EpisodeMeta(
            Title: @"One Last Thing",
            Overview: @"Luffy's dramatic battle finally draws to a close, and a whole host of the Big Mom Pirates watch the last mirror to see who will come through."),
        [@"Whole Cake Island|38"] = new EpisodeMeta(
            Title: @"BAD END MUSICAL",
            Overview: @"Sanji tries his best to save himself and his captain. Now, the fate of Totto Land rests on the taste of the wedding cake! With the help of Germa and the Sun Pirates, the Straw Hats see their chance to escape!"),
        [@"Whole Cake Island|39"] = new EpisodeMeta(
            Title: @"END ROLL",
            Overview: @"As the Big Mom Pirate fleet approaches, Jinbe makes a crucial decision. At a great cost of energy and life, the Straw Hats make it out of Totto Land. Left behind in their wake are allies, friends, and would-be lovers."),
        [@"Zou|1"] = new EpisodeMeta(
            Title: @"Zou",
            Overview: @"The mysterious island of Zou approaches in the distance, obscured by fog. When the haze clears, what greets the Straw Hats is beyond anyone’s expectations! Luffy and co. find the Sunny nearby, but the rest of the crew has already disembarked."),
        [@"Zou|2"] = new EpisodeMeta(
            Title: @"The Minks",
            Overview: @"The mysterious ""island"" may hold more danger than was bargained for, as Luffy and co. learn they are not alone! Luffy pushes deeper into the mysterious forest, but he is treading territory where he is not welcome."),
        [@"Zou|3"] = new EpisodeMeta(
            Title: @"At Rightflank Fortress",
            Overview: @"Luffy and co. ride out the rain-ruption and learn of its vital role in maintaining life on Zou. As they continue toward the fortress, they learn more about the mysterious minks, and are finally reunited with the others."),
        [@"Zou|4"] = new EpisodeMeta(
            Title: @"Duke Inuarashi and Master Nekomamushi",
            Overview: @"The Straw Hats finally meet the daytime ruler of this strange land. They learn more about the battle that took place here and discover the mysterious system by which the island is ruled."),
        [@"Zou|5"] = new EpisodeMeta(
            Title: @"The Curly Hat Pirates Arrive",
            Overview: @"While they put up a good fight, the minks were not able to subdue Jack. In the aftermath of Jack's deadly attack, Chopper and Sanji rushed in to save the fallen minks and enlisted the help of Caesar to overcome the lingering gas problem."),
        [@"Zou|6"] = new EpisodeMeta(
            Title: @"Tea Party Invitation",
            Overview: @"The mystery of Sanji's disappearance only deepens as Luffy learns that Big Mom’s lackeys caught up with him and offered him an invitation from one of the Four Emperors that simply could not be refused."),
        [@"Zou|7"] = new EpisodeMeta(
            Title: @"Let's Go See Master Nekomamushi",
            Overview: @"Being separated from one of his crew is more than Luffy is willing to tolerate! The pirates make their way toward the nighttime ruler to find out more about their friend's disappearance."),
        [@"Zou|8"] = new EpisodeMeta(
            Title: @"Raizo of the Mist",
            Overview: @"Revelations abound as the true nature of the men from Wano and their relationship with the minks is revealed, and Momonosuke's role is greater than any had imagined. But even more shocking is the visage of a real ninja!"),
        [@"Zou|9"] = new EpisodeMeta(
            Title: @"Momonosuke, Heir of the Kozuki Family",
            Overview: @"More mysteries of the Kozuki Clan are revealed, and its retainers propose an alliance to help topple one of the Four Emperors: Kaido of the Beast Pirates! But first, Luffy has some important Straw Hat business to attend to."),
        [@"Zou|10"] = new EpisodeMeta(
            Title: @"Understood",
            Overview: @"The Straw Hats divide and conquer: one group to go save Sanji, and the other to Wano! But just before their departure, the tremendous elephant quakes as Jack’s fleet launches an aggressive attack on the monstrous Zunesha."),
    };

    public static string Key(string arc, int part) => $"{NormalizeArc(arc)}|{part}";

    public static string NormalizeArc(string arc)
    {
        arc ??= string.Empty;
        arc = arc.Trim();
        arc = arc.Replace("_", " ").Trim();
        if (arc.EndsWith(" Arc", StringComparison.OrdinalIgnoreCase))
            arc = arc[..^4].Trim();
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

public sealed record EpisodeMeta(string Title, string Overview);
public sealed record ArcMeta(string Title, string Overview);
