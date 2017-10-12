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

            Automobile herbie = new Automobile(4, 13, 2, 4, 1400, "white", 88.8);
            herbie.Move();
            herbie.Move();
            Console.WriteLine("Automobile Distance Traveled: " + herbie.DistanceTraveled);

            Boat boaty = new Boat(2, 500, "red", 88.8, .9d);
            boaty.Move();
            boaty.Move();
            Console.WriteLine("Boat distance travelled: " + boaty.DistanceTraveled);

            Aircraft buzz = new Aircraft(4, 1000, "electric yellow", 888.8);
            buzz.Move();
            buzz.Move();
            Console.WriteLine(buzz.Altitude);

        }
    }
}
