using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Racing_Game.BL
{
    internal class Score
    {
        private int score;

        public Score()
        {
            score = 0;
        }

        public void AddScore(int value)
        {
            score += value;
        }

        public int GetScore()
        {
            return score;
        }
        public void ResetScore()
        {
            score = 0;
        }

        public static void GiveAward(PictureBox award,int score)
        {
            if (score < 300)
            {
                award.Image = Properties.Resources.bronze;
            }
            else if (score >= 300 && score < 600)
            {
                award.Image = Properties.Resources.silver;
            }
            else if (score >= 600)
            {
                award.Image = Properties.Resources.gold;
            }
        }
    }
}
