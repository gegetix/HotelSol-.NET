namespace Producto_2.Vista
{
    partial class frmAutenticacion
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
            this.grpUsuariosInicio = new System.Windows.Forms.GroupBox();
            this.txtNuevo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpAltaUsuario = new System.Windows.Forms.GroupBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtNuevoUsu = new System.Windows.Forms.TextBox();
            this.txtNuevaPass = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.grpUsuariosInicio.SuspendLayout();
            this.grpAltaUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpUsuariosInicio
            // 
            this.grpUsuariosInicio.Controls.Add(this.txtNuevo);
            this.grpUsuariosInicio.Controls.Add(this.label1);
            this.grpUsuariosInicio.Controls.Add(this.btnEntrar);
            this.grpUsuariosInicio.Controls.Add(this.txtPass);
            this.grpUsuariosInicio.Controls.Add(this.txtUsuario);
            this.grpUsuariosInicio.Controls.Add(this.label2);
            this.grpUsuariosInicio.Location = new System.Drawing.Point(73, 48);
            this.grpUsuariosInicio.Name = "grpUsuariosInicio";
            this.grpUsuariosInicio.Size = new System.Drawing.Size(674, 425);
            this.grpUsuariosInicio.TabIndex = 50;
            this.grpUsuariosInicio.TabStop = false;
            // 
            // txtNuevo
            // 
            this.txtNuevo.Location = new System.Drawing.Point(564, 378);
            this.txtNuevo.Name = "txtNuevo";
            this.txtNuevo.Size = new System.Drawing.Size(75, 23);
            this.txtNuevo.TabIndex = 7;
            this.txtNuevo.Text = "Alta Usuario";
            this.txtNuevo.UseVisualStyleBackColor = true;
            this.txtNuevo.Click += new System.EventHandler(this.txtNuevo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIO:";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(228, 292);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 4;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(352, 192);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(100, 20);
            this.txtPass.TabIndex = 3;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(352, 110);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "CONTRASEÑA:";
            // 
            // grpAltaUsuario
            // 
            this.grpAltaUsuario.Controls.Add(this.lblPassword);
            this.grpAltaUsuario.Controls.Add(this.lblUsuario);
            this.grpAltaUsuario.Controls.Add(this.txtNuevoUsu);
            this.grpAltaUsuario.Controls.Add(this.txtNuevaPass);
            this.grpAltaUsuario.Controls.Add(this.btnCerrar);
            this.grpAltaUsuario.Controls.Add(this.btnAgregar);
            this.grpAltaUsuario.Location = new System.Drawing.Point(73, 48);
            this.grpAltaUsuario.Name = "grpAltaUsuario";
            this.grpAltaUsuario.Size = new System.Drawing.Size(674, 425);
            this.grpAltaUsuario.TabIndex = 6;
            this.grpAltaUsuario.TabStop = false;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(232, 182);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(77, 17);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(232, 110);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 17);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtNuevoUsu
            // 
            this.txtNuevoUsu.Location = new System.Drawing.Point(320, 107);
            this.txtNuevoUsu.Name = "txtNuevoUsu";
            this.txtNuevoUsu.Size = new System.Drawing.Size(100, 20);
            this.txtNuevoUsu.TabIndex = 3;
            // 
            // txtNuevaPass
            // 
            this.txtNuevaPass.Location = new System.Drawing.Point(320, 179);
            this.txtNuevaPass.Name = "txtNuevaPass";
            this.txtNuevaPass.PasswordChar = '*';
            this.txtNuevaPass.Size = new System.Drawing.Size(100, 20);
            this.txtNuevaPass.TabIndex = 2;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(365, 292);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "Salir";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(228, 292);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // frmAutenticacion
            // 
            this.AcceptButton = this.btnEntrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(820, 583);
            this.Controls.Add(this.grpUsuariosInicio);
            this.Controls.Add(this.grpAltaUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAutenticacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Autenticacion";
            this.Load += new System.EventHandler(this.frmAutenticacion_Load);
            this.grpUsuariosInicio.ResumeLayout(false);
            this.grpUsuariosInicio.PerformLayout();
            this.grpAltaUsuario.ResumeLayout(false);
            this.grpAltaUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUsuariosInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpAltaUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtNuevoUsu;
        private System.Windows.Forms.TextBox txtNuevaPass;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button txtNuevo;
    }
}