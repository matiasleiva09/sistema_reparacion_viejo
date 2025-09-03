namespace reparaciones2.Insumos
{
    partial class FrmMarca
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
            this.panelBarraArriba = new System.Windows.Forms.Panel();
            this.btnApagar = new System.Windows.Forms.Button();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardarModelo = new System.Windows.Forms.Button();
            this.btnCancelarModelo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblmarca = new System.Windows.Forms.Label();
            this.panelBarraArriba.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBarraArriba
            // 
            this.panelBarraArriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.panelBarraArriba.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBarraArriba.Controls.Add(this.btnApagar);
            this.panelBarraArriba.Controls.Add(this.lbltitulo);
            this.panelBarraArriba.Location = new System.Drawing.Point(0, 2);
            this.panelBarraArriba.Margin = new System.Windows.Forms.Padding(2);
            this.panelBarraArriba.Name = "panelBarraArriba";
            this.panelBarraArriba.Size = new System.Drawing.Size(813, 50);
            this.panelBarraArriba.TabIndex = 6;
            // 
            // btnApagar
            // 
            this.btnApagar.FlatAppearance.BorderSize = 0;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Image = global::reparaciones2.Properties.Resources.exit;
            this.btnApagar.Location = new System.Drawing.Point(762, -1);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(2);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(50, 50);
            this.btnApagar.TabIndex = 6;
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
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
            this.lbltitulo.Size = new System.Drawing.Size(131, 33);
            this.lbltitulo.TabIndex = 3;
            this.lbltitulo.Text = "MARCAS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(130)))), ((int)(((byte)(172)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnGuardarModelo);
            this.panel1.Controls.Add(this.btnCancelarModelo);
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 176);
            this.panel1.TabIndex = 5;
            // 
            // btnGuardarModelo
            // 
            this.btnGuardarModelo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardarModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarModelo.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarModelo.ForeColor = System.Drawing.Color.White;
            this.btnGuardarModelo.Image = global::reparaciones2.Properties.Resources.apply;
            this.btnGuardarModelo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardarModelo.Location = new System.Drawing.Point(-1, 0);
            this.btnGuardarModelo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnGuardarModelo.Name = "btnGuardarModelo";
            this.btnGuardarModelo.Size = new System.Drawing.Size(138, 78);
            this.btnGuardarModelo.TabIndex = 4;
            this.btnGuardarModelo.Text = "GUARDAR";
            this.btnGuardarModelo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardarModelo.UseVisualStyleBackColor = true;
            this.btnGuardarModelo.Click += new System.EventHandler(this.btnGuardarModelo_Click);
            // 
            // btnCancelarModelo
            // 
            this.btnCancelarModelo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancelarModelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarModelo.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarModelo.ForeColor = System.Drawing.Color.White;
            this.btnCancelarModelo.Image = global::reparaciones2.Properties.Resources.cancel;
            this.btnCancelarModelo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelarModelo.Location = new System.Drawing.Point(-1, 76);
            this.btnCancelarModelo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCancelarModelo.Name = "btnCancelarModelo";
            this.btnCancelarModelo.Size = new System.Drawing.Size(138, 71);
            this.btnCancelarModelo.TabIndex = 5;
            this.btnCancelarModelo.Text = "CANCELAR";
            this.btnCancelarModelo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelarModelo.UseVisualStyleBackColor = true;
            this.btnCancelarModelo.Click += new System.EventHandler(this.btnCancelarModelo_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtMarca);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblmarca);
            this.panel2.Location = new System.Drawing.Point(138, 52);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(674, 176);
            this.panel2.TabIndex = 4;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(87, 31);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(440, 22);
            this.txtMarca.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(534, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "*";
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmarca.Location = new System.Drawing.Point(24, 35);
            this.lblmarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(55, 18);
            this.lblmarca.TabIndex = 13;
            this.lblmarca.Text = "Marca:";
            // 
            // FrmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(814, 229);
            this.Controls.Add(this.panelBarraArriba);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMarca";
            this.panelBarraArriba.ResumeLayout(false);
            this.panelBarraArriba.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarraArriba;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardarModelo;
        private System.Windows.Forms.Button btnCancelarModelo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblmarca;
    }
}