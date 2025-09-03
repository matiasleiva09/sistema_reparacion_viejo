namespace reparaciones2
{
    partial class FrmEnvioMailSimple
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblPara = new System.Windows.Forms.Label();
            this.txtdestinatario = new System.Windows.Forms.TextBox();
            this.lblcc = new System.Windows.Forms.Label();
            this.txtcc = new System.Windows.Forms.TextBox();
            this.lblcco = new System.Windows.Forms.Label();
            this.txtcco = new System.Windows.Forms.TextBox();
            this.lblsubject = new System.Windows.Forms.Label();
            this.txtsubject = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.dgwAdjunto = new System.Windows.Forms.DataGridView();
            this.PathArchivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Archivo = new System.Windows.Forms.DataGridViewLinkColumn();
            this.btnsubrayado = new System.Windows.Forms.Button();
            this.btnItalic = new System.Windows.Forms.Button();
            this.btnNegrita = new System.Windows.Forms.Button();
            this.btnAdjuntar = new System.Windows.Forms.Button();
            this.txtcuerpo = new System.Windows.Forms.RichTextBox();
            this.ofdBuscarArchivo = new System.Windows.Forms.OpenFileDialog();
            this.panelBarraArriba.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAdjunto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBarraArriba
            // 
            this.panelBarraArriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.panelBarraArriba.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBarraArriba.Controls.Add(this.btnApagar);
            this.panelBarraArriba.Controls.Add(this.lbltitulo);
            this.panelBarraArriba.Location = new System.Drawing.Point(8, -5);
            this.panelBarraArriba.Margin = new System.Windows.Forms.Padding(2);
            this.panelBarraArriba.Name = "panelBarraArriba";
            this.panelBarraArriba.Size = new System.Drawing.Size(1208, 54);
            this.panelBarraArriba.TabIndex = 54;
            // 
            // btnApagar
            // 
            this.btnApagar.FlatAppearance.BorderSize = 0;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Image = global::reparaciones2.Properties.Resources.exit;
            this.btnApagar.Location = new System.Drawing.Point(1157, 3);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(2);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(50, 50);
            this.btnApagar.TabIndex = 4;
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
            this.lbltitulo.Size = new System.Drawing.Size(247, 33);
            this.lbltitulo.TabIndex = 3;
            this.lbltitulo.Text = "NUEVO MENSAJE";
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Image = global::reparaciones2.Properties.Resources.mail_send;
            this.btnAceptar.Location = new System.Drawing.Point(2, 13);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(130, 69);
            this.btnAceptar.TabIndex = 42;
            this.btnAceptar.Text = "ENVIAR";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblPara
            // 
            this.lblPara.AutoSize = true;
            this.lblPara.Location = new System.Drawing.Point(153, 13);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(42, 17);
            this.lblPara.TabIndex = 0;
            this.lblPara.Text = "Para:";
            this.lblPara.Click += new System.EventHandler(this.lblPara_Click);
            // 
            // txtdestinatario
            // 
            this.txtdestinatario.Location = new System.Drawing.Point(215, 13);
            this.txtdestinatario.Name = "txtdestinatario";
            this.txtdestinatario.Size = new System.Drawing.Size(859, 22);
            this.txtdestinatario.TabIndex = 1;
            // 
            // lblcc
            // 
            this.lblcc.AutoSize = true;
            this.lblcc.Location = new System.Drawing.Point(153, 46);
            this.lblcc.Name = "lblcc";
            this.lblcc.Size = new System.Drawing.Size(30, 17);
            this.lblcc.TabIndex = 2;
            this.lblcc.Text = "CC:";
            // 
            // txtcc
            // 
            this.txtcc.Location = new System.Drawing.Point(215, 46);
            this.txtcc.Name = "txtcc";
            this.txtcc.Size = new System.Drawing.Size(859, 22);
            this.txtcc.TabIndex = 3;
            // 
            // lblcco
            // 
            this.lblcco.AutoSize = true;
            this.lblcco.Location = new System.Drawing.Point(153, 82);
            this.lblcco.Name = "lblcco";
            this.lblcco.Size = new System.Drawing.Size(41, 17);
            this.lblcco.TabIndex = 4;
            this.lblcco.Text = "CCO:";
            // 
            // txtcco
            // 
            this.txtcco.Location = new System.Drawing.Point(215, 79);
            this.txtcco.Name = "txtcco";
            this.txtcco.Size = new System.Drawing.Size(859, 22);
            this.txtcco.TabIndex = 5;
            // 
            // lblsubject
            // 
            this.lblsubject.AutoSize = true;
            this.lblsubject.Location = new System.Drawing.Point(153, 111);
            this.lblsubject.Name = "lblsubject";
            this.lblsubject.Size = new System.Drawing.Size(56, 17);
            this.lblsubject.TabIndex = 6;
            this.lblsubject.Text = "Asunto:";
            // 
            // txtsubject
            // 
            this.txtsubject.Location = new System.Drawing.Point(215, 111);
            this.txtsubject.Name = "txtsubject";
            this.txtsubject.Size = new System.Drawing.Size(859, 22);
            this.txtsubject.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnBorrar);
            this.panel2.Controls.Add(this.dgwAdjunto);
            this.panel2.Controls.Add(this.btnsubrayado);
            this.panel2.Controls.Add(this.btnItalic);
            this.panel2.Controls.Add(this.btnNegrita);
            this.panel2.Controls.Add(this.btnAdjuntar);
            this.panel2.Controls.Add(this.btnAceptar);
            this.panel2.Controls.Add(this.txtcuerpo);
            this.panel2.Controls.Add(this.txtsubject);
            this.panel2.Controls.Add(this.lblsubject);
            this.panel2.Controls.Add(this.txtcco);
            this.panel2.Controls.Add(this.lblcco);
            this.panel2.Controls.Add(this.txtcc);
            this.panel2.Controls.Add(this.lblcc);
            this.panel2.Controls.Add(this.txtdestinatario);
            this.panel2.Controls.Add(this.lblPara);
            this.panel2.Location = new System.Drawing.Point(8, 51);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1208, 699);
            this.panel2.TabIndex = 56;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnBorrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Location = new System.Drawing.Point(925, 195);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(149, 47);
            this.btnBorrar.TabIndex = 48;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // dgwAdjunto
            // 
            this.dgwAdjunto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAdjunto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PathArchivo,
            this.Archivo});
            this.dgwAdjunto.Location = new System.Drawing.Point(6, 195);
            this.dgwAdjunto.Name = "dgwAdjunto";
            this.dgwAdjunto.ReadOnly = true;
            this.dgwAdjunto.RowTemplate.Height = 24;
            this.dgwAdjunto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwAdjunto.Size = new System.Drawing.Size(914, 118);
            this.dgwAdjunto.TabIndex = 47;
            this.dgwAdjunto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAdjunto_CellContentClick);
            this.dgwAdjunto.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAdjunto_CellContentDoubleClick);
            // 
            // PathArchivo
            // 
            this.PathArchivo.HeaderText = "PathArchivo";
            this.PathArchivo.Name = "PathArchivo";
            this.PathArchivo.ReadOnly = true;
            this.PathArchivo.Visible = false;
            // 
            // Archivo
            // 
            this.Archivo.HeaderText = "Archivo";
            this.Archivo.Name = "Archivo";
            this.Archivo.ReadOnly = true;
            // 
            // btnsubrayado
            // 
            this.btnsubrayado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnsubrayado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsubrayado.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubrayado.ForeColor = System.Drawing.Color.White;
            this.btnsubrayado.Location = new System.Drawing.Point(118, 342);
            this.btnsubrayado.Name = "btnsubrayado";
            this.btnsubrayado.Size = new System.Drawing.Size(50, 37);
            this.btnsubrayado.TabIndex = 46;
            this.btnsubrayado.Text = "S";
            this.btnsubrayado.UseVisualStyleBackColor = false;
            this.btnsubrayado.Click += new System.EventHandler(this.btnsubrayado_Click);
            // 
            // btnItalic
            // 
            this.btnItalic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnItalic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItalic.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItalic.ForeColor = System.Drawing.Color.White;
            this.btnItalic.Location = new System.Drawing.Point(62, 342);
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(50, 37);
            this.btnItalic.TabIndex = 45;
            this.btnItalic.Text = "I";
            this.btnItalic.UseVisualStyleBackColor = false;
            this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
            // 
            // btnNegrita
            // 
            this.btnNegrita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnNegrita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNegrita.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btnNegrita.ForeColor = System.Drawing.Color.White;
            this.btnNegrita.Location = new System.Drawing.Point(6, 342);
            this.btnNegrita.Name = "btnNegrita";
            this.btnNegrita.Size = new System.Drawing.Size(50, 37);
            this.btnNegrita.TabIndex = 44;
            this.btnNegrita.Text = "B";
            this.btnNegrita.UseVisualStyleBackColor = false;
            this.btnNegrita.Click += new System.EventHandler(this.btnNegrita_Click);
            // 
            // btnAdjuntar
            // 
            this.btnAdjuntar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnAdjuntar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAdjuntar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdjuntar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdjuntar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdjuntar.ForeColor = System.Drawing.Color.White;
            this.btnAdjuntar.Location = new System.Drawing.Point(7, 143);
            this.btnAdjuntar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdjuntar.Name = "btnAdjuntar";
            this.btnAdjuntar.Size = new System.Drawing.Size(176, 47);
            this.btnAdjuntar.TabIndex = 43;
            this.btnAdjuntar.Text = "ADJUNTAR";
            this.btnAdjuntar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdjuntar.UseVisualStyleBackColor = false;
            this.btnAdjuntar.Click += new System.EventHandler(this.btnAdjuntar_Click);
            // 
            // txtcuerpo
            // 
            this.txtcuerpo.EnableAutoDragDrop = true;
            this.txtcuerpo.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcuerpo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtcuerpo.Location = new System.Drawing.Point(6, 385);
            this.txtcuerpo.Name = "txtcuerpo";
            this.txtcuerpo.Size = new System.Drawing.Size(1187, 276);
            this.txtcuerpo.TabIndex = 9;
            this.txtcuerpo.Text = "";
            // 
            // ofdBuscarArchivo
            // 
            this.ofdBuscarArchivo.FileName = "archivo";
            // 
            // FrmEnvioMailSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 763);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelBarraArriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEnvioMailSimple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEnvioMailSimple";
            this.panelBarraArriba.ResumeLayout(false);
            this.panelBarraArriba.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAdjunto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBarraArriba;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblPara;
        private System.Windows.Forms.TextBox txtdestinatario;
        private System.Windows.Forms.Label lblcc;
        private System.Windows.Forms.TextBox txtcc;
        private System.Windows.Forms.Label lblcco;
        private System.Windows.Forms.TextBox txtcco;
        private System.Windows.Forms.Label lblsubject;
        private System.Windows.Forms.TextBox txtsubject;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdjuntar;
        private System.Windows.Forms.Button btnNegrita;
        private System.Windows.Forms.RichTextBox txtcuerpo;
        private System.Windows.Forms.Button btnItalic;
        private System.Windows.Forms.Button btnsubrayado;
        private System.Windows.Forms.OpenFileDialog ofdBuscarArchivo;
        private System.Windows.Forms.DataGridView dgwAdjunto;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn PathArchivo;
        private System.Windows.Forms.DataGridViewLinkColumn Archivo;
    }
}