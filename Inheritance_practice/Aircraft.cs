using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_practice
{
    class Aircraft : Vehicle
    {

        private double Altitude { get; set; }

        public Aircraft(int seats, int carryingCapacity, string color, double movementSpeed)
        {
            this.seats = seats;
            this.carryingCapacity = carryingCapacity;
            this.color = color;
            this.movementSpeed = movementSpeed;

            this.Altitude = 0.0d;
        }
        public override void Move()
        {
            Altitude += 10000.0d;
            base.Move();
        }

    }
}
