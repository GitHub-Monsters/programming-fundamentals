using System;
namespace Learning_1
{
    class MainClass
    {
        public static void Main()
        {
            /* Write a program, which displays information about a video game character. 
             * You will receive:
             * their name, 
             * current health, 
             * maximum health, 
             * current energy and 
             * maximum energy on separate lines. 
             * 
             * The current values will always be valid (equal or lower than their respective max values). 
             * Print them in the format as per the examples:
             * Name: ...
             * Health: |||...|
             * Energy: ||||...|
             * where the dots are the missing point up to the max

            */

            string characterName = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());
            Console.WriteLine("Name: {0}", characterName);
            if (currentHealth == maxHealth)
            {
                Console.Write("Health: {0}\n", new string('|', maxHealth + 2));
            }
            else if (currentHealth < maxHealth)
            {
                Console.Write("Health: {0}{1}{2}{3}\n", new string('|', 1), new string('|', currentHealth), new string('.', (maxHealth - currentHealth)), new string('|', 1));
            }
            if (currentEnergy == maxEnergy)
            {
                Console.Write("Energy: {0}\n", new string('|', maxEnergy + 2));
            }
            else if (currentEnergy < maxEnergy)
            {
                Console.Write("Energy: {0}{1}{2}{3}\n", new string('|', 1), new string('|', currentEnergy), new string('.', (maxEnergy - currentEnergy)), new string('|', 1));
            }

        }
    }
}