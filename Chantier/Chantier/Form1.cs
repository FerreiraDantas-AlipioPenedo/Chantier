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
        List<ConstructionSite> ConstructionSites = new List<ConstructionSite>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddSite_Click(object sender, EventArgs e)
        {
            ConstructionSite cs = new ConstructionSite(txtAddressSite.Text, txtCitySite.Text, Int32.Parse(txtSizeSite.Text));
            ConstructionSites.Add(cs);
        }

        private void btnSelectSite_Click(object sender, EventArgs e)
        {

        }
    }
}
