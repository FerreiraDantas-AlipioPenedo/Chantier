using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Truck : Vehicles
    {
        private bool Lift;

        public Truck(int size, int nbWheels, int power, int tankCapacity, bool lift) : base(size, nbWheels, power, tankCapacity)
        {
            this.Lift = lift;
        }
    }
}
