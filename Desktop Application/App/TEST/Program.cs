using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
using DAL;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using System.Web;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {

            delete();
            //string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Replace("file:\\", "") + "\\log4j.config";
            //log4net.Config.XmlConfigurator.Configure(new FileInfo(path));
            //XML.configuration oConfiguration = new XML.configuration();
            //oConfiguration = ConfigurationBL.cargarConfiguracion();

            //DB_OlympicsEntities oConn = new DB_OlympicsEntities(ConnectionBL.changeDB(oConfiguration.connectiondb.servername, oConfiguration.connectiondb.dbname));

            //List<Federation> lstFederation = oConn.Federation.ToList();
            //Console.WriteLine(string.Format("Se encontro una lista de tamaño {0}", lstFederation.Count));
            //Console.ReadKey();

            //Federation oFederation = new Federation();
            //oFederation.FederationID = 20;
            //oFederation.FederationName = "dsadasdas";
            //oFederation.FederatedNumber = 1;

            //ServiceWebBL.addFederation(oFederation);





        }

        public static void List()
        {

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
                List<Federation> lstFederation = JsonConvert.DeserializeObject<List<Federation>>(sr.ReadToEnd());
                foreach (Federation oFederation in lstFederation)
                {
                    //Console.WriteLine(oFederation.FederatedNumber);
                    Console.WriteLine(oFederation.FederationName);
                }
                Console.ReadKey();
            }
        }

        public static void obtener() {
            string key = "123456";
            string uri = "http://ddczone.com/olympics/FederationSW/50";
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
            else {
                Stream stream1 = response.GetResponseStream();
                StreamReader sr = new StreamReader(stream1);
                Federation lstFederation = JsonConvert.DeserializeObject<Federation>(sr.ReadToEnd());
            }


        }

        public static void add()
        {
            Federation oFederation = new Federation();
            oFederation.FederationID = 20;
            oFederation.FederationName = "dsadasdas";
            oFederation.FederatedNumber = 1;

            ServiceWebBL.addFederation(oFederation);

            Skier oSkier = new Skier();


            ServiceWebBL.addSkier(oSkier);            
        }


        public static void delete()
        {

            string key = "123456";
            string uri = "http://ddczone.com/olympics/FederationSW/50";
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
                Console.WriteLine("Se elimino correctamente");
            }
            else {
                Console.WriteLine("Ocurrio un nproblema al eliminar.");
            }

            
        }


        public static void PUT()
        {

            string key = "123456";
            string uri = "http://ddczone.com/olympics/FederationSW/50";
            HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
            request.Headers.Add("X-API-KEY", HttpUtility.UrlEncode(key));

            request.Method = "PUT";
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
                Console.WriteLine("Se elimino correctamente");
            }
            else
            {
                Console.WriteLine("Ocurrio un nproblema al eliminar.");
            }


        }

    }
}
