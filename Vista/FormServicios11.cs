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
    public partial class FormServicios11 : Form
    {
        private readonly ServiciosControlador11 servicios = new ServiciosControlador11();
        public FormServicios11()
        {
            InitializeComponent();
            this.Move += new EventHandler(frm_Move);
        }
        private void frm_Move(Object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
        }
        private void FormServicios11_Load(object sender, EventArgs e)
        {

            serviciosDG.DataSource = servicios.obtenerServicios();
            serviciosDG.Columns["precioServicio"].Visible = false;


            serviciosDG.Columns["tipoServicioID"].HeaderText = " ";

            serviciosDG.Columns["idServicio"].HeaderText = " ";
            serviciosDG.Columns["idServicio"].Width = 40;

            serviciosDG.Columns["precioAlta"].HeaderText = "Alta";
            serviciosDG.Columns["precioAlta"].Width =70;
            serviciosDG.Columns["precioMedia"].HeaderText = "Media";
            serviciosDG.Columns["precioMedia"].Width = 70;
            serviciosDG.Columns["precioBaja"].HeaderText = "Baja";
            serviciosDG.Columns["precioBaja"].Width = 70;

            serviciosDG.Columns["permisoAlta"].HeaderText = "Alta";
            serviciosDG.Columns["permisoAlta"].Width = 70;
            serviciosDG.Columns["permisoMedia"].HeaderText = "Media";
            serviciosDG.Columns["permisoMedia"].Width = 70;
            serviciosDG.Columns["permisoBaja"].HeaderText = "Baja";
            serviciosDG.Columns["permisoBaja"].Width = 70;

            serviciosDG.Columns["descVIP"].HeaderText = " ";
            serviciosDG.Columns["descVIP"].Width = 60;

        }

        private void addServiceBTN_Click(object sender, EventArgs e)
        {
            frmAddServicio addServ  = new frmAddServicio();
            addServ.MdiParent = this.MdiParent;
            addServ.Show();
            this.Close();
        }
    }
}
