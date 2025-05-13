using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Racing_Game.BL
{
    internal class Player
    {
        private int _speed;
        private bool _goLeft;
        private bool _goRight;

        public Player() { }
        public void SetSpeed(int speed)
        {
            this._speed = speed;
        }
        public int GetSpeed()
        {
            return this._speed;
        }

        public void SetGoLeft(bool goLeft)
        {
            this._goLeft = goLeft;
        }
        public void SetGoRight(bool goRight)
        {
            this._goRight = goRight;
        }

        public bool GetGoLeft()
        {
            return this._goLeft;
        }
        public bool GetGoRight()
        {
            return this._goRight;
        }

        public void MovePlayer(PictureBox car, int speed)
        {
            if (car.Left > 125 && _goLeft)
            {
                car.Left -= speed;
            }
            if (car.Left < 445 && _goRight)
            {
                car.Left += speed;
            }
        }
    }
}
