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
    
    public partial class TeamMember
    {
        public int TeamMemberId { get; set; }
        public int TeamId { get; set; }
        public int NumberId { get; set; }
    
        public virtual Skier Skier { get; set; }
        public virtual Team Team { get; set; }
    }
}
