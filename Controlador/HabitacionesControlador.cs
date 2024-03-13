using Producto_2.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Producto_2.Controlador
{
    public class HabitacionesControlador
    {
        public List<Habitacion> ObtenerHabitaciones()
        {
            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                // Consulta para obtener las habitaciones
                var query = from habitacion in db.Habitacion
                            select habitacion;

                // Convertir los resultados en una lista de Habitaciones
                List<Habitacion> listaHabitaciones = query.ToList();

                return listaHabitaciones;
            }
        }


        public List<Habitacion> BuscarHabitacionPorNumero(String numeroHabitacion)
        {

            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                if (int.TryParse(numeroHabitacion, out int numero))
                {
                    return db.Habitacion.Where(c => c.numeroHabitacion == numero).ToList();
                }
                else
                {
                    return new List<Habitacion>();
                }
            }
        }

        public void AgregarHabitacion(Habitacion habitacion)
        {
            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                try
                {
                    // Crear una nueva instancia de la entidad Habitacion y asignar valores
                    var nuevaHabitacion = new Habitacion
                    {
                        numeroHabitacion = habitacion.numeroHabitacion,
                        descripcion = habitacion.descripcion,
                        tipoID = habitacion.tipoID,
                        maxPersonas = habitacion.maxPersonas,
                        minNoches = habitacion.minNoches,
                        precioAlta = habitacion.precioAlta,
                        precioBaja = habitacion.precioBaja,
                        PrecioMedia = habitacion.PrecioMedia,
                        fueraServicio = habitacion.fueraServicio
                    };

                    var HabitacionExiste = db.Habitacion.FirstOrDefault(c => c.numeroHabitacion == nuevaHabitacion.numeroHabitacion);
                    if (HabitacionExiste == null)
                    {
                        db.Habitacion.Add(nuevaHabitacion);
                    }
                    else
                    {
                        ModificarHabitacion(nuevaHabitacion);
                    }
                    db.SaveChanges();

                   
                }
                catch (DbEntityValidationException ex)
                {
                    // Manejar errores de validación de entidades
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
                    // Manejar errores de actualización de la base de datos
                    throw new Exception("Error al agregar la habitación: " + ex.InnerException?.Message ?? ex.Message);
                }
                catch (Exception ex)
                {
                    // Manejar otros errores
                    throw new Exception("Error al agregar la habitación: " + ex.Message);
                }
            }
        }

        public void AgregarTipoHabitacion(TipoHabitacion servicio)
        {
            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                try
                {
                    db.TipoHabitacion.Add(servicio);
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

        public void EliminarHabitacion(int numeroHabitacion)
        {
            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                try
                {
                    // Buscar la habitación por su número de habitación
                    var habitacionEliminar = db.Habitacion.FirstOrDefault(h => h.numeroHabitacion == numeroHabitacion) ?? throw new Exception("Habitación no encontrada.");

                    // Eliminar la habitación encontrada
                    db.Habitacion.Remove(habitacionEliminar);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar la habitación: " + ex.Message);
                }
            }
        }


        public void ModificarHabitacion(Habitacion habitacionModificar)
        {
            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                try
                {
                    var habitacionEncontrada = db.Habitacion.FirstOrDefault(h => h.numeroHabitacion == habitacionModificar.numeroHabitacion) ?? throw new Exception("Habitación no encontrada.");

                    habitacionEncontrada.numeroHabitacion = habitacionModificar.numeroHabitacion;
                    habitacionEncontrada.descripcion = habitacionModificar.descripcion;
                    habitacionEncontrada.tipoID = habitacionModificar.tipoID;
                    habitacionEncontrada.maxPersonas = habitacionModificar.maxPersonas;
                    habitacionEncontrada.minNoches = habitacionModificar.minNoches;
                    habitacionEncontrada.precioAlta = habitacionModificar.precioAlta;
                    habitacionEncontrada.PrecioMedia = habitacionModificar.PrecioMedia;
                    habitacionEncontrada.precioBaja = habitacionModificar.precioBaja;
                    habitacionEncontrada.fueraServicio = habitacionModificar.fueraServicio;
                    

                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al modificar la habitación: " + ex.Message);
                }
            }
        }

        public List<TipoHabitacion> ObtenerTiposDeHabitacion()
        {
            using (var dbHotelSQLEntities = new dbHotelSQLEntities())
            {
                return dbHotelSQLEntities.TipoHabitacion.ToList();
            }
        }

    }
}
