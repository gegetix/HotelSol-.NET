using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Producto_2.Controlador;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Producto_2.Modelo;
using Producto_2.Vista;
using System.Windows.Forms;

namespace Producto_2.Controlador
{
    public class FacturaControlador
    {
        private readonly ReservaControlador controladorR = new ReservaControlador();

        public List<Factura> ObtenerFactura()
        {
            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                return db.Factura.ToList();
            }
        }
        public List<Factura> BuscarFactura(int numeroFactura)
        {

            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                return db.Factura.Where(c => c.numeroFactura.Equals(numeroFactura)).ToList();
            }
        }
        public List<Factura> BuscarReservaEnFactura(int reservaEnFactura)
        {

            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                return db.Factura.Where(c => c.reservaID.Equals(reservaEnFactura)).ToList();
            }
        }
        public List<RegimenPension> BuscarRegimenPension(int pensionID)
        {

            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                return db.RegimenPension.Where(c => c.pensionID.Equals(pensionID)).ToList();
            }
        }
        public List<RegimenPension> BuscarRegimenesPension()
        {

            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                return db.RegimenPension.ToList();
            }
        }
        public List<HistoricoServicios> BuscarServiciosReserva(int reservaID)
        {

            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                return db.HistoricoServicios.Where(c => c.reservaID.Equals(reservaID)).ToList();
            }
        }
        public List<Clientes> ObtenerClienteNIF(String NIF)
        {
            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                return db.Clientes.Where(c => c.NIF.Equals(NIF)).ToList();
            }
        }
        public List<Servicio> ObtenerServicios()
        {

            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                return db.Servicio.ToList();
            }
        }
        public List<Temporada> ObtenerTemporadas()
        {
            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                return db.Temporada.ToList();
            }
        }
        public List<Habitacion> BuscarHabitacion(int numeroHabitacion)
        {

            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                return db.Habitacion.Where(c => c.numeroHabitacion.Equals(numeroHabitacion)).ToList();
            }
        }
        public void AgregarFactura(Factura factura)
        {
            int reservaEnFormulario = factura.reservaID;

            List<Factura> reservaFacturada = BuscarReservaEnFactura(reservaEnFormulario);
            List<Reservas> reservaEncontrada = controladorR.BuscarReserva(reservaEnFormulario);
            Reservas reservas = reservaEncontrada[0];

            if (reservas.firmado == 1)
            {

                if (reservaFacturada.Count > 0)
                {
                    MessageBox.Show("Esta reserva ya está facturada", "Datanerds", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    using (dbHotelSQLEntities db = new dbHotelSQLEntities())
                    {
                        try
                        {
                            db.Factura.Add(factura);
                            db.SaveChanges();
                            MessageBox.Show("Datos añadidos con éxito!", "Datanerds", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                            throw new Exception("Error al agregar factura: " + ex.InnerException?.Message ?? ex.Message);
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Error al agregar factura: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("La reserva no ha sido firmada por el Cliente. Proceda a solicitar la firma", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void addFactura(Factura factura)
        {
            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                try
                {
                    db.Factura.Add(factura);
                    db.SaveChanges();
                    MessageBox.Show("Datos añadidos con éxito!", "Datanerds", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                catch (DbUpdateException ex)
                {
                    throw new Exception("Error al agregar factura: " + ex.InnerException?.Message ?? ex.Message);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al agregar factura: " + ex.Message);
                }
            }
        }

        public void AgregarRegimen(RegimenPension servicio)
        {
            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                try
                {
                    db.RegimenPension.Add(servicio);
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
        public void AgregarTemporada(Temporada servicio)
        {
            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                try
                {
                    var TemporadaExiste = db.Temporada.FirstOrDefault(c => c.temporadaID == servicio.temporadaID);
                    if (TemporadaExiste == null)
                    {
                        db.Temporada.Add(servicio);
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
        public void EliminarFactura(int numeroFactura)
        {
            using (dbHotelSQLEntities db = new dbHotelSQLEntities())
            {
                try
                {
                    var facturaEliminar = db.Factura.FirstOrDefault(c => c.numeroFactura == numeroFactura);
                    if (facturaEliminar == null)
                    {
                        throw new Exception("Factura no encontrada. ");
                    }

                    db.Factura.Remove(facturaEliminar);
                    db.SaveChanges();

                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar la factura: " + ex.Message);
                }
            }
        }
        public void ActualizarFactura(int ID, byte firmado, DateTime fechaEntrada, DateTime fechaSalida, string NIF, int numeroHabitacion, int temporadaID)
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
        public void cargarComboBox<T>(System.Windows.Forms.ComboBox comboBox, string nombreColumna, string nombreColumnaValor) where T : class
        {
            using (var db = new dbHotelSQLEntities())
            {
                var datos = db.Set<T>().ToList();

                comboBox.DataSource = datos;
                comboBox.DisplayMember = nombreColumna;
                comboBox.ValueMember = nombreColumnaValor;
            }
        }
        public float PrecioDia(int reservaID)
        {
            float precioDia = 0f;

            List<Reservas> reservaEncontrada = controladorR.BuscarReserva(reservaID);

            if (reservaEncontrada.Count > 0)
            {
                Reservas reserva = reservaEncontrada[0];
                string nif = reserva.NIF;
                int NHabitacion = reserva.numeroHabitacion;
                List<Habitacion> HabitacionEncontrada = BuscarHabitacion(NHabitacion);
                Habitacion habitacion = HabitacionEncontrada[0];
                float descuento = 0.0f;

                if (saberSiVIP(nif))
                {

                    if (reserva.temporadaID == 1)
                    {
                        precioDia = (float)((habitacion.precioAlta) * 1.1f)*0.9f;
                    }
                    else if (reserva.temporadaID == 2)
                    {
                        precioDia = (float)(habitacion.PrecioMedia*0.9f);
                    }
                    else if (reserva.temporadaID == 3)
                    {
                        precioDia = (float)((habitacion.precioBaja) * 0.9f)*0.9f;
                    }
                    else
                    {
                        MessageBox.Show("Hay un error en la lectura de la temporada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                else
                {

                    if (reserva.temporadaID == 1)
                    {
                        precioDia = (float)(habitacion.precioAlta)*1.1f;
                    }
                    else if (reserva.temporadaID == 2)
                    {
                        precioDia = (float)(habitacion.PrecioMedia);
                    }
                    else if (reserva.temporadaID == 3)
                    {
                        precioDia = (float)(habitacion.precioBaja)*0.9f;
                    }
                    else
                    {
                        MessageBox.Show("Hay un error en la lectura de la temporada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }

            }
            else
            {
                MessageBox.Show("El número de reserva ingresado no es válido. Por favor, ingresa un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return precioDia;

        }
        public float PrecioServicio(int reservaID)
        {
            float precioServicio = 0f;
            int temporadaID = 0;
            int contador = 0;

            List<HistoricoServicios> serviciosEncontrados = BuscarServiciosReserva(reservaID);
            List<Reservas> reservaEncontrada = controladorR.BuscarReserva(reservaID);
            List<Servicio> servicios = ObtenerServicios();

            if (reservaEncontrada.Count > 0)
            {
                Reservas reserva = reservaEncontrada[0];
                String nif = reserva.NIF;
                float descuento = 0.0f;



                if (saberSiVIP(nif))
                {


                    foreach (HistoricoServicios NombreServicio in serviciosEncontrados)


                        if (reserva.temporadaID == 1)
                        {
                            Servicio servicioLista = servicios.FirstOrDefault(s => s.idServicio == NombreServicio.idServicio);
                            if (servicioLista != null)
                            {
                                precioServicio = (precioServicio + (float)servicioLista.precioAlta) * (float)(1 - servicioLista.descVIP);
                            }

                        }
                        else if (reserva.temporadaID == 2)
                        {
                            Servicio servicioLista = servicios.FirstOrDefault(s => s.idServicio == NombreServicio.idServicio);
                            if (servicioLista != null)
                            {
                                precioServicio = (precioServicio + (float)servicioLista.precioMedia) * (float)(1 - servicioLista.descVIP);
                            }
                        }
                        else if (reserva.temporadaID == 3)
                        {
                            Servicio servicioLista = servicios.FirstOrDefault(s => s.idServicio == NombreServicio.idServicio);
                            if (servicioLista != null)
                            {
                                precioServicio = (precioServicio + (float)servicioLista.precioBaja) * (float)(1 - servicioLista.descVIP);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Hay un error en la lectura de la temporada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                }
                else
                {

                    foreach (HistoricoServicios NombreServicio in serviciosEncontrados)


                        if (reserva.temporadaID == 1)
                        {
                            Servicio servicioLista = servicios.FirstOrDefault(s => s.idServicio == NombreServicio.idServicio);
                            if (servicioLista != null)
                            {
                                precioServicio = (precioServicio + (float)servicioLista.precioAlta);
                            }

                        }
                        else if (reserva.temporadaID == 2)
                        {
                            Servicio servicioLista = servicios.FirstOrDefault(s => s.idServicio == NombreServicio.idServicio);
                            if (servicioLista != null)
                            {
                                precioServicio = (precioServicio + (float)servicioLista.precioMedia);
                            }
                        }
                        else if (reserva.temporadaID == 3)
                        {
                            Servicio servicioLista = servicios.FirstOrDefault(s => s.idServicio == NombreServicio.idServicio);
                            if (servicioLista != null)
                            {
                                precioServicio = (precioServicio + (float)servicioLista.precioBaja);
                            }
                        }

                }

            }
            else
            {
                MessageBox.Show("El número de reserva ingresado no es válido. Por favor, ingresa un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




            return precioServicio;

        }
        public float calculoBaseImponible(float precioHabitacion, float precioPension, float precioServicios)
        {
            float BI = precioHabitacion + precioPension + precioServicios;
            return BI;
        }
        public float calculoIva(float BI)
        {
            float IVA = (BI * 0.21f);
            return IVA;
        }
        public float calculoImporte(float BI, float IVA)
        {
            float Importe = BI + IVA;
            return Importe;
        }
        public bool saberSiVIP(string NIF)
        {
            List<Clientes> clienteEncontrado = ObtenerClienteNIF(NIF);

            byte VIP = 0;

            if (clienteEncontrado.Count > 0)
            {
                Clientes cliente = clienteEncontrado[0];
                VIP = (byte)cliente.VIP;
            }
            else
            {
                MessageBox.Show("El número de reserva ingresado no es válido. Por favor, ingresa un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (VIP == 0)
            {
                return false;

            }
            else
            {

                return true;
            }
        }
    }


}