namespace reparaciones2
{
    partial class Whatsapp
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
            this.lblfrom = new System.Windows.Forms.Label();
            this.txtfrom = new System.Windows.Forms.TextBox();
            this.txtto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmessage = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblfrom
            // 
            this.lblfrom.AutoSize = true;
            this.lblfrom.Location = new System.Drawing.Point(13, 13);
            this.lblfrom.Name = "lblfrom";
            this.lblfrom.Size = new System.Drawing.Size(46, 17);
            this.lblfrom.TabIndex = 0;
            this.lblfrom.Text = "label1";
            // 
            // txtfrom
            // 
            this.txtfrom.Location = new System.Drawing.Point(13, 44);
            this.txtfrom.Name = "txtfrom";
            this.txtfrom.Size = new System.Drawing.Size(702, 22);
            this.txtfrom.TabIndex = 1;
            // 
            // txtto
            // 
            this.txtto.Location = new System.Drawing.Point(13, 108);
            this.txtto.Name = "txtto";
            this.txtto.Size = new System.Drawing.Size(702, 22);
            this.txtto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // txtmessage
            // 
            this.txtmessage.Location = new System.Drawing.Point(16, 161);
            this.txtmessage.Multiline = true;
            this.txtmessage.Name = "txtmessage";
            this.txtmessage.Size = new System.Drawing.Size(702, 270);
            this.txtmessage.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 76);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Whatsapp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 540);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtmessage);
            this.Controls.Add(this.txtto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtfrom);
            this.Controls.Add(this.lblfrom);
            this.Name = "Whatsapp";
            this.Text = "Whatsapp";
            this.Load += new System.EventHandler(this.Whatsapp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfrom;
        private System.Windows.Forms.TextBox txtfrom;
        private System.Windows.Forms.TextBox txtto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmessage;
        private System.Windows.Forms.Button button1;
    }
}