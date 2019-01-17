using System;

namespace ClassLibrary
{
    public class Parking
    {
        private int Capacity;
        private int VehiclesParked;

        public Parking(int capacity, int vehiclesParked)
        {
            this.Capacity = capacity;
            this.VehiclesParked = vehiclesParked;
        }

        public void ParkingLot(int places)
        {

        }

        public bool Park(Vehicles vehicle)
        {

        }

        public int AvailablePlaces
        {
            get
            {
                return Capacity - VehiclesParked;
            }
        }
    }
}
