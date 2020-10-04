using System;
namespace LineComparisonProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program" + "\n");

            // Input for first line
            Console.WriteLine("Enter the X and Y coordinates of end points of the first line");
            double pointX1 = Convert.ToDouble(Console.ReadLine());
            double pointY1 = Convert.ToDouble(Console.ReadLine());
            double pointX2 = Convert.ToDouble(Console.ReadLine());
            double pointY2 = Convert.ToDouble(Console.ReadLine());

            //Input for second line
            Console.WriteLine("Enter the X and Y coordinates of end points of the second line");
            double pointA1 = Convert.ToDouble(Console.ReadLine());
            double pointB1 = Convert.ToDouble(Console.ReadLine());
            double pointA2 = Convert.ToDouble(Console.ReadLine());
            double pointB2 = Convert.ToDouble(Console.ReadLine());


            //Power calculation for length
            double power1 = Math.Pow(pointX2 - pointX1, 2) + Math.Pow(pointY2 - pointY1, 2);
            double power2 = Math.Pow(pointA2 - pointA1, 2) + Math.Pow(pointB2 - pointB1, 2);


            //Length calculation
            double line1 = Math.Sqrt(power1);
            double line2 = Math.Sqrt(power2);


            //Converting double to string to compare
            String firstLine = Convert.ToString(line1);
            String secondLine = Convert.ToString(line2);

            //Printing the length value
            Console.WriteLine("Length of first line: " + line1);
            Console.WriteLine("Length of second line: " + line2);

            //Comparison of both lines:
            double compValue = line1.CompareTo(line2);
            if (compValue < 0)
                Console.WriteLine("First line is shorter than the second");
            else if (compValue == 0)
                Console.WriteLine("Both lines are equal");
            else if (compValue > 0)
                Console.WriteLine("First line is longer than the second");
        }
    }
}
