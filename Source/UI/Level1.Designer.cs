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
            this.panel1 = new System.Windows.Forms.Panel();
            this.track1 = new System.Windows.Forms.PictureBox();
            this.track2 = new System.Windows.Forms.PictureBox();
            this.track3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.track1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.track3);
            this.panel1.Controls.Add(this.track2);
            this.panel1.Controls.Add(this.track1);
            this.panel1.Location = new System.Drawing.Point(412, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 743);
            this.panel1.TabIndex = 0;
            // 
            // track1
            // 
            this.track1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("track1.BackgroundImage")));
            this.track1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.track1.Location = new System.Drawing.Point(0, 0);
            this.track1.Name = "track1";
            this.track1.Size = new System.Drawing.Size(569, 743);
            this.track1.TabIndex = 0;
            this.track1.TabStop = false;
            // 
            // track2
            // 
            this.track2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("track2.BackgroundImage")));
            this.track2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.track2.Location = new System.Drawing.Point(0, -743);
            this.track2.Name = "track2";
            this.track2.Size = new System.Drawing.Size(569, 743);
            this.track2.TabIndex = 1;
            this.track2.TabStop = false;
            // 
            // track3
            // 
            this.track3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("track3.BackgroundImage")));
            this.track3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.track3.Location = new System.Drawing.Point(0, 743);
            this.track3.Name = "track3";
            this.track3.Size = new System.Drawing.Size(569, 743);
            this.track3.TabIndex = 2;
            this.track3.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(993, 758);
            this.Controls.Add(this.panel1);
            this.Name = "Level1";
            this.Text = "Level1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Level1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Level1_KeyUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.track1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox track2;
        private System.Windows.Forms.PictureBox track1;
        private System.Windows.Forms.PictureBox track3;
        private System.Windows.Forms.Timer timer1;
    }
}