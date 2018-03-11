using System;

namespace Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
	    // Since the task is to collect four numbers from the Console and print them 
	       in the format of a Credit Card Number
            var digit1 = int.Parse(Console.ReadLine());
            var digit2 = int.Parse(Console.ReadLine());
            var digit3 = int.Parse(Console.ReadLine());
            var digit4 = int.Parse(Console.ReadLine()); // We collect and parse the four numbers as integers, although strings would work just as fine

            Console.WriteLine($"{digit1:D4} {digit2:D4} {digit3:D4} {digit4:D4}"); // Then we print them in the desired format with as many leading zeros as necessary to complete each 											to a four-digit number
	    			
        }
    }
}
