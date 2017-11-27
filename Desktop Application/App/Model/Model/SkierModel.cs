using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Model
{
    public class SkierModel
    {
        public int NumberId { get; set; }
        public string SkierName { get; set; }
        public DateTime Birthdate { get; set; }
        public int FederationID { get; set; }
    }
}
