using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Rectangle : Figure
    {
        protected double a;
        private double b;

        public Rectangle()
        {
            a = 1;
            b = 1;
        }

        public Rectangle(double newA, double newB)
        {
            a = newA;
            b = newB;
        }

        public virtual double GetA() { return a; }

        public virtual void SetA(double newA) { a = newA; }

        public virtual double GetB() { return b; }

        public virtual void SetB(double newB) { b = newB; }


        public override double CountPerimeter()
        {
            return 2 * (a + b); 
        }

        public override double CountSquare()
        {
            return a * b;
        }
    }
}
