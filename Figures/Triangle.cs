using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    public class Triangle : Figure
    {
        private double a;
        private double b;
        private double c;

        public static bool TriangleExists(double newA, double newB, double newC)
        {
            return !((newA + newB) < newC || (newA + newC) < newB || (newB + newC) < newA);
        }

        public Triangle()
        {
            a = 3;
            b = 4;
            c = 5;
        }

        public Triangle(double newA, double newB, double newC)
        {
            if (TriangleExists(newA, newB, newC))
            {
                a = newA;
                b = newB;
                c = newC;
            }
            else
            {
                throw new Exception("Такого треугольника не существует");
            }

        }

        public double GetA() { return a; }

        public void SetA(double newA)
        {
            if (TriangleExists(newA, b, c))
            {
                a = newA;
            }
            else
            {
                throw new Exception("Такого треугольника не существует");
            }
            
        }

        public double GetB() { return b; }

        public void SetB(double newB)
        {
            if (TriangleExists(a, newB, c))
            {
                b = newB;
            }
            else
            {
                throw new Exception("Такого треугольника не существует");
            }
        }

        public double GetС() { return c; }

        public void SetС(double newC)
        {
            if (TriangleExists(a, b, newC))
            {
                c = newC;
            }
            else
            {
                throw new Exception("Такого треугольника не существует");
            }
        }


        public override double CountPerimeter()
        {
            return a + b + c;
        }

        public override double CountSquare()
        {
            double p = this.CountPerimeter();

            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}
