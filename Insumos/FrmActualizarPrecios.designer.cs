namespace stocksires.Insumos
{
    partial class FrmActualizarPrecios
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
            this.lblporcentaje = new System.Windows.Forms.Label();
            this.txtporcentaje = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblporcentaje
            // 
            this.lblporcentaje.AutoSize = true;
            this.lblporcentaje.Location = new System.Drawing.Point(33, 63);
            this.lblporcentaje.Name = "lblporcentaje";
            this.lblporcentaje.Size = new System.Drawing.Size(74, 17);
            this.lblporcentaje.TabIndex = 0;
            this.lblporcentaje.Text = "Actualizar:";
            // 
            // txtporcentaje
            // 
            this.txtporcentaje.Location = new System.Drawing.Point(184, 60);
            this.txtporcentaje.Name = "txtporcentaje";
            this.txtporcentaje.Size = new System.Drawing.Size(273, 22);
            this.txtporcentaje.TabIndex = 1;
            this.txtporcentaje.Text = "10";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnActualizar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Image = global::reparaciones2.Properties.Resources.pay1;
            this.btnActualizar.Location = new System.Drawing.Point(157, 108);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(140, 86);
            this.btnActualizar.TabIndex = 45;
            this.btnActualizar.Text = "ACUALIZAR";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::reparaciones2.Properties.Resources.cancel;
            this.button1.Location = new System.Drawing.Point(317, 108);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 86);
            this.button1.TabIndex = 46;
            this.button1.Text = "SALIR";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmActualizarPrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(639, 219);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtporcentaje);
            this.Controls.Add(this.lblporcentaje);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmActualizarPrecios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmActualizarPrecios";
            this.Load += new System.EventHandler(this.FrmActualizarPrecios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblporcentaje;
        private System.Windows.Forms.TextBox txtporcentaje;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button button1;
    }
}