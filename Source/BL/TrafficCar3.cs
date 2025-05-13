using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Racing_Game.BL
{
    internal class TrafficCar3 : Traffic
    {
        public override void MoveTrafficCar(PictureBox car, int speed)
        {
            car.Top += speed;
        }
        public override void MoveCarToTop(PictureBox car)
        {
            car.Top = -30;
            Random random = new Random();
            int randomX = random.Next(0, 4);
            if (randomX == 0)
            {
                car.Left = 245;
            }
            else if (randomX == 1)
            {
                car.Left = 267;
            }
            else if (randomX == 2)
            {
                car.Left = 290;
            }
            else
            {
                car.Left = 320;
            }
        }
        public override void ChangeCarImage(PictureBox car)
        {
            int random = new Random().Next(1, 4);

            if (random == 1)
            {
                car.Image = Properties.Resources.ambulance;
            }
            else if (random == 2)
            {
                car.Image = Properties.Resources.TruckBlue;
            }
            else
            {
                car.Image = Properties.Resources.carPink;
            }
        }
    }
}
