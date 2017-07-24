using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* 
 * Name: Alvin Quijano
 * Date: 07-23-2017
 * Description: This is the Driver class for the Abstract Planet program
 * Version: 0.1 - Instantiated two objects using both the GiantPlanet and TerrestrialPlanet classes
 */

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // GIANT PLANET OBJECT 
            GiantPlanet Jupiter = new GiantPlanet("Jupiter", 139822, 1.898, "gas");
            Jupiter.MoonCount = 69;
            Jupiter.RingCount = 1;

            // TERRESTRIAL PLANET OBJECT
            TerrestrialPlanet Mars = new TerrestrialPlanet("Mars", 6779, 6.39, false);
            Mars.MoonCount = 2;

            Console.WriteLine(Jupiter);
            Console.WriteLine(Mars);
        }
    }
}
