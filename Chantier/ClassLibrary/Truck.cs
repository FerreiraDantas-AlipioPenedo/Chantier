using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Truck : Vehicles
    {
        private bool Lift;

        public Truck(bool lift)
        {
            this.Lift = lift;
        }
    }
}
