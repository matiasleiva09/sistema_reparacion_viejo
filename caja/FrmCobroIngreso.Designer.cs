namespace reparaciones2.caja
{
    partial class FrmCobroIngreso
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.panelBarraArriba = new System.Windows.Forms.Panel();
            this.btnApagar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panelFactura = new System.Windows.Forms.Panel();
            this.lbltipoFactura = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtidcliente = new System.Windows.Forms.TextBox();
            this.txtnombrecliente = new System.Windows.Forms.TextBox();
            this.btnEditarEquipo = new System.Windows.Forms.Button();
            this.btnAgregarEquipo = new System.Windows.Forms.Button();
            this.BtnXEquipo = new System.Windows.Forms.Button();
            this.btnBuscarEquipo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItemABuscar = new System.Windows.Forms.TextBox();
            this.btnBuscarArticulo = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnCantidad = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBorrarItem = new System.Windows.Forms.Button();
            this.dgwItem = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panelBarraArriba.SuspendLayout();
            this.panelFactura.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwItem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(130)))), ((int)(((byte)(172)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btncancelar);
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(107, 512);
            this.panel1.TabIndex = 50;
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::reparaciones2.Properties.Resources.apply;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardar.Location = new System.Drawing.Point(-1, 3);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(106, 66);
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
            this.btncancelar.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Image = global::reparaciones2.Properties.Resources.cancel;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(-1, 64);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(106, 66);
            this.btncancelar.TabIndex = 5;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // panelBarraArriba
            // 
            this.panelBarraArriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.panelBarraArriba.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBarraArriba.Controls.Add(this.btnApagar);
            this.panelBarraArriba.Controls.Add(this.label5);
            this.panelBarraArriba.Location = new System.Drawing.Point(0, 2);
            this.panelBarraArriba.Margin = new System.Windows.Forms.Padding(2);
            this.panelBarraArriba.Name = "panelBarraArriba";
            this.panelBarraArriba.Size = new System.Drawing.Size(684, 50);
            this.panelBarraArriba.TabIndex = 51;
            // 
            // btnApagar
            // 
            this.btnApagar.FlatAppearance.BorderSize = 0;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Image = global::reparaciones2.Properties.Resources.exit;
            this.btnApagar.Location = new System.Drawing.Point(612, 2);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(2);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(44, 47);
            this.btnApagar.TabIndex = 1;
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(303, 33);
            this.label5.TabIndex = 3;
            this.label5.Text = "COBRO DE INGRESOS";
            // 
            // panelFactura
            // 
            this.panelFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFactura.Controls.Add(this.lbltipoFactura);
            this.panelFactura.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFactura.Location = new System.Drawing.Point(333, 56);
            this.panelFactura.Name = "panelFactura";
            this.panelFactura.Size = new System.Drawing.Size(104, 74);
            this.panelFactura.TabIndex = 52;
            // 
            // lbltipoFactura
            // 
            this.lbltipoFactura.AutoSize = true;
            this.lbltipoFactura.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipoFactura.Location = new System.Drawing.Point(31, 15);
            this.lbltipoFactura.Name = "lbltipoFactura";
            this.lbltipoFactura.Size = new System.Drawing.Size(47, 45);
            this.lbltipoFactura.TabIndex = 0;
            this.lbltipoFactura.Text = "R";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 53;
            this.label1.Text = "CLIENTE";
            // 
            // txtidcliente
            // 
            this.txtidcliente.Location = new System.Drawing.Point(180, 136);
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.Size = new System.Drawing.Size(49, 21);
            this.txtidcliente.TabIndex = 54;
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.Location = new System.Drawing.Point(242, 136);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.Size = new System.Drawing.Size(268, 21);
            this.txtnombrecliente.TabIndex = 55;
            // 
            // btnEditarEquipo
            // 
            this.btnEditarEquipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnEditarEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarEquipo.Image = global::reparaciones2.Properties.Resources.editar_chiquito2;
            this.btnEditarEquipo.Location = new System.Drawing.Point(639, 133);
            this.btnEditarEquipo.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarEquipo.Name = "btnEditarEquipo";
            this.btnEditarEquipo.Size = new System.Drawing.Size(35, 27);
            this.btnEditarEquipo.TabIndex = 59;
            this.btnEditarEquipo.UseVisualStyleBackColor = false;
            this.btnEditarEquipo.Click += new System.EventHandler(this.btnEditarEquipo_Click);
            // 
            // btnAgregarEquipo
            // 
            this.btnAgregarEquipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnAgregarEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEquipo.Image = global::reparaciones2.Properties.Resources.viewmag_1;
            this.btnAgregarEquipo.Location = new System.Drawing.Point(598, 133);
            this.btnAgregarEquipo.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarEquipo.Name = "btnAgregarEquipo";
            this.btnAgregarEquipo.Size = new System.Drawing.Size(35, 27);
            this.btnAgregarEquipo.TabIndex = 58;
            this.btnAgregarEquipo.UseVisualStyleBackColor = false;
            this.btnAgregarEquipo.Click += new System.EventHandler(this.btnAgregarEquipo_Click);
            // 
            // BtnXEquipo
            // 
            this.BtnXEquipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.BtnXEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnXEquipo.Image = global::reparaciones2.Properties.Resources.stop;
            this.BtnXEquipo.Location = new System.Drawing.Point(558, 133);
            this.BtnXEquipo.Margin = new System.Windows.Forms.Padding(4);
            this.BtnXEquipo.Name = "BtnXEquipo";
            this.BtnXEquipo.Size = new System.Drawing.Size(35, 27);
            this.BtnXEquipo.TabIndex = 57;
            this.BtnXEquipo.UseVisualStyleBackColor = false;
            this.BtnXEquipo.Click += new System.EventHandler(this.BtnXEquipo_Click);
            // 
            // btnBuscarEquipo
            // 
            this.btnBuscarEquipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnBuscarEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarEquipo.Image = global::reparaciones2.Properties.Resources.viewmag1;
            this.btnBuscarEquipo.Location = new System.Drawing.Point(515, 133);
            this.btnBuscarEquipo.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarEquipo.Name = "btnBuscarEquipo";
            this.btnBuscarEquipo.Size = new System.Drawing.Size(35, 27);
            this.btnBuscarEquipo.TabIndex = 56;
            this.btnBuscarEquipo.UseVisualStyleBackColor = false;
            this.btnBuscarEquipo.Click += new System.EventHandler(this.btnBuscarEquipo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 60;
            this.label2.Text = "CODIGO:";
            // 
            // txtItemABuscar
            // 
            this.txtItemABuscar.Location = new System.Drawing.Point(180, 170);
            this.txtItemABuscar.Name = "txtItemABuscar";
            this.txtItemABuscar.Size = new System.Drawing.Size(217, 21);
            this.txtItemABuscar.TabIndex = 61;
            // 
            // btnBuscarArticulo
            // 
            this.btnBuscarArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnBuscarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarArticulo.Image = global::reparaciones2.Properties.Resources.viewmag1;
            this.btnBuscarArticulo.Location = new System.Drawing.Point(402, 167);
            this.btnBuscarArticulo.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarArticulo.Name = "btnBuscarArticulo";
            this.btnBuscarArticulo.Size = new System.Drawing.Size(35, 27);
            this.btnBuscarArticulo.TabIndex = 62;
            this.btnBuscarArticulo.UseVisualStyleBackColor = false;
            this.btnBuscarArticulo.Click += new System.EventHandler(this.btnBuscarArticulo_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnCantidad);
            this.groupBox7.Controls.Add(this.button1);
            this.groupBox7.Controls.Add(this.btnBorrarItem);
            this.groupBox7.Controls.Add(this.dgwItem);
            this.groupBox7.Location = new System.Drawing.Point(120, 197);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(554, 350);
            this.groupBox7.TabIndex = 63;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Resultado";
            // 
            // btnCantidad
            // 
            this.btnCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnCantidad.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCantidad.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCantidad.ForeColor = System.Drawing.Color.White;
            this.btnCantidad.Image = global::reparaciones2.Properties.Resources.color_line;
            this.btnCantidad.Location = new System.Drawing.Point(253, 249);
            this.btnCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.btnCantidad.Name = "btnCantidad";
            this.btnCantidad.Size = new System.Drawing.Size(130, 58);
            this.btnCantidad.TabIndex = 59;
            this.btnCantidad.Text = "CANTIDAD";
            this.btnCantidad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCantidad.UseVisualStyleBackColor = false;
            this.btnCantidad.Click += new System.EventHandler(this.btnCantidad_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::reparaciones2.Properties.Resources.color_line;
            this.button1.Location = new System.Drawing.Point(119, 249);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 58);
            this.button1.TabIndex = 58;
            this.button1.Text = "AC MONTO";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBorrarItem
            // 
            this.btnBorrarItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnBorrarItem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBorrarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarItem.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarItem.ForeColor = System.Drawing.Color.White;
            this.btnBorrarItem.Image = global::reparaciones2.Properties.Resources.apply;
            this.btnBorrarItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBorrarItem.Location = new System.Drawing.Point(7, 21);
            this.btnBorrarItem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBorrarItem.Name = "btnBorrarItem";
            this.btnBorrarItem.Size = new System.Drawing.Size(106, 58);
            this.btnBorrarItem.TabIndex = 6;
            this.btnBorrarItem.Text = "BORRAR";
            this.btnBorrarItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBorrarItem.UseVisualStyleBackColor = false;
            // 
            // dgwItem
            // 
            this.dgwItem.AllowUserToAddRows = false;
            this.dgwItem.AllowUserToDeleteRows = false;
            this.dgwItem.AllowUserToResizeColumns = false;
            this.dgwItem.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 7.6F);
            this.dgwItem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgwItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Codigo,
            this.Detalle,
            this.Monto});
            this.dgwItem.Location = new System.Drawing.Point(119, 21);
            this.dgwItem.Margin = new System.Windows.Forms.Padding(4);
            this.dgwItem.MultiSelect = false;
            this.dgwItem.Name = "dgwItem";
            this.dgwItem.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 7.8F);
            this.dgwItem.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgwItem.Size = new System.Drawing.Size(418, 223);
            this.dgwItem.TabIndex = 50;
            this.dgwItem.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgwItem_CellBeginEdit);
            this.dgwItem.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwItem_CellEndEdit);
            this.dgwItem.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgwItem_CellValidating);
            this.dgwItem.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwItem_CellValueChanged);
            this.dgwItem.CellValuePushed += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.dgwItem_CellValuePushed);
            // 
            // Cantidad
            // 
            this.Cantidad.Frozen = true;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 86;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.Visible = false;
            this.Codigo.Width = 87;
            // 
            // Detalle
            // 
            this.Detalle.Frozen = true;
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.MinimumWidth = 6;
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            this.Detalle.Width = 75;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.MinimumWidth = 6;
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            this.Monto.Width = 71;
            // 
            // FrmCobroIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(684, 559);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.btnBuscarArticulo);
            this.Controls.Add(this.txtItemABuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEditarEquipo);
            this.Controls.Add(this.btnAgregarEquipo);
            this.Controls.Add(this.BtnXEquipo);
            this.Controls.Add(this.btnBuscarEquipo);
            this.Controls.Add(this.txtnombrecliente);
            this.Controls.Add(this.txtidcliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelFactura);
            this.Controls.Add(this.panelBarraArriba);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCobroIngreso";
            this.Text = "FrmCobroIngreso";
            this.Load += new System.EventHandler(this.FrmCobroIngreso_Load);
            this.panel1.ResumeLayout(false);
            this.panelBarraArriba.ResumeLayout(false);
            this.panelBarraArriba.PerformLayout();
            this.panelFactura.ResumeLayout(false);
            this.panelFactura.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Panel panelBarraArriba;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelFactura;
        private System.Windows.Forms.Label lbltipoFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtidcliente;
        private System.Windows.Forms.TextBox txtnombrecliente;
        private System.Windows.Forms.Button btnEditarEquipo;
        private System.Windows.Forms.Button btnAgregarEquipo;
        private System.Windows.Forms.Button BtnXEquipo;
        private System.Windows.Forms.Button btnBuscarEquipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtItemABuscar;
        private System.Windows.Forms.Button btnBuscarArticulo;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dgwItem;
        private System.Windows.Forms.Button btnBorrarItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.Button btnCantidad;
        private System.Windows.Forms.Button button1;
    }
}