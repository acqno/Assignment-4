using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* 
 * Name: Alvin Quijano
 * Date: 07-20-2017
 * Description: This is the GiantPlanet subclass to the Planet superclass. 
 * Version: 0.2 - Implemented the IHasMoons and IHasRings Interface
 */

namespace Assignment_4
{
    public class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        // PRIVATE INSTANCE VARIABLES 
        private string _type;

        // CONSTRUCTOR METHOD 
        public GiantPlanet(string name,double diameter, double mass, string type)
            :base(name,diameter, mass)
        {
            this._type = type;
        }

        // PUBLIC METHODS 

        /// <summary>
        /// This is the HasMoons public bool method
        /// </summary>
        /// <returns> True - if moon count is greater than 0, otherwise false</returns>
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
        /// This is the HasRings public bool method 
        /// </summary>
        /// <returns> True - if the RingCount is greater than 0, otherwise return false</returns>
        public bool HasRings()
        {
            if (RingCount > 0)
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