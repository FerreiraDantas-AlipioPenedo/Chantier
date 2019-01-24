using System;
using System.Collections.Generic;
using System.Text;

namespace Chantier
{
    public class Crane : Vehicles
    {
        private int Height;

        public Crane(int size, int nbWheels, int power, int tankCapacity, int height) : base(size, nbWheels, power, tankCapacity)
        {
            this.Height = height;
        }
    }
}
