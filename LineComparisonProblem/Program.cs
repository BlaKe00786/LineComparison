using System;

namespace LineComparisonProblem
{
    class Program
    {
        public double x1_cordinate, x2_cordinate, y1_cordinate, y2_cordinate, lengthOfLine;
        public void getCoordinates()
        {
            Console.WriteLine("Enter the co-ordinates of the end points of the line:");
            Console.WriteLine("X1:");
            this.x1_cordinate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("X2");
            this.x2_cordinate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y1");
            this.y1_cordinate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Y2");
            this.y2_cordinate = Convert.ToDouble(Console.ReadLine());
            this.lengthOfLine = Math.Sqrt(((x2_cordinate - x1_cordinate) * (x2_cordinate - x1_cordinate)) + ((y1_cordinate - y2_cordinate) * (y1_cordinate - y2_cordinate)));
        }
        public static void compareLines(Program lineOne, Program lineTwo)
        {
            if ((lineOne.lengthOfLine.CompareTo(lineTwo.lengthOfLine)) == 0)
            {
                Console.WriteLine("Both Lines are equal");
            }
            else if ((lineOne.lengthOfLine.CompareTo(lineTwo.lengthOfLine)) < 0)
            {
                Console.WriteLine("1st Line is smaller than 2nd line");
            }
            else
            {
                Console.WriteLine("1st Line is greater than 2nd line");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Line Comparison Computation Program");
            Program lineOne = new Program();
            Program lineTwo = new Program();
            lineOne.getCoordinates();
            lineTwo.getCoordinates();
            compareLines(lineOne,lineTwo);
        }
    }
}
