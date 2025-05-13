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

namespace Car_Racing_Game.UI
{
    public partial class Level1 : Form
    {
        Player player;
        Traffic traffic;
        public Level1()
        {
            InitializeComponent();
            player = new Player();
            traffic = new Traffic();
            player.SetSpeed(10);
            traffic.SetTrafficSpeed(10);
        }


        // timer function
        private void timer1_Tick(object sender, EventArgs e)
        {
            track1.Top += traffic.GetTrafficSpeed();
            track2.Top += traffic.GetTrafficSpeed();
            track3.Top += traffic.GetTrafficSpeed();


            if (track1.Top > 743)
            {
                track1.Top = -600;
            }
            if (track2.Top > 743)
            {
                track2.Top = -600;
            }
            if (track3.Top > 743)
            {
                track3.Top = -600;
            }

        }

        private void Level1_KeyDown(object sender, KeyEventArgs e)
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

        private void Level1_KeyUp(object sender, KeyEventArgs e)
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
