using System;

namespace LineComparisonProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Line Comparison Computation Program on Master branch");
            double x1_cordinate, x2_cordinate, y1_cordinate, y2_cordinate;
            Console.WriteLine("Enter the co-ordinates of the end points of the line:");
            Console.WriteLine("X1:");
            x1_cordinate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("X2");
            x2_cordinate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y1");
            y1_cordinate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y2");
            y2_cordinate = Convert.ToDouble(Console.ReadLine());
            double lengthOfLine = Math.Sqrt(((x2_cordinate - x1_cordinate) * (x2_cordinate - x1_cordinate)) + ((y1_cordinate - y2_cordinate) * (y1_cordinate - y2_cordinate)));
            Console.WriteLine(lengthOfLine.ToString("N3"));
        }
    }
}
