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

        public static string addFederation(Federation oFederation) {

            MySoapServer.MySoapServer SWaddFederation = new MySoapServer.MySoapServer();
            String Response = SWaddFederation.addFederation(oFederation.FederationID.ToString(), oFederation.FederationName, oFederation.FederatedNumber.ToString());
            return Response;
            //Console.ReadKey();

        }


        public static string  addskier(Skier oSkier) {
            MySoapServer.MySoapServer SWAddSkier = new MySoapServer.MySoapServer();
            string response = SWAddSkier.addSkier(oSkier.NumberId.ToString(),oSkier.SkierName.ToString(), oSkier.Birthdate.Value.ToString(), oSkier.FederationID.ToString());
            return response;
        }


        public static string  addTeam(Team oTeam) {
            MySoapServer.MySoapServer SWAddSkier = new MySoapServer.MySoapServer();
            string response = SWAddSkier.addTeam(oTeam.TeamId.ToString(),oTeam.TeamName,oTeam.CoachName,oTeam.SkiersNumber.ToString());
            return response;
        }

       
    }
}
