using Microsoft.VisualBasic.FileIO;
using Producto_2.Controlador;
using Producto_2.Modelo;

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Validation;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;




namespace Producto_2.Vista
{
    public partial class frmCliente : Form
    {
        
        private readonly ClienteControlador controlador = new ClienteControlador();
        public frmCliente()
        {
            InitializeComponent();
            
            this.Move += new EventHandler(frm_Move);

        }

        private void frm_Move(Object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
        }

        public void ocultarGrupos()
        {
            grpClientes.Visible = false;
            
            grpClientesDatos.Visible = false;

        }

        
        private void limpiarForm()
        {
            textBoxNIF.Text = string.Empty;
            textBoxNombre.Text = string.Empty;
            textBoxApellido.Text = string.Empty;
            textBoxTelefono.Text = string.Empty;
            textBoxMail.Text = string.Empty;
            chkVIP.Checked = false;
            cmbPais.Text = string.Empty;
            cmbPrefijos.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtCiudad.Text = string.Empty;
            txtCP.Text = string.Empty;
            txtNomDom.Text = string.Empty;
            txtCuentaDom.Text = string.Empty;
            txtDetalles.Text = string.Empty;
            dtpFechaAltaDom.Value = DateTime.Now;
            dtpFechaNaci.Value = DateTime.Now;


        }


        private void frmCliente_Load(object sender, EventArgs e)
        {
            ocultarGrupos();
            try
            {
                grpClientes.Visible = true;
                dbGrid.DataSource = controlador.ObtenerClientes();
                //dbGrid.Columns[16].Visible = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message);
            }

            txtBuscarCli.Text = "Habitación a buscar...";
            if (txtBuscarCli.Text == "Habitación a buscar...") { txtBuscarCli.Font = new Font(txtBuscarCli.Font, FontStyle.Italic); }
            else { txtBuscarCli.Font = new Font(txtBuscarCli.Font, FontStyle.Regular); }

        }
      
        private void DbGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            grpClientesDatos.Visible = true;
            grpClientes.Visible = false;
            CargarComboBoxPrefijos();
            CargarComboBoxPaises();
            string Telefono;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dbGrid.Rows[e.RowIndex];
                
                textBoxNIF.Text = row.Cells["NIF"].Value?.ToString();
                textBoxNombre.Text = row.Cells["nombre"].Value?.ToString();
                textBoxApellido.Text = row.Cells["apellidos"].Value?.ToString();
                textBoxMail.Text = row.Cells["email"].Value?.ToString();
                Telefono = row.Cells["telefono"].Value?.ToString();
                string[] partes = Telefono.Split(new string[] {" - " }, StringSplitOptions.None);
                if (partes.Length >= 3)
                {
                    string prefijo = partes[0] + " - " + partes[1];
                    string numTel = partes[2];

                    cmbPrefijos.Text = prefijo;
                    textBoxTelefono.Text = numTel;
                }

                try
                {

                    byte vipValue = Convert.ToByte(row.Cells["VIP"].Value);
                    chkVIP.Checked = vipValue == 1;
                }
                catch
                {
                    chkVIP.Checked = false;
                }

                txtDireccion.Text = row.Cells["direccion"].Value?.ToString();
                txtCiudad.Text = row.Cells["ciudad"].Value?.ToString();
                txtCP.Text = row.Cells["cp"].Value?.ToString();
                cmbPais.Text = row.Cells["pais"].Value?.ToString();

                string fechaNacimiento = row.Cells["fechaN"].Value?.ToString();
                if (DateTime.TryParse(fechaNacimiento, out DateTime fechNac))
                {
                    dtpFechaNaci.Value = fechNac;
                }
                else
                {
                    dtpFechaNaci.Value = DateTime.Now;
                }
                
                txtDetalles.Text = row.Cells["detalle"].Value?.ToString();
                txtNomDom.Text = row.Cells["nombreCuenta"].Value?.ToString();
                txtCuentaDom.Text= row.Cells["numeroCuenta"].Value?.ToString();

