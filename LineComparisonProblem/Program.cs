using System;

namespace LineComparisonProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Line Comparison Computation Program on Master branch");
            double x1_cordinate, x2_cordinate, y1_cordinate, y2_cordinate;
            Console.WriteLine("Enter the co-ordinates of the end points of the first line:");
            Console.WriteLine("X1:");
            x1_cordinate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("X2");
            x2_cordinate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y1");
            y1_cordinate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y2");
            y2_cordinate = Convert.ToDouble(Console.ReadLine());
            double lengthOfLine1 = Math.Sqrt(((x2_cordinate - x1_cordinate) * (x2_cordinate - x1_cordinate)) + ((y1_cordinate - y2_cordinate) * (y1_cordinate - y2_cordinate)));
            double a1_cordinate, a2_cordinate, b1_cordinate, b2_cordinate;
            Console.WriteLine("Enter the co-ordinates of the end points of the second line:");
            Console.WriteLine("A1:");
            a1_cordinate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("A2");
            a2_cordinate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("B1");
            b1_cordinate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("B2");
            b2_cordinate = Convert.ToDouble(Console.ReadLine());
            double lengthOfLine2 = Math.Sqrt(((a2_cordinate - a1_cordinate) * (a2_cordinate - a1_cordinate)) + ((b1_cordinate - b2_cordinate) * (b1_cordinate - b2_cordinate)));
            if (lengthOfLine1 == lengthOfLine2)
            {
                Console.WriteLine("Both Lines are equal");
            }
            else
            {
                Console.WriteLine("Both Lines are not equal");
            }
        }
}
