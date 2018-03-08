using System;

namespace Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var currentHealth = int.Parse(Console.ReadLine());
            var maxHealth = int.Parse(Console.ReadLine());
            var currentEnergy = int.Parse(Console.ReadLine());
            var maxEnergy = int.Parse(Console.ReadLine());

            var currentHealthString = "";

            for (int i = 0; i < currentHealth; i++)
            {
                currentHealthString += "|";
            }

            var currebtHealthDots = "";

            for (int i = 0; i < maxHealth - currentHealth; i++)
            {
                currebtHealthDots += ".";
            }


            var currentEnergyString = "";

            for (int i = 0; i < currentEnergy; i++)
            {
                currentEnergyString += "|";
            }

            var currebtEnergyDots = "";

            for (int i = 0; i < maxEnergy - currentEnergy; i++)
            {
                currebtEnergyDots += ".";
            }


            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{currentHealthString}{currebtHealthDots}|");
            Console.WriteLine($"Energy: |{currentEnergyString}{currebtEnergyDots}|");


        }
    }
}
