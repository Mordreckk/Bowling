using Bowling.Classes;
using System.Windows;
using System.Windows.Controls;

namespace Bowling
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        int nBPlayer = 0;

        private void PlayerAdd(object sender, RoutedEventArgs e)
        {
            if (nBPlayer < 5)
            {
                Game.Players.Add(new Players(AddName.Text));
                AddName.Text = "Name : ";
                switch (nBPlayer)
                {
                    case 0:
                        player1Tb.Text = Game.Players[nBPlayer].NickName.ToString();
                        MessageBox.Show("Player 1 :" + Game.Players[0].NickName.ToString());
                        break;
                    case 1:
                        playertwoTb.Text = Game.Players[nBPlayer].NickName.ToString();
                        MessageBox.Show("Player 2 :" + Game.Players[1].NickName.ToString());
                        break;
                    case 2:
                        playerthreeTb.Text = Game.Players[nBPlayer].NickName.ToString();
                        MessageBox.Show("Player 3 :" + Game.Players[2].NickName.ToString());
                        break;
                    case 3:
                        playerfourTb.Text = Game.Players[nBPlayer].NickName.ToString();
                        MessageBox.Show("Player 4 :" + Game.Players[3].NickName.ToString());
                        break;
                    default:
                        MessageBox.Show("Too much player!");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Sorry! 4 players maximum");
            }
            nBPlayer++;
        }
        ///Fonction pour lancer une boule par joueurs///
        private void ButtonPlayerOne(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Game.Players[0].ScoreF.ToString()+" Round :"+ Game.Players[0].Round.ToString());
            Game.Players[0].RoundPlayer();
            if (Game.Players[0].Balls == 0)
            {
                if (Game.Players[0].StrikeP==true)
                {
                    Game.Players[0].StrikeP = false;
                    Game.Players[0].Status++;
                }
                ScoreT1p1.Text = Game.Players[0].ScoreList[Game.Players[0].Round, Game.Players[0].Balls].ToString();
                MessageBox.Show("Score Ball 1 :" + Game.Players[0].ScoreList[Game.Players[0].Round, Game.Players[0].Balls].ToString());
                StrikeManager.StrikeSpare(Game.Players[0]);
                if (Game.Players[0].StrikeP == true)
                {
                    MessageBox.Show("GG!!!! Strike!!!!");
                }
            }
            else
            {
                MessageBox.Show(Game.Players[0].Status.ToString());
                if (Game.Players[0].StrikeP == true)
                {
                    ScoreT2p1.Text = Game.Players[0].ScoreList[Game.Players[0].Round, Game.Players[0].Balls].ToString();
                }
                ScoreT2p1.Text = Game.Players[0].ScoreList[Game.Players[0].Round, Game.Players[0].Balls].ToString();
                MessageBox.Show("Score Ball 2 :" + Game.Players[0].ScoreList[Game.Players[0].Round, Game.Players[0].Balls].ToString());
                StrikeManager.SpareSPare(Game.Players[0]);
                if (Game.Players[0].SpareP == true)
                {
                    MessageBox.Show("Gg Spare!");
                }
            }
            Game.Players[0].Balls++;
            
            if (Game.Players[0].Balls >= 2)
            {
                
                EndTurn(0, 4);
                
            }
                
        }
        ///bouton p2///
        private void ButtonPlayerTwo(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Game.Players[1].ScoreF.ToString() + " Round :" + Game.Players[1].Round.ToString());
            Game.Players[1].RoundPlayer();
            if (Game.Players[1].Balls == 0)
            {
                if (Game.Players[1].StrikeP == true)
                {
                    Game.Players[1].StrikeP = false;
                    Game.Players[1].Status++;
                }
                ScoreT1p2.Text = Game.Players[1].ScoreList[Game.Players[1].Round, Game.Players[1].Balls].ToString();
                MessageBox.Show("Score Ball 1 :" + Game.Players[1].ScoreList[Game.Players[1].Round, Game.Players[1].Balls].ToString());
                StrikeManager.StrikeSpare(Game.Players[1]);
                if (Game.Players[1].StrikeP == true)
                {
                    MessageBox.Show("GG!!!! Strike!!!!");
                }
            }
            else
            {
                MessageBox.Show(Game.Players[1].Status.ToString());
                if (Game.Players[1].StrikeP == true)
                {
                    ScoreT2p2.Text = Game.Players[1].ScoreList[Game.Players[1].Round, Game.Players[1].Balls].ToString();
                }
                ScoreT2p2.Text = Game.Players[1].ScoreList[Game.Players[1].Round, Game.Players[1].Balls].ToString();
                MessageBox.Show("Score Ball 2 :" + Game.Players[1].ScoreList[Game.Players[1].Round, Game.Players[1].Balls].ToString());
                StrikeManager.SpareSPare(Game.Players[1]);
                if (Game.Players[1].SpareP == true)
                {
                    MessageBox.Show("Gg Spare!");
                }
            }
            Game.Players[1].Balls++;
            if (Game.Players[1].Balls >= 2)
            {
                EndTurn(1, 5);
            }
        }
        private void ButtonPlayerThree(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Game.Players[2].ScoreF.ToString() + " Round :" + Game.Players[2].Round.ToString());
            Game.Players[2].RoundPlayer();
            if (Game.Players[2].Balls == 0)
            {
                if (Game.Players[2].StrikeP == true)
                {
                    Game.Players[2].StrikeP = false;
                    Game.Players[2].Status++;
                }
                ScoreT1p3.Text = Game.Players[2].ScoreList[Game.Players[2].Round, Game.Players[2].Balls].ToString();
                MessageBox.Show("Score Ball 1 :" + Game.Players[2].ScoreList[Game.Players[2].Round, Game.Players[2].Balls].ToString());
                StrikeManager.StrikeSpare(Game.Players[2]);
                if (Game.Players[2].StrikeP == true)
                {
                    MessageBox.Show("GG!!!! Strike!!!!");
                }
            }
            else
            {
                MessageBox.Show(Game.Players[2].Status.ToString());
                if (Game.Players[2].StrikeP == true)
                {
                    ScoreT2p3.Text = Game.Players[2].ScoreList[Game.Players[2].Round, Game.Players[2].Balls].ToString();
                }
                ScoreT2p3.Text = Game.Players[2].ScoreList[Game.Players[2].Round, Game.Players[2].Balls].ToString();
                MessageBox.Show("Score Ball 2 :" + Game.Players[2].ScoreList[Game.Players[2].Round, Game.Players[2].Balls].ToString());
                StrikeManager.SpareSPare(Game.Players[2]);
                if (Game.Players[2].SpareP == true)
                {
                    MessageBox.Show("Gg Spare!");
                }
            }
            Game.Players[2].Balls++;
            if (Game.Players[2].Balls >= 2)
            {
                EndTurn(2, 6);
            }
        }
        private void ButtonPlayerFour(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Game.Players[3].ScoreF.ToString() + " Round :" + Game.Players[3].Round.ToString());
            Game.Players[3].RoundPlayer();
            if (Game.Players[3].Balls == 0)
            {
                if (Game.Players[3].StrikeP == true)
                {
                    Game.Players[3].StrikeP = false;
                    Game.Players[3].Status++;
                }
                ScoreT1p4.Text = Game.Players[3].ScoreList[Game.Players[3].Round, Game.Players[3].Balls].ToString();
                MessageBox.Show("Score Ball 1 :" + Game.Players[3].ScoreList[Game.Players[3].Round, Game.Players[3].Balls].ToString());
                StrikeManager.StrikeSpare(Game.Players[3]);
                if (Game.Players[3].StrikeP == true)
                {
                    MessageBox.Show("GG!!!! Strike!!!!");
                }
            }
            else
            {
                MessageBox.Show(Game.Players[3].Status.ToString());
                if (Game.Players[3].StrikeP == true)
                {
                    ScoreT2p4.Text = Game.Players[3].ScoreList[Game.Players[3].Round, Game.Players[3].Balls].ToString();
                }
                ScoreT2p4.Text = Game.Players[3].ScoreList[Game.Players[3].Round, Game.Players[3].Balls].ToString();
                MessageBox.Show("Score Ball 2 :" + Game.Players[3].ScoreList[Game.Players[3].Round, Game.Players[3].Balls].ToString());
                StrikeManager.SpareSPare(Game.Players[3]);
                if (Game.Players[3].SpareP == true)
                {
                    MessageBox.Show("Gg Spare!");
                }
            }
            Game.Players[3].Balls++;
            if (Game.Players[3].Balls >= 2)
            {
                EndTurn(3, 7);
            }
        }
        private void End_Turn(object sender, RoutedEventArgs e)
        {
            //fonction pour finir le tour de jeux et re initialisé les differente var.
            if (Game.EndTurn == Game.Players.Count)
            {
                ScoreT1p1.Text = "0";
                ScoreT1p2.Text = "0";
                ScoreT1p3.Text = "0";
                ScoreT1p4.Text = "0";
                ScoreT2p1.Text = "0";
                ScoreT2p2.Text = "0";
                ScoreT2p3.Text = "0";
                ScoreT2p4.Text = "0";
                Game.EndTurn = 0;
                for (int i = 0; i < Game.Players.Count; i++)
                {
                    Game.Players[i].Round++;
                    Game.Players[i].Balls = 0;
                    Game.Players[i].score[0] = 0;
                    Game.Players[i].score[1] = 0;
                    if (Game.Players[i].StrikeP == true ^ Game.Players[i].SpareP == true)
                    {
                        Game.Players[i].ScoreList[Game.Players[i].Round, 1] += Game.Players[i].ScoreF;
                        Game.Players[i].SpareP = false;
                    }
                    if (Game.Players[i].Status==Status.TStrike)
                    {
                        Game.Players[i].ScoreF = 0;
                        Game.Players[i].Status = Status.Neutre;
                    }
                    Button buttonPlayer = (Button)wpBouton.Children[i];
                    buttonPlayer.IsEnabled = true;
                }
            }
        }
        private void EndTurn(int player, int intChildren)
        {
            //fonction qui permet de finir et de validé le tour du joueur
            int toto;
            TextBlock tb = (TextBlock)wpBouton.Children[intChildren];
            int result = Game.Players[player].ScoreList[Game.Players[player].Round, 0] + Game.Players[player].ScoreList[Game.Players[player].Round, 1];
            int.TryParse(tb.Text, out toto);
            result += toto+Game.Players[player].ScoreF;
            tb.Text = result.ToString();
            MessageBox.Show("Score Final:" + result.ToString());
            Button buttonPlayer = (Button)wpBouton.Children[player];
            buttonPlayer.IsEnabled = false;
            Game.EndTurn++;
            Turn10(player);
        }
        private void Turn10(int player)
        {
            //fonction qui permet de check si turn 10 & appliqué la regle de jeux turn 10.
            if (Game.Players[player].Round == 10 && (Game.Players[player].StrikeP == true || Game.Players[player].SpareP == true))
            {
                Button buttonPlayer = (Button)wpBouton.Children[player];
                buttonPlayer.IsEnabled = true;
                Game.Players[player].RoundPlayer();
                buttonPlayer.IsEnabled = false;
            }
        }
    }
}


