namespace Producto_2.Vista
{
    partial class frmExportarAOdoo
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
            this.grpExportar = new System.Windows.Forms.GroupBox();
            this.btnExportarAOdoo = new System.Windows.Forms.Button();
            this.cmbTables = new System.Windows.Forms.ComboBox();
            this.dbgTables = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnImportarDeOdoo = new System.Windows.Forms.Button();
            this.grpExportar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgTables)).BeginInit();
            this.SuspendLayout();
            // 
            // grpExportar
            // 
            this.grpExportar.Controls.Add(this.btnImportarDeOdoo);
            this.grpExportar.Controls.Add(this.btnExportarAOdoo);
            this.grpExportar.Controls.Add(this.cmbTables);
            this.grpExportar.Controls.Add(this.dbgTables);
            this.grpExportar.Location = new System.Drawing.Point(57, 85);
            this.grpExportar.Name = "grpExportar";
            this.grpExportar.Size = new System.Drawing.Size(706, 412);
            this.grpExportar.TabIndex = 0;
            this.grpExportar.TabStop = false;
            this.grpExportar.Text = "Exportar a Odoo";
            // 
            // btnExportarAOdoo
            // 
            this.btnExportarAOdoo.Location = new System.Drawing.Point(297, 339);
            this.btnExportarAOdoo.Name = "btnExportarAOdoo";
            this.btnExportarAOdoo.Size = new System.Drawing.Size(112, 23);
            this.btnExportarAOdoo.TabIndex = 5;
            this.btnExportarAOdoo.Text = "Exportar a Odoo";
            this.btnExportarAOdoo.UseVisualStyleBackColor = true;
            this.btnExportarAOdoo.Click += new System.EventHandler(this.btnExportarAOdoo_Click);
            // 
            // cmbTables
            // 
            this.cmbTables.FormattingEnabled = true;
            this.cmbTables.Items.AddRange(new object[] {
            "",
            "Clientes",
            "Reservas",
            "Habitacion",
            "Factura",
            "Servicio",
            "TipoHabitacion",
            "Temporada",
            "RegimenPension",
            "HistoricoReservas",
            "HistoricoServicios"});
            this.cmbTables.Location = new System.Drawing.Point(72, 59);
            this.cmbTables.Name = "cmbTables";
            this.cmbTables.Size = new System.Drawing.Size(257, 21);
            this.cmbTables.TabIndex = 1;
            this.cmbTables.SelectedIndexChanged += new System.EventHandler(this.cmbTables_SelectedIndexChanged);
            // 
            // dbgTables
            // 
            this.dbgTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgTables.Location = new System.Drawing.Point(62, 110);
            this.dbgTables.Name = "dbgTables";
            this.dbgTables.Size = new System.Drawing.Size(582, 178);
            this.dbgTables.TabIndex = 3;
            // 
            // btnImportarDeOdoo
            // 
            this.btnImportarDeOdoo.Location = new System.Drawing.Point(415, 339);
            this.btnImportarDeOdoo.Name = "btnImportarDeOdoo";
            this.btnImportarDeOdoo.Size = new System.Drawing.Size(153, 23);
            this.btnImportarDeOdoo.TabIndex = 6;
            this.btnImportarDeOdoo.Text = "Importar de Odoo";
            this.btnImportarDeOdoo.UseVisualStyleBackColor = true;
            this.btnImportarDeOdoo.Click += new System.EventHandler(this.btnImportarDeOdoo_Click);
            // 
            // frmExportarAOdoo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(820, 583);
            this.Controls.Add(this.grpExportar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmExportarAOdoo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmExportarAOdoo_Load);
            this.grpExportar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbgTables)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpExportar;
        private System.Windows.Forms.ComboBox cmbTables;
        private System.Windows.Forms.DataGridView dbgTables;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnExportarAOdoo;
        private System.Windows.Forms.Button btnImportarDeOdoo;
    }
}