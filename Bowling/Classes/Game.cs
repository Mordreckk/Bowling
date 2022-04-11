using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{//classe qui permet d'initialisé une partie
    internal static class Game
    {
        public static List<int> Scores { get; set; } = new List<int>();
        public static List<Players> Players { get; set; } = new List<Players>();
        public static int EndTurn { get; set; }

    }
}
