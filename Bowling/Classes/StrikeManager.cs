using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling.Classes
{ // classe toolbox qui permet de gerer les strik et les spare
    internal static class StrikeManager
    {
        
        public static void  StrikeSpare( Players initPlayer)
        {
            //fonction qui permet de gerer les strikes
            if (initPlayer.ScoreList[initPlayer.Round, 0] == 10)
            {
                initPlayer.StrikeP = true;
                initPlayer.SpareP = false;
                switch (initPlayer.Status)
                {
                    case Status.Neutre:

                        break;
                    case Status.Strike:
                        initPlayer.ScoreF += 10;
                        initPlayer.ScoreList[initPlayer.Round - 1, 1] += 10;
                        break;
                    case Status.DStrike:
                        initPlayer.ScoreF += 10;
                        initPlayer.ScoreList[initPlayer.Round - 1, 1] += 10;
                        initPlayer.ScoreList[initPlayer.Round - 2, 1] += 10;

                        break;
                    case Status.TStrike:
                        initPlayer.ScoreF += 10;
                        initPlayer.ScoreList[initPlayer.Round - 1, 1] += 10;
                        initPlayer.ScoreList[initPlayer.Round - 2, 1] += 10;
                        break;
                    default:
                       // MessageBox.Show("Erreur Func. StrikeSPare");
                        break;
                }
            }
        }
        public static void SpareSPare(Players initPlayer)
        {
            if (initPlayer.ScoreList[initPlayer.Round, 0] < 10 && (initPlayer.ScoreList[initPlayer.Round, 0] + initPlayer.ScoreList[initPlayer.Round, 1] == 10))
            {
                initPlayer.StrikeP = false;
                initPlayer.SpareP = true;
                initPlayer.ScoreF += initPlayer.ScoreList[initPlayer.Round, 0] + initPlayer.ScoreList[initPlayer.Round, 1];
            }
        }
        
    }
}
