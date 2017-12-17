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

        public static void addFederation(Federation oFederation) {

            SW.SW.addFederation(oFederation);

        }

        public static void addSkier(Skier oSkier) {
            SW.SW.addskier(oSkier);
        }




    }
}
