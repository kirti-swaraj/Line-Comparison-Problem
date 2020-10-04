using System;

namespace LineComparisonProblem
{
    class Program
    {
        static void Main(string[] args)
        { 
         Console.WriteLine("Welcome to Line Comparison Computation Program"+"\n");
         LineComparison line1 = new LineComparison();
         LineComparison line2 = new LineComparison();
            line1.getCoordinates();
            line2.getCoordinates();
            line1.calculateLength();
            line2.calculateLength();
            line1.checkEquality(line1, line2);
           line1.compareLines(line1, line2);
           
        }
    }
}












