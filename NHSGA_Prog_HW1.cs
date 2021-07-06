using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHSGA_Prog_HW1
{
    /**
     * Create a weapon class that follows the specifications outlined below
     */
    class Weapon
    {
        // Parameters
        // Your class should track weapon type/name, attack stat, max durability, current durability, and weight.
        // Weight should be floating point, but all others numerical parameters can be ints.
        // Also create a static variable for the number of usable weapons in circulation

        /* TODO: Replace this comment with code */


        // Constructors
        // When creating a new weapon, you always need to specify the type, atack, max durability, and weight. Update the static variable as needed.
        // However, you should provide an alternate constructor that allows you to also provide current durability.

        /* TODO: Replace this comment with code */


        // Methods
        // Create the methods below as specified

        // Method 1: ReduceDurability - By default, takes no parameters and returns nothing.
        // Reduces current durability by 1, with a minimum of 0. At 0, remember to decrement the number of usable weapons.
        // Either by optional parameter or method overload, reduce the durability by a custom amount

        /* TODO: Replace this comment with code */


        // Method 2: Strike - By default, takes in a parameter for user strength and returns damage dealt (floating point).
        // Damage dealt is the sum of user strength & attack stat.
        // If current durability > 50%, return full damage. If durability > 25%, deal 70% Damage.
        // If durability > 0%, deal 40% damage. If durability is 0, deal no Damage.
        // Use ReduceDurability to reduce the durability by the default amount after attacking.

        /* TODO: Replace this comment with code */


        // Method 3: Last Resort - Attacks until the weapon reaches 0 durability. Takes in a parameter for user strength and returns damage dealt (floating point).
        // Base damage is weapon atk + user strength / 3.0
        // Each nth attack deals base damage times an additional n/5 damage, and consumes 2^n durability. (n starts at 0)
        // Ignore the damage modifiers from the previous method
        // The attack still happens if the consumed durability is greater than the remaining durability (as long as remaining durability is greater than 0). 

        /* TODO: Replace this comment with code */

    }

    class NHSGA_Prog_HW1
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Use the below space to write tests for yourself
            /**
            
            // User stats
            int str = 10;

            // Initializing sword stats
            int atkSwrd = 15;
            int maxDurabilitySwrd = 32;
            float weightSwrd = 6.3f;

            Console.WriteLine("You found a sword!");
            Weapon sword = new Weapon("Broadsword", atkSwrd, maxDurabilitySwrd, weightSwrd);
            Console.WriteLine("You have (x) weapons!");
            
            float dmgdealt = sword.Strike(str);
            Console.WriteLine("Sword did {dmgdealt} damage!");


            // Initializing spear stats
            int atkSpr = 10;
            int maxDurabilitySpr = 20;
            int curDurabilitySpr = 6;
            float weightSpr = 5f;
            Console.WriteLine("You found a spear!");
            Weapon spear = new Weapon("Iron Spear", atkSpr, maxDurabilitySpr, curDurabilitySpr, weightSpr);
            Console.WriteLine("You have (x) weapons!");

            dmgdealt = spear.Strike(str);
            Console.WriteLine("Spear did {dmgdealt} damage!");

            dmgdealt = spear.Strike(str);
            Console.WriteLine("Spear did {dmgdealt} damage!");

            dmgdealt = spear.LastResort(str);
            Console.WriteLine("Spear did {dmgdealt} damage!");
            Console.WriteLine("You have (x) weapons!");

            dmgdealt = sword.LastResort(str);
            Console.WriteLine("Sword did {dmgdealt} damage!");
            Console.WriteLine("You have (x) weapons!");
            */



            Console.WriteLine("Press any key to finish...");
            Console.ReadKey();
        }




    }
}
