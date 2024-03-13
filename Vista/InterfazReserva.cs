using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Producto_2.Controlador;
using Producto_2.Modelo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Producto_2.Vista
{
    public partial class InterfazReserva : Form
    {
        byte especial;
        private readonly ReservaControlador controlador = new ReservaControlador();
        private readonly ServiciosControlador11 controladorServ = new ServiciosControlador11();


        public InterfazReserva()
        {
            InitializeComponent();
            this.Move += new EventHandler(frm_Move);
        }
        private void frm_Move(Object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
        }
        public void limpiarBox() { 

            ServiciosLBox.Items.Clear();
        }

        /*Métodos de botones de navegación*/

        private void limpiarForm()
        {
            ReservaTXT.Text = "";
            NIFClienteTXT.Text = "";
            NPersonasTXT.Text = "";
            HabitacionCBox.Text = "";
            TipoPensionCB.Text = "";
            ServiciosLBox.Text = "";
            CHKFirm.Checked = false;
        }

        private void InterfazServicio_Load(object sender, EventArgs e)

        {
            controlador.cargarComboBox<Temporada>(TemporadaCbox, "descripcion", "temporadaID");
            controlador.cargarComboBox<Habitacion>(HabitacionCBox, "numeroHabitacion", "numeroHabitacion");
            controlador.cargarComboBox<RegimenPension>(TipoPensionCB, "descripcion", "pensionID");

            foreach (Servicio serv in controladorServ.obtenerServicios()){ 
            
                lbListaServicios.Items.Add(serv.descripcion.ToString());
            }

        }

        public void cargarServicios(int ID,ListBox lb ){

            List<HistoricoServicios> serviciosList = controladorServ.historicoServicios().Where(s => s.reservaID == ID).ToList();
            

            lb.Items.Clear();
            foreach (var srv in serviciosList) { 
            
                Servicio servicio = controladorServ.obtenerServicios().Where(r=> r.idServicio == srv.idServicio).FirstOrDefault();
                lb.Items.Add(servicio.descripcion.ToString());
            }
            
        }

        public void ocultarGrupos()
        {
            grpReserva.Visible = false;

        }

        public void activarBtnMenu()
        {
          //  inicioBtn.Enabled = true;
           // ClientesBtn.Enabled = true;
            //reservasVtb.Enabled = true;
          //  habitacionesBtn.Enabled = true;
          //  SrvidioBtn.Enabled = true;
          //  facturasBtn.Enabled = true;
          //  incidenciasbtn.Enabled = true;
          //  Usuariosbtn.Enabled = true;
          //  ajustesbtn.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FacturarBT_Click(object sender, EventArgs e)
        {
            ocultarGrupos();
            activarBtnMenu();
            cerrarForm();
        }

        private void ClientesBtn_Click(object sender, EventArgs e)
        {
            ocultarGrupos();
            activarBtnMenu();
          //  Form2 form2 = new Form2();
           // form2.Show();
            cerrarForm();
        }

        private void reservasVtb_Click(object sender, EventArgs e)
        {
            ocultarGrupos();
            activarBtnMenu();
            limpiarForm();
            grpReserva.Visible = true;
          //  reservasVtb.Enabled = false;

        }

        private void habitacionesBtn_Click(object sender, EventArgs e)
        {
            ocultarGrupos();
            activarBtnMenu();

            cerrarForm();
        }

        private void SrvidioBtn_Click(object sender, EventArgs e)
        {
            ocultarGrupos();
            activarBtnMenu();
            cerrarForm();
        }

        private void facturasBtn_Click(object sender, EventArgs e)
        {
            ocultarGrupos();
            activarBtnMenu();
            cerrarForm();
        }

        private void incidenciasbtn_Click(object sender, EventArgs e)
        {
            ocultarGrupos();
            activarBtnMenu();
            cerrarForm();
        }

        private void Usuariosbtn_Click(object sender, EventArgs e)
        {
            ocultarGrupos();
            activarBtnMenu();
            //InterfazUsuario interfazUsuario = new InterfazUsuario();
          //  interfazUsuario.Show();
            cerrarForm();
        }

        private void ajustesbtn_Click(object sender, EventArgs e)
        {
            ocultarGrupos();
            activarBtnMenu();
            cerrarForm();
        }

        private void inicioBtn_Click(object sender, EventArgs e)
        {
            ocultarGrupos();
            activarBtnMenu();
            cerrarForm();
        }
        private void cerrarForm()
        {
            this.Close();
        }

        /* Métodos de cajas de texto o botones de acción*/

        private void ReservaTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClienteTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void NPersonasTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateIniTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateFinTXT_TextChanged(object sender, EventArgs e)
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

        

        private void PrecioTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrecioServiciosTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrecioPensionTXT_TextChanged(object sender, EventArgs e)
        {

        }

        private void PrecioHabitacionTXT_TextChanged(object sender, EventArgs e)
        {

        }
        private void calculodias() {
          
            TimeSpan diferencia = fechaSDTP.Value - fechaEDTP.Value;
            int diasDiferencia = (int)diferencia.TotalDays;

            DiasTXT.Text = diasDiferencia.ToString();
        }

        private void DiasLB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calendario_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void ContratarBT_Click(object sender, EventArgs e)
        {
            ContratarBT_Click(sender, e, TemporadaCbox);
        }

        private void ContratarBT_Click(object sender, EventArgs e, System.Windows.Forms.ComboBox temporadaCBox)
        {
            byte especial = CHKFirm.Checked ? (byte)1 : (byte)0;

            DateTime fechaEntrada = fechaEDTP.Value.Date;
            DateTime fechaSalida = fechaSDTP.Value.Date;

            Reservas reserva = new Reservas
            {
                NIF = NIFClienteTXT.Text,
                fechaEntrada = fechaEntrada,
                fechaSalida = fechaSalida,
                numeroHabitacion = Convert.ToInt32(HabitacionCBox.SelectedValue),
                temporadaID = Convert.ToInt32(temporadaCBox.SelectedValue),
                pensionID = Convert.ToInt32(TipoPensionCB.SelectedValue),
                firmado = especial
            };
            try
            {
                controlador.AgregarReserva(reserva);
                MessageBox.Show("Datos añadidos con éxito!", "Datanerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }

        private void MostrarReservaBT_Click(object sender, EventArgs e)
        {
            byte especial = CHKFirm.Checked ? (byte)1 : (byte)0;
            string Nreserva = ReservaTXT.Text;

            if (int.TryParse(Nreserva, out int ID))
            {
                List<Reservas> reservaEncontrada = controlador.BuscarReserva(ID);

                if (reservaEncontrada.Count > 0)
                {
                    Reservas reserva = reservaEncontrada[0];
                
                    ReservaTXT.Text = ID.ToString();
                    NIFClienteTXT.Text = reserva.NIF.ToString();
                    fechaEDTP.Value = reserva.fechaEntrada;
                    fechaSDTP.Value = reserva.fechaSalida;
                    TipoPensionCB.SelectedValue = reserva.pensionID;
                    HabitacionCBox.SelectedValue = reserva.numeroHabitacion;      
                    TemporadaCbox.SelectedValue = reserva.temporadaID;
                    CHKFirm.Checked = Convert.ToBoolean(reserva.firmado);
                    cargarServicios(ID, ServiciosLBox);

                }
                calculodias();
            }
            else
            {
                MessageBox.Show("El número de reserva ingresado no es válido. Por favor, ingresa un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ModificarReservaBT_Click(object sender, EventArgs e)
        {
            byte especial = CHKFirm.Checked ? (byte)1 : (byte)0;

            DateTime fechaEntrada = fechaEDTP.Value.Date;
            DateTime fechaSalida = fechaSDTP.Value.Date;
            int numeroHabitacion = Convert.ToInt32(HabitacionCBox.SelectedValue);
            int temporadaID = Convert.ToInt32(TemporadaCbox.SelectedValue);
            int reservaNum =Convert.ToInt32(ReservaTXT.Text);
            
            try
            {
                controlador.ActualizarReserva(reservaNum, especial,fechaEntrada,fechaSalida,NIFClienteTXT.Text,numeroHabitacion,temporadaID);
                MessageBox.Show("Datos añadidos con éxito!", "Datanerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void AnularReservaBT_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ReservaTXT.Text);
            try
            {
                controlador.EliminarReserva(id);

                MessageBox.Show("Datos eliminados con éxito!", "Datanerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarForm();
            }
            catch (Exception ex) { 
            MessageBox.Show(ex.Message);    
            }
        }

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void TemporadaCbox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            CHKFirm.Focus();

        }

        private void addServBT_Click(object sender, EventArgs e)
        {

            var selectedItem = lbListaServicios.SelectedItem;
            if (selectedItem != null)
            {
                string selectedDescription = selectedItem.ToString();
                Servicio list = controladorServ.obtenerServicios()
                    .FirstOrDefault(s => s.descripcion.Equals(selectedDescription, StringComparison.OrdinalIgnoreCase));

                if (list.idServicio != null && list.idServicio != 0)
                {

                    controlador.addServicio(Convert.ToInt32(list.idServicio), Convert.ToInt32(ReservaTXT.Text));
                    cargarServicios(Convert.ToInt32(ReservaTXT.Text), ServiciosLBox);
                }
                else {
                    MessageBox.Show("EL servicio no es valido");
                }

            }  
        }

        private void lbListaServicios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CancelarBt_Click(object sender, EventArgs e)
        {
            mdiHotelSol mdiParent = this.MdiParent as mdiHotelSol;
            if (mdiParent != null)
            {

                mdiParent.abrirFomulario(typeof(Form7Reservas));
            }
            limpiarForm();
            this.Close();
        }
    }
}
