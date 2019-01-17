using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Parking
    {
        private int Capacity;
        private int NbVehiclesParked;
        List<Vehicles> VehiclesParked = new List<Vehicles>();

        public Parking(int capacity, int nbVehiclesParked)
        {
            this.Capacity = capacity;
            this.NbVehiclesParked = nbVehiclesParked;
        }

        public void ParkingLot(int places)
        {

        }

        public void Park(Vehicles vehicle)
        {
            VehiclesParked.Add(vehicle);
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
