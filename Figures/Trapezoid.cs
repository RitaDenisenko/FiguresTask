using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Trapezoid: Figure
    {
        // основания и высота
        private double a;
        private double b;
        private double h;

        public Trapezoid()
        {
            a = 3;
            b = 4;
            h = 5;
        }

        public Trapezoid(double newA, double newB, double newH)
        { 
            a = newA;
            b = newB;
            h = newH;

        }

        public double GetA() { return a; }

        public void SetA(double newA)
        {
            a = newA;

        }

        public double GetB() { return b; }

        public void SetB(double newB)
        {
            b = newB;
        }

        public double GetH() { return h; }

        public void SetH(double newH)
        {
            h = newH;
        }


        public override double CountPerimeter()
        {
            return a + b + 2 * Math.Sqrt(h * h + (a - b) * (a - b) / 4);
        }

        public override double CountSquare()
        {
            return (a + b) * h / 2;
        }
    }
}
