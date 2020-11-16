using System;
using System.Collections.Generic;
using System.Text;

namespace GoodDependencyLib.Service
{
    public interface ICar
    {
         string Brandt { get; set; }
         string Model { get; set; }
         DateTime ConstructionYear { get; set; }
         string Color { get; set; }
    }
}
