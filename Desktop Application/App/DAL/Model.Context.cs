﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DB_OlympicsEntities : DbContext
    {
        public DB_OlympicsEntities(String connectionstring)
            : base(connectionstring)
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Competitor> Competitor { get; set; }
        public virtual DbSet<Federation> Federation { get; set; }
        public virtual DbSet<Intervention> Intervention { get; set; }
        public virtual DbSet<Route> Route { get; set; }
        public virtual DbSet<Season> Season { get; set; }
        public virtual DbSet<Skier> Skier { get; set; }
        public virtual DbSet<Stage> Stage { get; set; }
        public virtual DbSet<Team> Team { get; set; }
        public virtual DbSet<TeamMember> TeamMember { get; set; }
        public virtual DbSet<Track_Route> Track_Route { get; set; }
        public virtual DbSet<TryOut> TryOut { get; set; }
        public virtual DbSet<TryOutType> TryOutType { get; set; }
        public virtual DbSet<Tm_Audit> Tm_Audit { get; set; }
    }
}