using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Racing_Game.BL
{
    internal class Track
    {
        private int track_speed;

        public Track() { }

        public void SetTrackSpeed(int speed)
        {
            this.track_speed = speed;
        }

        public int GetTrackSpeed()
        {
            return this.track_speed;
        }
    }
}
