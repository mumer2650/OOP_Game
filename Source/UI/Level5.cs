using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Car_Racing_Game.BL;
using Car_Racing_Game.UI;

namespace Car_Racing_Game.UI
{
    public partial class Level5 : Form
    {
        Player player;
        Traffic traffic;
        TrafficCar1 Car1;
        TrafficCar2 Car2;
        TrafficCar3 Car3;
        Score score;
        int value;
        public Level5()
        {
            InitializeComponent();
            timer1.Stop();

            load_objects();
            player.SetSpeed(10);
            traffic.SetTrafficSpeed(15);
            explotion.Visible = false;
            award.Visible = false;
            RESET.Enabled = false;
            BACK.Enabled = false;
            value = 0;
        }
        private void load_objects()
        {
            player = new Player();
            traffic = new Traffic();
            Car1 = new TrafficCar1();
            Car2 = new TrafficCar2();
            Car3 = new TrafficCar3();
            score = new Score();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            restart_game();
            button1.Enabled = false;
        }

        // restart
        private void RESET_Click(object sender, EventArgs e)
        {
            this.Close();
            new Level5().Show();
        }


        // back
        private void BACK_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form1().Show();
        }

        // timer function
        private void timer1_Tick(object sender, EventArgs e)
        {
            // score display
            scoreLabel.Text = score.GetScore().ToString();

            // movement of player
            player.MovePlayer(CarPlayer, player.GetSpeed());


            // movement of traffic cars 1
            Car1.MoveTrafficCar(TrafficCar1, traffic.GetTrafficSpeed());
            if (TrafficCar1.Top > 750)
            {
                //Car1.ChangeCarImage(TrafficCar1);
                Car1.MoveCarToTop(TrafficCar1);
            }

            // movement of traffic cars 2
            Car2.MoveTrafficCar(TrafficCar2, traffic.GetTrafficSpeed());
            if (TrafficCar2.Top > 750)
            {
                //Car2.ChangeCarImage(TrafficCar2);
                Car2.MoveCarToTop(TrafficCar2);
            }

            // movement of traffic cars 3
            Car3.MoveTrafficCar(TrafficCar3, traffic.GetTrafficSpeed());
            if (TrafficCar3.Top > 750)
            {
                //Car3.ChangeCarImage(TrafficCar3);
                Car3.MoveCarToTop(TrafficCar3);
            }


            // collision detection
            if (CarPlayer.Bounds.IntersectsWith(TrafficCar1.Bounds) || CarPlayer.Bounds.IntersectsWith(TrafficCar2.Bounds) || CarPlayer.Bounds.IntersectsWith(TrafficCar3.Bounds))
            {
                PlaySound();
                game_over();
            }


            // track movement 
            track1.Top += traffic.GetTrafficSpeed();
            track2.Top += traffic.GetTrafficSpeed();
            track3.Top += traffic.GetTrafficSpeed();


            if (track1.Top > 744)
            {
                track1.Top = -720;
            }
            if (track2.Top > 744)
            {
                track2.Top = -720;
            }
            if (track3.Top > 744)
            {
                track3.Top = -720;
            }

            // score addition
            value++;
            if (value % 10 == 0)
            {
                score.AddScore(1);
            }

        }
        private void restart_game()
        {
            timer1.Start();
            explotion.Visible = false;
            award.Visible = false;
            score.ResetScore();
            value = 0;
        }

        private void PlaySound()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "D:\\University\\2nd Semester\\OOP\\OOP Game\\OOP_Game\\Resources\\hit.wav";
            player.Play();
        }

        private void game_over()
        {

            timer1.Stop();
            //button1.Enabled = true;
            // show explosion
            explotion.Visible = true;
            CarPlayer.Controls.Add(explotion);
            explotion.BringToFront();
            explotion.Location = new Point(-8, 5);
            explotion.BackColor = Color.Transparent;

            RESET.Enabled = true;
            BACK.Enabled = true;
            award.Visible = true;
            Score.GiveAward(award, score.GetScore());

            return;
        }

        private void Level5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                player.SetGoLeft(true);
            }
            if (e.KeyCode == Keys.Right)
            {
                player.SetGoRight(true);
            }
        }

        private void Level5_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                player.SetGoLeft(false);
            }
            if (e.KeyCode == Keys.Right)
            {
                player.SetGoRight(false);
            }
        }
    }
}
