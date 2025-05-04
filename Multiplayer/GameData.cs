namespace ExitPath.Server.Multiplayer
{
    public static class GameData
    {
        public static int MatchXP(int rank) => rank switch
        {
            0 => 250,
            1 => 150,
            2 => 100,
            _ => 25,
        };

        public static int MatchKudos(int rank) => rank switch
        {
            0 => 3,
            1 => 2,
            2 => 1,
            _ => 0,
        };

        public const int MaxLevel = 41;

        public static int LevelXP(long level) => level switch
        {
            0 => 0,
            1 => 125,
            2 => 375,
            3 => 750,
            4 => 1250,
            5 => 1875,
            6 => 2625,
            7 => 3500,
            8 => 4500,
            9 => 5625,
            10 => 6875,
            11 => 8250,
            12 => 9750,
            13 => 11375,
            14 => 13125,
            15 => 15000,
            16 => 17000,
            17 => 19125,
            18 => 21375,
            19 => 23750,
            20 => 26250,
            21 => 28875,
            22 => 31625,
            23 => 34500,
            24 => 37500,
            25 => 40625,
            26 => 43875,
            27 => 47250,
            28 => 50750,
            29 => 54375,
            30 => 58125,
            31 => 62000,
            32 => 66000,
            33 => 70125,
            34 => 74375,
            35 => 78750,
            36 => 83250,
            37 => 87875,
            38 => 92625,
            39 => 97500,
            _ => 102500
        };

        public static int XPLevel(long xp)
        {
            int level;
            for (level = 1; level <= MaxLevel; level++)
            {
                if (xp < LevelXP(level))
                {
                    break;
                }
            }
            return level - 1;
        }

        public static string LevelName(int level) => level switch
        {
            0 => "Novice",
            1 => "Walker",
            2 => "Jogger",
            3 => "Runner",
            4 => "Sprinter",
            5 => "Windwalker",
            6 => "Speedrunner",
            7 => "Marathoner",
            8 => "Earthrunner",
            9 => "Pacer",
            10 => "Drifter",
            11 => "Voyager",
            12 => "Nimble",
            13 => "Expeditive",
            14 => "Quick",
            15 => "Outlast",
            16 => "Spring",
            17 => "Survivor",
            18 => "Swift",
            19 => "Trekker",
            20 => "Tour",
            21 => "Grace",
            22 => "Agility",
            23 => "Fast",
            24 => "Zoom",
            25 => "Fervor",
            26 => "Rush",
            27 => "Fly",
            28 => "Momentum",
            29 => "Haste",
            30 => "Fleetness",
            31 => "Forge",
            32 => "Drive",
            33 => "Boost",
            34 => "Velocity",
            35 => "Swiftness",
            36 => "Accelerator",
            37 => "Impel",
            38 => "Breakneck",
            39 => "Run Master",
            _ => "Grandmaster"
        };

        public static string? GameLevelName(int level) => level switch
        {
            0 => "Getting Out 1",
            1 => "Getting Out 2",
            2 => "Getting Out 3",
            3 => "The Stadium 1",
            4 => "The Stadium 2",
            5 => "The Stadium 3",
            6 => "The Stadium 4",
            7 => "The Stadium 5",
            8 => "The Stadium 6",
            9 => "The Stadium 7",
            10 => "The Audit",
            11 => "Lab Testing 1",
            12 => "Lab Testing 2",
            13 => "Lab Testing 3",
            14 => "Lab Testing 4",
            15 => "The Path to Freedom 1",
            16 => "The Path to Freedom 2",
            17 => "Backrooms 1",
            18 => "Backrooms 2",
            19 => "Backrooms 3",
            20 => "Outside 1",
            21 => "Outside 2",
            22 => "Outside 3",
            23 => "Outside 4",
            24 => "Outside 5",
            25 => "Skyline City Limits 1",
            26 => "Skyline City Limits 2",
            27 => "Skyline City Limits 3",
            28 => "Skyline City Limits 4",
            29 => "Skyline City Limits 5",
            30 => "Ending",
            100 => "Marathon",
            101 => "Front Door",
            102 => "Crossroads",
            103 => "Tubes",
            104 => "Death Wall",
            105 => "The Maze",
            106 => "Lunge",
            107 => "Unfriendly Teleporters",
            108 => "Funk",
            109 => "Cubicles",
            110 => "Over and Under",
            111 => "Zipper",
            112 => "Jumper",
            113 => "Slip and Slide",
            114 => "Wombat",
            115 => "Fuzz Balls",
            116 => "Secret Staircase",
            117 => "Cubey",
            118 => "Descending",
            119 => "Treadmillvania",
            120 => "Under and Over",
            121 => "Cubicles?",
            122 => "TPDWUT?",
            123 => "The Shrine",
            124 => "Teletorture++",
            125 => "Treadmillistic",
            126 => "Bounspikser Land",
            127 => "Defamation",
            128 => "-_-||",
            129 => "XP",
            130 => "Bounce Town++",
            131 => "Skywalker",
            _ => null,
        };
    }
}
