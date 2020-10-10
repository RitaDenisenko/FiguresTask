using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Program
    {
        static Random rand = new Random();

        static double CountSumSquare(Figure[] figures)
        {
            double sumSquare = 0;
            foreach (Figure f in figures)
            {
                sumSquare += f.CountSquare();
            }

            return sumSquare;
        }

        static double CountSumPerimeter(Figure[] figures)
        {
            double sumSquare = 0;
            foreach (Figure f in figures)
            {
                sumSquare += f.CountPerimeter();
            }

            return sumSquare;
        }

        static Figure GenerateFigure()
        {
            int i = rand.Next(1, 1000);

            switch (i % 5)
            {
                case 0:
                    {
                        return new Circle(i * i);
                    }
                case 1:
                    {
                        return new Rectangle(i, i * 2);
                    }
                case 2:
                    {
                        return new Square(i);
                    }
                case 3:
                    {
                        return new Trapezoid(i, i * 2, i + 2);
                    }
                default:
                    {
                        return new Triangle(3 * i, 4 * i, 5 * i);
                    }
            }
        }

        static Figure[] GenerateFigures(int n)
        {
            Figure[] figures = new Figure[n];
            for (int i = 0; i < n; i++)
            {
                figures[i] = GenerateFigure();
            }

            return figures;
        }

        static void Main(string[] args)
        {
            Figure[] figures = GenerateFigures(100);

            System.Console.WriteLine("Суммарная площадь фигур: " + CountSumSquare(figures));
            System.Console.WriteLine("Суммарный периметр фигур: " + CountSumPerimeter(figures));
            System.Console.ReadLine();
        }
    }
}
