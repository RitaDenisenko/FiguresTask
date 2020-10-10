using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Circle: Figure
    {
        private const double PI = 3.14;
        private double radius;

        public Circle()
        {
            radius = 1;
        }

        public Circle(double newRadius)
        {
            radius = newRadius;
        }

        public double GetRadius() { return radius; }

        public void SetRadius(double newRadius) { radius = newRadius; }

        public override double CountSquare()
        {
            return radius * radius * PI;
        }

        public override double CountPerimeter()
        {
            return 2 * radius * PI;
        }
    }
}
