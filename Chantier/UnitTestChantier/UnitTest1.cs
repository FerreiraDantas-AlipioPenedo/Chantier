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
        public void TestMethodAddVehicle()
        {
            int expectedVehiclesInList = 2;

            List<Vehicles> vehicles = new List<Vehicles>();
            Vehicles v = new Vehicles(2, 4, 250, 250);
            Truck t = new Truck(2, 6, 500, 1000, true);

            vehicles.Add(t);
            vehicles.Add(v);
            

            Assert.AreEqual(expectedVehiclesInList, vehicles.Count);
        }

        [TestMethod]
        public void TestMethodVehiclesInSite()
        {
           


            //Assert.AreEqual(expectedVehiclesInList, vehicles.Count);
        }
    }
}
