using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVehicle
{
    internal class Car : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car khoi dong");
        }
    }
}
