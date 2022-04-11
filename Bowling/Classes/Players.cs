using System;

namespace Bowling
{//classe de joueurs.
    internal class Players
    {
        public string NickName { get; set; }
        public int[,] ScoreList { get; set; }
        public int Round { get; set; }
        public int[] score { get; set; }
        public bool StrikeP { get; set; }
        public bool SpareP { get; set; }
        public int Balls { get; set; }
        public int ScoreF { get; set; }
        public Status Status { get; set; }
        public Players(string nickName)
        {
            NickName = nickName ?? throw new ArgumentNullException(nameof(nickName));
            ScoreList = new int[11, 2];
            Round = 0;
            score = new int[2];
            StrikeP = false;
            SpareP = false;
            Balls = 0;
            ScoreF = 0;
            Status = Status.Neutre;
        }
        public void RoundPlayer()
        {
            //if (Round==11)
            //{
            //    return;
            //}
                if (score[0] == 0 && score[1] == 0)
                {
                    score[0] = new Random().Next(0,11) ;
                    ScoreList[Round, 0] = score[0];
                }
                else
                {
                    score[1] = new Random().Next(0, (11 - score[0]));
                    ScoreList[Round, 1] = score[1];

                }

        }
    }
}
