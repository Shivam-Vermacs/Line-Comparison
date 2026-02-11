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
         
            Line line2 = new Line(0.0, 0.0, 3.0, 4.0);

            
            double length2 = line2.CalculateLength();

            Console.WriteLine("UC1: Calculating Length of Lines");
            Console.WriteLine($"Line 1: Point1({l1.X1}, {l1.Y1}) to Point2({l1.X2}, {l1.Y2})");
            Console.WriteLine($"Length of Line 1: {Length:F2}");

            Console.WriteLine($"\nLine 2: Point1({line2.X1}, {line2.Y1}) to Point2({line2.X2}, {line2.Y2})");
            Console.WriteLine($"Length of Line 2: {length2:F2}");
        }
    }
}
