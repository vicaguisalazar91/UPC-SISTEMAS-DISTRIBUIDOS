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


namespace UI
{
    public partial class frmTeam : Form
    {
        public frmTeam()
        {
            InitializeComponent();

        }

        public void Buscar()
        {
            var skierDA = new SkierDA();
            var skier = skierDA.GetSkierList();
            dgvTeam.DataSource = null;
            dgvTeam.Refresh();
            dgvTeam.DataSource = skier;
        }

        private void frmTeam_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Buscar();
        }
    }
}
