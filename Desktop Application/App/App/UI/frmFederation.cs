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
using System.Net;
using System.Web;
using System.IO;

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
                string response = ServiceWebBL.addFederation(oFederation);
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

            
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dgvFederation.CurrentRow;
            string parameters = Convert.ToString(row.Cells[0].Value);
            if (!string.IsNullOrEmpty(parameters))
            {

                

                string key = "123456";
                string uri = "http://ddczone.com/olympics/FederationSW/"+parameters;
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
            else {
                MessageBox.Show("Debe seleccionar una fila.");
            }
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvFederation.CurrentRow;
            string parameters = Convert.ToString(row.Cells[0].Value);
            if (!string.IsNullOrEmpty(parameters))
            {
                string key = "123456";
                string uri = "http://ddczone.com/olympics/FederationSW/"+parameters;
                HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
                request.Headers.Add("X-API-KEY", HttpUtility.UrlEncode(key));

                request.Method = "GET";
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

                if (statusCode.Equals("404"))
                {
                    Console.WriteLine("No se econtró");
                }
                else
                {
                    Stream stream1 = response.GetResponseStream();
                    StreamReader sr = new StreamReader(stream1);
                    Federation lstFederation = Newtonsoft.Json.JsonConvert.DeserializeObject<Federation>(sr.ReadToEnd());
                    txtFedeId.Text = lstFederation.FederationID.ToString();
                    txtFedeName.Text = lstFederation.FederationName;
                }
            }
                
        }
    }
}
