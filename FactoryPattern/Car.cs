using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Car : IVehicle
    {
        public string Tires { get; set; }
        public void Drive()
        {
            Console.WriteLine("Your new Car is on its way!");
        }
    }
}
