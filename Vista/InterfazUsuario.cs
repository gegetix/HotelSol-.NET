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

namespace Producto_2.Vista
{
    public partial class InterfazUsuario : Form
    {
        byte especial;
        private readonly UsuarioControlador controlador = new UsuarioControlador();
        public InterfazUsuario()
        {
            InitializeComponent();
        }

        private void InterfazUsuario_Load(object sender, EventArgs e)
        {
            ocultarGrupos();
            try
            {

  //              dbGrid.DataSource = controlador.ObtenerIncidencias();
                grpUsuario.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las Incidencias: " + ex.Message);
            }

        }
        public void ocultarGrupos()
        {
            grpUsuario.Visible = false;

        }

        public void activarBtnMenu()
        {
          //  inicioBtn.Enabled = true;
          //  ClientesBtn.Enabled = true;
          //  reservasVtb.Enabled = true;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void inicioBtn_Click(object sender, EventArgs e)
        {
            ocultarGrupos();
            activarBtnMenu();
            cerrarForm();
        }

        private void Usuariosbtn_Click(object sender, EventArgs e)
        {
            ocultarGrupos();
            activarBtnMenu();
            grpUsuario.Visible = true;
          //  Usuariosbtn.Enabled = false;
        }

        private void ClientesBtn_Click(object sender, EventArgs e)
        {
            ocultarGrupos();
            activarBtnMenu();
          //  Form2 form2 = new Form2();
           // form2.Show();
            cerrarForm();
        }

        private void facturasBtn_Click(object sender, EventArgs e)
        {
            ocultarGrupos();
            activarBtnMenu();
            cerrarForm();
        }

        private void reservasVtb_Click(object sender, EventArgs e)
        {
            ocultarGrupos();
            activarBtnMenu();
            InterfazReserva interfazReserva = new InterfazReserva();
            interfazReserva.Show();
            cerrarForm();
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

        private void incidenciasbtn_Click(object sender, EventArgs e)
        {
            ocultarGrupos();
            activarBtnMenu();
            cerrarForm();
        }

        private void ajustesbtn_Click(object sender, EventArgs e)
        {
            ocultarGrupos();
            activarBtnMenu();
            cerrarForm();
        }

        private void cambioContrasenaButton_Click(object sender, EventArgs e)
        {

        }
        private void cerrarForm()
        {
            this.Close();
        }
    }
}
