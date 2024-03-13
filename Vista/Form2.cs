using Producto_2.Controlador;
using Producto_2.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Windows.Forms;




namespace Producto_2.Vista
{
    public partial class Form2 : Form
    {
        byte especial;
        private readonly ClienteControlador controlador = new ClienteControlador();
        public Form2()
        {
            InitializeComponent();
        }

        

        public void ocultarGrupos()
        {
            grpClientes.Visible = false;

        }

        public void activarBtnMenu()
        {
            ClientesBtn.Enabled = true;
            Usuariosbtn.Enabled = true;
            ajustesbtn.Enabled = true;
        }

        private void limpiarForm()
        {
            textBoxNIF.Text = "";
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            textBoxTelefono.Text = "";
            textBoxMail.Text = "";
            chkVIP.Checked = false;
        }

        private void addCliente_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nombre = txtBuscarCli.Text;
            var clientes = controlador.BuscarClientesPorNombre(nombre); 
            dbGrid.DataSource = clientes;
            txtBuscarCli.Text = "Cliente a buscar...";

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ocultarGrupos();
            try
            {

                dbGrid.DataSource = controlador.ObtenerClientes();
                dbGrid.Columns[6].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los clientes: " + ex.Message);
            }

        }

        private void txtBuscarCli_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscarCli_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ClientesBtn_Click(object sender, EventArgs e)
        {
            ocultarGrupos();
            activarBtnMenu();
            grpClientes.Visible = true;
            ClientesBtn.Enabled = false;
        }

        private void Usuariosbtn_Click(object sender, EventArgs e)
        {
            ocultarGrupos();
            activarBtnMenu();

            Usuariosbtn.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ajustesbtn_Click(object sender, EventArgs e)
        {
            ocultarGrupos();
            activarBtnMenu();

            ajustesbtn.Enabled = false;
        }

        private void Usuariosbtn_Click_1(object sender, EventArgs e)
        {
            ocultarGrupos();
            activarBtnMenu();

            Usuariosbtn.Enabled = false;
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
                    dbGrid.DataSource= controlador.ObtenerClientes();   
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el cliente: " + ex.Message);
                }

            }
        }

        private void addCliente_Click_1(object sender, EventArgs e)
        {
            byte especial = chkVIP.Checked ? (byte)1 : (byte)0;

            var cliente = new Clientes
            {
                NIF = textBoxNIF.Text,
                nombre = textBoxNombre.Text,
                apellidos = textBoxApellido.Text,
                telefono = textBoxTelefono.Text,
                email = textBoxMail.Text,
                VIP = especial
            };

            try
            {
                controlador.AgregarCliente(cliente);
                MessageBox.Show("Datos añadidos con exito!", "Datanerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiarForm();
                dbGrid.DataSource = controlador.ObtenerClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 

        private void modClienteBtn_Click(object sender, EventArgs e) {
            if (dbGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dbGrid.SelectedRows[0];
                String Nif = selectedRow.Cells["NIF"].Value.ToString();

                byte vipValue = chkVIP.Checked ? (byte)1 : (byte)0;

                try
                {
                    controlador.ActualizarCliente(
                        Nif,
                        textBoxNombre.Text,
                        textBoxApellido.Text,
                        textBoxMail.Text,
                        textBoxTelefono.Text,
                        vipValue
                        );
                    MessageBox.Show("Datos Actualizados con exito.", "Datanerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dbGrid.DataSource = controlador.ObtenerClientes();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selecciona un cliente para actualizar.", "Datanerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dbGrid_CellClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dbGrid.Rows[e.RowIndex];
                    textBoxNIF.Text = row.Cells["NIF"].Value?.ToString();
                    textBoxNombre.Text = row.Cells["nombre"].Value?.ToString();
                    textBoxApellido.Text = row.Cells["apellidos"].Value?.ToString();
                    textBoxMail.Text = row.Cells["email"].Value?.ToString();
                    textBoxTelefono.Text = row.Cells["telefono"].Value?.ToString();

                    try
                    {

                        byte vipValue = Convert.ToByte(row.Cells["VIP"].Value);
                        chkVIP.Checked = vipValue == 1;
                    }
                    catch
                    {
                        chkVIP.Checked = false;
                    }

                }
            }

        private void txtBuscarCli_Enter(object sender, EventArgs e)
            {
                txtBuscarCli.Text = "";
            }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            dbGrid.DataSource = controlador.ObtenerClientes();
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dbGrid.DataSource = controlador.BuscarClientesPorNombre(txtBuscarCli.Text);
            txtBuscarCli.Text = "Cliente a buscar...";
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML Files (*.xml)|*.xml";
            saveFileDialog.DefaultExt = "xml";
            saveFileDialog.AddExtension = true;
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = saveFileDialog.FileName;
                List<Clientes> listaClientes = controlador.ObtenerClientes();
                controlador.ExportarClientesAXML(listaClientes, rutaArchivo);
                MessageBox.Show("Datos exportados con éxito!");

            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files (*.xml)|*.xml";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaArchivo = openFileDialog.FileName;
                List<Clientes> listaClientesImportados = controlador.ImportarXML(rutaArchivo);

                foreach (var cliente in listaClientesImportados)
                {
                    try
                    {
                        controlador.AgregarCliente(cliente);
                    } 
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error al agregar el cliente: " + ex.Message);
                    }
                }
                MessageBox.Show("Datos importados y agregados con éxito!");
                dbGrid.DataSource = controlador.ObtenerClientes();
            }

        }
    }       
}




