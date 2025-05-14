namespace Car_Racing_Game.UI
{
    partial class Level1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BACK = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RESET = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.explotion = new System.Windows.Forms.PictureBox();
            this.award = new System.Windows.Forms.PictureBox();
            this.TrafficCar3 = new System.Windows.Forms.PictureBox();
            this.TrafficCar2 = new System.Windows.Forms.PictureBox();
            this.TrafficCar1 = new System.Windows.Forms.PictureBox();
            this.CarPlayer = new System.Windows.Forms.PictureBox();
            this.track3 = new System.Windows.Forms.PictureBox();
            this.track2 = new System.Windows.Forms.PictureBox();
            this.track1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.explotion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.award)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrafficCar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrafficCar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrafficCar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.scoreLabel);
            this.panel2.Location = new System.Drawing.Point(9, 9);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(352, 774);
            this.panel2.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.BACK);
            this.panel4.Location = new System.Drawing.Point(3, 659);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(159, 100);
            this.panel4.TabIndex = 13;
            // 
            // BACK
            // 
            this.BACK.BackColor = System.Drawing.Color.Transparent;
            this.BACK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BACK.FlatAppearance.BorderSize = 0;
            this.BACK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BACK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.BACK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BACK.Font = new System.Drawing.Font("Algerian", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BACK.ForeColor = System.Drawing.Color.Transparent;
            this.BACK.Location = new System.Drawing.Point(-1, -1);
            this.BACK.Name = "BACK";
            this.BACK.Size = new System.Drawing.Size(159, 96);
            this.BACK.TabIndex = 12;
            this.BACK.Text = "BACK";
            this.BACK.UseVisualStyleBackColor = false;
            this.BACK.Click += new System.EventHandler(this.BACK_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.RESET);
            this.panel3.Location = new System.Drawing.Point(182, 659);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(159, 100);
            this.panel3.TabIndex = 11;
            // 
            // RESET
            // 
            this.RESET.BackColor = System.Drawing.Color.Transparent;
            this.RESET.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RESET.FlatAppearance.BorderSize = 0;
            this.RESET.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RESET.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RESET.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RESET.Font = new System.Drawing.Font("Algerian", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RESET.ForeColor = System.Drawing.Color.Transparent;
            this.RESET.Location = new System.Drawing.Point(-1, -1);
            this.RESET.Name = "RESET";
            this.RESET.Size = new System.Drawing.Size(159, 96);
            this.RESET.TabIndex = 12;
            this.RESET.Text = "RESTART";
            this.RESET.UseVisualStyleBackColor = false;
            this.RESET.Click += new System.EventHandler(this.RESET_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(48, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 84);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.scoreLabel.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(177, 221);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(27, 30);
            this.scoreLabel.TabIndex = 9;
            this.scoreLabel.Text = "0";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.explotion);
            this.panel1.Controls.Add(this.award);
            this.panel1.Controls.Add(this.TrafficCar3);
            this.panel1.Controls.Add(this.TrafficCar2);
            this.panel1.Controls.Add(this.TrafficCar1);
            this.panel1.Controls.Add(this.CarPlayer);
            this.panel1.Controls.Add(this.track3);
            this.panel1.Controls.Add(this.track2);
            this.panel1.Controls.Add(this.track1);
            this.panel1.Location = new System.Drawing.Point(377, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 774);
            this.panel1.TabIndex = 5;
            // 
            // explotion
            // 
            this.explotion.BackColor = System.Drawing.Color.DimGray;
            this.explotion.BackgroundImage = global::Car_Racing_Game.Properties.Resources.explosion;
            this.explotion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.explotion.Image = global::Car_Racing_Game.Properties.Resources.explosion;
            this.explotion.Location = new System.Drawing.Point(239, 498);
            this.explotion.Name = "explotion";
            this.explotion.Size = new System.Drawing.Size(62, 68);
            this.explotion.TabIndex = 8;
            this.explotion.TabStop = false;
            // 
            // award
            // 
            this.award.BackgroundImage = global::Car_Racing_Game.Properties.Resources.silver;
            this.award.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.award.Location = new System.Drawing.Point(248, 248);
            this.award.Name = "award";
            this.award.Size = new System.Drawing.Size(292, 122);
            this.award.TabIndex = 7;
            this.award.TabStop = false;
            // 
            // TrafficCar3
            // 
            this.TrafficCar3.BackColor = System.Drawing.Color.SaddleBrown;
            this.TrafficCar3.BackgroundImage = global::Car_Racing_Game.Properties.Resources.LS20250513182022;
            this.TrafficCar3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TrafficCar3.Location = new System.Drawing.Point(369, 21);
            this.TrafficCar3.Margin = new System.Windows.Forms.Padding(0);
            this.TrafficCar3.Name = "TrafficCar3";
            this.TrafficCar3.Size = new System.Drawing.Size(64, 135);
            this.TrafficCar3.TabIndex = 6;
            this.TrafficCar3.TabStop = false;
            // 
            // TrafficCar2
            // 
            this.TrafficCar2.BackColor = System.Drawing.Color.SaddleBrown;
            this.TrafficCar2.BackgroundImage = global::Car_Racing_Game.Properties.Resources.LS20250513181958;
            this.TrafficCar2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TrafficCar2.Location = new System.Drawing.Point(561, 202);
            this.TrafficCar2.Margin = new System.Windows.Forms.Padding(0);
            this.TrafficCar2.Name = "TrafficCar2";
            this.TrafficCar2.Size = new System.Drawing.Size(56, 126);
            this.TrafficCar2.TabIndex = 5;
            this.TrafficCar2.TabStop = false;
            // 
            // TrafficCar1
            // 
            this.TrafficCar1.BackColor = System.Drawing.Color.Sienna;
            this.TrafficCar1.BackgroundImage = global::Car_Racing_Game.Properties.Resources.LS20250513182001;
            this.TrafficCar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TrafficCar1.Location = new System.Drawing.Point(186, 344);
            this.TrafficCar1.Margin = new System.Windows.Forms.Padding(0);
            this.TrafficCar1.Name = "TrafficCar1";
            this.TrafficCar1.Size = new System.Drawing.Size(56, 123);
            this.TrafficCar1.TabIndex = 4;
            this.TrafficCar1.TabStop = false;
            // 
            // CarPlayer
            // 
            this.CarPlayer.BackColor = System.Drawing.Color.DimGray;
            this.CarPlayer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CarPlayer.BackgroundImage")));
            this.CarPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CarPlayer.Location = new System.Drawing.Point(429, 574);
            this.CarPlayer.Name = "CarPlayer";
            this.CarPlayer.Size = new System.Drawing.Size(59, 124);
            this.CarPlayer.TabIndex = 3;
            this.CarPlayer.TabStop = false;
            // 
            // track3
            // 
            this.track3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("track3.BackgroundImage")));
            this.track3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.track3.Location = new System.Drawing.Point(0, 774);
            this.track3.Margin = new System.Windows.Forms.Padding(0);
            this.track3.Name = "track3";
            this.track3.Size = new System.Drawing.Size(809, 774);
            this.track3.TabIndex = 2;
            this.track3.TabStop = false;
            // 
            // track2
            // 
            this.track2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("track2.BackgroundImage")));
            this.track2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.track2.Location = new System.Drawing.Point(0, 0);
            this.track2.Margin = new System.Windows.Forms.Padding(0);
            this.track2.Name = "track2";
            this.track2.Size = new System.Drawing.Size(809, 774);
            this.track2.TabIndex = 1;
            this.track2.TabStop = false;
            // 
            // track1
            // 
            this.track1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("track1.BackgroundImage")));
            this.track1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.track1.Location = new System.Drawing.Point(0, -774);
            this.track1.Margin = new System.Windows.Forms.Padding(0);
            this.track1.Name = "track1";
            this.track1.Size = new System.Drawing.Size(809, 774);
            this.track1.TabIndex = 0;
            this.track1.TabStop = false;
            // 
            // Level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1205, 807);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Level1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Level1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Level1_KeyUp);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.explotion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.award)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrafficCar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrafficCar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrafficCar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button BACK;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button RESET;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox explotion;
        private System.Windows.Forms.PictureBox award;
        private System.Windows.Forms.PictureBox TrafficCar3;
        private System.Windows.Forms.PictureBox TrafficCar2;
        private System.Windows.Forms.PictureBox TrafficCar1;
        private System.Windows.Forms.PictureBox CarPlayer;
        private System.Windows.Forms.PictureBox track3;
        private System.Windows.Forms.PictureBox track2;
        private System.Windows.Forms.PictureBox track1;
    }
}