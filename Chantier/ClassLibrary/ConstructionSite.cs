using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class ConstructionSite
    {
        private string Address;
        private string City;
        private int Size;
        private List<Vehicles> ListOfVehicles = new List<Vehicles>();
        private List<Workers> ListOfWorkers = new List<Workers>();

        public ConstructionSite(string address, string city, int size)
        {
            this.Address = address;
            this.City = city;
            this.Size = size;
        }

        public void AddVehicle(Vehicles vehicle, List<Vehicles> vehicles)
        {

        }

        public void AddWorker(Workers worker)
        {

        }

        public List<Vehicles> vehiclesInSite
        {
            get
            {
                return ListOfVehicles;
            }
        }

        public List<Workers> workersInSite
        {
            get
            {
                return ListOfWorkers;
            }
        }


    }
}
