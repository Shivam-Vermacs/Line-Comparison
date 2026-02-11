using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class UseCase1
    {
        public class Line
        {
            public double X1 { get; set; }
            public double Y1 { get; set; }
            public double X2 { get; set; }
            public double Y2 { get; set; }

            public Line(double x1, double y1, double x2, double y2)
            {
                this.X1 = x1;
                this.Y1 = y1;
                this.X2 = x2;
                this.Y2 = y2;
            }
            public double CalculateLength()
            {
                double lengthOfLine = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
                return lengthOfLine;
            }
        }
        public static void Main(string[] args)
        {
            Line l1 = new Line(1.0, 4.0, 4.0, 8.0);
            double Length = l1.CalculateLength();
            Console.WriteLine(Length);
        }
    }
}
