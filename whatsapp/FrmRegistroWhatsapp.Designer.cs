namespace reparaciones2.whatsapp
{
    partial class FrmRegistroWhatsapp
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
            this.paso1 = new System.Windows.Forms.GroupBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.lblnombrecompleto = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.paso2 = new System.Windows.Forms.GroupBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtSMS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.paso1.SuspendLayout();
            this.paso2.SuspendLayout();
            this.SuspendLayout();
            // 
            // paso1
            // 
            this.paso1.Controls.Add(this.btnEnviar);
            this.paso1.Controls.Add(this.txtNombreCompleto);
            this.paso1.Controls.Add(this.lblnombrecompleto);
            this.paso1.Controls.Add(this.txtTelefono);
            this.paso1.Controls.Add(this.lbltelefono);
            this.paso1.Location = new System.Drawing.Point(12, 12);
            this.paso1.Name = "paso1";
            this.paso1.Size = new System.Drawing.Size(681, 250);
            this.paso1.TabIndex = 5;
            this.paso1.TabStop = false;
            this.paso1.Text = "Paso 1 Request Code";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(23, 172);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(640, 55);
            this.btnEnviar.TabIndex = 9;
            this.btnEnviar.Text = "ENVIAR";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(23, 127);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(640, 22);
            this.txtNombreCompleto.TabIndex = 8;
            // 
            // lblnombrecompleto
            // 
            this.lblnombrecompleto.AutoSize = true;
            this.lblnombrecompleto.Location = new System.Drawing.Point(20, 97);
            this.lblnombrecompleto.Name = "lblnombrecompleto";
            this.lblnombrecompleto.Size = new System.Drawing.Size(125, 17);
            this.lblnombrecompleto.TabIndex = 7;
            this.lblnombrecompleto.Text = "Nombre Completo:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(23, 60);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(640, 22);
            this.txtTelefono.TabIndex = 6;
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Location = new System.Drawing.Point(20, 30);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(142, 17);
            this.lbltelefono.TabIndex = 5;
            this.lbltelefono.Text = "Numero de Telefono:";
            // 
            // paso2
            // 
            this.paso2.Controls.Add(this.btnConfirmar);
            this.paso2.Controls.Add(this.txtSMS);
            this.paso2.Controls.Add(this.label2);
            this.paso2.Location = new System.Drawing.Point(12, 280);
            this.paso2.Name = "paso2";
            this.paso2.Size = new System.Drawing.Size(681, 185);
            this.paso2.TabIndex = 10;
            this.paso2.TabStop = false;
            this.paso2.Text = "Paso 2 Confirmación";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(23, 105);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(640, 55);
            this.btnConfirmar.TabIndex = 9;
            this.btnConfirmar.Text = "CONFIRMAR";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // txtSMS
            // 
            this.txtSMS.Location = new System.Drawing.Point(23, 60);
            this.txtSMS.Name = "txtSMS";
            this.txtSMS.Size = new System.Drawing.Size(640, 22);
            this.txtSMS.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Código SMS:";
            // 
            // FrmRegistroWhatsapp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 489);
            this.Controls.Add(this.paso2);
            this.Controls.Add(this.paso1);
            this.Name = "FrmRegistroWhatsapp";
            this.Text = "FrmRegistroWhatsapp";
            this.Load += new System.EventHandler(this.FrmRegistroWhatsapp_Load);
            this.paso1.ResumeLayout(false);
            this.paso1.PerformLayout();
            this.paso2.ResumeLayout(false);
            this.paso2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox paso1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.Label lblnombrecompleto;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.GroupBox paso2;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtSMS;
        private System.Windows.Forms.Label label2;
    }
}