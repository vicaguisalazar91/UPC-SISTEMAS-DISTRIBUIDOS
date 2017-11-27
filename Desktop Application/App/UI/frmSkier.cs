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
    }
}
