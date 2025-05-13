using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Racing_Game.BL
{
    internal class Traffic
    {
        private int _trafficSpeed;

        public Traffic() { }

        public void SetTrafficSpeed(int speed)
        {
            this._trafficSpeed = speed;
        }
        public int GetTrafficSpeed()
        {
            return this._trafficSpeed;
        }

        public virtual void MoveTrafficCar(PictureBox pictureBox, int speed) { }

        public virtual void MoveCarToTop(PictureBox car) { }

        public virtual void ChangeCarImage(PictureBox car) { }


    }
}
