using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle baseVehicle = new Vehicle(4, 2000, "green", 55.0d);
            baseVehicle.Move();
            Console.WriteLine(baseVehicle.DistanceTraveled);
        }
    }
}
