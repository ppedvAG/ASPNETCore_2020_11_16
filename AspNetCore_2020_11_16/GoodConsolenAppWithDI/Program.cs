using DevExpressCarImpl;
using GoodDependencyLib.Service;
using System;

namespace GoodConsolenAppWithDI
{
    class Program
    {
        static void Main(string[] args)
        {

            ICarService service = new CarService();

            service.Repair(new TestCarObj()); // Für eigene Test kann ich mit DI -> Mock-Objekte erzeugen

            service.Repair(new DevExpressCar());
            
        }
    }
}
