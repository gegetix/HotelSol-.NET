namespace Producto_2.Vista
{
    partial class FrmHabitaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpListadoHabitaciones = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnModificarHabitacion = new System.Windows.Forms.Button();
            this.BtnEliminarHabitacion = new System.Windows.Forms.Button();
            this.txtBuscarHabitacion = new System.Windows.Forms.TextBox();
            this.addHabitacion = new System.Windows.Forms.Button();
            this.dbGridHabitacion = new System.Windows.Forms.DataGridView();
            this.habitacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpDatosHabitacion = new System.Windows.Forms.GroupBox();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.numericUpDownMinNoches = new System.Windows.Forms.NumericUpDown();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.numericUpDownMaxPersonas = new System.Windows.Forms.NumericUpDown();
            this.checkFueraDeServicio = new System.Windows.Forms.CheckBox();
            this.numUpDownPvPxNocheTMedia = new System.Windows.Forms.NumericUpDown();
            this.numUpDownPvPxNocheTAlta = new System.Windows.Forms.NumericUpDown();
            this.numUpDownPvPxNocheTBaja = new System.Windows.Forms.NumericUpDown();
            this.labelPrecioNoche = new System.Windows.Forms.Label();
            this.labelTempMedia = new System.Windows.Forms.Label();
            this.labelTempAlta = new System.Windows.Forms.Label();
            this.comboBoxTipoHab = new System.Windows.Forms.ComboBox();
            this.labelTipoHabitacion = new System.Windows.Forms.Label();
            this.BtnGuardarHabitacion = new System.Windows.Forms.Button();
            this.labelMinNoches = new System.Windows.Forms.Label();
            this.labelTempBaja = new System.Windows.Forms.Label();
            this.labelMaxPersonas = new System.Windows.Forms.Label();
            this.LabelNumHabitacion = new System.Windows.Forms.Label();
            this.textBoxNumHabitacion = new System.Windows.Forms.TextBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.grpListadoHabitaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbGridHabitacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionBindingSource)).BeginInit();
            this.grpDatosHabitacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinNoches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxPersonas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPvPxNocheTMedia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPvPxNocheTAlta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPvPxNocheTBaja)).BeginInit();
            this.SuspendLayout();
            // 
            // grpListadoHabitaciones
            // 
            this.grpListadoHabitaciones.Controls.Add(this.button1);
            this.grpListadoHabitaciones.Controls.Add(this.BtnModificarHabitacion);
            this.grpListadoHabitaciones.Controls.Add(this.BtnEliminarHabitacion);
            this.grpListadoHabitaciones.Controls.Add(this.txtBuscarHabitacion);
            this.grpListadoHabitaciones.Controls.Add(this.addHabitacion);
            this.grpListadoHabitaciones.Controls.Add(this.dbGridHabitacion);
            this.grpListadoHabitaciones.Location = new System.Drawing.Point(70, 49);
            this.grpListadoHabitaciones.Name = "grpListadoHabitaciones";
            this.grpListadoHabitaciones.Size = new System.Drawing.Size(680, 484);
            this.grpListadoHabitaciones.TabIndex = 38;
            this.grpListadoHabitaciones.TabStop = false;
            this.grpListadoHabitaciones.Text = "Listado de habitaciones";
            this.grpListadoHabitaciones.Enter += new System.EventHandler(this.grpListadoHabitaciones_Enter);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Producto_2.Properties.Resources.lupa;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(262, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 47;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnModificarHabitacion
            // 
            this.BtnModificarHabitacion.Location = new System.Drawing.Point(243, 414);
            this.BtnModificarHabitacion.Name = "BtnModificarHabitacion";
            this.BtnModificarHabitacion.Size = new System.Drawing.Size(180, 23);
            this.BtnModificarHabitacion.TabIndex = 44;
            this.BtnModificarHabitacion.Text = "Modificar Datos Habitación";
            this.BtnModificarHabitacion.UseVisualStyleBackColor = true;
            this.BtnModificarHabitacion.Click += new System.EventHandler(this.BtnModificarHabitacion_Click);
            // 
            // BtnEliminarHabitacion
            // 
            this.BtnEliminarHabitacion.Location = new System.Drawing.Point(450, 414);
            this.BtnEliminarHabitacion.Name = "BtnEliminarHabitacion";
            this.BtnEliminarHabitacion.Size = new System.Drawing.Size(180, 23);
            this.BtnEliminarHabitacion.TabIndex = 43;
            this.BtnEliminarHabitacion.Text = "Eliminar Habitación";
            this.BtnEliminarHabitacion.UseVisualStyleBackColor = true;
            this.BtnEliminarHabitacion.Click += new System.EventHandler(this.BtnEliminarHabitacion_Click);
            // 
            // txtBuscarHabitacion
            // 
            this.txtBuscarHabitacion.Location = new System.Drawing.Point(19, 62);
            this.txtBuscarHabitacion.Name = "txtBuscarHabitacion";
            this.txtBuscarHabitacion.Size = new System.Drawing.Size(237, 20);
            this.txtBuscarHabitacion.TabIndex = 32;
            this.txtBuscarHabitacion.Text = "Buscar Habitación...";
            this.txtBuscarHabitacion.TextChanged += new System.EventHandler(this.txtBuscarHabitacion_TextChanged);
            // 
            // addHabitacion
            // 
            this.addHabitacion.Location = new System.Drawing.Point(33, 414);
            this.addHabitacion.Name = "addHabitacion";
            this.addHabitacion.Size = new System.Drawing.Size(180, 23);
            this.addHabitacion.TabIndex = 29;
            this.addHabitacion.Text = "Nueva Habitación";
            this.addHabitacion.UseVisualStyleBackColor = true;
            this.addHabitacion.Click += new System.EventHandler(this.AddHabitacion_Click);
            // 
            // dbGridHabitacion
            // 
            this.dbGridHabitacion.AutoGenerateColumns = false;
            this.dbGridHabitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGridHabitacion.DataSource = this.habitacionBindingSource;
            this.dbGridHabitacion.Location = new System.Drawing.Point(19, 88);
            this.dbGridHabitacion.Name = "dbGridHabitacion";
            this.dbGridHabitacion.Size = new System.Drawing.Size(643, 320);
            this.dbGridHabitacion.TabIndex = 28;
            this.dbGridHabitacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbGridHabitacion_CellContentClick);
            // 
            // habitacionBindingSource
            // 
            this.habitacionBindingSource.DataMember = "Habitacion";
            // 
            // grpDatosHabitacion
            // 
            this.grpDatosHabitacion.Controls.Add(this.buttonModificar);
            this.grpDatosHabitacion.Controls.Add(this.label1);
            this.grpDatosHabitacion.Controls.Add(this.textBoxDescripcion);
            this.grpDatosHabitacion.Controls.Add(this.numericUpDownMinNoches);
            this.grpDatosHabitacion.Controls.Add(this.btnLimpiar);
            this.grpDatosHabitacion.Controls.Add(this.numericUpDownMaxPersonas);
            this.grpDatosHabitacion.Controls.Add(this.checkFueraDeServicio);
            this.grpDatosHabitacion.Controls.Add(this.numUpDownPvPxNocheTMedia);
            this.grpDatosHabitacion.Controls.Add(this.numUpDownPvPxNocheTAlta);
            this.grpDatosHabitacion.Controls.Add(this.numUpDownPvPxNocheTBaja);
            this.grpDatosHabitacion.Controls.Add(this.labelPrecioNoche);
            this.grpDatosHabitacion.Controls.Add(this.labelTempMedia);
            this.grpDatosHabitacion.Controls.Add(this.labelTempAlta);
            this.grpDatosHabitacion.Controls.Add(this.comboBoxTipoHab);
            this.grpDatosHabitacion.Controls.Add(this.labelTipoHabitacion);
            this.grpDatosHabitacion.Controls.Add(this.BtnGuardarHabitacion);
            this.grpDatosHabitacion.Controls.Add(this.labelMinNoches);
            this.grpDatosHabitacion.Controls.Add(this.labelTempBaja);
            this.grpDatosHabitacion.Controls.Add(this.labelMaxPersonas);
            this.grpDatosHabitacion.Controls.Add(this.LabelNumHabitacion);
            this.grpDatosHabitacion.Controls.Add(this.textBoxNumHabitacion);
            this.grpDatosHabitacion.Controls.Add(this.BtnCancelar);
            this.grpDatosHabitacion.Location = new System.Drawing.Point(70, 49);
            this.grpDatosHabitacion.Name = "grpDatosHabitacion";
            this.grpDatosHabitacion.Size = new System.Drawing.Size(680, 485);
            this.grpDatosHabitacion.TabIndex = 39;
            this.grpDatosHabitacion.TabStop = false;
            this.grpDatosHabitacion.Text = "Datos Habitacion";
            this.grpDatosHabitacion.Enter += new System.EventHandler(this.grpDatosHabitacion_Enter);
            // 
            // buttonModificar
            // 
            this.buttonModificar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonModificar.Location = new System.Drawing.Point(455, 231);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(152, 23);
            this.buttonModificar.TabIndex = 64;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = false;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Descripción";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(141, 139);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(95, 20);
            this.textBoxDescripcion.TabIndex = 62;
            this.textBoxDescripcion.TextChanged += new System.EventHandler(this.textBoxDescripcion_TextChanged);
            // 
            // numericUpDownMinNoches
            // 
            this.numericUpDownMinNoches.Location = new System.Drawing.Point(141, 263);
            this.numericUpDownMinNoches.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownMinNoches.Name = "numericUpDownMinNoches";
            this.numericUpDownMinNoches.Size = new System.Drawing.Size(95, 20);
            this.numericUpDownMinNoches.TabIndex = 61;
            this.numericUpDownMinNoches.ValueChanged += new System.EventHandler(this.numericUpDownMinNoches_ValueChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnLimpiar.Location = new System.Drawing.Point(455, 292);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(152, 23);
            this.btnLimpiar.TabIndex = 60;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // numericUpDownMaxPersonas
            // 
            this.numericUpDownMaxPersonas.Location = new System.Drawing.Point(141, 222);
            this.numericUpDownMaxPersonas.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownMaxPersonas.Name = "numericUpDownMaxPersonas";
            this.numericUpDownMaxPersonas.Size = new System.Drawing.Size(95, 20);
            this.numericUpDownMaxPersonas.TabIndex = 59;
            this.numericUpDownMaxPersonas.ValueChanged += new System.EventHandler(this.numericUpDownMaxPersonas_ValueChanged);
            // 
            // checkFueraDeServicio
            // 
            this.checkFueraDeServicio.AutoSize = true;
            this.checkFueraDeServicio.Location = new System.Drawing.Point(460, 84);
            this.checkFueraDeServicio.Name = "checkFueraDeServicio";
            this.checkFueraDeServicio.Size = new System.Drawing.Size(140, 17);
            this.checkFueraDeServicio.TabIndex = 57;
            this.checkFueraDeServicio.Text = "¿Está fuera de servicio?";
            this.checkFueraDeServicio.UseVisualStyleBackColor = true;
            this.checkFueraDeServicio.CheckedChanged += new System.EventHandler(this.checkFueraDeServicio_CheckedChanged);
            // 
            // numUpDownPvPxNocheTMedia
            // 
            this.numUpDownPvPxNocheTMedia.DecimalPlaces = 2;
            this.numUpDownPvPxNocheTMedia.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpDownPvPxNocheTMedia.Location = new System.Drawing.Point(243, 349);
            this.numUpDownPvPxNocheTMedia.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numUpDownPvPxNocheTMedia.Name = "numUpDownPvPxNocheTMedia";
            this.numUpDownPvPxNocheTMedia.Size = new System.Drawing.Size(85, 20);
            this.numUpDownPvPxNocheTMedia.TabIndex = 56;
            this.numUpDownPvPxNocheTMedia.ValueChanged += new System.EventHandler(this.numUpDownPvPxNocheTMedia_ValueChanged);
            // 
            // numUpDownPvPxNocheTAlta
            // 
            this.numUpDownPvPxNocheTAlta.DecimalPlaces = 2;
            this.numUpDownPvPxNocheTAlta.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpDownPvPxNocheTAlta.Location = new System.Drawing.Point(243, 384);
            this.numUpDownPvPxNocheTAlta.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numUpDownPvPxNocheTAlta.Name = "numUpDownPvPxNocheTAlta";
            this.numUpDownPvPxNocheTAlta.Size = new System.Drawing.Size(85, 20);
            this.numUpDownPvPxNocheTAlta.TabIndex = 55;
            this.numUpDownPvPxNocheTAlta.ValueChanged += new System.EventHandler(this.numUpDownPvPxNocheTAlta_ValueChanged);
            // 
            // numUpDownPvPxNocheTBaja
            // 
            this.numUpDownPvPxNocheTBaja.DecimalPlaces = 2;
            this.numUpDownPvPxNocheTBaja.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpDownPvPxNocheTBaja.Location = new System.Drawing.Point(243, 314);
            this.numUpDownPvPxNocheTBaja.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numUpDownPvPxNocheTBaja.Name = "numUpDownPvPxNocheTBaja";
            this.numUpDownPvPxNocheTBaja.Size = new System.Drawing.Size(85, 20);
            this.numUpDownPvPxNocheTBaja.TabIndex = 54;
            this.numUpDownPvPxNocheTBaja.ValueChanged += new System.EventHandler(this.numUpDownPvPxNocheTBaja_ValueChanged);
            // 
            // labelPrecioNoche
            // 
            this.labelPrecioNoche.AutoSize = true;
            this.labelPrecioNoche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioNoche.Location = new System.Drawing.Point(28, 316);
            this.labelPrecioNoche.Name = "labelPrecioNoche";
            this.labelPrecioNoche.Size = new System.Drawing.Size(88, 13);
            this.labelPrecioNoche.TabIndex = 53;
            this.labelPrecioNoche.Text = "Precio por noche";
            // 
            // labelTempMedia
            // 
            this.labelTempMedia.AutoSize = true;
            this.labelTempMedia.Location = new System.Drawing.Point(138, 353);
            this.labelTempMedia.Name = "labelTempMedia";
            this.labelTempMedia.Size = new System.Drawing.Size(93, 13);
            this.labelTempMedia.TabIndex = 49;
            this.labelTempMedia.Text = "Temporada Media";
            // 
            // labelTempAlta
            // 
            this.labelTempAlta.AutoSize = true;
            this.labelTempAlta.Location = new System.Drawing.Point(138, 390);
            this.labelTempAlta.Name = "labelTempAlta";
            this.labelTempAlta.Size = new System.Drawing.Size(82, 13);
            this.labelTempAlta.TabIndex = 48;
            this.labelTempAlta.Text = "Temporada Alta";
            // 
            // comboBoxTipoHab
            // 
            this.comboBoxTipoHab.FormattingEnabled = true;
            this.comboBoxTipoHab.Location = new System.Drawing.Point(141, 180);
            this.comboBoxTipoHab.Name = "comboBoxTipoHab";
            this.comboBoxTipoHab.Size = new System.Drawing.Size(95, 21);
            this.comboBoxTipoHab.TabIndex = 47;
            this.comboBoxTipoHab.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoHab_SelectedIndexChanged);
            // 
            // labelTipoHabitacion
            // 
            this.labelTipoHabitacion.AutoSize = true;
            this.labelTipoHabitacion.Location = new System.Drawing.Point(28, 184);
            this.labelTipoHabitacion.Name = "labelTipoHabitacion";
            this.labelTipoHabitacion.Size = new System.Drawing.Size(82, 13);
            this.labelTipoHabitacion.TabIndex = 45;
            this.labelTipoHabitacion.Text = "Tipo Habitación";
            // 
            // BtnGuardarHabitacion
            // 
            this.BtnGuardarHabitacion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnGuardarHabitacion.Location = new System.Drawing.Point(455, 170);
            this.BtnGuardarHabitacion.Name = "BtnGuardarHabitacion";
            this.BtnGuardarHabitacion.Size = new System.Drawing.Size(152, 23);
            this.BtnGuardarHabitacion.TabIndex = 44;
            this.BtnGuardarHabitacion.Text = "Guardar";
            this.BtnGuardarHabitacion.UseVisualStyleBackColor = false;
            this.BtnGuardarHabitacion.Click += new System.EventHandler(this.BtnGuardarHabitacion_Click);
            // 
            // labelMinNoches
            // 
            this.labelMinNoches.AutoSize = true;
            this.labelMinNoches.Location = new System.Drawing.Point(28, 270);
            this.labelMinNoches.Name = "labelMinNoches";
            this.labelMinNoches.Size = new System.Drawing.Size(64, 13);
            this.labelMinNoches.TabIndex = 41;
            this.labelMinNoches.Text = "Min Noches";
            // 
            // labelTempBaja
            // 
            this.labelTempBaja.AutoSize = true;
            this.labelTempBaja.Location = new System.Drawing.Point(138, 316);
            this.labelTempBaja.Name = "labelTempBaja";
            this.labelTempBaja.Size = new System.Drawing.Size(85, 13);
            this.labelTempBaja.TabIndex = 39;
            this.labelTempBaja.Text = "Temporada Baja";
            // 
            // labelMaxPersonas
            // 
            this.labelMaxPersonas.AutoSize = true;
            this.labelMaxPersonas.Location = new System.Drawing.Point(28, 227);
            this.labelMaxPersonas.Name = "labelMaxPersonas";
            this.labelMaxPersonas.Size = new System.Drawing.Size(74, 13);
            this.labelMaxPersonas.TabIndex = 37;
            this.labelMaxPersonas.Text = "Max Personas";
            // 
            // LabelNumHabitacion
            // 
            this.LabelNumHabitacion.AutoSize = true;
            this.LabelNumHabitacion.Location = new System.Drawing.Point(28, 98);
            this.LabelNumHabitacion.Name = "LabelNumHabitacion";
            this.LabelNumHabitacion.Size = new System.Drawing.Size(73, 13);
            this.LabelNumHabitacion.TabIndex = 34;
            this.LabelNumHabitacion.Text = "Nº Habitación";
            // 
            // textBoxNumHabitacion
            // 
            this.textBoxNumHabitacion.Location = new System.Drawing.Point(141, 98);
            this.textBoxNumHabitacion.Name = "textBoxNumHabitacion";
            this.textBoxNumHabitacion.Size = new System.Drawing.Size(95, 20);
            this.textBoxNumHabitacion.TabIndex = 33;
            this.textBoxNumHabitacion.TextChanged += new System.EventHandler(this.textBoxNumHabitacion_TextChanged);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnCancelar.Location = new System.Drawing.Point(455, 353);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(152, 23);
            this.BtnCancelar.TabIndex = 29;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmHabitaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(820, 583);
            this.Controls.Add(this.grpDatosHabitacion);
            this.Controls.Add(this.grpListadoHabitaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHabitaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Habitaciones";
            this.Load += new System.EventHandler(this.FrmHabitaciones_Load);
            this.grpListadoHabitaciones.ResumeLayout(false);
            this.grpListadoHabitaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbGridHabitacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.habitacionBindingSource)).EndInit();
            this.grpDatosHabitacion.ResumeLayout(false);
            this.grpDatosHabitacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinNoches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxPersonas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPvPxNocheTMedia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPvPxNocheTAlta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownPvPxNocheTBaja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpListadoHabitaciones;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnModificarHabitacion;
        private System.Windows.Forms.Button BtnEliminarHabitacion;
        private System.Windows.Forms.TextBox txtBuscarHabitacion;
        private System.Windows.Forms.Button addHabitacion;
        private System.Windows.Forms.DataGridView dbGridHabitacion;
       // private HotelSQLDataSet hotelSQLDataSet;
        private System.Windows.Forms.BindingSource habitacionBindingSource;
        //private HotelSQLDataSetTableAdapters.HabitacionTableAdapter habitacionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroHabitacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoHabitacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox grpDatosHabitacion;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxPersonas;
        private System.Windows.Forms.CheckBox checkFueraDeServicio;
        private System.Windows.Forms.NumericUpDown numUpDownPvPxNocheTMedia;
        private System.Windows.Forms.NumericUpDown numUpDownPvPxNocheTAlta;
        private System.Windows.Forms.NumericUpDown numUpDownPvPxNocheTBaja;
        private System.Windows.Forms.Label labelPrecioNoche;
        private System.Windows.Forms.Label labelTempMedia;
        private System.Windows.Forms.Label labelTempAlta;
        private System.Windows.Forms.ComboBox comboBoxTipoHab;
        private System.Windows.Forms.Label labelTipoHabitacion;
        private System.Windows.Forms.Button BtnGuardarHabitacion;
        private System.Windows.Forms.Label labelMinNoches;
        private System.Windows.Forms.Label labelMaxPersonas;
        private System.Windows.Forms.Label LabelNumHabitacion;
        private System.Windows.Forms.TextBox textBoxNumHabitacion;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label labelTempBaja;
        private System.Windows.Forms.NumericUpDown numericUpDownMinNoches;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Button buttonModificar;
    }
}