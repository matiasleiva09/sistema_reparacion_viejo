namespace reparaciones2.Insumos
{
    partial class FrmFacturasDeProveedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgwFacturas = new System.Windows.Forms.DataGridView();
            this.lblfiltro = new System.Windows.Forms.Label();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.panelBarraArriba = new System.Windows.Forms.Panel();
            this.btnApagar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFacturas)).BeginInit();
            this.panelBarraArriba.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(130)))), ((int)(((byte)(172)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnsalir);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Location = new System.Drawing.Point(2, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 506);
            this.panel1.TabIndex = 57;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnsalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnsalir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.White;
            this.btnsalir.Image = global::reparaciones2.Properties.Resources.cancel;
            this.btnsalir.Location = new System.Drawing.Point(-2, 85);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(140, 86);
            this.btnsalir.TabIndex = 41;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = global::reparaciones2.Properties.Resources.edit_add1;
            this.btnAgregar.Location = new System.Drawing.Point(-2, 5);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(140, 86);
            this.btnAgregar.TabIndex = 42;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgwFacturas);
            this.panel2.Controls.Add(this.lblfiltro);
            this.panel2.Controls.Add(this.txtfiltro);
            this.panel2.Controls.Add(this.btnFiltrar);
            this.panel2.Controls.Add(this.btnX);
            this.panel2.Location = new System.Drawing.Point(147, 70);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1109, 500);
            this.panel2.TabIndex = 58;
            // 
            // dgwFacturas
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgwFacturas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwFacturas.Location = new System.Drawing.Point(26, 60);
            this.dgwFacturas.Margin = new System.Windows.Forms.Padding(2);
            this.dgwFacturas.Name = "dgwFacturas";
            this.dgwFacturas.ReadOnly = true;
            this.dgwFacturas.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgwFacturas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwFacturas.Size = new System.Drawing.Size(1070, 428);
            this.dgwFacturas.TabIndex = 12;
            this.dgwFacturas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwFacturas_CellDoubleClick);
            // 
            // lblfiltro
            // 
            this.lblfiltro.AutoSize = true;
            this.lblfiltro.Location = new System.Drawing.Point(577, 22);
            this.lblfiltro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfiltro.Name = "lblfiltro";
            this.lblfiltro.Size = new System.Drawing.Size(43, 17);
            this.lblfiltro.TabIndex = 8;
            this.lblfiltro.Text = "Filtro:";
            // 
            // txtfiltro
            // 
            this.txtfiltro.Location = new System.Drawing.Point(624, 22);
            this.txtfiltro.Margin = new System.Windows.Forms.Padding(2);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(374, 22);
            this.txtfiltro.TabIndex = 9;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Image = global::reparaciones2.Properties.Resources.viewmag;
            this.btnFiltrar.Location = new System.Drawing.Point(1002, 13);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(42, 35);
            this.btnFiltrar.TabIndex = 10;
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Image = global::reparaciones2.Properties.Resources.stop;
            this.btnX.Location = new System.Drawing.Point(1048, 13);
            this.btnX.Margin = new System.Windows.Forms.Padding(2);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(48, 35);
            this.btnX.TabIndex = 11;
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // panelBarraArriba
            // 
            this.panelBarraArriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.panelBarraArriba.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBarraArriba.Controls.Add(this.btnApagar);
            this.panelBarraArriba.Controls.Add(this.label3);
            this.panelBarraArriba.Location = new System.Drawing.Point(2, 2);
            this.panelBarraArriba.Margin = new System.Windows.Forms.Padding(2);
            this.panelBarraArriba.Name = "panelBarraArriba";
            this.panelBarraArriba.Size = new System.Drawing.Size(1254, 62);
            this.panelBarraArriba.TabIndex = 56;
            // 
            // btnApagar
            // 
            this.btnApagar.FlatAppearance.BorderSize = 0;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Image = global::reparaciones2.Properties.Resources.exit;
            this.btnApagar.Location = new System.Drawing.Point(1192, 8);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(2);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(50, 50);
            this.btnApagar.TabIndex = 4;
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(530, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "CONSULTA FACTURAS DE PROVEEDOR";
            // 
            // FrmFacturasDeProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1256, 575);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelBarraArriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFacturasDeProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFacturasDeProveedor";
            this.Load += new System.EventHandler(this.FrmFacturasDeProveedor_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwFacturas)).EndInit();
            this.panelBarraArriba.ResumeLayout(false);
            this.panelBarraArriba.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgwFacturas;
        private System.Windows.Forms.Label lblfiltro;
        private System.Windows.Forms.TextBox txtfiltro;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Panel panelBarraArriba;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label label3;
    }
}