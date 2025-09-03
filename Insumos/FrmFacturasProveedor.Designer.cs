namespace reparaciones2.Insumos
{
    partial class FrmFacturasProveedor
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAgregarInsumo = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnEditarInsumo = new System.Windows.Forms.Button();
            this.btnBuscarItem = new System.Windows.Forms.Button();
            this.BtnBorrarItem = new System.Windows.Forms.Button();
            this.txtIdProveedor = new System.Windows.Forms.TextBox();
            this.btnBuscarProveedor = new System.Windows.Forms.Button();
            this.btnXProveedor = new System.Windows.Forms.Button();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.cmbFecha = new System.Windows.Forms.DateTimePicker();
            this.lblfecha = new System.Windows.Forms.Label();
            this.txtItemABuscar = new System.Windows.Forms.TextBox();
            this.cmbTipoFactura = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwItem = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Neto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panelBarraArriba = new System.Windows.Forms.Panel();
            this.btnApagar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwItem)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelBarraArriba.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAgregarInsumo);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.btnEditarInsumo);
            this.panel2.Controls.Add(this.btnBuscarItem);
            this.panel2.Controls.Add(this.BtnBorrarItem);
            this.panel2.Controls.Add(this.txtIdProveedor);
            this.panel2.Controls.Add(this.btnBuscarProveedor);
            this.panel2.Controls.Add(this.btnXProveedor);
            this.panel2.Controls.Add(this.txtProveedor);
            this.panel2.Controls.Add(this.lblProveedor);
            this.panel2.Controls.Add(this.cmbFecha);
            this.panel2.Controls.Add(this.lblfecha);
            this.panel2.Controls.Add(this.txtItemABuscar);
            this.panel2.Controls.Add(this.cmbTipoFactura);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtNro);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dgwItem);
            this.panel2.Location = new System.Drawing.Point(137, 64);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1014, 626);
            this.panel2.TabIndex = 57;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnAgregarInsumo
            // 
            this.btnAgregarInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnAgregarInsumo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarInsumo.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarInsumo.ForeColor = System.Drawing.Color.White;
            this.btnAgregarInsumo.Image = global::reparaciones2.Properties.Resources.edit_add;
            this.btnAgregarInsumo.Location = new System.Drawing.Point(6, 257);
            this.btnAgregarInsumo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarInsumo.Name = "btnAgregarInsumo";
            this.btnAgregarInsumo.Size = new System.Drawing.Size(117, 62);
            this.btnAgregarInsumo.TabIndex = 52;
            this.btnAgregarInsumo.Text = "AGREGAR";
            this.btnAgregarInsumo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregarInsumo.UseVisualStyleBackColor = false;
            this.btnAgregarInsumo.Click += new System.EventHandler(this.btnAgregarInsumo_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(611, 195);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(350, 1);
            this.panel4.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(445, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 50;
            this.label5.Text = "Detalle";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Location = new System.Drawing.Point(21, 195);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(350, 1);
            this.panel5.TabIndex = 48;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(602, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 1);
            this.panel3.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "Datos Básicos";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel7.Location = new System.Drawing.Point(12, 22);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(350, 1);
            this.panel7.TabIndex = 45;
            // 
            // btnEditarInsumo
            // 
            this.btnEditarInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnEditarInsumo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditarInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarInsumo.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarInsumo.ForeColor = System.Drawing.Color.White;
            this.btnEditarInsumo.Image = global::reparaciones2.Properties.Resources.color_line;
            this.btnEditarInsumo.Location = new System.Drawing.Point(6, 322);
            this.btnEditarInsumo.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarInsumo.Name = "btnEditarInsumo";
            this.btnEditarInsumo.Size = new System.Drawing.Size(117, 62);
            this.btnEditarInsumo.TabIndex = 43;
            this.btnEditarInsumo.Text = "EDITAR";
            this.btnEditarInsumo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditarInsumo.UseVisualStyleBackColor = false;
            this.btnEditarInsumo.Click += new System.EventHandler(this.btnEditarInsumo_Click);
            // 
            // btnBuscarItem
            // 
            this.btnBuscarItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnBuscarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarItem.Image = global::reparaciones2.Properties.Resources.viewmag1;
            this.btnBuscarItem.Location = new System.Drawing.Point(948, 216);
            this.btnBuscarItem.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarItem.Name = "btnBuscarItem";
            this.btnBuscarItem.Size = new System.Drawing.Size(40, 29);
            this.btnBuscarItem.TabIndex = 44;
            this.btnBuscarItem.UseVisualStyleBackColor = false;
            this.btnBuscarItem.Click += new System.EventHandler(this.btnBuscarItem_Click);
            // 
            // BtnBorrarItem
            // 
            this.BtnBorrarItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.BtnBorrarItem.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnBorrarItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnBorrarItem.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrarItem.ForeColor = System.Drawing.Color.White;
            this.BtnBorrarItem.Image = global::reparaciones2.Properties.Resources.trashcan_full;
            this.BtnBorrarItem.Location = new System.Drawing.Point(6, 388);
            this.BtnBorrarItem.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBorrarItem.Name = "BtnBorrarItem";
            this.BtnBorrarItem.Size = new System.Drawing.Size(117, 60);
            this.BtnBorrarItem.TabIndex = 43;
            this.BtnBorrarItem.Text = "BORRAR";
            this.BtnBorrarItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BtnBorrarItem.UseVisualStyleBackColor = false;
            this.BtnBorrarItem.Click += new System.EventHandler(this.BtnBorrarItem_Click);
            // 
            // txtIdProveedor
            // 
            this.txtIdProveedor.Enabled = false;
            this.txtIdProveedor.Location = new System.Drawing.Point(146, 145);
            this.txtIdProveedor.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.Size = new System.Drawing.Size(63, 22);
            this.txtIdProveedor.TabIndex = 27;
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProveedor.Image = global::reparaciones2.Properties.Resources.viewmag1;
            this.btnBuscarProveedor.Location = new System.Drawing.Point(702, 142);
            this.btnBuscarProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(40, 29);
            this.btnBuscarProveedor.TabIndex = 29;
            this.btnBuscarProveedor.UseVisualStyleBackColor = false;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // btnXProveedor
            // 
            this.btnXProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnXProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXProveedor.Image = global::reparaciones2.Properties.Resources.stop;
            this.btnXProveedor.Location = new System.Drawing.Point(749, 142);
            this.btnXProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnXProveedor.Name = "btnXProveedor";
            this.btnXProveedor.Size = new System.Drawing.Size(40, 29);
            this.btnXProveedor.TabIndex = 30;
            this.btnXProveedor.UseVisualStyleBackColor = false;
            this.btnXProveedor.Click += new System.EventHandler(this.btnXProveedor_Click);
            // 
            // txtProveedor
            // 
            this.txtProveedor.Enabled = false;
            this.txtProveedor.Location = new System.Drawing.Point(219, 145);
            this.txtProveedor.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(466, 22);
            this.txtProveedor.TabIndex = 28;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(50, 145);
            this.lblProveedor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(78, 17);
            this.lblProveedor.TabIndex = 31;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // cmbFecha
            // 
            this.cmbFecha.CustomFormat = "dd/MM/yyyy";
            this.cmbFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.cmbFecha.Location = new System.Drawing.Point(146, 46);
            this.cmbFecha.Name = "cmbFecha";
            this.cmbFecha.Size = new System.Drawing.Size(114, 22);
            this.cmbFecha.TabIndex = 8;
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(61, 51);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(51, 17);
            this.lblfecha.TabIndex = 7;
            this.lblfecha.Text = "Fecha:";
            // 
            // txtItemABuscar
            // 
            this.txtItemABuscar.Location = new System.Drawing.Point(128, 219);
            this.txtItemABuscar.Name = "txtItemABuscar";
            this.txtItemABuscar.Size = new System.Drawing.Size(813, 22);
            this.txtItemABuscar.TabIndex = 6;
            this.txtItemABuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemABuscar_KeyPress);
            // 
            // cmbTipoFactura
            // 
            this.cmbTipoFactura.FormattingEnabled = true;
            this.cmbTipoFactura.Location = new System.Drawing.Point(146, 89);
            this.cmbTipoFactura.Name = "cmbTipoFactura";
            this.cmbTipoFactura.Size = new System.Drawing.Size(89, 24);
            this.cmbTipoFactura.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo:";
            // 
            // txtNro
            // 
            this.txtNro.Location = new System.Drawing.Point(327, 90);
            this.txtNro.Name = "txtNro";
            this.txtNro.Size = new System.Drawing.Size(462, 22);
            this.txtNro.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nro:";
            // 
            // dgwItem
            // 
            this.dgwItem.AllowUserToAddRows = false;
            this.dgwItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgwItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Codigo,
            this.Detalle,
            this.Neto,
            this.IVA,
            this.Total});
            this.dgwItem.Location = new System.Drawing.Point(128, 257);
            this.dgwItem.Name = "dgwItem";
            this.dgwItem.RowHeadersWidth = 51;
            this.dgwItem.RowTemplate.Height = 24;
            this.dgwItem.Size = new System.Drawing.Size(860, 317);
            this.dgwItem.TabIndex = 0;
            this.dgwItem.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwItem_CellEndEdit);
            this.dgwItem.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgwItem_CellValidating);
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 93;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 81;
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.MinimumWidth = 6;
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            this.Detalle.Width = 81;
            // 
            // Neto
            // 
            this.Neto.HeaderText = "Neto";
            this.Neto.MinimumWidth = 6;
            this.Neto.Name = "Neto";
            this.Neto.Width = 67;
            // 
            // IVA
            // 
            this.IVA.HeaderText = "IVA";
            this.IVA.MinimumWidth = 6;
            this.IVA.Name = "IVA";
            this.IVA.Width = 58;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.Width = 69;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(130)))), ((int)(((byte)(172)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnsalir);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Location = new System.Drawing.Point(-3, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 626);
            this.panel1.TabIndex = 56;
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
            this.btnsalir.Location = new System.Drawing.Point(-1, 108);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(140, 86);
            this.btnsalir.TabIndex = 41;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Image = global::reparaciones2.Properties.Resources.apply;
            this.btnEditar.Location = new System.Drawing.Point(-1, 20);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(140, 86);
            this.btnEditar.TabIndex = 42;
            this.btnEditar.Text = "GUARDAR";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            this.label3.Size = new System.Drawing.Size(369, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "INGRESO DE MERCADERIA";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(-623, 414);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(148, 54);
            this.btnBorrar.TabIndex = 54;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(-623, -163);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(155, 40);
            this.btnAgregar.TabIndex = 53;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // panelBarraArriba
            // 
            this.panelBarraArriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.panelBarraArriba.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBarraArriba.Controls.Add(this.btnApagar);
            this.panelBarraArriba.Controls.Add(this.label3);
            this.panelBarraArriba.Location = new System.Drawing.Point(-3, 2);
            this.panelBarraArriba.Margin = new System.Windows.Forms.Padding(2);
            this.panelBarraArriba.Name = "panelBarraArriba";
            this.panelBarraArriba.Size = new System.Drawing.Size(1157, 62);
            this.panelBarraArriba.TabIndex = 55;
            // 
            // btnApagar
            // 
            this.btnApagar.FlatAppearance.BorderSize = 0;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Image = global::reparaciones2.Properties.Resources.exit;
            this.btnApagar.Location = new System.Drawing.Point(1103, 8);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(2);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(50, 50);
            this.btnApagar.TabIndex = 4;
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // FrmFacturasProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1154, 719);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panelBarraArriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFacturasProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFacturasProveedor";
            this.Load += new System.EventHandler(this.FrmFacturasProveedor_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwItem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelBarraArriba.ResumeLayout(false);
            this.panelBarraArriba.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.TextBox txtItemABuscar;
        private System.Windows.Forms.ComboBox cmbTipoFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwItem;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panelBarraArriba;
        private System.Windows.Forms.DateTimePicker cmbFecha;
        private System.Windows.Forms.TextBox txtIdProveedor;
        private System.Windows.Forms.Button btnBuscarProveedor;
        private System.Windows.Forms.Button btnXProveedor;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Button btnEditarInsumo;
        private System.Windows.Forms.Button btnBuscarItem;
        private System.Windows.Forms.Button BtnBorrarItem;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Neto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button btnAgregarInsumo;
    }
}