using GoodDependencyLib.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoodDependencyLib.Entities
{
    public class GoodCar : ICar // Programmieraufwand: 4 Wochen für Programmierer A
    {
        public string Brandt { get; set; }
        public string Model { get; set; }
        public DateTime ConstructionYear { get; set; }
        public string Color { get; set; }
    }
}
