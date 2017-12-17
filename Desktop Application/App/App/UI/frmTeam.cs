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
using System.Net;
using System.Web;
using BL;

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
            
                Team oteam = new Team();
                oteam.TeamId = Convert.ToInt32(txtTeamId.Text);
                oteam.TeamName = txtTeamName.Text;
                oteam.SkiersNumber = 1;
                string response = ServiceWebBL.addTeam(oteam);
                MessageBox.Show("Se registro correctamente la federacion");
                Buscar();

                //if (Convert.ToBoolean(response))
                //{
                //    MessageBox.Show("Se registro correctamente la federacion");
                //}
                //else {
                //    MessageBox.Show("Ocurrrio un incidente al registrar la federacion");
                //}


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Buscar();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dgvTeam.CurrentRow;
            string parameters = Convert.ToString(row.Cells[0].Value);
            if (!string.IsNullOrEmpty(parameters))
            {



                string key = "123456";
                string uri = "http://ddczone.com/olympics/Team/" + parameters;
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
