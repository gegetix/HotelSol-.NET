using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Producto_2.Modelo;
using Producto_2.Controlador;


namespace Producto_2.Vista
{
    public partial class InterfazFacturas : Form
    {
        private readonly FacturaControlador controlador = new FacturaControlador();
        private readonly ReservaControlador controladorR = new ReservaControlador();
        private readonly HabitacionesControlador controladorH = new HabitacionesControlador();
 

        public InterfazFacturas()
        {
            InitializeComponent();
            this.Move += new EventHandler(frm_Move);
        }

        /*Métodos de botones de navegación*/
        private void frm_Move(Object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
        }
        private void InterfazFacturas_Load(object sender, EventArgs e)
        {
            controlador.cargarComboBox<Temporada>(TemporadaCBox, "descripcion", "temporadaID");
            controlador.cargarComboBox<Habitacion>(HabitacionCBox, "numeroHabitacion", "numeroHabitacion");
            controlador.cargarComboBox<RegimenPension>(TipoPensionCB, "descripcion", "pensionID");
            FacturaTXT.Text = "Rellenar solo Búsqueda";
            FacturaTXT.Text = "Rellenar solo Búsqueda";
            /*if (FacturaTXT.Text == "Rellenar solo Búsqueda") { FacturaTXT.Font = new Font(FacturaTXT.Font, FontStyle.Italic); }
            else { FacturaTXT.Font = new Font(FacturaTXT.Font, FontStyle.Regular); }
            ReservaTXT.Text = "Rellenar solo Búsqueda";
            if (ReservaTXT.Text == "Rellenar solo Búsqueda") { ReservaTXT.Font = new Font(ReservaTXT.Font, FontStyle.Italic); }
            else { ReservaTXT.Font = new Font(ReservaTXT.Font, FontStyle.Regular); }*/
        }

        private void limpiarForm()
        {
            FacturaTXT.Text = "";
            ReservaTXT.Text = "";
            fechaFacturaDP.Text = "";
            DNITXT.Text = "";
            NPersonasTXT.Text = "";
            DateIniTXT.Text = "";
            DateFinTXT.Text = "";
            NDiasTXT.Text = "";
            PrecioHabitacionTXT.Text = "";
            PrecioPensionTXT.Text = "";
            PrecioServiciosTXT.Text = "";
            BaseImponibleTXT.Text = "";
            ivatxt.Text = "";
            ImporteTotalTXT.Text = "";
            HabitacionCBox.Text = "";
            TipoPensionCB.Text = "";
            ServiciosLBox.Text = "";
            TemporadaCBox.Text = "";
            ServiciosLBox.Items.Clear();
        }

        

    



        /* Métodos de cajas de texto o botones de acción*/
        private void FacturaTXT_Click(object sender, EventArgs e)
        {
          FacturaTXT.Text = string.Empty;
           /* if (FacturaTXT.Text == "Rellenar solo Búsqueda") { FacturaTXT.Font = new Font(FacturaTXT.Font, FontStyle.Italic); }
            else { FacturaTXT.Font = new Font(FacturaTXT.Font, FontStyle.Regular); }*/
        }
        private void ReservaTXT_LostFocus(object sender, EventArgs e)
        {
          
          if (ReservaTXT.Text == String.Empty ) { ReservaTXT.Font = new Font(ReservaTXT.Font, FontStyle.Italic);
               ReservaTXT.Text = "Rellenar solo Búsqueda";
            }
            else { ReservaTXT.Font = new Font(ReservaTXT.Font, FontStyle.Regular); }
        }
        private void FacturaTXT_LostFocus(object sender, EventArgs e)
        {
         
            if (FacturaTXT.Text == String.Empty) { FacturaTXT.Font = new Font(FacturaTXT.Font, FontStyle.Italic);
                FacturaTXT.Text = "Rellenar solo Búsqueda";
            }
            else { FacturaTXT.Font = new Font(FacturaTXT.Font, FontStyle.Regular); }
        }

