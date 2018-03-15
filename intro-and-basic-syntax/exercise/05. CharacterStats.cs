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
            //receve name of character
            string charName = Console.ReadLine();
            // on next 4 lines we recieve health information about character
            int currentHealth = int.Parse(Console.ReadLine());
            double maxHealth = double.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());
                
            Console.WriteLine("Name: {0}", charName); //print the name of character
            
            if (currentHealth == maxHealth) //we check that the current health is equal to the maximum
            {
                Console.Write("Health: {0}\n", new string('|', maxHealth + 2)); //print the result
            }
            else if (currentHealth < maxHealth)  // we check that current health is less than the maximum
            {
                // print the result
                Console.Write("Health: {0}{1}{2}{3}\n", new string('|', 1), new string('|', currentHealth), new string('.', (maxHealth - currentHealth)), new string('|', 1));
            }
            if (currentEnergy == maxEnergy). // we check that current health is equal with maximum
            {
                Console.Write("Energy: {0}\n", new string('|', maxEnergy + 2));  //print the result
            }
            else if (currentEnergy < maxEnergy) // we check that current energy is less than maximum energy
            {
                // print the result
                Console.Write("Energy: {0}{1}{2}{3}\n", new string('|', 1), new string('|', currentEnergy), new string('.', (maxEnergy - currentEnergy)), new string('|', 1));
            }

        }
    }
}
