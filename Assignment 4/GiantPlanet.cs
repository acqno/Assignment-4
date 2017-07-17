using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* 
 * Name: Alvin Quijano
 * Date: 07-17-2017
 * Description: This is the GiantPlanet subclass to the Planet superclass. 
 * Version: 0.1 - Created the GiantPlanet subclass
 */

namespace Assignment_4
{
    public class GiantPlanet : Planet
    {
        // PRIVATE INSTANCE VARIABLES 
        private string _type;

        //CONSTRUCTOR METHOD 
        public GiantPlanet(string name,double diameter, double mass, string type)
            :base(name,diameter, mass)
        {
            this._type = type;
        }

    }
}