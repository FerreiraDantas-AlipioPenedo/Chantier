using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Crane : Vehicles
    {
        private int Height;

        public Crane(int height)
        {
            this.Height = height;
        }
    }
}
