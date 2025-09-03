namespace reparaciones2
{
    partial class FrmInformeVersion
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
            this.lblversionactual = new System.Windows.Forms.Label();
            this.lblnroVersion = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblversionactual
            // 
            this.lblversionactual.AutoSize = true;
            this.lblversionactual.Location = new System.Drawing.Point(10, 22);
            this.lblversionactual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblversionactual.Name = "lblversionactual";
            this.lblversionactual.Size = new System.Drawing.Size(106, 17);
            this.lblversionactual.TabIndex = 0;
            this.lblversionactual.Text = "Versión Actual:";
            // 
            // lblnroVersion
            // 
            this.lblnroVersion.AutoSize = true;
            this.lblnroVersion.Location = new System.Drawing.Point(125, 22);
            this.lblnroVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnroVersion.Name = "lblnroVersion";
            this.lblnroVersion.Size = new System.Drawing.Size(58, 17);
            this.lblnroVersion.TabIndex = 1;
            this.lblnroVersion.Text = "V1.3.0B";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(14, 53);
            this.txtdescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.ReadOnly = true;
            this.txtdescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtdescripcion.Size = new System.Drawing.Size(654, 230);
            this.txtdescripcion.TabIndex = 2;
            this.txtdescripcion.TextChanged += new System.EventHandler(this.txtdescripcion_TextChanged);
            // 
            // btnsalir
            // 
            this.btnsalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnsalir.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btnsalir.Image = global::reparaciones2.Properties.Resources.cancel;
            this.btnsalir.Location = new System.Drawing.Point(298, 294);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(106, 46);
            this.btnsalir.TabIndex = 5;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // FrmInformeVersion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(707, 463);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.lblnroVersion);
            this.Controls.Add(this.lblversionactual);
            this.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmInformeVersion";
            this.Text = "Informe de Versión";
            this.Load += new System.EventHandler(this.FrmInformeVersion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblversionactual;
        private System.Windows.Forms.Label lblnroVersion;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Button btnsalir;
    }
}