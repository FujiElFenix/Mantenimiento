﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CLConexion
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBMantencionEntities1 : DbContext
    {
        public DBMantencionEntities1()
            : base("name=DBMantencionEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Conductor> Conductor { get; set; }
        public DbSet<Servicios> Servicios { get; set; }
        public DbSet<Vehiculo> Vehiculo { get; set; }
    }
}
