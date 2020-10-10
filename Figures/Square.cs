using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Square: Rectangle
    {
        public Square()
        {
            a = 1;
        }

        public Square(double newA)
        {
            a = newA;
        }

        public override double CountPerimeter()
        {
            return 4 * a;
        }

        public override double CountSquare()
        {
            return a * a;
        }

    }
}
