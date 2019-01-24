using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chantier
{
    public partial class Form1 : Form
    {

        private Form2 f2;
        public Parking park;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int nbVehicles = 0;
            int nbTrucks = 0;
            int nbCranes = 0;

            //List of workers
            List<Workers> WorkersList = new List<Workers>();

            //Creation of workers
            Workers w = new Workers("Juan", "D'el Muro", 19, Chantier.Workers.Roles.ChefDeChantier);
            Workers w1 = new Workers("Unbertino", "Youh", 30, Chantier.Workers.Roles.ChefDeChantier);
            Workers w2 = new Workers("Deuxbertino", "Sept", 71, Chantier.Workers.Roles.ChefDeChantier);
            Workers w3 = new Workers("Troisbertino", "Zaphir", 59, Chantier.Workers.Roles.ChefDeChantier);
            Workers w4 = new Workers("Cinqbertino", "Zéee", 23, Chantier.Workers.Roles.ChefDeChantier);
            Workers w5 = new Workers("Juan", "D'el Muro", 19, Chantier.Workers.Roles.Machiniste);
            Workers w6 = new Workers("Unbertino", "Youh", 30, Chantier.Workers.Roles.Machiniste);
            Workers w7 = new Workers("Deuxbertino", "Sept", 71, Chantier.Workers.Roles.Machiniste);
            Workers w8 = new Workers("Troisbertino", "Zaphir", 59, Chantier.Workers.Roles.Machiniste);
            Workers w9 = new Workers("Cinqbertino", "Zéee", 23, Chantier.Workers.Roles.Machiniste);
            Workers w10 = new Workers("Juan", "D'el Muro", 19, Chantier.Workers.Roles.OuvrierQualifié);
            Workers w11 = new Workers("Unbertino", "Youh", 30, Chantier.Workers.Roles.OuvrierQualifié);
            Workers w12 = new Workers("Deuxbertino", "Sept", 71, Chantier.Workers.Roles.OuvrierQualifié);
            Workers w13 = new Workers("Troisbertino", "Zaphir", 59, Chantier.Workers.Roles.OuvrierQualifié);
            Workers w14 = new Workers("Cinqbertino", "Zéee", 23, Chantier.Workers.Roles.OuvrierQualifié);

            //Add workers in they list
            WorkersList.Add(w);
            WorkersList.Add(w1);
            WorkersList.Add(w2);
            WorkersList.Add(w3);
            WorkersList.Add(w4);
            WorkersList.Add(w5);
            WorkersList.Add(w6);
            WorkersList.Add(w7);
            WorkersList.Add(w8);
            WorkersList.Add(w9);
            WorkersList.Add(w10);
            WorkersList.Add(w11);
            WorkersList.Add(w12);
            WorkersList.Add(w13);
            WorkersList.Add(w14);

            //Display all workers in the application
            foreach(Workers worker in WorkersList)
            {
                txtWorkers.Text += worker.WorkerDescription() + System.Environment.NewLine;
                
            }

            //Create a Parking with 50 places
            park = new Parking(50);          

            //Global size of the vehicles
            int SizeVehicle = 1;
            int SizeTruck = 3;
            int SizeCrane = 2;

            //Creates all vehicles
            Vehicles v = new Vehicles(SizeVehicle, 4, 200, 60);
            Vehicles v1 = new Vehicles(SizeVehicle, 4, 200, 60);
            Vehicles v2 = new Vehicles(SizeVehicle, 4, 200, 60);
            Vehicles v3 = new Vehicles(SizeVehicle, 4, 200, 60);
            Vehicles v4 = new Vehicles(SizeVehicle, 4, 200, 60);

            Truck t = new Truck(SizeTruck, 6, 150, 200, true);
            Truck t1 = new Truck(SizeTruck, 8, 185, 300, false);
            Truck t2 = new Truck(SizeTruck, 8, 250, 500, true);
            Truck t3 = new Truck(SizeTruck, 6, 100, 150, false);
            Truck t4 = new Truck(SizeTruck, 6, 100, 150, true);

            Crane c = new Crane(SizeCrane, 0, 45, 0, 1500);
            Crane c1 = new Crane(SizeCrane, 0, 45, 0, 1500);
            Crane c2 = new Crane(SizeCrane, 0, 45, 0, 1500);

            //Park the vehicles in the parking
            park.Park(v);
            park.Park(v1);
            park.Park(v2);
            park.Park(v3);
            park.Park(v4);

            park.Park(t);
            park.Park(t1);
            park.Park(t2);
            park.Park(t3);
            park.Park(t4);

            park.Park(c);
            park.Park(c1);
            park.Park(c2);

            //List of vehicles
            List<Vehicles> VehiclesList = park.vehiclesInPark;

            foreach (Vehicles vehicle in VehiclesList)
            {
                string type = vehicle.GetType().ToString();                

                if(type == "Chantier.Vehicles")
                {
                    nbVehicles++;

                }else if(type == "Chantier.Truck")
                {
                    nbTrucks++;

                }else if(type == "Chantier.Crane")
                {
                    nbCranes++;
                }
            }

            txtNbVehicles.Text = nbVehicles.ToString();
            txtNbTruks.Text = nbTrucks.ToString();
            txtNbCranes.Text = nbCranes.ToString();
            txtAvailablePlaces.Text = park.AvailablePlaces.ToString();
        }

        private void cmdNewConstructionSite_Click(object sender, EventArgs e)
        {          
            f2 = new Form2(this);
            f2.ShowDialog();
        }
    }
}
