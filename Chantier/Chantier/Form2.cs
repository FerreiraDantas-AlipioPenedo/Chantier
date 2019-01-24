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
    public partial class Form2 : Form
    {
        private Form1 dad;

        public Form2(Form1 f)
        {
            dad = f;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConstructionSite constructionSite = new ConstructionSite(txtAdress.Text, txtCity.Text, Int32.Parse(txtSize.Text));

            int availablePlaces = dad.park.AvailablePlaces;

            int AskedNbVehicles = Int32.Parse(txtNbVehicles.Text);
            int AskedNbTrucks = Int32.Parse(txtNbTrucks.Text);
            int AskedNbCranes = Int32.Parse(txtNbCranes.Text);

            int AvailableVehicles = 0;
            int AvailableTrucks = 0;
            int AvailableCranes = 0;

            List<Vehicles> ListVehicles = dad.park.vehiclesInPark;

            foreach(Vehicles v in ListVehicles)
            {
                string type = v.GetType().ToString();

                if (type == "Chantier.Vehicles")
                {
                    AvailableVehicles++;
                }
                else if (type == "Chantier.Truck")
                {
                    AvailableTrucks++;
                }
                else if (type == "Chantier.Crane")
                {
                    AvailableCranes++;
                }
            }

            if(AvailableVehicles > AskedNbVehicles)
            {
                if(AvailableTrucks > AskedNbTrucks)
                {
                    if(AvailableCranes > AskedNbCranes)
                    {

                    }
                }
            }
        }
    }
}
