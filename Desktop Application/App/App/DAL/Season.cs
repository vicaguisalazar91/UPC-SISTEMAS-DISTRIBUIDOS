//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Season
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Season()
        {
            this.Route = new HashSet<Route>();
            this.Federation = new HashSet<Federation>();
        }
    
        public int SeasonId { get; set; }
        public string SeasonName { get; set; }
        public string ContactName { get; set; }
        public string SeasonAddress { get; set; }
        public int SeasonPhone { get; set; }
        public Nullable<decimal> kilometersNumber { get; set; }
        public Nullable<int> QtTracks { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Route> Route { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Federation> Federation { get; set; }
    }
}
