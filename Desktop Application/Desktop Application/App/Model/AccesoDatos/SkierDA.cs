using Model.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Model.AccesoDatos
{
    public class SkierDA
    {
        public List<SkierModel> GetSkierList()
        {
            List<SkierModel> skierList = new List<SkierModel>();

            string key = "123456";
            string uri = "http://ddczone.com/olympics/SkierSW/";
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
                List<SkierModel> lstskier = JsonConvert.DeserializeObject<List<SkierModel>>(sr.ReadToEnd());
                foreach (SkierModel oSkier in lstskier)
                {
                    //Console.WriteLine(oFederation.FederatedNumber);
                    //Console.WriteLine(oFederation.FederationName);
                    SkierModel skier = new SkierModel();
                    skier.NumberId = oSkier.NumberId;
                    skier.SkierName = oSkier.SkierName;

                    skierList.Add(skier);
                }
            }

            return skierList;
        }
    }
}
