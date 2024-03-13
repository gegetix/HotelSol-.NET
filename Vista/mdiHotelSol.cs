using Producto_2.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Producto_2.Controlador;

namespace Producto_2.Vista
{
    public partial class mdiHotelSol : Form
    {
        private int childFormNumber = 0;

       

        public mdiHotelSol()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
           // this.DeshabilitarBoton();
           
           
        }

        //Evita abrir mas de una instacia de un formulario
        public void abrirFomulario(Type tipoForm)
        {
            var formulariosabiertos = this.MdiChildren.FirstOrDefault(f =>  f.GetType() == tipoForm);

            if (formulariosabiertos != null)
            {
                formulariosabiertos.BringToFront();
               
                formulariosabiertos.Close();
            }
            else
            {
                var formularioHijo = (Form)Activator.CreateInstance(tipoForm);

                formularioHijo.MdiParent = this;
               
                formularioHijo.Show();

            }
        }

        private void mdiHotelSol_Load(object sender, EventArgs e)
        {
            cerrarForms();
            abrirFomulario(typeof(frmAutenticacion));
            DeshabilitarBoton();
            
        }
       
        public void HabilitarBoton()
        {
            
            mnuClientes.Enabled = true;
            mnuReservas.Enabled = true;
            mnuHabitaciones.Enabled = true;
            mnuServicios.Enabled = true;
            mnuFacturas.Enabled = true;
            //mnuImportarXML.Enabled = true;
            //mnuExportarXML.Enabled = true;
            mnuImportarAOdoo.Enabled = true;
        }

        public void DeshabilitarBoton()
        {
           
            mnuClientes.Enabled = false;
            mnuReservas.Enabled = false;
            mnuHabitaciones.Enabled = false;
            mnuServicios.Enabled = false;
            mnuFacturas.Enabled = false;
           // mnuExportarXML.Enabled = false;
            //mnuImportarXML.Enabled = false;
            mnuImportarAOdoo.Enabled=false;
        }

        private void mnuFacturas_Click(object sender, EventArgs e)
        {
            cerrarForms();
            abrirFomulario(typeof(InterfazFacturas));
        }

        private void mnuClientes_Click(object sender, EventArgs e)
        {
            cerrarForms();
            abrirFomulario(typeof(frmCliente));
        }

        private void mnuReservas_Click(object sender, EventArgs e)
        {
            cerrarForms();
            abrirFomulario(typeof(Form7Reservas));
        }

        private void mnuHabitaciones_Click(object sender, EventArgs e)
        {
            cerrarForms();
            abrirFomulario(typeof(FrmHabitaciones));
        }

        private void mnuServicios_Click(object sender, EventArgs e)
        {
            
            abrirFomulario(typeof(FormServicios11));
        }

        private void cerrarForms()
        {
            
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }

        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnuImportarXML_Click(object sender, EventArgs e)
        {
            
            generadorXMLcontrolador gen =new generadorXMLcontrolador();
           gen.importarXML();
        }

        private void mnuExportarXML_Click(object sender, EventArgs e)
        {
            generadorXMLcontrolador gen = new generadorXMLcontrolador();
            gen.exportarXML();
        }

        private void mnuImportarAOdoo_Click(object sender, EventArgs e)
        {
            cerrarForms();
            abrirFomulario(typeof(frmExportarAOdoo));
        }
    }
}
