namespace Producto_2.Vista
{
    partial class FormServicios11
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
            this.grpClientes = new System.Windows.Forms.GroupBox();
            this.addServiceBTN = new System.Windows.Forms.Button();
            this.serviciosDG = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TEMPORADA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MEDIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAJA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ALTA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioNocheG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dscVipG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.servicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoServicioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grpClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviciosDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoServicioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grpClientes
            // 
            this.grpClientes.Controls.Add(this.addServiceBTN);
            this.grpClientes.Controls.Add(this.serviciosDG);
            this.grpClientes.Controls.Add(this.dataGridView1);
            this.grpClientes.Location = new System.Drawing.Point(21, 43);
            this.grpClientes.Name = "grpClientes";
            this.grpClientes.Size = new System.Drawing.Size(778, 497);
            this.grpClientes.TabIndex = 29;
            this.grpClientes.TabStop = false;
            // 
            // addServiceBTN
            // 
            this.addServiceBTN.Location = new System.Drawing.Point(301, 353);
            this.addServiceBTN.Name = "addServiceBTN";
            this.addServiceBTN.Size = new System.Drawing.Size(197, 23);
            this.addServiceBTN.TabIndex = 2;
            this.addServiceBTN.Text = "Modificar servicio";
            this.addServiceBTN.UseVisualStyleBackColor = true;
            this.addServiceBTN.Click += new System.EventHandler(this.addServiceBTN_Click);
            // 
            // serviciosDG
            // 
            this.serviciosDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviciosDG.Location = new System.Drawing.Point(6, 44);
            this.serviciosDG.Name = "serviciosDG";
            this.serviciosDG.Size = new System.Drawing.Size(766, 281);
            this.serviciosDG.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TEMPORADA,
            this.MEDIA,
            this.BAJA,
            this.ALTA,
            this.precioNocheG,
            this.dscVipG});
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(766, 29);
            this.dataGridView1.TabIndex = 0;
            // 
            // TEMPORADA
            // 
            this.TEMPORADA.HeaderText = "ID";
            this.TEMPORADA.Name = "TEMPORADA";
            this.TEMPORADA.ReadOnly = true;
            this.TEMPORADA.Width = 40;
            // 
            // MEDIA
            // 
            this.MEDIA.HeaderText = "DESCRIPCION";
            this.MEDIA.Name = "MEDIA";
            this.MEDIA.ReadOnly = true;
            // 
            // BAJA
            // 
            this.BAJA.HeaderText = "TIPO";
            this.BAJA.Name = "BAJA";
            this.BAJA.ReadOnly = true;
            // 
            // ALTA
            // 
            this.ALTA.HeaderText = "PERMITIDO";
            this.ALTA.Name = "ALTA";
            this.ALTA.ReadOnly = true;
            this.ALTA.Width = 210;
            // 
            // precioNocheG
            // 
            this.precioNocheG.HeaderText = "PRECIO NOCHE";
            this.precioNocheG.Name = "precioNocheG";
            this.precioNocheG.ReadOnly = true;
            this.precioNocheG.Width = 210;
            // 
            // dscVipG
            // 
            this.dscVipG.HeaderText = "VIP";
            this.dscVipG.Name = "dscVipG";
            this.dscVipG.ReadOnly = true;
            this.dscVipG.Width = 60;
            // 
            // servicioBindingSource1
            // 
            this.servicioBindingSource1.DataMember = "Servicio";
            // 
            // servicioBindingSource
            // 
            this.servicioBindingSource.DataMember = "Servicio";
            // 
            // tipoServicioBindingSource
            // 
            this.tipoServicioBindingSource.DataMember = "TipoServicio";
            // 
            // FormServicios11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(820, 583);
            this.Controls.Add(this.grpClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormServicios11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FormServicios11";
            this.Load += new System.EventHandler(this.FormServicios11_Load);
            this.grpClientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serviciosDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoServicioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpClientes;
        private System.Windows.Forms.DataGridView serviciosDG;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tipoServicioBindingSource;
        private System.Windows.Forms.BindingSource servicioBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idServicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioAltaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioBajaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permisoAltaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permisoMediaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permisoBajaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descVIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button addServiceBTN;
        private System.Windows.Forms.BindingSource servicioBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEMPORADA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MEDIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAJA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ALTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioNocheG;
        private System.Windows.Forms.DataGridViewTextBoxColumn dscVipG;
    }
}