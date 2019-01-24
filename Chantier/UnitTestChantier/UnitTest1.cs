using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chantier
{
    [TestClass]
    public class UnitTestChantier
    {
        [TestMethod]
        //this method add vehicles in a park
        public void TestMethodAddVehicle()
        {
            Parking Park = new Parking(2);
            int expectedVehiclesInList = Park.AvailablePlaces;
            
            List<Vehicles> vehicles = new List<Vehicles>();
            Vehicles v = new Vehicles(2, 4, 250, 250);
            Truck t = new Truck(2, 6, 500, 1000, true);

            vehicles.Add(t);
            vehicles.Add(v);

            Park.Park(t);
            Park.Park(v);
            
            Assert.AreEqual(expectedVehiclesInList, vehicles.Count);
        }

        [TestMethod]
        //this test method test if the availables places in a parking are correct
        public void TestMethodCorrectAvailablePlaces()
        {
            Parking Park = new Parking(5);
            int expectedAvailablePlaces = 3;

            Vehicles v = new Vehicles(2, 4, 250, 250);
            Truck t = new Truck(2, 6, 500, 1000, true);

            Park.Park(t);
            Park.Park(v);

            Assert.AreEqual(expectedAvailablePlaces, Park.AvailablePlaces);
        }

        [TestMethod]
        //this test method create a new object worker
        public void TestMethodAddOneWorker()
        {
            int expectedWorkers = 1;

            List <Workers> workers = new List<Workers>();
            Workers Worker = new Workers("Juan", "D'el Muro", 20, Workers.Roles.ChefDeChantier);

            workers.Add(Worker);

            Assert.AreEqual(expectedWorkers, workers.Count);
        }

        [TestMethod]
        //this test method creates 3 objects workers
        public void TestMethodAdd3Workers()
        {
            int expectedWorkers = 3;

            List<Workers> workers = new List<Workers>();

            Workers Worker = new Workers("Juan", "D'el Muro", 20, Workers.Roles.ChefDeChantier);
            Workers Worker1 = new Workers("Unbertino", "D'el Muro", 30, Workers.Roles.Machiniste);
            Workers Worker2 = new Workers("DeuxBertina", "D'el Muro", 32, Workers.Roles.OuvrierQualifié);

            workers.Add(Worker);
            workers.Add(Worker1);
            workers.Add(Worker2);

            Assert.AreEqual(expectedWorkers, workers.Count);
        }

        [TestMethod]
        //this test method adds a new Construction Site
        public void TestMethodAddAConstructionSite()
        {
            int expectedConstructionSite = 1;

            List<ConstructionSite> CS = new List<ConstructionSite>();

            ConstructionSite cs = new ConstructionSite("Rue de la gare 2", "Ste-Croix", 2);

            CS.Add(cs);

            Assert.AreEqual(expectedConstructionSite, CS.Count);
        }

        [TestMethod]
        //this test method add a vehicle with the good size in a construction site
        public void TestMethodAddAVehicleInACS()
        {
            int expectedVehicleInCS = 1;

            ConstructionSite cs = new ConstructionSite("Rue de la gare 2", "Ste-Croix", 2);
            Truck t = new Truck(2, 6, 500, 1000, true);

            cs.AddVehicle(t);

            int VehiclesInSite = cs.vehiclesInSite;

            Assert.AreEqual(expectedVehicleInCS, VehiclesInSite);

        }

        [TestMethod]
        //this test method add a vehicle to much big in a construction site 
        public void TestMethodAddABiggerVehicleInACS()
        {
            int expectedVehicleInCS = 0;

            ConstructionSite cs = new ConstructionSite("Rue de la gare 2", "Ste-Croix", 2);
            Truck t = new Truck(3, 6, 500, 1000, true);

            cs.AddVehicle(t);

            int VehiclesInSite = cs.vehiclesInSite;

            Assert.AreEqual(expectedVehicleInCS, VehiclesInSite);
        }
    }
}
