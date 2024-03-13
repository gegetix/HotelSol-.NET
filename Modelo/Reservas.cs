//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Reservas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reservas()
        {
            this.Factura = new HashSet<Factura>();
            this.HistoricoServicios = new HashSet<HistoricoServicios>();
        }
    
        public int reservaID { get; set; }
        public byte firmado { get; set; }
        public System.DateTime fechaEntrada { get; set; }
        public System.DateTime fechaSalida { get; set; }
        public string NIF { get; set; }
        public int numeroHabitacion { get; set; }
        public int temporadaID { get; set; }
        public int pensionID { get; set; }
    
        internal virtual Clientes Clientes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        internal virtual ICollection<Factura> Factura { get; set; }
        internal virtual Habitacion Habitacion { get; set; }
        internal virtual historicoReservas historicoReservas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        internal virtual ICollection<HistoricoServicios> HistoricoServicios { get; set; }
        internal virtual RegimenPension RegimenPension { get; set; }
        internal virtual Temporada Temporada { get; set; }
    }
}
