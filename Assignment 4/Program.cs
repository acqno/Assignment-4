using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* 
 * Name: Alvin Quijano
 * Date: 07-28-2017
 * Description: This is the Driver class for the Abstract Planet program
 * Version: 0.2 - Refactored driver class
 */

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // GIANT PLANET OBJECT 
            GiantPlanet Jupiter = new GiantPlanet("Jupiter", 139822, 1.898e27, "gas");
            Jupiter.MoonCount = 69;
            Jupiter.RingCount = 1;
            Console.WriteLine(Jupiter);
            Console.WriteLine("Has Moons: " + Jupiter.HasMoons());
            Console.WriteLine("Number of Moons: " + Jupiter.MoonCount);
            Console.WriteLine("Has Rings: " + Jupiter.HasRings());

            Console.WriteLine("\n----------------------------------------------------------------------------\n");

            // TERRESTRIAL PLANET OBJECT
            TerrestrialPlanet Mars = new TerrestrialPlanet("Mars", 6779, 6.39e23, false);
            Mars.MoonCount = 2;
            Console.WriteLine(Mars);
            Console.WriteLine("Has Moons: " + Mars.HasMoons());
            Console.WriteLine("Number of Moons: " + Mars.MoonCount);
            Console.WriteLine("Is Habitable: " + Mars.Habitable());

        }
    }
}
