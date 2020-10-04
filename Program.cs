using System;

namespace LineComparisonProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program" + "\n");
            Console.WriteLine("Enter the X and Y coordinates of end points of the first line");
            double pointX1 = Convert.ToDouble(Console.ReadLine());
            double pointY1 = Convert.ToDouble(Console.ReadLine());
            double pointX2 = Convert.ToDouble(Console.ReadLine());
            double pointY2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the X and Y coordinates of end points of the second line");
            double pointA1 = Convert.ToDouble(Console.ReadLine());
            double pointB1 = Convert.ToDouble(Console.ReadLine());
            double pointA2 = Convert.ToDouble(Console.ReadLine());
            double pointB2 = Convert.ToDouble(Console.ReadLine());
            double power1 = Math.Pow(pointX2 - pointX1, 2) + Math.Pow(pointY2 - pointY1, 2);
            double power2 = Math.Pow(pointA2 - pointA1, 2) + Math.Pow(pointB2 - pointB1, 2);

            double line1 = Math.Sqrt(power1);
            double line2 = Math.Sqrt(power2);
            Console.WriteLine("Length of line 1= " + line1);
            Console.WriteLine("Length of line 2= " + line2);

            String firstLine = Convert.ToString(line1);
            String secondLine = Convert.ToString(line2);

            //Check whether lines are equal:

            Console.WriteLine("Both lines are equal: " + firstLine.Equals(secondLine));
        }
    }
}