        private void ReservaTXT_Click(object sender, EventArgs e)
        {
           ReservaTXT.Text = string.Empty;
           /* if (ReservaTXT.Text == "Rellenar solo Búsqueda") { ReservaTXT.Font = new Font(ReservaTXT.Font, FontStyle.Italic); }
            else { ReservaTXT.Font = new Font(ReservaTXT.Font, FontStyle.Regular); }*/
        }

        private void NPersonasTXT_TextChanged(object sender, EventArgs e)
        {

        }


        private void HabitacionCBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TipoPensionCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ServiciosLBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TemporadaCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }


        private void DNITXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DateTime fechaEntrada = DateIniTXT.Value;
            DateTime fechaSalida = DateFinTXT.Value;

            if (fechaSalida >= fechaEntrada)
            {
                TimeSpan diferencia = fechaSalida - fechaEntrada;
                int diasDiferencia = (int)diferencia.TotalDays;

                NDiasTXT.Text = diasDiferencia.ToString();
            }
            else
            {
                NDiasTXT.Text = "Error: fechas inválidas";
            }
        }

        private void PrecioHabitacionTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrecioPensionTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrecioServiciosTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ivatxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ImporteTotalTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConfirmarFacturaBT_Click(object sender, EventArgs e)
        {


            DateTime fechaFactura = fechaFacturaDP.Value.Date;
            string numeroFacturaFormulario = FacturaTXT.Text;

            if (numeroFacturaFormulario != "")
            {
                MessageBox.Show("Borre el campo de Numero de Factura", "Datanerds", MessageBoxButtons.OK, MessageBoxIcon.Information);

            } else { 
                Factura factura = new Factura
                {
                    fechaFactura = fechaFactura,
                    precioTotal = Convert.ToDouble(ImporteTotalTXT.Text),
                    reservaID = Convert.ToInt32(ReservaTXT.Text),
                    idCliente = DNITXT.Text,
                };

                try
                {
                    controlador.AgregarFactura(factura);
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            limpiarForm();
        }

        private void MostrarFacturaBT_Click(object sender, EventArgs e)
        {

            string Nfactura = FacturaTXT.Text;

            if (int.TryParse(Nfactura, out int numeroFactura))
            {
                List<Factura> facturaEncontrada = controlador.BuscarFactura(numeroFactura);

                if (facturaEncontrada.Count > 0)
                {
                    Factura factura = facturaEncontrada[0];

                    int NReserva = factura.reservaID;

                    List<Reservas> reservaEncontrada = controladorR.BuscarReserva(NReserva);

                    if (reservaEncontrada.Count > 0)
                    {
                        Reservas reserva = reservaEncontrada[0];
                        int NHabitacion = reserva.numeroHabitacion;
                        int pensionID = reserva.pensionID;
                        double PVD = controlador.PrecioDia(reserva.reservaID);

                        List<Habitacion> habitacionEncontrada = controlador.BuscarHabitacion(NHabitacion);
                        List<RegimenPension> regimenEncontrado = controlador.BuscarRegimenPension(pensionID);
                        List<HistoricoServicios> serviciosEncontrados = controlador.BuscarServiciosReserva(NReserva);
                        List<Servicio> servicios = controlador.ObtenerServicios();

                        if (habitacionEncontrada.Count > 0 || regimenEncontrado.Count > 0)
                        {

                            Habitacion habitacion = habitacionEncontrada[0];
                            RegimenPension pension = regimenEncontrado[0];
                            float precioHabitacion = 0f;
                            float precioPension;
                            float precioServicios = 0f;

                            foreach (HistoricoServicios NombreServicio in serviciosEncontrados)
                            {

                                Servicio servicioLista = servicios.FirstOrDefault(s => s.idServicio == NombreServicio.idServicio);
                                if (servicioLista != null)
                                {
                                    ServiciosLBox.Items.Add(servicioLista.descripcion);
                                }

                                precioServicios = controlador.PrecioServicio(NReserva);
                            }

                            if (controlador.saberSiVIP(reserva.NIF))
                            {
                                ServiciosLBox.Items.Add("Se aplican descuentos").ToString();
                                ServiciosLBox.Items.Add("al Cliente VIP").ToString();
                                MessageBox.Show("El cliente es VIP. ", "Informe del descuento", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                            else
                            {

                                MessageBox.Show("El cliente es NO VIP. ", "Proponga hacerlo VIP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }



                            FacturaTXT.Text = numeroFactura.ToString();
                            ReservaTXT.Text = NReserva.ToString();
                            DNITXT.Text = factura.idCliente.ToString();
                            fechaFacturaDP.Text = factura.fechaFactura.ToString();
                            NPersonasTXT.Text = habitacion.tipoID.ToString();
                            DateIniTXT.Text = reserva.fechaEntrada.ToString();
                            DateFinTXT.Text = reserva.fechaSalida.ToString();
                            HabitacionCBox.SelectedValue = reserva.numeroHabitacion;
                            TemporadaCBox.SelectedValue = reserva.temporadaID;
                            TipoPensionCB.SelectedValue = reserva.pensionID;
                            DateIniTXT.TextChanged += textBox1_TextChanged;
                            DateFinTXT.TextChanged += textBox1_TextChanged;
                            precioHabitacion = (float)((PVD * habitacion.tipoID) * calculoDias());
                            precioPension = (float)(((pension.precio) * (habitacion.tipoID)) * calculoDias());
                            precioServicios = (precioServicios * calculoDias());
                            PrecioHabitacionTXT.Text = precioHabitacion.ToString();
                            PrecioServiciosTXT.Text = precioServicios.ToString();
                            PrecioPensionTXT.Text = precioPension.ToString();
                            float BaseImp = controlador.calculoBaseImponible(precioHabitacion, precioPension, precioServicios);
                            BaseImponibleTXT.Text = BaseImp.ToString();
                            float iva = controlador.calculoIva(BaseImp);
                            ivatxt.Text = iva.ToString();
                            float importe = controlador.calculoImporte(BaseImp, iva);
                            ImporteTotalTXT.Text = importe.ToString();
                        }

                    }

                }
                else
                {
                    MessageBox.Show("El número de factura ingresado no es válido. Por favor, ingresa un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpiarForm();
                }
            }
            else
            {
                MessageBox.Show("El número de factura ingresado no es válido. Por favor, ingresa un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiarForm();
            }
        }

        private void MostrarReserva_Click(object sender, EventArgs e)
        {

            string Nreserva = ReservaTXT.Text;

            if (int.TryParse(Nreserva, out int ID))
            {
                List<Reservas> reservaEncontrada = controladorR.BuscarReserva(ID);

                if (reservaEncontrada.Count > 0)
                {
                    Reservas reserva = reservaEncontrada[0];
                    int NHabitacion = reserva.numeroHabitacion;
                    int pensionID = reserva.pensionID;
                    List<Habitacion> habitacionEncontrada = controlador.BuscarHabitacion(NHabitacion);
                    List<RegimenPension> regimenEncontrado = controlador.BuscarRegimenPension(pensionID);
                    List<HistoricoServicios> serviciosEncontrados = controlador.BuscarServiciosReserva(ID);
                    List<Servicio> servicios = controlador.ObtenerServicios();
                    Habitacion habitacion = habitacionEncontrada[0];
                    RegimenPension pension = regimenEncontrado[0];
                    float PVD = controlador.PrecioDia(reserva.reservaID);
                    float precioHabitacion = 0f;
                    float precioPension = 0f;
                    float precioServicios = 0f;

                    foreach (HistoricoServicios NombreServicio in serviciosEncontrados)
                    {

                        Servicio servicioLista = servicios.FirstOrDefault(s => s.idServicio == NombreServicio.idServicio);
                        if (servicioLista != null)
                        {
                            ServiciosLBox.Items.Add(servicioLista.descripcion);
                        }

                        precioServicios = controlador.PrecioServicio(ID);
                    }

                    if (controlador.saberSiVIP(reserva.NIF))
                    {
                        ServiciosLBox.Items.Add("Se aplican descuentos").ToString();
                        ServiciosLBox.Items.Add("al Cliente VIP").ToString();
                        MessageBox.Show("El cliente es VIP. ", "Informe del descuento", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {

                        MessageBox.Show("El cliente es NO VIP. ", "Proponga hacerlo VIP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    ReservaTXT.Text = ID.ToString();
                    DNITXT.Text = reserva.NIF.ToString();
                    NPersonasTXT.Text = habitacion.tipoID.ToString();
                    DateIniTXT.Text = reserva.fechaEntrada.ToString();
                    DateFinTXT.Text = reserva.fechaSalida.ToString();
                    HabitacionCBox.SelectedValue = reserva.numeroHabitacion;
                    TipoPensionCB.SelectedValue = reserva.pensionID;
                    TemporadaCBox.SelectedValue = reserva.temporadaID;
                    DateIniTXT.ValueChanged += textBox1_TextChanged;
                    DateFinTXT.ValueChanged += textBox1_TextChanged;
                    precioHabitacion = (float)((PVD * (habitacion.tipoID)) * (calculoDias()));
                    precioPension = (float)(((pension.precio) * (habitacion.tipoID)) * (calculoDias()));
                    precioServicios = (precioServicios * calculoDias());
                    PrecioServiciosTXT.Text = precioServicios.ToString();
                    PrecioHabitacionTXT.Text = precioHabitacion.ToString();
                    PrecioPensionTXT.Text = precioPension.ToString();
                    float BaseImp = controlador.calculoBaseImponible(precioHabitacion, precioPension, precioServicios);
                    BaseImponibleTXT.Text = BaseImp.ToString();
                    float iva = controlador.calculoIva(BaseImp);
                    ivatxt.Text = iva.ToString();
                    float importe = controlador.calculoImporte(BaseImp, iva);
                    ImporteTotalTXT.Text = importe.ToString();
                }
                else
                {
                    MessageBox.Show("El número de reserva ingresado no es válido. Por favor, ingresa un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpiarForm();
                }
            }
            else
            {
                MessageBox.Show("El número de reserva ingresado no es válido. Por favor, ingresa un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                limpiarForm();
            }
        }

        private void AnularFacturaBT_Click(object sender, EventArgs e)
        {
            string Nfactura = FacturaTXT.Text;

            if (int.TryParse(Nfactura, out int numeroFactura))
            {
                List<Factura> facturaEncontrada = controlador.BuscarFactura(numeroFactura);

                if (facturaEncontrada.Count > 0)
                {
                    try
                    {
                        controlador.EliminarFactura(numeroFactura);
                        MessageBox.Show("Factura eliminada con Exito!", "Datanerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el cliente: " + ex.Message);
                    }
                }
            }

            limpiarForm();

        }

        private void CancelarBt_Click(object sender, EventArgs e)
        {
            limpiarForm();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void DateIniTXT_ValueChanged(object sender, EventArgs e)
        {

        }
        private void DateFinTXT_ValueChanged(object sender, EventArgs e)
        {

        }

        private int calculoDias()
        {
            DateTime fechaEntrada = DateIniTXT.Value;
            DateTime fechaSalida = DateFinTXT.Value;
            int diasDiferencia = 0;

            if (fechaSalida >= fechaEntrada)
            {
                TimeSpan diferencia = fechaSalida - fechaEntrada;
                diasDiferencia = (int)diferencia.TotalDays;

                NDiasTXT.Text = diasDiferencia.ToString();
                
            }
            else
            {
                NDiasTXT.Text = "Error: fechas inválidas";
            }
            return diasDiferencia;
        }

    }



}
