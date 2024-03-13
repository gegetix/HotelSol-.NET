using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Producto_2.Modelo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace Producto_2.Controlador
{
    public class ReservaControlador
    {
        public void cargarComboBox<T>(System.Windows.Forms.ComboBox comboBox,string nombreColumna,string nombreColumnaValor) where T:class
        {
            using (var db = new dbHotelSQLEntities()) { 
            
                var datos = db.Set<T>().ToList();
                
                comboBox.DataSource = datos;
                comboBox.DisplayMember = nombreColumna;
                comboBox.ValueMember = nombreColumnaValor;

               
            }
        }
        

        public List<Reservas> ObtenerReserva()
        {
            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                return db.Reservas.ToList();
            }
        }
        public List<Reservas> BuscarReserva(int ID)
        {

            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                return db.Reservas.Where(c => c.reservaID.Equals(ID)).ToList();
            }
        }
        public void AgregarReserva(Reservas reserva)
        {
            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                try
                {
                    var reservaExiste = db.Reservas.FirstOrDefault(c => c.reservaID == reserva.reservaID);
                    if (reservaExiste == null)
                    {
                        db.Reservas.Add(reserva);
                    }
                    else
                    {
                        ActualizarReserva(reserva.reservaID, reserva.firmado, Convert.ToDateTime(reserva.fechaEntrada),
                        Convert.ToDateTime(reserva.fechaSalida), reserva.NIF, Convert.ToInt32(reserva.numeroHabitacion),
                        Convert.ToInt32(reserva.temporadaID));
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
        public void EliminarReserva(int ID)
        {
            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                try
                {
                    var reservaEliminar = db.Reservas.FirstOrDefault(c => c.reservaID == ID);
                    if (reservaEliminar == null)
                    {
                        throw new Exception("Reserva no encontrada. ");
                    }

                    db.Reservas.Remove(reservaEliminar);
                    db.SaveChanges();

                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar la reserva: " + ex.Message);
                }
            }
        }
        public void ActualizarReserva(int ID, byte firmado, DateTime fechaEntrada, DateTime fechaSalida, string NIF, int numeroHabitacion, int temporadaID)
        {
            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                try
                {
                    var reservaActualizar = db.Reservas.FirstOrDefault(c => c.reservaID == ID);
                    if (reservaActualizar == null)
                    {
                        throw new Exception("Reserva no encontrado. ");
                    }
                    reservaActualizar.reservaID = ID;
                    reservaActualizar.firmado = firmado;
                    reservaActualizar.fechaEntrada = fechaEntrada;
                    reservaActualizar.fechaSalida = fechaSalida;
                    reservaActualizar.NIF = NIF;
                    reservaActualizar.numeroHabitacion = numeroHabitacion;
                    reservaActualizar.temporadaID = temporadaID;

                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al modificar la reserva: " + ex.Message);
                }
            }
        }

        public void addServicio(int idServicio, int idReserva)
        {

            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                
                try
                {
                    HistoricoServicios hist = new HistoricoServicios();
                    hist.reservaID = idReserva;
                    hist.idServicio = idServicio;
                    
                    db.HistoricoServicios.Add(hist);
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
                    throw new Exception("Error al agregar historicoServicio: " + ex.InnerException?.Message ?? ex.Message);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al agregar historicoServicio: " + ex.Message);
                }

            }

        }
    }

}
