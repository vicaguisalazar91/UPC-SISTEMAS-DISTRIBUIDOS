using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Model.Model;
using BL;
using System.Web;

namespace Model.AccesoDatos
{
    public class FederationDA
    {
        
        public List<FederationModel> GetFederationList()
        {
            List<FederationModel> fedetationList = new List<FederationModel>();

            string key = "123456";
            string uri = "http://ddczone.com/olympics/FederationSW/";
            HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
            request.Headers.Add("X-API-KEY", HttpUtility.UrlEncode(key));

            request.Method = "GET";
            request.ContentType = "application/json";

            //Hacer la llamada
            using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
            {
                //Leer el resultado de la llamada
                Stream stream1 = response.GetResponseStream();
                StreamReader sr = new StreamReader(stream1);
                List<FederationModel> lstFederation = JsonConvert.DeserializeObject<List<FederationModel>>(sr.ReadToEnd());
                foreach (FederationModel oFederation in lstFederation)
                {
                    //Console.WriteLine(oFederation.FederatedNumber);
                    //Console.WriteLine(oFederation.FederationName);
                    FederationModel fedetation = new FederationModel();
                    fedetation.FederationID = oFederation.FederationID;
                    fedetation.FederationName = oFederation.FederationName;
                    fedetation.FederatedNumber = oFederation.FederatedNumber;
                    fedetationList.Add(fedetation);
                }
            }

            return fedetationList;
        }

        public void InsertFederation(FederationModel model)
        {
            var federation = new FederationModel();
            //federation.FederationID = Int32.Parse(dgvFederation.SelectedRows[0].Cells["FederationID"].Value.ToString());
            federation.FederationName = model.FederationName;
            federation.FederatedNumber = model.FederatedNumber;

            //ServiceWebBL.addFederation(federation);

        }
    }
}
