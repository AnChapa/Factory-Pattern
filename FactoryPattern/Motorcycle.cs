using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Motorcycle : IVehicle
    {
        public string Tires { get; set; }
        public void Drive()
        {
            Console.WriteLine("Your new Motorcycle is on its way!");
        }
    }
}
