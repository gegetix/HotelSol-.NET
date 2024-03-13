using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Producto_2.Modelo;


namespace Producto_2.Controlador
{
    internal class ServiciosControlador11
    {
        public List<Servicio> obtenerServicios() { 
            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
                {
                    return db.Servicio.ToList();
                }
        }

        public List<HistoricoServicios> historicoServicios()
        {

            using (dbHotelSQLEntities db = new dbHotelSQLEntities()) { 
                return db.HistoricoServicios.ToList();
            }
        }
        public List<Reservas> obtenerReservas() {

            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                return db.Reservas.ToList();
            }

        }

        
    }
}
