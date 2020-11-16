using GoodDependencyLib.Service;
using System;

namespace DevExpressCarImpl
{
    public class DevExpressCar : ICar
    {
        public string Brandt { get; set; }
        public string Model { get; set; }
        public DateTime ConstructionYear { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
