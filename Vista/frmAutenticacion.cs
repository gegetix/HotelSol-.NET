using Producto_2.Controlador;
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
    public partial class frmAutenticacion : Form
    {
        
        public frmAutenticacion()
        { 
            InitializeComponent();
            
            this.Move += new EventHandler(frm_Move);
            grpUsuariosInicio.Visible = true;
            grpAltaUsuario.Visible = false;
            

        }

        private UtenticacionControlador autControler = new UtenticacionControlador();
        
        private void frm_Move (Object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
        }
        private void frmAutenticacion_Load(object sender, EventArgs e)
        {

           
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text;
            string password = txtPass.Text;

            var mdiHotelSol = this.MdiParent as mdiHotelSol;

            if (autControler.inicioSesion(nombreUsuario, password))
            {
                MessageBox.Show("Te has logueado con exito");
                mdiHotelSol.HabilitarBoton();
                mdiHotelSol.abrirFomulario(typeof(Form7Reservas));
                this.Close();
                
                
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtNuevo_Click(object sender, EventArgs e)
        {
            String nombreUsuario = txtUsuario.Text;
            String password = txtPass.Text;

           if (nombreUsuario == "admin" && password == "admin")
            {
                grpAltaUsuario.Visible = true;
                grpUsuariosInicio.Visible = false;

            }
            else
            {
                MessageBox.Show("Acceso denegado. Debes ser administrador para accede.");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombreUsu = txtNuevoUsu.Text;
            string pass = txtNuevaPass.Text;
            autControler.AgregarUsuario(nombreUsu,pass);
            MessageBox.Show("Usuario agregado con exito");
            txtNuevaPass.Text = string.Empty;
            txtPass.Text = string.Empty;
            txtNuevoUsu.Text = string.Empty;
            txtUsuario.Text = string.Empty;
            grpUsuariosInicio.Visible = true;
            grpAltaUsuario.Visible = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            grpAltaUsuario.Visible = false;
            grpUsuariosInicio.Visible = true;
           
        }
    }
}
