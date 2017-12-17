using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using SW;

namespace BL
{
    public class ServiceWebBL
    {

        public static string addFederation(Federation oFederation) {

            return SW.SW.addFederation(oFederation);

        }

        public static string addSkier(Skier oSkier) {
           return SW.SW.addskier(oSkier);
        }

        public static string addTeam(Team oTeam) {
           return SW.SW.addTeam(oTeam);
        }


    }
}
