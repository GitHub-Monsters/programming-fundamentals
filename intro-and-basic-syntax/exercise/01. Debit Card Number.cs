using System;

namespace Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
	    // Since the task is to collect four numbers from the Console and print them 
	       in the format of a Credit Card Number
            var digit1 = int.Parse(Console.ReadLine());
            var digit2 = int.Parse(Console.ReadLine());
            var digit3 = int.Parse(Console.ReadLine());
            var digit4 = int.Parse(Console.ReadLine()); // We collect and parse the four numbers as integers, although strings would work just as fine

            Console.WriteLine($"{digit1:D4} {digit2:D4} {digit3:D4} {digit4:D4}"); // Then we print them in the desired format with as many leading zeros as necessary to complete each 											to a four-digit number
	    			
=======
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var num3 = int.Parse(Console.ReadLine());
            var num4 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{num1:D4} {num2:D4} {num3:D4} {num4:D4}");
>>>>>>> e614043b806c26de3ab26c07e02fb26543776292
        }
    }
}
