using System;

namespace Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var digit1 = int.Parse(Console.ReadLine());
            var digit2 = int.Parse(Console.ReadLine());
            var digit3 = int.Parse(Console.ReadLine());
            var digit4 = int.Parse(Console.ReadLine());

            Console.WriteLine($"{digit1:D4} {digit2:D4} {digit3:D4} {digit4:D4}");
        }
    }
}
