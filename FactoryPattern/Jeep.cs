using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Jeep : IVehicle
    {
        public string Tires { get; set; }
        public void Drive()
        {
            Console.WriteLine("Your new Jeep is on its way!");
        }
    }
}
