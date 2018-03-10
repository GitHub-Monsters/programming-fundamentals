// CONFIRMED from HrBozhidarov
using System;

namespace _02._Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
			//declare variables
			//declare the rectangle's width
            double width = double.Parse(Console.ReadLine());
			//declare the rectangle's heigth
            double heigth = double.Parse(Console.ReadLine());
			//multiply the width by the heigth to get the rectangle's area and store in a new variable
            double area = width * heigth;
			//write the rectangle's area on the console with two digits after the decimal sign
            Console.WriteLine($"{area:f2}");
        }
    }
}
