using Producto_2.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto_2
{
    public interface IMyDbContext
    {
        DbSet<dbHotelSQLEntities> MyEntities { get; set; }

    }
}
