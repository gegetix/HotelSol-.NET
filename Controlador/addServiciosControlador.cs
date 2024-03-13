using Producto_2.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Producto_2.Controlador
{
    public class addServiciosControlador
    {
        public void AgregarServivio(Servicio servicio)
        {
            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                try
                {
                    var servicioExiste = db.Servicio.FirstOrDefault(c => c.idServicio == servicio.idServicio);
                    if (servicioExiste == null)
                    {
                        db.Servicio.Add(servicio);
                    }
                    else
                    {
                     modificarServicio(servicio.idServicio, servicio.descripcion, servicio.precioAlta, servicio.precioMedia, servicio.precioBaja,
                     Convert.ToByte(servicio.permisoAlta), Convert.ToByte(servicio.permisoMedia), Convert.ToByte(servicio.permisoBaja), 
                     Convert.ToDouble(servicio.descVIP));
                    }
                    db.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var validationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            sb.AppendLine($"Property: {validationError.PropertyName}, Error: {validationError.ErrorMessage}");
                        }
                    }
                    throw new Exception(sb.ToString());
                }
                catch (DbUpdateException ex)
                {
                    throw new Exception("Error al agregar reserva: " + ex.InnerException?.Message ?? ex.Message);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al agregar reserva: " + ex.Message);
                }
            }
        }

        public void AgregarHistoricoServicio(HistoricoServicios servicio)
        {
            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                try
                {
                    db.HistoricoServicios.Add(servicio);
                    db.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var validationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            sb.AppendLine($"Property: {validationError.PropertyName}, Error: {validationError.ErrorMessage}");
                        }
                    }
                    throw new Exception(sb.ToString());
                }
                catch (DbUpdateException ex)
                {
                    throw new Exception("Error al agregar reserva: " + ex.InnerException?.Message ?? ex.Message);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al agregar reserva: " + ex.Message);
                }
            }
        }
        public void eliminarServicio(int ID) {
            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                try
                {
                    var servicioEliminar = db.Servicio.FirstOrDefault(c => c.idServicio == ID);
                    if (servicioEliminar == null)
                    {
                        throw new Exception("Reserva no encontrada. ");
                    }

                    db.Servicio.Remove(servicioEliminar);
                    db.SaveChanges();

                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar la reserva: " + ex.Message);
                }
            }
        }
        public List<Servicio> BuscarServicio(int ID)
        {

            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                return db.Servicio.Where(c => c.idServicio.Equals(ID)).ToList();
            }
        }

        public void modificarServicio(int ID,String desc,double precioAlta, double precioMedia, double precioBaja ,byte permAlta,byte permMedia, byte permBaja,double VIP) {

            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                try
                {
                    var servicioActualizar = db.Servicio.FirstOrDefault(c => c.idServicio == ID);
                    if (servicioActualizar == null)
                    {
                        throw new Exception("Reserva no encontrada.");
                    }
                    servicioActualizar.descripcion = desc;
                    servicioActualizar.precioAlta = precioAlta;
                    servicioActualizar.precioMedia  = precioMedia;
                    servicioActualizar.precioBaja   = precioBaja;
                    servicioActualizar.permisoAlta = permAlta;
                    servicioActualizar.permisoMedia = permMedia;
                    servicioActualizar.permisoBaja = permBaja;
                    servicioActualizar.descVIP = VIP;
                    

                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al modificar la reserva: " + ex.Message);
                }
            }
        }

        
    }
}
