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
using System.Net;
using System.Web;

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
            oskier.Birthdate = DateTime.Now.Date;
            

            ServiceWebBL.addSkier(oskier);
            Buscar();
        }

        private void frmSkier_Load(object sender, EventArgs e)
        {

        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dgvSkier.CurrentRow;
            string parameters = Convert.ToString(row.Cells[0].Value);
            if (!string.IsNullOrEmpty(parameters))
            {



                string key = "123456";
                string uri = "http://ddczone.com/olympics/SkierSW/" + parameters;
                HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
                request.Headers.Add("X-API-KEY", HttpUtility.UrlEncode(key));

                request.Method = "DELETE";
                request.ContentType = "application/json";

                HttpWebResponse response = null;
                HttpStatusCode statusCode;
                try
                {
                    response = (HttpWebResponse)request.GetResponse();
                }
                catch (WebException we)
                {
                    response = (HttpWebResponse)we.Response;
                }

                statusCode = response.StatusCode;
                if (statusCode.Equals("OK"))
                {
                    MessageBox.Show("Se elimino correctamente");
                    Buscar();
                }
                else
                {
                    MessageBox.Show("Se elimino correctamente");
                    Buscar();
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila.");
            }
        }
    }
}
