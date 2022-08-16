using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassHomework.Models
{
    class Square:Figure
    {
        private float _side;
        public float Side {
            get {
                return _side;
            }
            set
            {
                if (value > 0)
                {

                    _side = value;
                }
            }
        }
        public Square(float side)
        {
            Side = side;
        }

        public override float CalcArea()
        {
            return Side * Side;
        }
    }
}
