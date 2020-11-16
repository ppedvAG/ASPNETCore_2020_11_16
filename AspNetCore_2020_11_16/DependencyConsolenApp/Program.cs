using DependencyLib.Entities;
using DependencyLib.Service;
using System;

namespace DependencyConsolenApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BadCar car = new BadCar();
            car.Brandt = "VW";
            car.Model = "Käfer";
            car.ConstructionYear = DateTime.Now;
            car.Color = "Rot";

            //BadCarService benötigt beide Dll um Service aufzurufen. 
            BadCarService service = new BadCarService();
            service.RepairCar(car);



            Console.WriteLine("Hello World!");
        }
    }
}