                string fechaAltaDomStr = row.Cells["fechaAlta"].Value?.ToString();
                if (DateTime.TryParse(fechaAltaDomStr, out DateTime fechaAltaDom))
                {
                    dtpFechaAltaDom.Value = fechaAltaDom;
                }
                else
                {
                    dtpFechaAltaDom.Value = DateTime.Now;
                }
               

            }
        }

        private void txtBuscarCli_Enter(object sender, EventArgs e)
        {
            txtBuscarCli.Text = "";
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
           
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            

        }

        private void addCliente_Click(object sender, EventArgs e)
        {
            byte especial = chkVIP.Checked ? (byte)1 : (byte)0;

            var cliente = new Clientes
            {

                NIF = textBoxNIF.Text,
                nombre = textBoxNombre.Text,
                apellidos = textBoxApellido.Text,
                telefono = cmbPrefijos.Text + " - " + textBoxTelefono.Text ,
                email = textBoxMail.Text,
                VIP = especial,
                direccion = txtDireccion.Text,
                ciudad = txtCiudad.Text,    
                cp = int.Parse(txtCP.Text),
                pais = cmbPais.Text,
                fechaN = dtpFechaNaci.Value,
                detalle = txtDetalles.Text,
                nombreCuenta=txtNomDom.Text,
                numeroCuenta = txtCuentaDom.Text,
                fechaAlta = dtpFechaAltaDom.Value
                

            };

            try
            {
                controlador.AgregarCliente(cliente);
                MessageBox.Show("Datos añadidos con exito!", "Datanerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarForm();
                dbGrid.DataSource = controlador.ObtenerClientes();
                grpClientes.Visible = true;
                grpClientesDatos.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void delClienteBtn_Click(object sender, EventArgs e)
        {
            if (dbGrid.CurrentRow != null)
            {
                try
                {
                    string nifSeleccionado = dbGrid.CurrentRow.Cells["NIF"].Value.ToString();
                    controlador.EliminarCliente(nifSeleccionado);
                    MessageBox.Show("Datos eliminados con Exito!", "Datanerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dbGrid.DataSource = controlador.ObtenerClientes();
                    grpClientes.Visible = true;
                    grpClientesDatos.Visible=false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el cliente: " + ex.Message);
                }

            }
        }

        private void modClienteBtn_Click(object sender, EventArgs e)
        {
            
                string Nif = textBoxNIF.Text;
                string telfConPrefijo = cmbPrefijos.Text + " - " + textBoxTelefono.Text;
                int CP;
                int.TryParse(txtCP.Text, out CP);

                byte vipValue = chkVIP.Checked ? (byte)1 : (byte)0;

                try
                {
                    controlador.ActualizarCliente(
                        Nif,
                        textBoxNombre.Text,
                        textBoxApellido.Text,
                        textBoxMail.Text,
                        telfConPrefijo,
                        vipValue,
                        txtDireccion.Text,
                        txtCiudad.Text, 
                        CP,
                        cmbPais.Text,
                        dtpFechaNaci.Value,
                        txtDetalles.Text,
                        txtNomDom.Text,
                        txtCuentaDom.Text,
                        dtpFechaAltaDom.Value
                       
                        );
                    MessageBox.Show("Datos Actualizados con exito.", "Datanerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dbGrid.DataSource = controlador.ObtenerClientes();
                    limpiarForm();
                    grpClientes.Visible = true;
                    grpClientesDatos.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        private void btnBuscarCli_Click(object sender, EventArgs e)
        {
            dbGrid.DataSource = controlador.BuscarClientesPorNombre(txtBuscarCli.Text);
            txtBuscarCli.Text = "Cliente a buscar...";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            grpClientes.Visible = true;
            grpClientesDatos.Visible = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarForm();
        }
       
        private void CargarComboBoxPrefijos()
        {

            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "prefijos.csv");
            List<string> datosCombo = new List<string>();

            using (TextFieldParser parser = new TextFieldParser(filePath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();

                    if (fields.Length >= 2)
                    {
                        string columna1 = fields[4];
                        string columna2 = fields[5];

                        string elementoCombo = columna1 + " - " + columna2;
                        datosCombo.Add(elementoCombo);
                    }
                }
            }


            cmbPrefijos.Items.AddRange(datosCombo.ToArray());
        }

        private void CargarComboBoxPaises()
        {

            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Paises.csv");

            List<string> datosCombo = new List<string>();

            using (TextFieldParser parser = new TextFieldParser(filePath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();

                    if (fields.Length >= 2)
                    {
                        string columna1 = fields[1];


                        string elementoCombo = columna1;
                        datosCombo.Add(elementoCombo);
                    }
                }
            }


            cmbPais.Items.AddRange(datosCombo.ToArray());

        }

        private void cmbPrefijos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscarCli_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtBuscarCli_Click(object sender, EventArgs e)
        {
            txtBuscarCli.Text = "Habitación a buscar...";
            if (txtBuscarCli.Text == "Habitación a buscar...") { txtBuscarCli.Font = new Font(txtBuscarCli.Font, FontStyle.Italic); }
            else { txtBuscarCli.Font = new Font(txtBuscarCli.Font, FontStyle.Regular); }
        }
    }   

}




