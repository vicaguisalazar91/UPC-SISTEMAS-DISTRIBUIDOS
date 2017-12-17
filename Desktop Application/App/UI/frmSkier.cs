using Model.AccesoDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BL;

namespace UI
{
    public partial class frmSkier : Form
    {
        public frmSkier()
        {
            InitializeComponent();
            dgvSkier.AutoGenerateColumns = false;
           
        }

        public void Buscar()
        {
            var skierDA = new SkierDA();
            var skier = skierDA.GetSkierList();
            dgvSkier.DataSource = null;
            dgvSkier.Refresh();
            dgvSkier.DataSource = skier;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Skier oskier = new Skier();
            oskier.NumberId = int.Parse(txtSkierId.Text);
            oskier.FederationID = 1;
            oskier.SkierName = txtSkierFullName.Text;
            oskier.Birthdate = DateTime.Now;
            

            ServiceWebBL.addSkier(oskier);
        }

        private void frmSkier_Load(object sender, EventArgs e)
        {

        }
    }
}
