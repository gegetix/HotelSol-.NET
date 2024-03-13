namespace Producto_2.Vista
{
    partial class frmAddServicio
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
            this.gbAddService = new System.Windows.Forms.GroupBox();
            this.porcentajeVipTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ModificarReservaBT = new System.Windows.Forms.Button();
            this.MostrarSrvBT = new System.Windows.Forms.Button();
            this.AnularReservaBT = new System.Windows.Forms.Button();
            this.CancelarBt = new System.Windows.Forms.Button();
            this.guardarBT = new System.Windows.Forms.Button();
            this.dpBajaCB = new System.Windows.Forms.CheckBox();
            this.dpMediaCB = new System.Windows.Forms.CheckBox();
            this.dspAltaCB = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pBajaTXT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pMediaTXT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pAltaTXT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.precioAltaLBL = new System.Windows.Forms.Label();
            this.servTXT = new System.Windows.Forms.TextBox();
            this.ReservaLB = new System.Windows.Forms.Label();
            this.descServicioTXT = new System.Windows.Forms.TextBox();
            this.descB = new System.Windows.Forms.Label();
            this.gbAddService.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAddService
            // 
            this.gbAddService.Controls.Add(this.porcentajeVipTB);
            this.gbAddService.Controls.Add(this.label8);
            this.gbAddService.Controls.Add(this.ModificarReservaBT);
            this.gbAddService.Controls.Add(this.MostrarSrvBT);
            this.gbAddService.Controls.Add(this.AnularReservaBT);
            this.gbAddService.Controls.Add(this.CancelarBt);
            this.gbAddService.Controls.Add(this.guardarBT);
            this.gbAddService.Controls.Add(this.dpBajaCB);
            this.gbAddService.Controls.Add(this.dpMediaCB);
            this.gbAddService.Controls.Add(this.dspAltaCB);
            this.gbAddService.Controls.Add(this.label5);
            this.gbAddService.Controls.Add(this.label6);
            this.gbAddService.Controls.Add(this.label7);
            this.gbAddService.Controls.Add(this.label4);
            this.gbAddService.Controls.Add(this.pBajaTXT);
            this.gbAddService.Controls.Add(this.label3);
            this.gbAddService.Controls.Add(this.pMediaTXT);
            this.gbAddService.Controls.Add(this.label1);
            this.gbAddService.Controls.Add(this.pAltaTXT);
            this.gbAddService.Controls.Add(this.label2);
            this.gbAddService.Controls.Add(this.precioAltaLBL);
            this.gbAddService.Controls.Add(this.servTXT);
            this.gbAddService.Controls.Add(this.ReservaLB);
            this.gbAddService.Controls.Add(this.descServicioTXT);
            this.gbAddService.Controls.Add(this.descB);
            this.gbAddService.Location = new System.Drawing.Point(29, 71);
            this.gbAddService.Name = "gbAddService";
            this.gbAddService.Size = new System.Drawing.Size(763, 440);
            this.gbAddService.TabIndex = 0;
            this.gbAddService.TabStop = false;
            this.gbAddService.Text = "Datos de los servicios";
            // 
            // porcentajeVipTB
            // 
            this.porcentajeVipTB.Location = new System.Drawing.Point(140, 248);
            this.porcentajeVipTB.Name = "porcentajeVipTB";
            this.porcentajeVipTB.Size = new System.Drawing.Size(120, 20);
            this.porcentajeVipTB.TabIndex = 73;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 72;
            this.label8.Text = "Porcentaje VIP";
            // 
            // ModificarReservaBT
            // 
            this.ModificarReservaBT.Location = new System.Drawing.Point(379, 310);
            this.ModificarReservaBT.Name = "ModificarReservaBT";
            this.ModificarReservaBT.Size = new System.Drawing.Size(106, 23);
            this.ModificarReservaBT.TabIndex = 71;
            this.ModificarReservaBT.Text = "Modificar Servicio";
            this.ModificarReservaBT.UseVisualStyleBackColor = true;
            this.ModificarReservaBT.Click += new System.EventHandler(this.ModificarReservaBT_Click);
            // 
            // MostrarSrvBT
            // 
            this.MostrarSrvBT.Location = new System.Drawing.Point(267, 310);
            this.MostrarSrvBT.Name = "MostrarSrvBT";
            this.MostrarSrvBT.Size = new System.Drawing.Size(106, 23);
            this.MostrarSrvBT.TabIndex = 70;
            this.MostrarSrvBT.Text = "Mostrar Servicio";
            this.MostrarSrvBT.UseVisualStyleBackColor = true;
            this.MostrarSrvBT.Click += new System.EventHandler(this.MostrarSrvBT_Click);
            // 
            // AnularReservaBT
            // 
            this.AnularReservaBT.Location = new System.Drawing.Point(491, 310);
            this.AnularReservaBT.Name = "AnularReservaBT";
            this.AnularReservaBT.Size = new System.Drawing.Size(106, 23);
            this.AnularReservaBT.TabIndex = 69;
            this.AnularReservaBT.Text = "Eliminar Servicio";
            this.AnularReservaBT.UseVisualStyleBackColor = true;
            this.AnularReservaBT.Click += new System.EventHandler(this.AnularReservaBT_Click);
            // 
            // CancelarBt
            // 
            this.CancelarBt.Location = new System.Drawing.Point(634, 395);
            this.CancelarBt.Name = "CancelarBt";
            this.CancelarBt.Size = new System.Drawing.Size(106, 23);
            this.CancelarBt.TabIndex = 68;
            this.CancelarBt.Text = "Cancelar";
            this.CancelarBt.UseVisualStyleBackColor = true;
            this.CancelarBt.Click += new System.EventHandler(this.CancelarBt_Click);
            // 
            // guardarBT
            // 
            this.guardarBT.Location = new System.Drawing.Point(155, 310);
            this.guardarBT.Name = "guardarBT";
            this.guardarBT.Size = new System.Drawing.Size(106, 23);
            this.guardarBT.TabIndex = 67;
            this.guardarBT.Text = "Guardar Servicio";
            this.guardarBT.UseVisualStyleBackColor = true;
            this.guardarBT.Click += new System.EventHandler(this.guardarBT_Click);
            // 
            // dpBajaCB
            // 
            this.dpBajaCB.AutoSize = true;
            this.dpBajaCB.Location = new System.Drawing.Point(656, 225);
            this.dpBajaCB.Name = "dpBajaCB";
            this.dpBajaCB.Size = new System.Drawing.Size(15, 14);
            this.dpBajaCB.TabIndex = 53;
            this.dpBajaCB.UseVisualStyleBackColor = true;
            // 
            // dpMediaCB
            // 
            this.dpMediaCB.AutoSize = true;
            this.dpMediaCB.Location = new System.Drawing.Point(656, 200);
            this.dpMediaCB.Name = "dpMediaCB";
            this.dpMediaCB.Size = new System.Drawing.Size(15, 14);
            this.dpMediaCB.TabIndex = 52;
            this.dpMediaCB.UseVisualStyleBackColor = true;
            // 
            // dspAltaCB
            // 
            this.dspAltaCB.AutoSize = true;
            this.dspAltaCB.Location = new System.Drawing.Point(656, 174);
            this.dspAltaCB.Name = "dspAltaCB";
            this.dspAltaCB.Size = new System.Drawing.Size(15, 14);
            this.dspAltaCB.TabIndex = 51;
            this.dspAltaCB.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(541, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Tremparada Baja";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(541, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 49;
            this.label6.Text = "Tremparada Media";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(541, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Tremparada Alta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(542, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 12);
            this.label4.TabIndex = 47;
            this.label4.Text = "DISPONIBILIDAD";
            // 
            // pBajaTXT
            // 
            this.pBajaTXT.Location = new System.Drawing.Point(435, 229);
            this.pBajaTXT.Name = "pBajaTXT";
            this.pBajaTXT.Size = new System.Drawing.Size(73, 20);
            this.pBajaTXT.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Tremparada Baja";
            // 
            // pMediaTXT
            // 
            this.pMediaTXT.Location = new System.Drawing.Point(435, 203);
            this.pMediaTXT.Name = "pMediaTXT";
            this.pMediaTXT.Size = new System.Drawing.Size(73, 20);
            this.pMediaTXT.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Tremparada Media";
            // 
            // pAltaTXT
            // 
            this.pAltaTXT.Location = new System.Drawing.Point(435, 177);
            this.pAltaTXT.Name = "pAltaTXT";
            this.pAltaTXT.Size = new System.Drawing.Size(73, 20);
            this.pAltaTXT.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(334, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 12);
            this.label2.TabIndex = 41;
            this.label2.Text = "PRECIOS";
            // 
            // precioAltaLBL
            // 
            this.precioAltaLBL.AutoSize = true;
            this.precioAltaLBL.Location = new System.Drawing.Point(333, 177);
            this.precioAltaLBL.Name = "precioAltaLBL";
            this.precioAltaLBL.Size = new System.Drawing.Size(85, 13);
            this.precioAltaLBL.TabIndex = 40;
            this.precioAltaLBL.Text = "Tremparada Alta";
            // 
            // servTXT
            // 
            this.servTXT.Location = new System.Drawing.Point(140, 171);
            this.servTXT.Name = "servTXT";
            this.servTXT.Size = new System.Drawing.Size(120, 20);
            this.servTXT.TabIndex = 39;
            this.servTXT.Text = "Rellenar solo Búsqueda";
            // 
            // ReservaLB
            // 
            this.ReservaLB.AutoSize = true;
            this.ReservaLB.Location = new System.Drawing.Point(51, 174);
            this.ReservaLB.Name = "ReservaLB";
            this.ReservaLB.Size = new System.Drawing.Size(81, 13);
            this.ReservaLB.TabIndex = 38;
            this.ReservaLB.Text = "Nº de Servicio: ";
            // 
            // descServicioTXT
            // 
            this.descServicioTXT.Location = new System.Drawing.Point(140, 197);
            this.descServicioTXT.Name = "descServicioTXT";
            this.descServicioTXT.Size = new System.Drawing.Size(120, 20);
            this.descServicioTXT.TabIndex = 37;
            // 
            // descB
            // 
            this.descB.AutoSize = true;
            this.descB.Location = new System.Drawing.Point(47, 197);
            this.descB.Name = "descB";
            this.descB.Size = new System.Drawing.Size(63, 13);
            this.descB.TabIndex = 34;
            this.descB.Text = "Descripcion";
            // 
            // frmAddServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(820, 583);
            this.Controls.Add(this.gbAddService);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmAddServicio";
            this.Load += new System.EventHandler(this.frmAddServicio_Load);
            this.gbAddService.ResumeLayout(false);
            this.gbAddService.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.GroupBox gbAddService;
        private System.Windows.Forms.Label descB;
        private System.Windows.Forms.TextBox descServicioTXT;
        private System.Windows.Forms.TextBox servTXT;
        private System.Windows.Forms.Label ReservaLB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pBajaTXT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pMediaTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pAltaTXT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label precioAltaLBL;
        private System.Windows.Forms.CheckBox dpBajaCB;
        private System.Windows.Forms.CheckBox dpMediaCB;
        private System.Windows.Forms.CheckBox dspAltaCB;
        private System.Windows.Forms.Button ModificarReservaBT;
        private System.Windows.Forms.Button MostrarSrvBT;
        private System.Windows.Forms.Button AnularReservaBT;
        private System.Windows.Forms.Button CancelarBt;
        private System.Windows.Forms.Button guardarBT;
        private System.Windows.Forms.TextBox porcentajeVipTB;
        private System.Windows.Forms.Label label8;
    }
}