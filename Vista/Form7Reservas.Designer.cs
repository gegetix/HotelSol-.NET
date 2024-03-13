namespace Producto_2.Vista
{
    partial class Form7Reservas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.firmaBTN = new System.Windows.Forms.Button();
            this.pendDG = new System.Windows.Forms.DataGridView();
            this.chinDG = new System.Windows.Forms.DataGridView();
            this.checkoutHDG = new System.Windows.Forms.DataGridView();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nuevaReservaBTN = new System.Windows.Forms.Button();
            this.pendienteLBL = new System.Windows.Forms.Label();
            this.checkInLBL = new System.Windows.Forms.Label();
            this.checkoutLBL = new System.Windows.Forms.Label();
            this.historicoReservasBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.historicoReservasBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.historicoReservasBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.historicoReservasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.historicoReservasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.historicoReservasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pendDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chinDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkoutHDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicoReservasBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicoReservasBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicoReservasBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicoReservasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicoReservasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicoReservasBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.firmaBTN);
            this.groupBox1.Controls.Add(this.pendDG);
            this.groupBox1.Controls.Add(this.chinDG);
            this.groupBox1.Controls.Add(this.checkoutHDG);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.nuevaReservaBTN);
            this.groupBox1.Controls.Add(this.pendienteLBL);
            this.groupBox1.Controls.Add(this.checkInLBL);
            this.groupBox1.Controls.Add(this.checkoutLBL);
            this.groupBox1.Location = new System.Drawing.Point(21, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 463);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            // 
            // firmaBTN
            // 
            this.firmaBTN.Location = new System.Drawing.Point(603, 173);
            this.firmaBTN.Name = "firmaBTN";
            this.firmaBTN.Size = new System.Drawing.Size(135, 23);
            this.firmaBTN.TabIndex = 21;
            this.firmaBTN.Text = "FIRMAR";
            this.firmaBTN.UseVisualStyleBackColor = true;
            this.firmaBTN.Click += new System.EventHandler(this.firmaBTN_Click);
            // 
            // pendDG
            // 
            this.pendDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pendDG.Location = new System.Drawing.Point(23, 267);
            this.pendDG.Name = "pendDG";
            this.pendDG.Size = new System.Drawing.Size(486, 165);
            this.pendDG.TabIndex = 17;
            // 
            // chinDG
            // 
            this.chinDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chinDG.Location = new System.Drawing.Point(23, 160);
            this.chinDG.Name = "chinDG";
            this.chinDG.Size = new System.Drawing.Size(486, 74);
            this.chinDG.TabIndex = 20;
            // 
            // checkoutHDG
            // 
            this.checkoutHDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.checkoutHDG.Location = new System.Drawing.Point(23, 46);
            this.checkoutHDG.Name = "checkoutHDG";
            this.checkoutHDG.Size = new System.Drawing.Size(486, 89);
            this.checkoutHDG.TabIndex = 15;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(572, 19);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 11;
            // 
            // nuevaReservaBTN
            // 
            this.nuevaReservaBTN.Location = new System.Drawing.Point(603, 85);
            this.nuevaReservaBTN.Name = "nuevaReservaBTN";
            this.nuevaReservaBTN.Size = new System.Drawing.Size(135, 23);
            this.nuevaReservaBTN.TabIndex = 10;
            this.nuevaReservaBTN.Text = "Gestion Reservas";
            this.nuevaReservaBTN.UseVisualStyleBackColor = true;
            this.nuevaReservaBTN.Click += new System.EventHandler(this.nuevaReservaBTN_Click);
            // 
            // pendienteLBL
            // 
            this.pendienteLBL.AutoSize = true;
            this.pendienteLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendienteLBL.Location = new System.Drawing.Point(20, 246);
            this.pendienteLBL.Name = "pendienteLBL";
            this.pendienteLBL.Size = new System.Drawing.Size(192, 18);
            this.pendienteLBL.TabIndex = 3;
            this.pendienteLBL.Text = "TODAS LAS RESERVAS";
            // 
            // checkInLBL
            // 
            this.checkInLBL.AutoSize = true;
            this.checkInLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInLBL.Location = new System.Drawing.Point(20, 138);
            this.checkInLBL.Name = "checkInLBL";
            this.checkInLBL.Size = new System.Drawing.Size(87, 18);
            this.checkInLBL.TabIndex = 2;
            this.checkInLBL.Text = "CHECK IN";
            // 
            // checkoutLBL
            // 
            this.checkoutLBL.AutoSize = true;
            this.checkoutLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutLBL.Location = new System.Drawing.Point(20, 25);
            this.checkoutLBL.Name = "checkoutLBL";
            this.checkoutLBL.Size = new System.Drawing.Size(106, 18);
            this.checkoutLBL.TabIndex = 1;
            this.checkoutLBL.Text = "CHECK OUT";
            // 
            // historicoReservasBindingSource5
            // 
            this.historicoReservasBindingSource5.DataMember = "historicoReservas";
            // 
            // historicoReservasBindingSource4
            // 
            this.historicoReservasBindingSource4.DataMember = "historicoReservas";
            // 
            // historicoReservasBindingSource3
            // 
            this.historicoReservasBindingSource3.DataMember = "historicoReservas";
            // 
            // historicoReservasBindingSource
            // 
            this.historicoReservasBindingSource.DataMember = "historicoReservas";
            // 
            // historicoReservasBindingSource1
            // 
            this.historicoReservasBindingSource1.DataMember = "historicoReservas";
            // 
            // historicoReservasBindingSource2
            // 
            this.historicoReservasBindingSource2.DataMember = "historicoReservas";
            // 
            // Form7Reservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(820, 583);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form7Reservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form7Reservas";
            this.Load += new System.EventHandler(this.Form7Reservas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pendDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chinDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkoutHDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicoReservasBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicoReservasBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicoReservasBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicoReservasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicoReservasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historicoReservasBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label pendienteLBL;
        private System.Windows.Forms.Label checkInLBL;
        private System.Windows.Forms.Label checkoutLBL;
        private System.Windows.Forms.Button nuevaReservaBTN;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.BindingSource historicoReservasBindingSource;
        private System.Windows.Forms.BindingSource historicoReservasBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn habitacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn idIncidenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource historicoReservasBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn habitacionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource historicoReservasBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource historicoReservasBindingSource4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn entradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource historicoReservasBindingSource5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn entradaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn estadoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView checkoutHDG;
        private System.Windows.Forms.DataGridView pendDG;
        private System.Windows.Forms.DataGridView chinDG;
        private System.Windows.Forms.Button firmaBTN;
    }
}