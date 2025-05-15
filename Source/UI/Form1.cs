using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Car_Racing_Game.UI;
using Car_Racing_Game.BL;
using Car_Racing_Game.Source.UI;

namespace Car_Racing_Game
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            load_data();
            
        }
        private void load_data()
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 200;
            progressBar1.Value = 0;
            progressBar1.Step = 1;
            progressBar1.Style = ProgressBarStyle.Continuous;
            button1.Enabled = false;
            button2.Enabled = false;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 1;
            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = true;
                timer1.Stop();
                //MessageBox.Show("Game Loaded!");
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            select_level select = new select_level();
            select.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Level._level == 1)
            {
                Level.Form = new Level1();
            }
            else if (Level._level == 2)
            {
                Level.Form = new Level2();
            }
            else if (Level._level == 3)
            {
                Level.Form = new Level3();
            }
            else if (Level._level == 4)
            {
                Level.Form = new newLevel4();
            }
            else if (Level._level == 5)
            {
                Level.Form = new Level5();
            }
            else if (Level._level == 6)
            {
                Level.Form = new Level6();
            }
            else
            {
                MessageBox.Show("Please select a level first.");
                return;
            }

            this.Hide();
            Level.Form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
