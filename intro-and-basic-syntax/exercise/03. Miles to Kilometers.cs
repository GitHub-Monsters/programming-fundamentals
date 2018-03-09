using System;

namespace P03_Miles_To_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            const double mile= 1.60934;

            var kilometers = double.Parse(Console.ReadLine());

            var miles = kilometers * mile;

            Console.WriteLine($"{miles:F2}");
        }
    }
}