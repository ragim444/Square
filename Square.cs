using System;

namespace SquareApp
{
    public class Square
    {
        public int Radius { get; set; }

        public double GetSquareCircle(double radius)
        {
            double square;
            square = (Math.PI * (radius * 2));
            return square;
        }

        public double GetSquareTriangle(double a, double b, double c)
        {
            double square;
            double p = ((a + b + c) / 2);
            square = Math.Sqrt(p * ((p - a) * (p - b) * (p - c)));
            return square;
        }

        public bool IsTriangleRectangular(double a, double b, double c)
        {

            if (a >= b && a >= c)
            {
                if (Math.Sqrt(a) == Math.Sqrt(b) + Math.Sqrt(c)) return (true);
                else return (false);
            }
            else
            {
                if (b >= a && b >= c)
                {
                    if (Math.Sqrt(b) == Math.Sqrt(a) + Math.Sqrt(c)) return (true);
                    else return (false);
                }
                else
                {
                    if (c >= b && c >= a)
                    {
                        if (Math.Sqrt(c) == Math.Sqrt(b) + Math.Sqrt(a)) return (true);
                        else return (false);
                    }
                }
            }
            return (false);
        }
    }
}
