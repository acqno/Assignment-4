using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* 
 * Name: Alvin Quijano
 * Date: 07-17-2017
 * Description: This is the TerrestrialPlanet subclass to the Planet superclass
 * Version: 0.1 - Created the TerrestrialPlanet subclass
 */

namespace Assignment_4
{
    public class TerrestrialPlanet : Planet
    {
        // PRIVATE INSTANCE VARIABLES 
        private bool _oxygen;

        // CONSTRUCTOR METHOD 
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
            :base(name, diameter, mass)
        {
            this._oxygen = oxygen;
        }
    }
}