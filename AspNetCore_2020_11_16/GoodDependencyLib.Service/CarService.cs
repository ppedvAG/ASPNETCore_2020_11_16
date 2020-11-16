using System;
using System.Collections.Generic;
using System.Text;

namespace GoodDependencyLib.Service
{
    public class CarService : ICarService //// Programmieraufwand: 2 Wochen für Programmierer B
    {
        public void Repair(ICar car)
        {
            //Machwas....
        }
    }
}
