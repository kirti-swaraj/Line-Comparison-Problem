using System;

namespace LineComparisonProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to Line Comparison Computation Program" + "\n");
            Console.WriteLine("Enter the X1 coordinate of end points of the line");
            double pointX1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the X2 coordinate of end points of the line");
            double pointY1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Y1 coordinate of end points of the line");
            double pointX2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Y2 coordinate of end points of the line");
            double pointY2 = Convert.ToDouble(Console.ReadLine());

            double powerX = Math.Pow(pointX2 - pointX1, 2);
            double powerY = Math.Pow(pointY2 - pointY1, 2);
            double lineLength = Math.Sqrt(powerX + powerY);
            Console.WriteLine("Length of line= " + lineLength);
        }
    }
}