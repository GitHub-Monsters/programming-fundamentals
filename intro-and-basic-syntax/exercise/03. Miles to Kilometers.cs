using System;

namespace P03_Miles_To_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            const double mile= 1.60934; // 1 mile = 1.60934 km

            decimal kilometers = decimal.Parse(Console.ReadLine()); // we read the km from the console

            var miles = kilometers * mile; // we turn the km in miles

            Console.WriteLine($"{miles:F2}"); // we get back the km in miles
        } 
    }
}