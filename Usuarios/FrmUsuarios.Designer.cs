namespace reparaciones2.Usuarios
{
    partial class FrmUsuarios
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
            this.dgwUsuario = new System.Windows.Forms.DataGridView();
            this.lblfiltro = new System.Windows.Forms.Label();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            this.panelBarraArriba = new System.Windows.Forms.Panel();
            this.btnApagar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGrupo = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnBajaAlta = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnCambiarContrasena = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsuario)).BeginInit();
            this.panelBarraArriba.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwUsuario
            // 
            this.dgwUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUsuario.Location = new System.Drawing.Point(160, 106);
            this.dgwUsuario.Name = "dgwUsuario";
            this.dgwUsuario.RowHeadersWidth = 51;
            this.dgwUsuario.RowTemplate.Height = 24;
            this.dgwUsuario.Size = new System.Drawing.Size(615, 330);
            this.dgwUsuario.TabIndex = 0;
            // 
            // lblfiltro
            // 
            this.lblfiltro.AutoSize = true;
            this.lblfiltro.Location = new System.Drawing.Point(362, 72);
            this.lblfiltro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfiltro.Name = "lblfiltro";
            this.lblfiltro.Size = new System.Drawing.Size(59, 22);
            this.lblfiltro.TabIndex = 10;
            this.lblfiltro.Text = "Filtro:";
            // 
            // txtfiltro
            // 
            this.txtfiltro.Location = new System.Drawing.Point(425, 68);
            this.txtfiltro.Margin = new System.Windows.Forms.Padding(2);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(242, 29);
            this.txtfiltro.TabIndex = 11;
            // 
            // panelBarraArriba
            // 
            this.panelBarraArriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.panelBarraArriba.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBarraArriba.Controls.Add(this.btnApagar);
            this.panelBarraArriba.Controls.Add(this.label5);
            this.panelBarraArriba.Location = new System.Drawing.Point(0, 2);
            this.panelBarraArriba.Margin = new System.Windows.Forms.Padding(2);
            this.panelBarraArriba.Name = "panelBarraArriba";
            this.panelBarraArriba.Size = new System.Drawing.Size(787, 50);
            this.panelBarraArriba.TabIndex = 19;
            // 
            // btnApagar
            // 
            this.btnApagar.FlatAppearance.BorderSize = 0;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Image = global::reparaciones2.Properties.Resources.exit;
            this.btnApagar.Location = new System.Drawing.Point(707, 2);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(2);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(50, 50);
            this.btnApagar.TabIndex = 4;
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(315, 33);
            this.label5.TabIndex = 3;
            this.label5.Text = "ADMINISTAR USUARIO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(130)))), ((int)(((byte)(172)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnGrupo);
            this.panel1.Controls.Add(this.btnguardar);
            this.panel1.Controls.Add(this.btnBajaAlta);
            this.panel1.Controls.Add(this.btncancelar);
            this.panel1.Controls.Add(this.btnCambiarContrasena);
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(107, 445);
            this.panel1.TabIndex = 20;
            // 
            // btnGrupo
            // 
            this.btnGrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnGrupo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGrupo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrupo.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.btnGrupo.ForeColor = System.Drawing.Color.White;
            this.btnGrupo.Image = global::reparaciones2.Properties.Resources.equipo;
            this.btnGrupo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGrupo.Location = new System.Drawing.Point(-1, 217);
            this.btnGrupo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnGrupo.Name = "btnGrupo";
            this.btnGrupo.Size = new System.Drawing.Size(113, 79);
            this.btnGrupo.TabIndex = 19;
            this.btnGrupo.Text = "CAMBIAR GRUPO";
            this.btnGrupo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGrupo.UseVisualStyleBackColor = false;
            this.btnGrupo.Click += new System.EventHandler(this.btnGrupo_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnguardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.Image = global::reparaciones2.Properties.Resources.edit_add;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnguardar.Location = new System.Drawing.Point(-1, 0);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(106, 78);
            this.btnguardar.TabIndex = 4;
            this.btnguardar.Text = "AGREGAR";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnBajaAlta
            // 
            this.btnBajaAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnBajaAlta.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBajaAlta.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBajaAlta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBajaAlta.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.btnBajaAlta.ForeColor = System.Drawing.Color.White;
            this.btnBajaAlta.Image = global::reparaciones2.Properties.Resources.cambio;
            this.btnBajaAlta.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBajaAlta.Location = new System.Drawing.Point(-1, 76);
            this.btnBajaAlta.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnBajaAlta.Name = "btnBajaAlta";
            this.btnBajaAlta.Size = new System.Drawing.Size(106, 68);
            this.btnBajaAlta.TabIndex = 18;
            this.btnBajaAlta.Text = "Baja/Alta";
            this.btnBajaAlta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBajaAlta.UseVisualStyleBackColor = false;
            this.btnBajaAlta.Click += new System.EventHandler(this.btnBajaAlta_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Image = global::reparaciones2.Properties.Resources.cancel;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(-1, 295);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(106, 73);
            this.btncancelar.TabIndex = 15;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = false;
            // 
            // btnCambiarContrasena
            // 
            this.btnCambiarContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnCambiarContrasena.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCambiarContrasena.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCambiarContrasena.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarContrasena.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.btnCambiarContrasena.ForeColor = System.Drawing.Color.White;
            this.btnCambiarContrasena.Image = global::reparaciones2.Properties.Resources.llave;
            this.btnCambiarContrasena.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCambiarContrasena.Location = new System.Drawing.Point(-8, 141);
            this.btnCambiarContrasena.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCambiarContrasena.Name = "btnCambiarContrasena";
            this.btnCambiarContrasena.Size = new System.Drawing.Size(113, 79);
            this.btnCambiarContrasena.TabIndex = 16;
            this.btnCambiarContrasena.Text = "CAMBIAR CON";
            this.btnCambiarContrasena.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCambiarContrasena.UseVisualStyleBackColor = false;
            this.btnCambiarContrasena.Click += new System.EventHandler(this.btnCambiarContrasena_Click);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnX.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Image = global::reparaciones2.Properties.Resources.stop;
            this.btnX.Location = new System.Drawing.Point(721, 68);
            this.btnX.Margin = new System.Windows.Forms.Padding(2);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(52, 30);
            this.btnX.TabIndex = 13;
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnFiltrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Image = global::reparaciones2.Properties.Resources.viewmag;
            this.btnFiltrar.Location = new System.Drawing.Point(672, 68);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(44, 30);
            this.btnFiltrar.TabIndex = 12;
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(789, 496);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBarraArriba);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.txtfiltro);
            this.Controls.Add(this.lblfiltro);
            this.Controls.Add(this.dgwUsuario);
            this.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de Usuarios";
            this.Load += new System.EventHandler(this.FrmUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwUsuario)).EndInit();
            this.panelBarraArriba.ResumeLayout(false);
            this.panelBarraArriba.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwUsuario;
        private System.Windows.Forms.Label lblfiltro;
        private System.Windows.Forms.TextBox txtfiltro;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnCambiarContrasena;
        private System.Windows.Forms.Button btnBajaAlta;
        private System.Windows.Forms.Panel panelBarraArriba;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnGrupo;
    }
}