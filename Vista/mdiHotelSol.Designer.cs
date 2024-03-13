namespace Producto_2.Vista
{
    partial class mdiHotelSol
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdiHotelSol));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.mnuClientes = new System.Windows.Forms.ToolStripButton();
            this.mnuReservas = new System.Windows.Forms.ToolStripButton();
            this.mnuHabitaciones = new System.Windows.Forms.ToolStripButton();
            this.mnuServicios = new System.Windows.Forms.ToolStripButton();
            this.mnuFacturas = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuImportarAOdoo = new System.Windows.Forms.ToolStripButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(91, 46);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuClientes,
            this.mnuReservas,
            this.mnuHabitaciones,
            this.mnuServicios,
            this.mnuFacturas,
            this.toolStripSeparator1,
            this.mnuImportarAOdoo});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip.Size = new System.Drawing.Size(824, 53);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            this.toolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip_ItemClicked);
            // 
            // mnuClientes
            // 
            this.mnuClientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuClientes.Image = ((System.Drawing.Image)(resources.GetObject("mnuClientes.Image")));
            this.mnuClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuClientes.Name = "mnuClientes";
            this.mnuClientes.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.mnuClientes.Size = new System.Drawing.Size(95, 50);
            this.mnuClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.mnuClientes.ToolTipText = "Clientes";
            this.mnuClientes.Click += new System.EventHandler(this.mnuClientes_Click);
            // 
            // mnuReservas
            // 
            this.mnuReservas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuReservas.Image = ((System.Drawing.Image)(resources.GetObject("mnuReservas.Image")));
            this.mnuReservas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuReservas.Name = "mnuReservas";
            this.mnuReservas.Size = new System.Drawing.Size(95, 50);
            this.mnuReservas.ToolTipText = "Reservas";
            this.mnuReservas.Click += new System.EventHandler(this.mnuReservas_Click);
            // 
            // mnuHabitaciones
            // 
            this.mnuHabitaciones.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuHabitaciones.Image = ((System.Drawing.Image)(resources.GetObject("mnuHabitaciones.Image")));
            this.mnuHabitaciones.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuHabitaciones.Name = "mnuHabitaciones";
            this.mnuHabitaciones.Size = new System.Drawing.Size(95, 50);
            this.mnuHabitaciones.ToolTipText = "Habitaciones";
            this.mnuHabitaciones.Click += new System.EventHandler(this.mnuHabitaciones_Click);
            // 
            // mnuServicios
            // 
            this.mnuServicios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuServicios.Image = ((System.Drawing.Image)(resources.GetObject("mnuServicios.Image")));
            this.mnuServicios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuServicios.Name = "mnuServicios";
            this.mnuServicios.Size = new System.Drawing.Size(95, 50);
            this.mnuServicios.ToolTipText = "Servicios";
            this.mnuServicios.Click += new System.EventHandler(this.mnuServicios_Click);
            // 
            // mnuFacturas
            // 
            this.mnuFacturas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuFacturas.Image = ((System.Drawing.Image)(resources.GetObject("mnuFacturas.Image")));
            this.mnuFacturas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuFacturas.Name = "mnuFacturas";
            this.mnuFacturas.Size = new System.Drawing.Size(95, 50);
            this.mnuFacturas.ToolTipText = "Facturas";
            this.mnuFacturas.Click += new System.EventHandler(this.mnuFacturas_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 53);
            // 
            // mnuImportarAOdoo
            // 
            this.mnuImportarAOdoo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mnuImportarAOdoo.Image = ((System.Drawing.Image)(resources.GetObject("mnuImportarAOdoo.Image")));
            this.mnuImportarAOdoo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuImportarAOdoo.Name = "mnuImportarAOdoo";
            this.mnuImportarAOdoo.Size = new System.Drawing.Size(95, 50);
            this.mnuImportarAOdoo.Text = "Importar A Odoo";
            this.mnuImportarAOdoo.Click += new System.EventHandler(this.mnuImportarAOdoo_Click);
            // 
            // mdiHotelSol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 641);
            this.Controls.Add(this.toolStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mdiHotelSol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Hotel Sol";
            this.Load += new System.EventHandler(this.mdiHotelSol_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton mnuClientes;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripButton mnuReservas;
        private System.Windows.Forms.ToolStripButton mnuHabitaciones;
        private System.Windows.Forms.ToolStripButton mnuServicios;
        private System.Windows.Forms.ToolStripButton mnuFacturas;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton mnuImportarAOdoo;
    }
}



