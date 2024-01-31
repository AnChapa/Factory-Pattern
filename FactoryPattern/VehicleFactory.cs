using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class VehicleFactory
    {
        public static IVehicle GetVehicle(string wheels)
        {
            switch(wheels)
            {
                case "1":
                    return new Unicycle() { Tires = wheels };
                case "2":
                    return new Motorcycle() { Tires = wheels };
                case "3":
                    return new Tricicle() { Tires = wheels };
                case "4":
                    return new Car() { Tires = wheels};
                case "5":
                    return new Jeep() { Tires = wheels};
                default:
                    Console.WriteLine($"We don't have a vehicle with {wheels} wheels, but we've got something, for you.");
                    return new Car();
            }
        }
    }
}
