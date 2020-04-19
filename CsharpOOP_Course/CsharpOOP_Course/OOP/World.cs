using CsharpOOP_Course.OOP.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace WorldNamespace
{
    public class World
    {
        private string planetName;

        public string PlanetName
        {
            get { return planetName; }
            set { planetName = value; }
        }
        
        private Continents continents;
        public Continents Continents
        {
            get { return continents; }
            set { continents = value; }
        }

    }
}
