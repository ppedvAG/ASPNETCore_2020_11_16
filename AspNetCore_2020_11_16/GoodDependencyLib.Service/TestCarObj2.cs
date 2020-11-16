using System;
using System.Collections.Generic;
using System.Text;

namespace GoodDependencyLib.Service
{
    public class TestCarObj2 : ICar
    {
        public string Brandt { get; set; } = "Prosche";
        public string Model { get; set; } = "911";
        public DateTime ConstructionYear { get; set; } = new DateTime(2019, 11, 11);
        public string Color { get; set; } = "Gelb";
    }
}
