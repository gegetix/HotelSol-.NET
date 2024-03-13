namespace Producto_2.Vista
{
    partial class InterfazReserva
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
            this.grpReserva = new System.Windows.Forms.GroupBox();
            this.addServBT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbListaServicios = new System.Windows.Forms.ListBox();
            this.TemporadaCbox = new System.Windows.Forms.ComboBox();
            this.fechaSDTP = new System.Windows.Forms.DateTimePicker();
            this.fechaEDTP = new System.Windows.Forms.DateTimePicker();
            this.ModificarReservaBT = new System.Windows.Forms.Button();
            this.CHKFirm = new System.Windows.Forms.CheckBox();
            this.MostrarReservaBT = new System.Windows.Forms.Button();
            this.AnularReservaBT = new System.Windows.Forms.Button();
            this.HabitacionCBox = new System.Windows.Forms.ComboBox();
            this.DiasTXT = new System.Windows.Forms.TextBox();
            this.NDiasLB = new System.Windows.Forms.Label();
            this.CancelarBt = new System.Windows.Forms.Button();
            this.ContratarBT = new System.Windows.Forms.Button();
            this.Calendario = new System.Windows.Forms.MonthCalendar();
            this.TemporadaLB = new System.Windows.Forms.Label();
            this.ServiciosLBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TipoPensionCB = new System.Windows.Forms.ComboBox();
            this.TipoPensionTXT = new System.Windows.Forms.Label();
            this.NHabitacion = new System.Windows.Forms.Label();
            this.FechasLB = new System.Windows.Forms.Label();
            this.NPersonasTXT = new System.Windows.Forms.TextBox();
            this.PersonasTXT = new System.Windows.Forms.Label();
            this.NIFClienteTXT = new System.Windows.Forms.TextBox();
            this.ClienteLB = new System.Windows.Forms.Label();
            this.ReservaTXT = new System.Windows.Forms.TextBox();
            this.ReservaLB = new System.Windows.Forms.Label();
            this.grpReserva.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpReserva
            // 
            this.grpReserva.Controls.Add(this.addServBT);
            this.grpReserva.Controls.Add(this.label2);
            this.grpReserva.Controls.Add(this.lbListaServicios);
            this.grpReserva.Controls.Add(this.TemporadaCbox);
            this.grpReserva.Controls.Add(this.fechaSDTP);
            this.grpReserva.Controls.Add(this.fechaEDTP);
            this.grpReserva.Controls.Add(this.ModificarReservaBT);
            this.grpReserva.Controls.Add(this.CHKFirm);
            this.grpReserva.Controls.Add(this.MostrarReservaBT);
            this.grpReserva.Controls.Add(this.AnularReservaBT);
            this.grpReserva.Controls.Add(this.HabitacionCBox);
            this.grpReserva.Controls.Add(this.DiasTXT);
            this.grpReserva.Controls.Add(this.NDiasLB);
            this.grpReserva.Controls.Add(this.CancelarBt);
            this.grpReserva.Controls.Add(this.ContratarBT);
            this.grpReserva.Controls.Add(this.Calendario);
            this.grpReserva.Controls.Add(this.TemporadaLB);
            this.grpReserva.Controls.Add(this.ServiciosLBox);
            this.grpReserva.Controls.Add(this.label1);
            this.grpReserva.Controls.Add(this.TipoPensionCB);
            this.grpReserva.Controls.Add(this.TipoPensionTXT);
            this.grpReserva.Controls.Add(this.NHabitacion);
            this.grpReserva.Controls.Add(this.FechasLB);
            this.grpReserva.Controls.Add(this.NPersonasTXT);
            this.grpReserva.Controls.Add(this.PersonasTXT);
            this.grpReserva.Controls.Add(this.NIFClienteTXT);
            this.grpReserva.Controls.Add(this.ClienteLB);
            this.grpReserva.Controls.Add(this.ReservaTXT);
            this.grpReserva.Controls.Add(this.ReservaLB);
            this.grpReserva.Location = new System.Drawing.Point(70, 56);
            this.grpReserva.Name = "grpReserva";
            this.grpReserva.Size = new System.Drawing.Size(680, 470);
            this.grpReserva.TabIndex = 29;
            this.grpReserva.TabStop = false;
            this.grpReserva.Text = "Datos Reserva";
            // 
            // addServBT
            // 
            this.addServBT.Location = new System.Drawing.Point(394, 374);
            this.addServBT.Name = "addServBT";
            this.addServBT.Size = new System.Drawing.Size(106, 23);
            this.addServBT.TabIndex = 72;
            this.addServBT.Text = "Añadir";
            this.addServBT.UseVisualStyleBackColor = true;
            this.addServBT.Click += new System.EventHandler(this.addServBT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "Selecciona los servicios";
            // 
            // lbListaServicios
            // 
            this.lbListaServicios.BackColor = System.Drawing.SystemColors.Info;
            this.lbListaServicios.FormattingEnabled = true;
            this.lbListaServicios.Location = new System.Drawing.Point(394, 273);
            this.lbListaServicios.Name = "lbListaServicios";
            this.lbListaServicios.Size = new System.Drawing.Size(120, 95);
            this.lbListaServicios.TabIndex = 70;
            this.lbListaServicios.SelectedIndexChanged += new System.EventHandler(this.lbListaServicios_SelectedIndexChanged);
            // 
            // TemporadaCbox
            // 
            this.TemporadaCbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TemporadaCbox.FormattingEnabled = true;
            this.TemporadaCbox.Location = new System.Drawing.Point(113, 367);
            this.TemporadaCbox.Name = "TemporadaCbox";
            this.TemporadaCbox.Size = new System.Drawing.Size(121, 21);
            this.TemporadaCbox.TabIndex = 69;
            this.TemporadaCbox.SelectedIndexChanged += new System.EventHandler(this.TemporadaCbox_SelectedIndexChanged_1);
            // 
            // fechaSDTP
            // 
            this.fechaSDTP.Location = new System.Drawing.Point(213, 160);
            this.fechaSDTP.Name = "fechaSDTP";
            this.fechaSDTP.Size = new System.Drawing.Size(84, 20);
            this.fechaSDTP.TabIndex = 68;
            // 
            // fechaEDTP
            // 
            this.fechaEDTP.Location = new System.Drawing.Point(123, 160);
            this.fechaEDTP.Name = "fechaEDTP";
            this.fechaEDTP.Size = new System.Drawing.Size(84, 20);
            this.fechaEDTP.TabIndex = 67;
            // 
            // ModificarReservaBT
            // 
            this.ModificarReservaBT.Location = new System.Drawing.Point(525, 304);
            this.ModificarReservaBT.Name = "ModificarReservaBT";
            this.ModificarReservaBT.Size = new System.Drawing.Size(106, 23);
            this.ModificarReservaBT.TabIndex = 66;
            this.ModificarReservaBT.Text = "Modificar Reserva";
            this.ModificarReservaBT.UseVisualStyleBackColor = true;
            this.ModificarReservaBT.Click += new System.EventHandler(this.ModificarReservaBT_Click);
            // 
            // CHKFirm
            // 
            this.CHKFirm.AccessibleName = "CHKFirm";
            this.CHKFirm.AutoSize = true;
            this.CHKFirm.Location = new System.Drawing.Point(28, 402);
            this.CHKFirm.Name = "CHKFirm";
            this.CHKFirm.Size = new System.Drawing.Size(109, 17);
            this.CHKFirm.TabIndex = 65;
            this.CHKFirm.Text = "Entrada Firmada?";
            this.CHKFirm.UseVisualStyleBackColor = true;
            this.CHKFirm.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // MostrarReservaBT
            // 
            this.MostrarReservaBT.Location = new System.Drawing.Point(525, 268);
            this.MostrarReservaBT.Name = "MostrarReservaBT";
            this.MostrarReservaBT.Size = new System.Drawing.Size(106, 23);
            this.MostrarReservaBT.TabIndex = 64;
            this.MostrarReservaBT.Text = "Mostrar Reserva";
            this.MostrarReservaBT.UseVisualStyleBackColor = true;
            this.MostrarReservaBT.Click += new System.EventHandler(this.MostrarReservaBT_Click);
            // 
            // AnularReservaBT
            // 
            this.AnularReservaBT.Location = new System.Drawing.Point(525, 345);
            this.AnularReservaBT.Name = "AnularReservaBT";
            this.AnularReservaBT.Size = new System.Drawing.Size(106, 23);
            this.AnularReservaBT.TabIndex = 62;
            this.AnularReservaBT.Text = "Anular Reserva";
            this.AnularReservaBT.UseVisualStyleBackColor = true;
            this.AnularReservaBT.Click += new System.EventHandler(this.AnularReservaBT_Click);
            // 
            // HabitacionCBox
            // 
            this.HabitacionCBox.FormattingEnabled = true;
            this.HabitacionCBox.Location = new System.Drawing.Point(114, 191);
            this.HabitacionCBox.Name = "HabitacionCBox";
            this.HabitacionCBox.Size = new System.Drawing.Size(110, 21);
            this.HabitacionCBox.TabIndex = 61;
            this.HabitacionCBox.SelectedIndexChanged += new System.EventHandler(this.HabitacionCBox_SelectedIndexChanged);
            // 
            // DiasTXT
            // 
            this.DiasTXT.Location = new System.Drawing.Point(394, 160);
            this.DiasTXT.Name = "DiasTXT";
            this.DiasTXT.Size = new System.Drawing.Size(65, 20);
            this.DiasTXT.TabIndex = 60;
            this.DiasTXT.TextChanged += new System.EventHandler(this.DiasLB_TextChanged);
            // 
            // NDiasLB
            // 
            this.NDiasLB.AutoSize = true;
            this.NDiasLB.Location = new System.Drawing.Point(326, 163);
            this.NDiasLB.Name = "NDiasLB";
            this.NDiasLB.Size = new System.Drawing.Size(49, 13);
            this.NDiasLB.TabIndex = 59;
            this.NDiasLB.Text = "Nº Dias: ";
            // 
            // CancelarBt
            // 
            this.CancelarBt.Location = new System.Drawing.Point(525, 397);
            this.CancelarBt.Name = "CancelarBt";
            this.CancelarBt.Size = new System.Drawing.Size(106, 23);
            this.CancelarBt.TabIndex = 58;
            this.CancelarBt.Text = "Cancelar";
            this.CancelarBt.UseVisualStyleBackColor = true;
            this.CancelarBt.Click += new System.EventHandler(this.CancelarBt_Click);
            // 
            // ContratarBT
            // 
            this.ContratarBT.Location = new System.Drawing.Point(525, 233);
            this.ContratarBT.Name = "ContratarBT";
            this.ContratarBT.Size = new System.Drawing.Size(106, 23);
            this.ContratarBT.TabIndex = 57;
            this.ContratarBT.Text = "Guardar Reserva";
            this.ContratarBT.UseVisualStyleBackColor = true;
            this.ContratarBT.Click += new System.EventHandler(this.ContratarBT_Click);
            // 
            // Calendario
            // 
            this.Calendario.Location = new System.Drawing.Point(482, 14);
            this.Calendario.Name = "Calendario";
            this.Calendario.TabIndex = 56;
            this.Calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendario_DateChanged);
            // 
            // TemporadaLB
            // 
            this.TemporadaLB.AutoSize = true;
            this.TemporadaLB.Location = new System.Drawing.Point(25, 370);
            this.TemporadaLB.Name = "TemporadaLB";
            this.TemporadaLB.Size = new System.Drawing.Size(67, 13);
            this.TemporadaLB.TabIndex = 48;
            this.TemporadaLB.Text = "Temporada: ";
            // 
            // ServiciosLBox
            // 
            this.ServiciosLBox.FormattingEnabled = true;
            this.ServiciosLBox.Location = new System.Drawing.Point(114, 253);
            this.ServiciosLBox.Name = "ServiciosLBox";
            this.ServiciosLBox.Size = new System.Drawing.Size(120, 95);
            this.ServiciosLBox.TabIndex = 47;
            this.ServiciosLBox.SelectedIndexChanged += new System.EventHandler(this.ServiciosLBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Servicios: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TipoPensionCB
            // 
            this.TipoPensionCB.FormattingEnabled = true;
            this.TipoPensionCB.Location = new System.Drawing.Point(114, 220);
            this.TipoPensionCB.Name = "TipoPensionCB";
            this.TipoPensionCB.Size = new System.Drawing.Size(110, 21);
            this.TipoPensionCB.TabIndex = 45;
            this.TipoPensionCB.SelectedIndexChanged += new System.EventHandler(this.TipoPensionCB_SelectedIndexChanged);
            // 
            // TipoPensionTXT
            // 
            this.TipoPensionTXT.AutoSize = true;
            this.TipoPensionTXT.Location = new System.Drawing.Point(25, 223);
            this.TipoPensionTXT.Name = "TipoPensionTXT";
            this.TipoPensionTXT.Size = new System.Drawing.Size(75, 13);
            this.TipoPensionTXT.TabIndex = 44;
            this.TipoPensionTXT.Text = "Tipo Pension: ";
            // 
            // NHabitacion
            // 
            this.NHabitacion.AutoSize = true;
            this.NHabitacion.Location = new System.Drawing.Point(25, 194);
            this.NHabitacion.Name = "NHabitacion";
            this.NHabitacion.Size = new System.Drawing.Size(79, 13);
            this.NHabitacion.TabIndex = 42;
            this.NHabitacion.Text = "Nº Habitación: ";
            // 
            // FechasLB
            // 
            this.FechasLB.AutoSize = true;
            this.FechasLB.Location = new System.Drawing.Point(25, 163);
            this.FechasLB.Name = "FechasLB";
            this.FechasLB.Size = new System.Drawing.Size(101, 13);
            this.FechasLB.TabIndex = 39;
            this.FechasLB.Text = "Fechas de reserva: ";
            // 
            // NPersonasTXT
            // 
            this.NPersonasTXT.Location = new System.Drawing.Point(123, 125);
            this.NPersonasTXT.Name = "NPersonasTXT";
            this.NPersonasTXT.Size = new System.Drawing.Size(84, 20);
            this.NPersonasTXT.TabIndex = 38;
            this.NPersonasTXT.TextChanged += new System.EventHandler(this.NPersonasTXT_TextChanged);
            // 
            // PersonasTXT
            // 
            this.PersonasTXT.AutoSize = true;
            this.PersonasTXT.Location = new System.Drawing.Point(25, 128);
            this.PersonasTXT.Name = "PersonasTXT";
            this.PersonasTXT.Size = new System.Drawing.Size(72, 13);
            this.PersonasTXT.TabIndex = 37;
            this.PersonasTXT.Text = "Nº Personas: ";
            // 
            // NIFClienteTXT
            // 
            this.NIFClienteTXT.Location = new System.Drawing.Point(114, 94);
            this.NIFClienteTXT.Name = "NIFClienteTXT";
            this.NIFClienteTXT.Size = new System.Drawing.Size(120, 20);
            this.NIFClienteTXT.TabIndex = 36;
            this.NIFClienteTXT.TextChanged += new System.EventHandler(this.ClienteTXT_TextChanged);
            // 
            // ClienteLB
            // 
            this.ClienteLB.AutoSize = true;
            this.ClienteLB.Location = new System.Drawing.Point(25, 97);
            this.ClienteLB.Name = "ClienteLB";
            this.ClienteLB.Size = new System.Drawing.Size(67, 13);
            this.ClienteLB.TabIndex = 35;
            this.ClienteLB.Text = "DNI Cliente: ";
            // 
            // ReservaTXT
            // 
            this.ReservaTXT.Location = new System.Drawing.Point(114, 67);
            this.ReservaTXT.Name = "ReservaTXT";
            this.ReservaTXT.Size = new System.Drawing.Size(120, 20);
            this.ReservaTXT.TabIndex = 34;
            this.ReservaTXT.Text = "Rellenar solo Búsqueda";
            this.ReservaTXT.TextChanged += new System.EventHandler(this.ReservaTXT_TextChanged);
            // 
            // ReservaLB
            // 
            this.ReservaLB.AutoSize = true;
            this.ReservaLB.Location = new System.Drawing.Point(25, 70);
            this.ReservaLB.Name = "ReservaLB";
            this.ReservaLB.Size = new System.Drawing.Size(83, 13);
            this.ReservaLB.TabIndex = 33;
            this.ReservaLB.Text = "Nº de Reserva: ";
            // 
            // InterfazReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(820, 583);
            this.Controls.Add(this.grpReserva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InterfazReserva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Hotel SOL";
            this.Load += new System.EventHandler(this.InterfazServicio_Load);
            this.grpReserva.ResumeLayout(false);
            this.grpReserva.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpReserva;
        private System.Windows.Forms.Label ReservaLB;
        private System.Windows.Forms.TextBox ReservaTXT;
        private System.Windows.Forms.TextBox NIFClienteTXT;
        private System.Windows.Forms.Label ClienteLB;
        private System.Windows.Forms.Label FechasLB;
        private System.Windows.Forms.TextBox NPersonasTXT;
        private System.Windows.Forms.Label PersonasTXT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TipoPensionCB;
        private System.Windows.Forms.Label TipoPensionTXT;
        private System.Windows.Forms.Label NHabitacion;
        private System.Windows.Forms.Label TemporadaLB;
        private System.Windows.Forms.ListBox ServiciosLBox;
        private System.Windows.Forms.TextBox DiasTXT;
        private System.Windows.Forms.Label NDiasLB;
        private System.Windows.Forms.Button CancelarBt;
        private System.Windows.Forms.Button ContratarBT;
        private System.Windows.Forms.MonthCalendar Calendario;
        private System.Windows.Forms.Button AnularReservaBT;
        private System.Windows.Forms.ComboBox HabitacionCBox;
        private System.Windows.Forms.Button MostrarReservaBT;
        private System.Windows.Forms.CheckBox CHKFirm;
        private System.Windows.Forms.Button ModificarReservaBT;
        private System.Windows.Forms.DateTimePicker fechaSDTP;
        private System.Windows.Forms.DateTimePicker fechaEDTP;
        private System.Windows.Forms.ComboBox TemporadaCbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbListaServicios;
        private System.Windows.Forms.Button addServBT;
    }
}