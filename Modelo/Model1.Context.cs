﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Producto_2.Modelo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbHotelSQLEntities : DbContext
    {
        public dbHotelSQLEntities()
            : base("name=dbHotelSQLEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<Factura> Factura { get; set; }
        public virtual DbSet<Habitacion> Habitacion { get; set; }
        public virtual DbSet<historicoReservas> historicoReservas { get; set; }
        public virtual DbSet<HistoricoServicios> HistoricoServicios { get; set; }
        public virtual DbSet<Incidencias> Incidencias { get; set; }
        public virtual DbSet<RegimenPension> RegimenPension { get; set; }
        public virtual DbSet<Reservas> Reservas { get; set; }
        public virtual DbSet<Servicio> Servicio { get; set; }
        public virtual DbSet<Temporada> Temporada { get; set; }
        public virtual DbSet<TipoHabitacion> TipoHabitacion { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
    }
}
