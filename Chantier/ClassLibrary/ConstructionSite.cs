using System;
using System.Collections.Generic;
using System.Text;

namespace Chantier
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

        public void AddVehicle(Vehicles vehicle)
        {
            if(vehicle.size <= this.Size)
            {
                ListOfVehicles.Add(vehicle);
            }            
        }

        public void AddWorker(Workers worker)
        {
            ListOfWorkers.Add(worker);
        }

        public int vehiclesInSite
        {
            get
            {
                return ListOfVehicles.Count;
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
