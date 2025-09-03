namespace reparaciones2.Insumos
{
    partial class FrmConsultarInsumos
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgwInsumos = new System.Windows.Forms.DataGridView();
            this.lblfiltro = new System.Windows.Forms.Label();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            this.panelBarraArriba = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwInsumos)).BeginInit();
            this.panelBarraArriba.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(130)))), ((int)(((byte)(172)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnBorrar);
            this.panel1.Controls.Add(this.btnsalir);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Location = new System.Drawing.Point(-5, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 506);
            this.panel1.TabIndex = 54;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgwInsumos);
            this.panel2.Controls.Add(this.lblfiltro);
            this.panel2.Controls.Add(this.txtfiltro);
            this.panel2.Controls.Add(this.btnFiltrar);
            this.panel2.Controls.Add(this.btnX);
            this.panel2.Location = new System.Drawing.Point(140, 68);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(964, 500);
            this.panel2.TabIndex = 55;
            // 
            // dgwInsumos
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgwInsumos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwInsumos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwInsumos.Location = new System.Drawing.Point(26, 60);
            this.dgwInsumos.Margin = new System.Windows.Forms.Padding(2);
            this.dgwInsumos.Name = "dgwInsumos";
            this.dgwInsumos.ReadOnly = true;
            this.dgwInsumos.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgwInsumos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwInsumos.Size = new System.Drawing.Size(929, 428);
            this.dgwInsumos.TabIndex = 12;
            this.dgwInsumos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwInsumos_CellDoubleClick);
            // 
            // lblfiltro
            // 
            this.lblfiltro.AutoSize = true;
            this.lblfiltro.Location = new System.Drawing.Point(437, 25);
            this.lblfiltro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfiltro.Name = "lblfiltro";
            this.lblfiltro.Size = new System.Drawing.Size(43, 17);
            this.lblfiltro.TabIndex = 8;
            this.lblfiltro.Text = "Filtro:";
            // 
            // txtfiltro
            // 
            this.txtfiltro.Location = new System.Drawing.Point(484, 25);
            this.txtfiltro.Margin = new System.Windows.Forms.Padding(2);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(374, 22);
            this.txtfiltro.TabIndex = 9;
            // 
            // panelBarraArriba
            // 
            this.panelBarraArriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.panelBarraArriba.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBarraArriba.Controls.Add(this.btnApagar);
            this.panelBarraArriba.Controls.Add(this.label3);
            this.panelBarraArriba.Location = new System.Drawing.Point(-5, 0);
            this.panelBarraArriba.Margin = new System.Windows.Forms.Padding(2);
            this.panelBarraArriba.Name = "panelBarraArriba";
            this.panelBarraArriba.Size = new System.Drawing.Size(1109, 62);
            this.panelBarraArriba.TabIndex = 53;
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
            this.label3.Size = new System.Drawing.Size(338, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "CONSULTA DE INSUMOS";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::reparaciones2.Properties.Resources.pay1;
            this.button1.Location = new System.Drawing.Point(2, 87);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 86);
            this.button1.TabIndex = 45;
            this.button1.Text = "ACTUALIZAR";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBorrar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Image = global::reparaciones2.Properties.Resources.trashcan_full;
            this.btnBorrar.Location = new System.Drawing.Point(2, 167);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(140, 86);
            this.btnBorrar.TabIndex = 43;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
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
            this.btnsalir.Location = new System.Drawing.Point(2, 247);
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
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Image = global::reparaciones2.Properties.Resources.viewmag;
            this.btnFiltrar.Location = new System.Drawing.Point(862, 16);
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
            this.btnX.Location = new System.Drawing.Point(908, 16);
            this.btnX.Margin = new System.Windows.Forms.Padding(2);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(48, 35);
            this.btnX.TabIndex = 11;
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.FlatAppearance.BorderSize = 0;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Image = global::reparaciones2.Properties.Resources.exit;
            this.btnApagar.Location = new System.Drawing.Point(1049, 2);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(2);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(50, 50);
            this.btnApagar.TabIndex = 4;
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // FrmConsultarInsumos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1108, 570);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelBarraArriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsultarInsumos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConsultarInsumos";
            this.Load += new System.EventHandler(this.FrmConsultarInsumos_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwInsumos)).EndInit();
            this.panelBarraArriba.ResumeLayout(false);
            this.panelBarraArriba.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgwInsumos;
        private System.Windows.Forms.Label lblfiltro;
        private System.Windows.Forms.TextBox txtfiltro;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Panel panelBarraArriba;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}