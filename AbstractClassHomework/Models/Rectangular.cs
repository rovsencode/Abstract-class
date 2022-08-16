using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassHomework.Models
{
    class Rectangular:Figure
    {
        private float _length;
        private float _width;
        public float Length
        {
            get
            {
                return _length;
            }

            set
            {
                if (value > 0)
                {
                    _length = value;
                }
            }
        }
        public float Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value>0)
                {
                    _width = value;
                }
            }

        }
        public Rectangular(float length,float width)
        {
             Length=length;
             Width=width;
        }

        public override float CalcArea()
        {
            return Width * Length;
        }
    }
}
