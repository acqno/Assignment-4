using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* 
 * Name: Alvin Quijano
 * Date: 07-20-2017
 * Description: This is the TerrestrialPlanet subclass to the Planet superclass
 * Version: 0.2 - Implemented the IHasMoons and IHabitable interfaces. 
 */

namespace Assignment_4
{
    public class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        // PRIVATE INSTANCE VARIABLES 
        private bool _oxygen;

        // CONSTRUCTOR METHOD 
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
            :base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }

        // PUBLIC METHODS 

        /// <summary>
        /// This is the HasMoons public bool method
        /// </summary>
        /// <returns> True - if MoonCount is greater than 0, otherwise false </returns>
        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// This is the Habitable public bool method 
        /// </summary>
        /// <returns> True - if oxygen bool variable is set to true, otherwise false</returns>
        public bool Habitable()
        {
            if (_oxygen == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}