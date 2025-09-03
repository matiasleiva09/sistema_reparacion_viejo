namespace reparaciones2.reparaciones
{
    partial class ItemReparacion
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelBarraArriba = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.raServicio = new System.Windows.Forms.RadioButton();
            this.cmbTarifa = new System.Windows.Forms.ComboBox();
            this.raProducto = new System.Windows.Forms.RadioButton();
            this.BtnXProducto = new System.Windows.Forms.Button();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.txtcodigoProducto = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panelBarraArriba.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::reparaciones2.Properties.Resources.apply;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(-1, 0);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(121, 62);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Image = global::reparaciones2.Properties.Resources.cancel;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(-1, 61);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(121, 70);
            this.btncancelar.TabIndex = 5;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(130)))), ((int)(((byte)(172)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btncancelar);
            this.panel1.Location = new System.Drawing.Point(2, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 201);
            this.panel1.TabIndex = 49;
            // 
            // panelBarraArriba
            // 
            this.panelBarraArriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.panelBarraArriba.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBarraArriba.Controls.Add(this.button1);
            this.panelBarraArriba.Controls.Add(this.lbltitulo);
            this.panelBarraArriba.Location = new System.Drawing.Point(2, 0);
            this.panelBarraArriba.Margin = new System.Windows.Forms.Padding(2);
            this.panelBarraArriba.Name = "panelBarraArriba";
            this.panelBarraArriba.Size = new System.Drawing.Size(813, 50);
            this.panelBarraArriba.TabIndex = 50;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::reparaciones2.Properties.Resources.exit;
            this.button1.Location = new System.Drawing.Point(738, -1);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbltitulo.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.White;
            this.lbltitulo.Location = new System.Drawing.Point(14, 12);
            this.lbltitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(218, 33);
            this.lbltitulo.TabIndex = 3;
            this.lbltitulo.Text = "ITEM SERVICIO";
            // 
            // raServicio
            // 
            this.raServicio.AutoSize = true;
            this.raServicio.Location = new System.Drawing.Point(158, 68);
            this.raServicio.Name = "raServicio";
            this.raServicio.Size = new System.Drawing.Size(79, 21);
            this.raServicio.TabIndex = 51;
            this.raServicio.TabStop = true;
            this.raServicio.Text = "Servicio";
            this.raServicio.UseVisualStyleBackColor = true;
            // 
            // cmbTarifa
            // 
            this.cmbTarifa.FormattingEnabled = true;
            this.cmbTarifa.Location = new System.Drawing.Point(158, 110);
            this.cmbTarifa.Name = "cmbTarifa";
            this.cmbTarifa.Size = new System.Drawing.Size(612, 24);
            this.cmbTarifa.TabIndex = 52;
            // 
            // raProducto
            // 
            this.raProducto.AutoSize = true;
            this.raProducto.Location = new System.Drawing.Point(156, 155);
            this.raProducto.Name = "raProducto";
            this.raProducto.Size = new System.Drawing.Size(86, 21);
            this.raProducto.TabIndex = 53;
            this.raProducto.TabStop = true;
            this.raProducto.Text = "Producto";
            this.raProducto.UseVisualStyleBackColor = true;
            // 
            // BtnXProducto
            // 
            this.BtnXProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.BtnXProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnXProducto.Image = global::reparaciones2.Properties.Resources.stop;
            this.BtnXProducto.Location = new System.Drawing.Point(721, 180);
            this.BtnXProducto.Margin = new System.Windows.Forms.Padding(4);
            this.BtnXProducto.Name = "BtnXProducto";
            this.BtnXProducto.Size = new System.Drawing.Size(40, 29);
            this.BtnXProducto.TabIndex = 55;
            this.BtnXProducto.UseVisualStyleBackColor = false;
            // 
            // txtproducto
            // 
            this.txtproducto.Enabled = false;
            this.txtproducto.Location = new System.Drawing.Point(273, 183);
            this.txtproducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(392, 22);
            this.txtproducto.TabIndex = 56;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProducto.Image = global::reparaciones2.Properties.Resources.viewmag1;
            this.btnBuscarProducto.Location = new System.Drawing.Point(673, 180);
            this.btnBuscarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(40, 29);
            this.btnBuscarProducto.TabIndex = 54;
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            // 
            // txtcodigoProducto
            // 
            this.txtcodigoProducto.Enabled = false;
            this.txtcodigoProducto.Location = new System.Drawing.Point(156, 183);
            this.txtcodigoProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtcodigoProducto.Name = "txtcodigoProducto";
            this.txtcodigoProducto.Size = new System.Drawing.Size(109, 22);
            this.txtcodigoProducto.TabIndex = 57;
            // 
            // ItemReparacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(802, 249);
            this.Controls.Add(this.txtcodigoProducto);
            this.Controls.Add(this.BtnXProducto);
            this.Controls.Add(this.txtproducto);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.raProducto);
            this.Controls.Add(this.cmbTarifa);
            this.Controls.Add(this.raServicio);
            this.Controls.Add(this.panelBarraArriba);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemReparacion";
            this.Text = "ItemReparacion";
            this.Load += new System.EventHandler(this.ItemReparacion_Load);
            this.panel1.ResumeLayout(false);
            this.panelBarraArriba.ResumeLayout(false);
            this.panelBarraArriba.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelBarraArriba;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.RadioButton raServicio;
        private System.Windows.Forms.ComboBox cmbTarifa;
        private System.Windows.Forms.RadioButton raProducto;
        private System.Windows.Forms.Button BtnXProducto;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.TextBox txtcodigoProducto;
    }
}