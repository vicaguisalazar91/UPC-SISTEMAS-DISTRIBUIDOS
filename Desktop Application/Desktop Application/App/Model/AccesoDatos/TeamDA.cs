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
    public class TeamDA
    {
        public List<TeamModel> GetTeamList()
        {
            List<TeamModel> TeamList = new List<TeamModel>();

            string key = "123456";
            string uri = "http://ddczone.com/olympics/TeamSW/";
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
                List<TeamModel> lstTeam = JsonConvert.DeserializeObject<List<TeamModel>>(sr.ReadToEnd());
                foreach (TeamModel oTeam in lstTeam)
                {
                    //Console.WriteLine(oFederation.FederatedNumber);
                    //Console.WriteLine(oFederation.FederationName);
                    TeamModel Team = new TeamModel();
                    Team.NumberId = oTeam.NumberId;
                    //Team.TeamName = oTeam.TeamName;

                    TeamList.Add(Team);
                }
            }

            return TeamList;
        }
    }
}
