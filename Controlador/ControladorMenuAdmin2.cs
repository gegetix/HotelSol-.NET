using Producto_2.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto_2.Controlador
{
    internal class ControladorMenuAdmin2
    {
        public List<Usuario> obtenerUsuario()
        {
            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                return db.Usuario.ToList();
            }
        }
        public List<historicoReservas> obtenerHistoricoReservas()
        {
            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                return db.historicoReservas.ToList();
            }
        }
        public List<Habitacion> obtenerHabitacion()
        {
            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                return db.Habitacion.ToList();
            }
        }
        public List<Incidencias> obtenerIncidencia()
        {
            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                return db.Incidencias.ToList();
            }
        }

    }
}
