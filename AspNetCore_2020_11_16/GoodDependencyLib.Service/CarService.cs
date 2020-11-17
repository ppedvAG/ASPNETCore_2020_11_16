using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GoodDependencyLib.Service
{
    public class CarService : ICarService //// Programmieraufwand: 2 Wochen für Programmierer B
    {
        public IList<Car> GetAll()
        {
            IList<Car> carList = new List<Car>();
            carList.Add(new Car { Brandt = "VW", Model = "abc", Color = "gelb", ConstructionYear = DateTime.Now });
            carList.Add(new Car { Brandt = "BMW", Model = "abc", Color = "gelb", ConstructionYear = DateTime.Now });
            carList.Add(new Car { Brandt = "Ferrari", Model = "abc", Color = "gelb", ConstructionYear = DateTime.Now });
            return carList;
        }

        public void Repair(ICar car)
        {
            //Machwas....
        }


    }
}
