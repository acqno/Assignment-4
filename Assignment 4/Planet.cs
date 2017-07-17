using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* 
 * Name: Alvin Quijano
 * Date: 07-17-2017
 * Description: This is the abstract class planet
 * Version: 0.2 - Created the constructor method and the public override ToString method
 */

namespace Assignment_4
{
    public abstract class Planet
    {
        // PRIVATE INSTANCE VARIABLES 
        private double _diameter,
            _mass,
            _orbitalPeriod,
            _rotationPeriod;
        private int _moonCount,
            _ringCount;
        private string _name;

        // PUBLIC PROPERTIES 
        public  double Diameter { get; }
        public double Mass { get; }
        public int MoonCount { get; set; }
        public string Name { get; }
        public double OrbitalPeriod { get; set; }
        public int RingCount { get; set; }
        public double RotationPeriod { get; set; }

        // CONSTRUCTOR METHOD 
        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }

        // PUBLIC METHODS 
        public override string ToString()
        {
            return string.Format("Name: {0}  Diameter: {1}  Mass: {2}", _name, _diameter, _mass);
        }

    }
}