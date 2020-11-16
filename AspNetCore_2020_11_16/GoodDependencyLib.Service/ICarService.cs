using System;
using System.Collections.Generic;
using System.Text;

namespace GoodDependencyLib.Service
{
    public interface ICarService
    {
        public void Repair(ICar car);
    }
}
