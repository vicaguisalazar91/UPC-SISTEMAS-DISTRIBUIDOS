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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "SYSTEM" && txtPassw.Text == "123456")
            {
                frmMenu frm = new frmMenu();
                frmLogin frmlog = new frmLogin();
                frm.Show();
                frmlog.Close();
            }
            else
            {
                MessageBox.Show("Errors, valide contrañse");

            }
        }
    }
}
