using Microsoft.VisualBasic.FileIO;
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
using System.IO;
using System.Drawing;

namespace Producto_2.Vista
{
    public partial class FrmHabitaciones : Form
    {
        private readonly HabitacionesControlador controlador = new HabitacionesControlador();
        public FrmHabitaciones()
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
            grpListadoHabitaciones.Visible = false;
            grpDatosHabitacion.Visible = false;

        }
        private void FrmHabitaciones_Load(object sender, EventArgs e)
        {
            grpListadoHabitaciones.Visible = true;
            grpDatosHabitacion.Visible = false;

            // Configurar el DataGridView para auto generar las columnas
            dbGridHabitacion.AutoGenerateColumns = true;

            // Asignar el origen de datos al DataGridView
            dbGridHabitacion.DataSource = controlador.ObtenerHabitaciones();

            List<TipoHabitacion> tipoHabitacion = controlador.ObtenerTiposDeHabitacion();

            comboBoxTipoHab.DataSource = tipoHabitacion;
            comboBoxTipoHab.DisplayMember = "TipoID"; 
            comboBoxTipoHab.ValueMember = "TipoID";

            ConfigurarColumnaCheckBox("fueraServicio");
            txtBuscarHabitacion.Text = "Habitación a buscar...";
            if (txtBuscarHabitacion.Text == "Habitación a buscar...") { txtBuscarHabitacion.Font = new Font(txtBuscarHabitacion.Font, FontStyle.Italic); }
            else { txtBuscarHabitacion.Font = new Font(txtBuscarHabitacion.Font, FontStyle.Regular); }

        }
        private void ConfigurarColumnaCheckBox(string nombreColumna)
        {
            DataGridViewCheckBoxColumn checkBoxColumn = dbGridHabitacion.Columns[nombreColumna] as DataGridViewCheckBoxColumn;

            if (checkBoxColumn != null)
            {
                checkBoxColumn.TrueValue = true;
                checkBoxColumn.FalseValue = false;
                checkBoxColumn.ThreeState = false;
                checkBoxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void LimpiarForm()
        {
            textBoxNumHabitacion.Text = string.Empty;
            textBoxDescripcion.Text = string.Empty;
            comboBoxTipoHab.Text = string.Empty;
            numericUpDownMaxPersonas.Value = 0;
            numericUpDownMinNoches.Value = 0;
            numUpDownPvPxNocheTBaja.Value = 0;
            numUpDownPvPxNocheTMedia.Value = 0;
            numUpDownPvPxNocheTAlta.Value = 0; 
            checkFueraDeServicio.Checked = false;
        }

        private void txtBuscarHabitacion_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtBuscarHabitacion_Click(object sender, EventArgs e)
        {
            txtBuscarHabitacion.Text = string.Empty;
            if (txtBuscarHabitacion.Text == "Habitación a buscar...") { txtBuscarHabitacion.Font = new Font(txtBuscarHabitacion.Font, FontStyle.Italic); }
            else { txtBuscarHabitacion.Font = new Font(txtBuscarHabitacion.Font, FontStyle.Regular); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbGridHabitacion.DataSource = controlador.BuscarHabitacionPorNumero(txtBuscarHabitacion.Text);
         
        }

        private void dbGridHabitacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            grpListadoHabitaciones.Visible = true;
            grpDatosHabitacion.Visible = false;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dbGridHabitacion.Rows[e.RowIndex];

                textBoxNumHabitacion.Text = row.Cells["numeroHabitacion"].Value?.ToString() ?? "";
                textBoxDescripcion.Text = row.Cells["descripcion"].Value?.ToString();

                comboBoxTipoHab.Text = row.Cells["tipoHabitacion"].Value?.ToString() ?? "";
                numericUpDownMaxPersonas.Value = Convert.ToDecimal(row.Cells["maxPersonas"]?.Value ?? 0);

                numericUpDownMinNoches.Value = Convert.ToDecimal(row.Cells["minNoches"]?.Value ?? 0);
                checkFueraDeServicio.Checked = Convert.ToBoolean(row.Cells["fueraServicio"]?.Value ?? false);

                numUpDownPvPxNocheTBaja.Value = Convert.ToDecimal(row.Cells["precioBaja"]?.Value ?? 0);
                numUpDownPvPxNocheTMedia.Value = Convert.ToDecimal(row.Cells["precioMedia"]?.Value ?? 0);
                numUpDownPvPxNocheTAlta.Value = Convert.ToDecimal(row.Cells["precioAlta"]?.Value ?? 0);
            }
        }


        private void AddHabitacion_Click(object sender, EventArgs e)
        {
            // Crear una nueva instancia del formulario de datos
            Habitacion habitacion = new Habitacion();

            grpDatosHabitacion.Visible = true;
            grpListadoHabitaciones.Visible = false;

        }

        private void BtnModificarHabitacion_Click(object sender, EventArgs e)
        {
            if (dbGridHabitacion.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dbGridHabitacion.SelectedRows[0];
                int numeroHabitacion = Convert.ToInt32(selectedRow.Cells["numeroHabitacion"].Value.ToString());

                // Asignar los valores al formulario de datos
                textBoxNumHabitacion.Text = selectedRow.Cells["numeroHabitacion"].Value?.ToString() ?? "";
                textBoxDescripcion.Text = selectedRow.Cells["descripcion"].Value?.ToString();

                comboBoxTipoHab.Text = selectedRow.Cells["tipoID"].Value?.ToString() ?? "";
                numericUpDownMaxPersonas.Value = Convert.ToDecimal(selectedRow.Cells["maxPersonas"]?.Value ?? 0);

                numericUpDownMinNoches.Value = Convert.ToDecimal(selectedRow.Cells["minNoches"]?.Value ?? 0);
                checkFueraDeServicio.Checked = Convert.ToBoolean(selectedRow.Cells["fueraServicio"]?.Value ?? false);

                numUpDownPvPxNocheTBaja.Value = Convert.ToDecimal(selectedRow.Cells["precioBaja"]?.Value ?? 0);
                numUpDownPvPxNocheTMedia.Value = Convert.ToDecimal(selectedRow.Cells["precioMedia"]?.Value ?? 0);
                numUpDownPvPxNocheTAlta.Value = Convert.ToDecimal(selectedRow.Cells["precioAlta"]?.Value ?? 0);

                // Mostrar el formulario de datos y ocultar el de listado
                grpDatosHabitacion.Visible = true;
                grpListadoHabitaciones.Visible = false;
            }
            else
            {
                MessageBox.Show("Selecciona una habitación para actualizar.", "Datanerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void BtnEliminarHabitacion_Click(object sender, EventArgs e)
        {
            if (dbGridHabitacion.CurrentRow != null)
            {
                try
                {
                    int numeroHabitacionSeleccionado = int.Parse(dbGridHabitacion.CurrentRow.Cells["numeroHabitacion"].Value.ToString()); ;
                    controlador.EliminarHabitacion(numeroHabitacionSeleccionado);
                    MessageBox.Show("Datos eliminados con éxito!", "Datanerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dbGridHabitacion.DataSource = controlador.ObtenerHabitaciones();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la habitación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una habitación para eliminar.", "Datanerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void textBoxNumHabitacion_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxNumHabitacion.Text, out _))
            {
                MessageBox.Show("Por favor, ingrese solo números en el campo de número de habitación.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                textBoxNumHabitacion.Clear();
            }
        }

        private void comboBoxTipoHab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownMaxPersonas_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMinNocheTBaja_TextChanged(object sender, EventArgs e)
        {

        }

        private void numUpDownPvPxNocheTBaja_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numUpDownPvPxNocheTMedia_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numUpDownPvPxNocheTAlta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkCamaExtra_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkClienteVip_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkFueraDeServicio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarForm();
        }

        private void BtnGuardarHabitacion_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxNumHabitacion.Text, out int numeroHabitacion))
            {
                // Crear una nueva instancia de la clase Habitacion con los valores ingresados por el usuario
                var habitacion = new Habitacion
                {
                    numeroHabitacion = int.Parse(textBoxNumHabitacion.Text),
                    tipoID = (int)comboBoxTipoHab.SelectedValue,
                    descripcion = textBoxDescripcion.Text,
                    maxPersonas = (byte)numericUpDownMaxPersonas.Value,
                    minNoches = (byte)numericUpDownMinNoches.Value,
                    precioBaja = (double)numUpDownPvPxNocheTBaja.Value,
                    PrecioMedia = (double)numUpDownPvPxNocheTMedia.Value,
                    precioAlta = (double)numUpDownPvPxNocheTAlta.Value,
                    fueraServicio = checkFueraDeServicio.Checked ? (byte)1 : (byte)0,


                };

                try
                {
                    controlador.AgregarHabitacion(habitacion);

                    MessageBox.Show("Habitación añadida con éxito!", "Datanerds", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dbGridHabitacion.DataSource = controlador.ObtenerHabitaciones();

                    grpListadoHabitaciones.Visible = true;
                    grpDatosHabitacion.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar la habitación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            grpListadoHabitaciones.Visible = true;
            grpDatosHabitacion.Visible = false;
           
        }


        private void grpListadoHabitaciones_Enter(object sender, EventArgs e)
        {

        }

        private void grpDatosHabitacion_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDownMinNoches_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (dbGridHabitacion.SelectedRows.Count > 0)
            {
                int numeroHabitacion = int.Parse(textBoxNumHabitacion.Text);
                string descripcion = textBoxDescripcion.Text;
                int tipoID = (int)comboBoxTipoHab.SelectedValue; 
                byte maxPersonas = (byte)numericUpDownMaxPersonas.Value;
                byte minNoches = (byte)numericUpDownMinNoches.Value;
                double precioAlta = (double)numUpDownPvPxNocheTAlta.Value;
                double PrecioMedia = (double)numUpDownPvPxNocheTMedia.Value;
                double precioBaja = (double)numUpDownPvPxNocheTBaja.Value;
                byte fueraServicio = checkFueraDeServicio.Checked ? (byte)1 : (byte)0;

                
                Habitacion habitacionModificada = new Habitacion
                {
                    numeroHabitacion = numeroHabitacion,
                    descripcion = descripcion,
                    tipoID = tipoID,
                    maxPersonas = maxPersonas,
                    minNoches = minNoches,
                    precioAlta = precioAlta,
                    PrecioMedia = PrecioMedia,
                    precioBaja = precioBaja,
                    fueraServicio = fueraServicio
                };

                try
                {
                    controlador.ModificarHabitacion(habitacionModificada);

                    MessageBox.Show("Habitación modificada con éxito!", "Datanerds", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dbGridHabitacion.DataSource = controlador.ObtenerHabitaciones();

                    grpListadoHabitaciones.Visible = true;
                    grpDatosHabitacion.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar la habitación: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione una habitación para modificar.", "Datanerds", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       
    }
}
