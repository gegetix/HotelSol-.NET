using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Producto_2.Modelo;

namespace Producto_2.Controlador
{
    [Serializable]
    [XmlInclude(typeof(Clientes))]
    [XmlInclude(typeof(Reservas))]
    [XmlInclude(typeof(Habitacion))]
    [XmlInclude(typeof(Factura))]
    [XmlInclude(typeof(Servicio))]
    [XmlInclude(typeof(TipoHabitacion))]
    [XmlInclude(typeof(Temporada))]
    [XmlInclude(typeof(RegimenPension))]
    [XmlInclude(typeof(historicoReservas))]
    [XmlInclude(typeof(HistoricoServicios))]
    public class DatosExportados<T>
    {
        public List<T> Elementos { get; set; }  
        public DatosExportados() { 
        Elementos = new List<T>();
        }
    }
    
}
