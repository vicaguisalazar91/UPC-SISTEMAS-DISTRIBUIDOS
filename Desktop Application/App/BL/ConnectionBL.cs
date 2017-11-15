using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ConnectionBL
    {

        public static String changeDB(String server, String Database)
        {
            // Build the connection string from the provided datasource and database
            String connString = @"data source=" + server +
            ";initial catalog=" + Database +
            ";integrated security=True;MultipleActiveResultSets=True;App=EntityFramework;";

            // Build the MetaData... feel free to copy/paste it from the connection string in the config file.
            EntityConnectionStringBuilder esb = new EntityConnectionStringBuilder();
            esb.Metadata = "res://*/Model.csdl|res://*/Model.ssdl|res://*/Model.msl";
            esb.Provider = "System.Data.SqlClient";
            esb.ProviderConnectionString = connString;

            // Generate the full string and return it
            return esb.ToString();
        }

    }
}
