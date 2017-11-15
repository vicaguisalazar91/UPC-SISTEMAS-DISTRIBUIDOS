using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
using DAL;
using System.IO;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Replace("file:\\", "") + "\\log4j.config";
            log4net.Config.XmlConfigurator.Configure(new FileInfo(path));
            XML.configuration oConfiguration = new XML.configuration();
            oConfiguration = ConfigurationBL.cargarConfiguracion();

            DB_OlympicsEntities oConn = new DB_OlympicsEntities(ConnectionBL.changeDB(oConfiguration.connectiondb.servername, oConfiguration.connectiondb.dbname));

            List<Federation> lstFederation = oConn.Federation.ToList();
            Console.WriteLine(string.Format("Se encontro una lista de tamaño {0}", lstFederation.Count));
            Console.ReadKey();
        } 
    }
}
