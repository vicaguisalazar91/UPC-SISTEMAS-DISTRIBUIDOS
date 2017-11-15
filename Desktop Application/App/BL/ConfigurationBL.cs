using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.IO;
using log4net;
using System.Xml;
using System.Xml.Serialization;

namespace BL
{
    public class ConfigurationBL
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(ConfigurationBL));

        private static DAL.XML.configuration oConfiguracion;
        public static DAL.XML.configuration cargarConfiguracion()
        {
            try
            {
                string FilePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Replace("file:\\", "") + "\\Config.xml";
                if (File.Exists(FilePath))
                {
                    oConfiguracion = DeserializeXMLFileToObject<DAL.XML.configuration>(FilePath);
                }
                else
                {
                    log.Debug(" [ERROR]  No existe el archivo de configuración : " + FilePath + " .");
                    return null;
                }

            }
            catch (Exception ex)
            {
                log.Debug(" [ERROR]  " + ex.Message);
            }
            log.Debug(" [SUCCESS]  Se cargó correctamente la configuración. ");
            return oConfiguracion;
        }

        public static void guardarConfiguracion(DAL.XML.configuration oConfiguracion)
        {
            try
            {
                string FilePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Replace("file:\\", "") + "\\Config.xml";
                XmlDocument xmlDocument = new XmlDocument();
                XmlSerializer serializer = new XmlSerializer(oConfiguracion.GetType());
                using (MemoryStream stream = new MemoryStream())
                {
                    serializer.Serialize(stream, oConfiguracion);
                    stream.Position = 0;
                    xmlDocument.Load(stream);
                    xmlDocument.Save(FilePath);
                    stream.Close();
                }
                log.Debug(System.Reflection.MethodBase.GetCurrentMethod().Name + " [SUCCESS]  Se guardó correctamente la configuración. ");
            }
            catch (Exception ex)
            {
                log.Debug(System.Reflection.MethodBase.GetCurrentMethod().Name + " [ERROR]  " + ex.Message);
            }

        }

        private static T DeserializeXMLFileToObject<T>(string XmlFilename)
        {
            T returnObject = default(T);
            if (string.IsNullOrEmpty(XmlFilename)) return default(T);

            try
            {
                StreamReader xmlStream = new StreamReader(XmlFilename);
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                returnObject = (T)serializer.Deserialize(xmlStream);
                xmlStream.Close();
                log.Debug(System.Reflection.MethodBase.GetCurrentMethod().Name + " [SUCCESS]  Se cargó correctamente cargado de la ruta : " + XmlFilename + " .");
            }
            catch (Exception ex)
            {
                log.Error(System.Reflection.MethodBase.GetCurrentMethod().Name + " [ERROR] : " + ex.Message);
            }
            return returnObject;
        }

    }
}
