using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model.AccesoDatos;
using DAL;
using BL;

namespace UI
{
    public partial class frmFederation : Form
    {

        string opcion = "INSERT";
        public frmFederation()
        {
            InitializeComponent();
            dgvFederation.AutoGenerateColumns = false;
            
        }

        private void Buscar()
        {
            var federationDA = new FederationDA();            
            var federation = federationDA.GetFederationList();
            dgvFederation.DataSource = null;
            dgvFederation.Refresh();
            dgvFederation.DataSource = federation;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtFedeId.Enabled = true;
            txtFedeName.Enabled = true;
            
        }

        private void frmFederation_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void dgvFederation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            var federation = new Federation();
            federation.FederationID = Int32.Parse( dgvFederation.SelectedRows[0].Cells["FederationID"].Value.ToString());
            federation.FederationName = dgvFederation.SelectedRows[0].Cells["FederationName"].Value.ToString();
            federation.FederatedNumber = Int32.Parse(dgvFederation.SelectedRows[0].Cells["FederatedNumber"].Value.ToString());

*/            




        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (opcion == "UPDATE")
            {
                Federation oFederation = new Federation();
                oFederation.FederationName = txtFedeName.Text;
                oFederation.FederatedNumber = 1;
                oFederation.FederationID = int.Parse(txtFedeId.Text);
                ServiceWebBL.addFederation(oFederation);
            }
            else
            {
                Federation oFederation = new Federation();
                oFederation.FederationName = txtFedeName.Text;
                oFederation.FederatedNumber = 1;
                oFederation.FederationID = int.Parse(txtFedeId.Text);
                ServiceWebBL.addFederation(oFederation);

            }

            
        }
    }
}
