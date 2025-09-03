namespace reparaciones2.Configuracion
{
    partial class FrmConfiguracionDatos
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
            this.lbldireccionIP = new System.Windows.Forms.Label();
            this.txtDireccionIP = new System.Windows.Forms.TextBox();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.lblPuerto = new System.Windows.Forms.Label();
            this.lblusuarioDB = new System.Windows.Forms.Label();
            this.txtUsuarioDB = new System.Windows.Forms.TextBox();
            this.lblcontrasenaDB = new System.Windows.Forms.Label();
            this.txtContrasenaDB = new System.Windows.Forms.TextBox();
            this.txtNombreDB = new System.Windows.Forms.TextBox();
            this.lblnombreDB = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbldireccionIP
            // 
            this.lbldireccionIP.AutoSize = true;
            this.lbldireccionIP.Location = new System.Drawing.Point(13, 28);
            this.lbldireccionIP.Name = "lbldireccionIP";
            this.lbldireccionIP.Size = new System.Drawing.Size(116, 22);
            this.lbldireccionIP.TabIndex = 0;
            this.lbldireccionIP.Text = "Dirección IP:";
            // 
            // txtDireccionIP
            // 
            this.txtDireccionIP.Location = new System.Drawing.Point(135, 25);
            this.txtDireccionIP.Name = "txtDireccionIP";
            this.txtDireccionIP.Size = new System.Drawing.Size(383, 29);
            this.txtDireccionIP.TabIndex = 1;
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(135, 69);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(131, 29);
            this.txtPuerto.TabIndex = 3;
            // 
            // lblPuerto
            // 
            this.lblPuerto.AutoSize = true;
            this.lblPuerto.Location = new System.Drawing.Point(13, 72);
            this.lblPuerto.Name = "lblPuerto";
            this.lblPuerto.Size = new System.Drawing.Size(71, 22);
            this.lblPuerto.TabIndex = 2;
            this.lblPuerto.Text = "Puerto:";
            // 
            // lblusuarioDB
            // 
            this.lblusuarioDB.AutoSize = true;
            this.lblusuarioDB.Location = new System.Drawing.Point(13, 114);
            this.lblusuarioDB.Name = "lblusuarioDB";
            this.lblusuarioDB.Size = new System.Drawing.Size(108, 22);
            this.lblusuarioDB.TabIndex = 4;
            this.lblusuarioDB.Text = "Usuario DB:";
            // 
            // txtUsuarioDB
            // 
            this.txtUsuarioDB.Location = new System.Drawing.Point(135, 111);
            this.txtUsuarioDB.Name = "txtUsuarioDB";
            this.txtUsuarioDB.Size = new System.Drawing.Size(383, 29);
            this.txtUsuarioDB.TabIndex = 5;
            // 
            // lblcontrasenaDB
            // 
            this.lblcontrasenaDB.AutoSize = true;
            this.lblcontrasenaDB.Location = new System.Drawing.Point(13, 155);
            this.lblcontrasenaDB.Name = "lblcontrasenaDB";
            this.lblcontrasenaDB.Size = new System.Drawing.Size(110, 22);
            this.lblcontrasenaDB.TabIndex = 6;
            this.lblcontrasenaDB.Text = "Contraseña:";
            // 
            // txtContrasenaDB
            // 
            this.txtContrasenaDB.Location = new System.Drawing.Point(135, 152);
            this.txtContrasenaDB.Name = "txtContrasenaDB";
            this.txtContrasenaDB.PasswordChar = '*';
            this.txtContrasenaDB.Size = new System.Drawing.Size(383, 29);
            this.txtContrasenaDB.TabIndex = 7;
            this.txtContrasenaDB.UseSystemPasswordChar = true;
            // 
            // txtNombreDB
            // 
            this.txtNombreDB.Location = new System.Drawing.Point(135, 199);
            this.txtNombreDB.Name = "txtNombreDB";
            this.txtNombreDB.Size = new System.Drawing.Size(383, 29);
            this.txtNombreDB.TabIndex = 9;
            // 
            // lblnombreDB
            // 
            this.lblnombreDB.AutoSize = true;
            this.lblnombreDB.Location = new System.Drawing.Point(13, 202);
            this.lblnombreDB.Name = "lblnombreDB";
            this.lblnombreDB.Size = new System.Drawing.Size(109, 22);
            this.lblnombreDB.TabIndex = 8;
            this.lblnombreDB.Text = "Nombre DB:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(74, 269);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(221, 102);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(316, 269);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(221, 102);
            this.BtnSalir.TabIndex = 11;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(524, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(272, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(524, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(524, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 22);
            this.label9.TabIndex = 15;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(524, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 22);
            this.label10.TabIndex = 16;
            this.label10.Text = "*";
            // 
            // FrmConfiguracionDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(604, 405);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNombreDB);
            this.Controls.Add(this.lblnombreDB);
            this.Controls.Add(this.txtContrasenaDB);
            this.Controls.Add(this.lblcontrasenaDB);
            this.Controls.Add(this.txtUsuarioDB);
            this.Controls.Add(this.lblusuarioDB);
            this.Controls.Add(this.txtPuerto);
            this.Controls.Add(this.lblPuerto);
            this.Controls.Add(this.txtDireccionIP);
            this.Controls.Add(this.lbldireccionIP);
            this.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmConfiguracionDatos";
            this.Text = "CONFIGURACION DE BASE DE DATOS";
            this.Load += new System.EventHandler(this.FrmConfiguracionDatos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldireccionIP;
        private System.Windows.Forms.TextBox txtDireccionIP;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.Label lblPuerto;
        private System.Windows.Forms.Label lblusuarioDB;
        private System.Windows.Forms.TextBox txtUsuarioDB;
        private System.Windows.Forms.Label lblcontrasenaDB;
        private System.Windows.Forms.TextBox txtContrasenaDB;
        private System.Windows.Forms.TextBox txtNombreDB;
        private System.Windows.Forms.Label lblnombreDB;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}