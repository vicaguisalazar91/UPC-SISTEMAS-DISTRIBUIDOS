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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void registroDeIntegrantesDeEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegTeamMember frm = new frmRegTeamMember();
            frm.Show();
        }

        private void federacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFederation frm = new frmFederation();
            
            frm.Show();
        }

        private void esquiadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSkier frm = new frmSkier();
            frm.Show();
        }

        private void equiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeam frm = new frmTeam();
            frm.Show();
        }

        private void estacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
