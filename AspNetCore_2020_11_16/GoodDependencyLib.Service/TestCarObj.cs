using System;
using System.Collections.Generic;
using System.Text;

namespace GoodDependencyLib.Service
{
    public class TestCarObj : ICar
    {
        public string Brandt { get; set; } = "BMW";
        public string Model { get; set; } = "Z8";
        public DateTime ConstructionYear { get; set; } = DateTime.Now;
        public string Color { get; set; } = "Schwarz";
    }
}
