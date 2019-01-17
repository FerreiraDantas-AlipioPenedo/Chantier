using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    class Crane : Vehicles
    {
        private int Height;

        public Crane(int height)
        {
            this.Height = height;
        }
    }
}
