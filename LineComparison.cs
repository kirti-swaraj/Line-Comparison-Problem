using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisonProblem
    {
        class LineComparison
        {
            double pointX1;
            double pointY1;
            double pointX2;
            double pointY2;
            public void getCoordinates()
            {
                Console.WriteLine("\nEnter Xcoordinate of first point:");
                pointX1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Ycoordinate of first point:");
                pointY1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Xcoordinate of second point:");
                pointX2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Ycoordinate of second point:");
                pointY2 = Convert.ToDouble(Console.ReadLine());
            }
            public double calculateLength()
            {
                
                double power = Math.Pow(pointX2 - pointX1, 2) + Math.Pow(pointY2 - pointY1, 2);
                double length = Math.Sqrt(power);
                Console.WriteLine("Length of the line: " + length);
                return length;
            }
            public void checkEquality(LineComparison line1, LineComparison line2)
            {
                String firstLine = Convert.ToString(line1.calculateLength());
                String secondLine = Convert.ToString(line2.calculateLength());
                Console.WriteLine("Both lines are equal: " + firstLine.Equals(secondLine));
            }
            public void compareLines(LineComparison line1, LineComparison line2)
            {
                double length1 = line1.calculateLength();
                double length2 = line2.calculateLength();
                double compValue = length1.CompareTo(length2);
                if (compValue < 0)
                    Console.WriteLine("First line is shorter than the second");
                else if (compValue == 0)
                    Console.WriteLine("Both lines are equal");
                else if (compValue > 0)
                    Console.WriteLine("First line is longer than the second");
            }
        }
    }
