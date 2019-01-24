using System;
using System.Collections.Generic;
using System.Text;

namespace Chantier
{
    public class Parking
    {
        private int Capacity;
        private int NbVehiclesParked = 0;
        List<Vehicles> VehiclesParked = new List<Vehicles>();

        public Parking(int capacity)
        {
            this.Capacity = capacity;
        }

        public void Park(Vehicles vehicle)
        {
            VehiclesParked.Add(vehicle);
            NbVehiclesParked++;
        }

        public int AvailablePlaces
        {
            get
            {
                return Capacity - NbVehiclesParked;
            }
        }

        public List<Vehicles> vehiclesInPark
        {
            get
            {
                return VehiclesParked;
            }
        }
    }
}
