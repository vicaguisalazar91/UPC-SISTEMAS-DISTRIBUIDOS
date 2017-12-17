using Model.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
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
                var format = "yyyy-MM-dd"; // your datetime format
                var dateTimeConverter = new IsoDateTimeConverter { DateTimeFormat = format };
                List<SkierModel> lstskier = JsonConvert.DeserializeObject<List<SkierModel>>(sr.ReadToEnd(), dateTimeConverter);
                foreach (SkierModel oSkier in lstskier)
                {
                    SkierModel oskier = new SkierModel();
                    oskier.NumberId = oSkier.NumberId;
                    oskier.FederationID = oSkier.FederationID;
                    oskier.SkierName = oskier.SkierName;
                    oskier.Birthdate = oSkier.Birthdate;

                    skierList.Add(oskier);
                }
            }

            return skierList;
        }
    }
}
