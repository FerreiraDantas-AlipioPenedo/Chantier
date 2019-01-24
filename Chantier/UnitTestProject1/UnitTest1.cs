using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary;

namespace UnitTestChantier
{
    [TestClass]
    public class UnitTestChantier
    {
        [TestMethod]
        public void TestMethodAddVehicle()
        {
            List<Vehicles> vehicles = new List<Vehicles>();
            Vehicles v = new Vehicles(2, 4, 250, 250);

            Truck t = new Truck(2, 6, 500, 1000, true);
        }
    }
}
