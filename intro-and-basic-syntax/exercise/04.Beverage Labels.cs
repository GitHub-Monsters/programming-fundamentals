using System;

namespace Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
			// Read from console name of product
            string name = Console.ReadLine();
			
			// Read from console volume of product
            int volume = int.Parse(Console.ReadLine());
			
			// Read from console energy of product
            int energy = int.Parse(Console.ReadLine());
			
			// Read from console sugar of product
            int sugar = int.Parse(Console.ReadLine());

			// Calculate energy
            double energyResult= (volume * energy) / 100.00;
			
			// Calculate sugar
            double sugarResult = (sugar * volume) / 100.00;
		
			// Print volume and name of product
            Console.WriteLine($"{volume}ml {name}:");
			
			// Print energy in kcal and sugar in g of product
            Console.WriteLine($"{energyResult}kcal, {sugarResult}g sugars");
        }
    }
}
