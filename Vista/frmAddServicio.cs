using Producto_2.Controlador;
using Producto_2.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Producto_2.Vista
{
    public partial class frmAddServicio : Form
    {
        private readonly addServiciosControlador controlador = new addServiciosControlador();
        public frmAddServicio()
        {
            InitializeComponent();
            this.Move += new EventHandler(frm_Move);
        }
        private void frm_Move(Object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
        }
        private void limpiarForm() {

            descServicioTXT.Text = "";
            pAltaTXT.Text = "";
            pBajaTXT.Text = "";
            pMediaTXT.Text = "";
            dspAltaCB.Checked = false;
            dpMediaCB.Checked = false;
            dpBajaCB.Checked = false;
            porcentajeVipTB.Text = "";
            

        }

        private void guardarBT_Click(object sender, EventArgs e)
        {
            byte altaCB = dspAltaCB.Checked ? (byte)1 : (byte)0;
            byte mediaCB = dpMediaCB.Checked ? (byte)1 : (byte)0;
            byte bajaCB = dpBajaCB.Checked ? (byte)1 : (byte)0;



            Servicio servicio = new Servicio
            {
                idServicio = 1,
                descripcion = descServicioTXT.Text,
                precioAlta = Convert.ToDouble(pAltaTXT.Text),
                precioBaja = Convert.ToDouble(pBajaTXT.Text),
                precioMedia = Convert.ToDouble(pMediaTXT.Text),
                precioServicio = Convert.ToDouble(pMediaTXT.Text),
                permisoAlta = altaCB,
                permisoMedia =  mediaCB,
                permisoBaja = bajaCB,
                descVIP = Convert.ToDouble(porcentajeVipTB.Text)


            };
            try
            {
                controlador.AgregarServivio(servicio);
                MessageBox.Show("Datos añadidos con éxito!", "Datanerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MostrarSrvBT_Click(object sender, EventArgs e)
        {
            byte altaCB = dspAltaCB.Checked ? (byte)1 : (byte)0;
            byte mediaCB = dpMediaCB.Checked ? (byte)1 : (byte)0;
            byte bajaCB = dpBajaCB.Checked ? (byte)1 : (byte)0;


            string Nservicio = servTXT.Text;

            if (int.TryParse(Nservicio, out int ID))
            {
                List<Servicio> servicioEncontrado = controlador.BuscarServicio(ID);

                if (servicioEncontrado.Count > 0)
                {
                    Servicio servicio = servicioEncontrado[0];

                    servTXT.Text = ID.ToString();
                    descServicioTXT.Text = servicio.descripcion.ToString();   
                    pAltaTXT.Text = servicio.precioAlta.ToString();
                    pMediaTXT.Text = servicio.precioMedia.ToString();
                    pBajaTXT.Text = servicio.precioBaja.ToString();
                    dspAltaCB.Checked = Convert.ToBoolean(servicio.permisoAlta);
                    dpMediaCB.Checked = Convert.ToBoolean(servicio.permisoMedia);
                    dpBajaCB.Checked = Convert.ToBoolean(servicio.permisoBaja);
                    porcentajeVipTB.Text = servicio.descVIP.ToString();

                }
            }
            else
            {
                MessageBox.Show("El número de reserva ingresado no es válido. Por favor, ingresa un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AnularReservaBT_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(servTXT.Text);
            try
            {
                controlador.eliminarServicio(id);

                MessageBox.Show("Datos eliminados con éxito!", "Datanerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ModificarReservaBT_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(servTXT.Text);
            double precioAlta = Convert.ToDouble(pAltaTXT.Text);
            double precioBaja = Convert.ToDouble(pBajaTXT.Text);
            double precioMedia = Convert.ToDouble(pMediaTXT.Text);
            double VIP = Convert.ToDouble(porcentajeVipTB.Text);
            byte dAlta = Convert.ToByte(dspAltaCB.Checked);
            byte dMedia = Convert.ToByte(dpMediaCB.Checked);
            byte dBaja = Convert.ToByte(dpBajaCB.Checked);

            try
            {
                controlador.modificarServicio(ID, descServicioTXT.Text, precioAlta, precioMedia, precioBaja, dAlta, dMedia, dBaja, VIP);
                MessageBox.Show("Datos modificados con éxito!", "Datanerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarForm();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void frmAddServicio_Load(object sender, EventArgs e)
        {

           
        }

        private void CancelarBt_Click(object sender, EventArgs e)
        {
            mdiHotelSol mdiParent = this.MdiParent as mdiHotelSol;
            if (mdiParent != null)
            {

                mdiParent.abrirFomulario(typeof(FormServicios11));
            }
            limpiarForm();
            this.Close();
        }
    }

}
