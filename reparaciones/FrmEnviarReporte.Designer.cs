namespace reparaciones2.reparaciones
{
    partial class FrmEnviarReporte
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
            this.label5 = new System.Windows.Forms.Label();
            this.panelBarraArriba = new System.Windows.Forms.Panel();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnmail = new System.Windows.Forms.Button();
            this.btnWhatsapp = new System.Windows.Forms.Button();
            this.panelBarraArriba.SuspendLayout();
            this.SuspendLayout();
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
            this.label5.Size = new System.Drawing.Size(344, 33);
            this.label5.TabIndex = 3;
            this.label5.Text = "IMPRESION DE REPORTE";
            // 
            // panelBarraArriba
            // 
            this.panelBarraArriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.panelBarraArriba.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBarraArriba.Controls.Add(this.btnApagar);
            this.panelBarraArriba.Controls.Add(this.label5);
            this.panelBarraArriba.Location = new System.Drawing.Point(0, 0);
            this.panelBarraArriba.Margin = new System.Windows.Forms.Padding(2);
            this.panelBarraArriba.Name = "panelBarraArriba";
            this.panelBarraArriba.Size = new System.Drawing.Size(637, 53);
            this.panelBarraArriba.TabIndex = 6;
            // 
            // btnApagar
            // 
            this.btnApagar.FlatAppearance.BorderSize = 0;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Image = global::reparaciones2.Properties.Resources.exit;
            this.btnApagar.Location = new System.Drawing.Point(583, 2);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(2);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(50, 50);
            this.btnApagar.TabIndex = 1;
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Image = global::reparaciones2.Properties.Resources.printer;
            this.btnImprimir.Location = new System.Drawing.Point(46, 86);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(145, 86);
            this.btnImprimir.TabIndex = 43;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnmail
            // 
            this.btnmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnmail.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnmail.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmail.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmail.ForeColor = System.Drawing.Color.White;
            this.btnmail.Image = global::reparaciones2.Properties.Resources.mail_send1;
            this.btnmail.Location = new System.Drawing.Point(390, 86);
            this.btnmail.Margin = new System.Windows.Forms.Padding(2);
            this.btnmail.Name = "btnmail";
            this.btnmail.Size = new System.Drawing.Size(140, 86);
            this.btnmail.TabIndex = 44;
            this.btnmail.Text = "EMAIL";
            this.btnmail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnmail.UseVisualStyleBackColor = false;
            this.btnmail.Click += new System.EventHandler(this.btnmail_Click);
            // 
            // btnWhatsapp
            // 
            this.btnWhatsapp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnWhatsapp.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnWhatsapp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWhatsapp.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWhatsapp.ForeColor = System.Drawing.Color.White;
            this.btnWhatsapp.Image = global::reparaciones2.Properties.Resources.whatsapp__1_;
            this.btnWhatsapp.Location = new System.Drawing.Point(220, 86);
            this.btnWhatsapp.Margin = new System.Windows.Forms.Padding(2);
            this.btnWhatsapp.Name = "btnWhatsapp";
            this.btnWhatsapp.Size = new System.Drawing.Size(140, 86);
            this.btnWhatsapp.TabIndex = 45;
            this.btnWhatsapp.Text = "WHATSAPP";
            this.btnWhatsapp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnWhatsapp.UseVisualStyleBackColor = false;
            this.btnWhatsapp.Click += new System.EventHandler(this.btnWhatsapp_Click);
            // 
            // FrmEnviarReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(635, 221);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnmail);
            this.Controls.Add(this.btnWhatsapp);
            this.Controls.Add(this.panelBarraArriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEnviarReporte";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEnviarReporte";
            this.Load += new System.EventHandler(this.FrmEnviarReporte_Load);
            this.panelBarraArriba.ResumeLayout(false);
            this.panelBarraArriba.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelBarraArriba;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnmail;
        private System.Windows.Forms.Button btnWhatsapp;
    }
}