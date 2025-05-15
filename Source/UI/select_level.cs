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
using Car_Racing_Game.BL;

namespace Car_Racing_Game.UI
{
    public partial class select_level : Form
    {
        public static PictureBox selected_level;
        public select_level()
        {
            InitializeComponent();
        }


        // Zoombiie theme 
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Level._level = 6;
            Level.PictureBox = pictureBox1;
            selected_level = pictureBox1;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }


        // day light wala level
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Level._level = 2;
            Level.PictureBox = pictureBox6;
            selected_level = pictureBox6;
        }

        // dull light wala level
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Level._level = 1;
            Level.PictureBox = pictureBox2;
            selected_level = pictureBox2;
        }

        //slight dull light wala level
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Level._level = 3;
            Level.PictureBox = pictureBox4;
            selected_level = pictureBox4;
        }


        // night wala level
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Level._level = 4;
            Level.PictureBox = pictureBox5;
            selected_level = pictureBox5;
        }

        
        private void select_level_Click(object sender, EventArgs e)
        {
            
        }
        // desert theme
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Level._level = 5;
            Level.PictureBox = pictureBox3;
            selected_level = pictureBox3;
        }
    }
}
