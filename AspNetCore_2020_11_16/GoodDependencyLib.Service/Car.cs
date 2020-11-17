using System;
using System.Collections.Generic;
using System.Text;

namespace GoodDependencyLib.Service
{
    public class Car : ICar
    {
        public string Brandt { get ; set ; }
        public string Model { get ; set ; }
        public DateTime ConstructionYear { get ; set ; }
        public string Color { get ; set ; }
    }
}
