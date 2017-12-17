using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using DAL;
namespace SW
{
    public class SW
    {

        public static void addFederation(Federation oFederation) {

            MySoapServer.MySoapServer SWaddFederation = new MySoapServer.MySoapServer();
            String Response = SWaddFederation.addFederation(oFederation.FederationID.ToString(), oFederation.FederationName, oFederation.FederatedNumber.ToString());
            //Console.ReadKey();

        }

       
    }
}
