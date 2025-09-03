using System;

namespace reparaciones2.Presupuesto
{
    partial class FrmPresupuesto
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
            this.btnCantidad = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEditarProveedor = new System.Windows.Forms.Button();
            this.btnAgregarProveedor = new System.Windows.Forms.Button();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.lblfechaentrega = new System.Windows.Forms.Label();
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
            this.dgwItem = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Neto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lbltitulo = new System.Windows.Forms.Label();
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
            this.panel2.Controls.Add(this.btnCantidad);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnEditarProveedor);
            this.panel2.Controls.Add(this.btnAgregarProveedor);
            this.panel2.Controls.Add(this.dtpFechaEntrega);
            this.panel2.Controls.Add(this.lblfechaentrega);
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
            this.panel2.Controls.Add(this.dgwItem);
            this.panel2.Location = new System.Drawing.Point(137, 64);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(957, 640);
            this.panel2.TabIndex = 57;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnCantidad
            // 
            this.btnCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnCantidad.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCantidad.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCantidad.ForeColor = System.Drawing.Color.White;
            this.btnCantidad.Image = global::reparaciones2.Properties.Resources.color_line;
            this.btnCantidad.Location = new System.Drawing.Point(250, 518);
            this.btnCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.btnCantidad.Name = "btnCantidad";
            this.btnCantidad.Size = new System.Drawing.Size(117, 62);
            this.btnCantidad.TabIndex = 57;
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
            this.button1.Location = new System.Drawing.Point(124, 518);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 62);
            this.button1.TabIndex = 56;
            this.button1.Text = "AC MONTO";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEditarProveedor
            // 
            this.btnEditarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnEditarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarProveedor.Image = global::reparaciones2.Properties.Resources.editar_chiquito2;
            this.btnEditarProveedor.Location = new System.Drawing.Point(848, 82);
            this.btnEditarProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarProveedor.Name = "btnEditarProveedor";
            this.btnEditarProveedor.Size = new System.Drawing.Size(40, 29);
            this.btnEditarProveedor.TabIndex = 55;
            this.btnEditarProveedor.UseVisualStyleBackColor = false;
            this.btnEditarProveedor.Click += new System.EventHandler(this.btnEditarProveedor_Click);
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnAgregarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProveedor.Image = global::reparaciones2.Properties.Resources.viewmag_1;
            this.btnAgregarProveedor.Location = new System.Drawing.Point(801, 82);
            this.btnAgregarProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(40, 29);
            this.btnAgregarProveedor.TabIndex = 54;
            this.btnAgregarProveedor.UseVisualStyleBackColor = false;
            this.btnAgregarProveedor.Click += new System.EventHandler(this.btnAgregarProveedor_Click);
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaEntrega.Location = new System.Drawing.Point(390, 46);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(114, 22);
            this.dtpFechaEntrega.TabIndex = 53;
            // 
            // lblfechaentrega
            // 
            this.lblfechaentrega.AutoSize = true;
            this.lblfechaentrega.Location = new System.Drawing.Point(279, 46);
            this.lblfechaentrega.Name = "lblfechaentrega";
            this.lblfechaentrega.Size = new System.Drawing.Size(105, 17);
            this.lblfechaentrega.TabIndex = 52;
            this.lblfechaentrega.Text = "Fecha Entrega:";
            // 
            // btnAgregarInsumo
            // 
            this.btnAgregarInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnAgregarInsumo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregarInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarInsumo.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarInsumo.ForeColor = System.Drawing.Color.White;
            this.btnAgregarInsumo.Image = global::reparaciones2.Properties.Resources.edit_add;
            this.btnAgregarInsumo.Location = new System.Drawing.Point(2, 207);
            this.btnAgregarInsumo.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarInsumo.Name = "btnAgregarInsumo";
            this.btnAgregarInsumo.Size = new System.Drawing.Size(117, 62);
            this.btnAgregarInsumo.TabIndex = 51;
            this.btnAgregarInsumo.Text = "AGREGAR";
            this.btnAgregarInsumo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregarInsumo.UseVisualStyleBackColor = false;
            this.btnAgregarInsumo.Click += new System.EventHandler(this.btnAgregarInsumo_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(538, 134);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(350, 1);
            this.panel4.TabIndex = 49;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(441, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 50;
            this.label5.Text = "Detalle";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Location = new System.Drawing.Point(17, 134);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(350, 1);
            this.panel5.TabIndex = 48;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(561, 22);
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
            this.btnEditarInsumo.Location = new System.Drawing.Point(0, 273);
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
            this.btnBuscarItem.Location = new System.Drawing.Point(858, 155);
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
            this.BtnBorrarItem.Location = new System.Drawing.Point(2, 339);
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
            this.txtIdProveedor.Location = new System.Drawing.Point(148, 85);
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
            this.btnBuscarProveedor.Location = new System.Drawing.Point(704, 82);
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
            this.btnXProveedor.Location = new System.Drawing.Point(751, 82);
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
            this.txtProveedor.Location = new System.Drawing.Point(221, 85);
            this.txtProveedor.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(466, 22);
            this.txtProveedor.TabIndex = 28;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(52, 85);
            this.lblProveedor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(55, 17);
            this.lblProveedor.TabIndex = 31;
            this.lblProveedor.Text = "Cliente:";
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
            this.txtItemABuscar.Location = new System.Drawing.Point(124, 158);
            this.txtItemABuscar.Name = "txtItemABuscar";
            this.txtItemABuscar.Size = new System.Drawing.Size(717, 22);
            this.txtItemABuscar.TabIndex = 6;
            this.txtItemABuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemABuscar_KeyPress);
            // 
            // dgwItem
            // 
            this.dgwItem.AllowUserToAddRows = false;
            this.dgwItem.AllowUserToDeleteRows = false;
            this.dgwItem.AllowUserToResizeColumns = false;
            this.dgwItem.AllowUserToResizeRows = false;
            this.dgwItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgwItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Codigo,
            this.Detalle,
            this.Neto,
            this.IVA,
            this.MontoU,
            this.Total});
            this.dgwItem.Location = new System.Drawing.Point(124, 196);
            this.dgwItem.Name = "dgwItem";
            this.dgwItem.RowHeadersWidth = 51;
            this.dgwItem.RowTemplate.Height = 24;
            this.dgwItem.Size = new System.Drawing.Size(787, 317);
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
            this.Neto.ReadOnly = true;
            this.Neto.Visible = false;
            this.Neto.Width = 67;
            // 
            // IVA
            // 
            this.IVA.HeaderText = "IVA";
            this.IVA.MinimumWidth = 6;
            this.IVA.Name = "IVA";
            this.IVA.ReadOnly = true;
            this.IVA.Visible = false;
            this.IVA.Width = 58;
            // 
            // MontoU
            // 
            this.MontoU.HeaderText = "Monto Unitario";
            this.MontoU.MinimumWidth = 6;
            this.MontoU.Name = "MontoU";
            this.MontoU.ReadOnly = true;
            this.MontoU.Width = 129;
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
            this.panel1.Size = new System.Drawing.Size(138, 634);
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
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbltitulo.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.White;
            this.lbltitulo.Location = new System.Drawing.Point(14, 12);
            this.lbltitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(212, 33);
            this.lbltitulo.TabIndex = 3;
            this.lbltitulo.Text = "PRESUPUESTO";
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
            this.panelBarraArriba.Controls.Add(this.lbltitulo);
            this.panelBarraArriba.Location = new System.Drawing.Point(-3, 2);
            this.panelBarraArriba.Margin = new System.Windows.Forms.Padding(2);
            this.panelBarraArriba.Name = "panelBarraArriba";
            this.panelBarraArriba.Size = new System.Drawing.Size(1097, 62);
            this.panelBarraArriba.TabIndex = 55;
            // 
            // btnApagar
            // 
            this.btnApagar.FlatAppearance.BorderSize = 0;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Image = global::reparaciones2.Properties.Resources.exit;
            this.btnApagar.Location = new System.Drawing.Point(1016, 7);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(2);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(50, 50);
            this.btnApagar.TabIndex = 4;
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // FrmPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1096, 709);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panelBarraArriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPresupuesto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFacturasProveedor";
            this.Load += new System.EventHandler(this.FrmPresupuesto_Load);
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
        private System.Windows.Forms.TextBox txtItemABuscar;
        private System.Windows.Forms.DataGridView dgwItem;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panelBarraArriba;
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
        private System.Windows.Forms.DateTimePicker cmbFecha;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Button btnAgregarInsumo;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.Label lblfechaentrega;
        private System.Windows.Forms.Button btnEditarProveedor;
        private System.Windows.Forms.Button btnAgregarProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Neto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoU;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCantidad;
    }
}