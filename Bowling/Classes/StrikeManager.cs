using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

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
        public static void EndTurn(Players initPlayer,int player, int intChildren,WrapPanel initWrap)
        {
            //fonction qui permet de finir et de validé le tour du joueur
            int toto;
            TextBlock tb = (TextBlock)initWrap.Children[intChildren];
            int result = initPlayer.ScoreList[initPlayer.Round, 0] + initPlayer.ScoreList[initPlayer.Round, 1];
            int.TryParse(tb.Text, out toto);
            result += toto + initPlayer.ScoreF;
            tb.Text = result.ToString();
            MessageBox.Show("Score Final:" + result.ToString());
            Button buttonPlayer = (Button)initWrap.Children[player];
            buttonPlayer.IsEnabled = false;
            Game.EndTurn++;
            Turn10(player,initWrap,initPlayer);
        }
        public static void Turn10(int player, WrapPanel initWrap, Players initPlayer)
        {
            //fonction qui permet de check si turn 10 & appliqué la regle de jeux turn 10.
            if (initPlayer.Round == 10 && (initPlayer.StrikeP == true || initPlayer.SpareP == true))
            {
                Button buttonPlayer = (Button)initWrap.Children[player];
                buttonPlayer.IsEnabled = true;
                initPlayer.RoundPlayer();
                buttonPlayer.IsEnabled = false;
            }
        }
    }
}
