using Producto_2.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto_2.Controlador
{   
    
    internal class ClienteReservas7
    {
        public List<Reservas> obtenerHistoricoReservas()
        {
            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                return db.Reservas.ToList();
            }
        }
        


    }
}
