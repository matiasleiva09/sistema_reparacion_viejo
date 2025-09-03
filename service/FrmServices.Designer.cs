namespace reparaciones2.service
{
    partial class FrmServices
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
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnX = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            this.lblfiltro = new System.Windows.Forms.Label();
            this.dgwServices = new System.Windows.Forms.DataGridView();
            this.panelBarraArriba = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnApagar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGenerarRecibo = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btneditardatos = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnXCliente = new System.Windows.Forms.Button();
            this.txtidcliente = new System.Windows.Forms.TextBox();
            this.txtnombrecliente = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblcliente = new System.Windows.Forms.Label();
            this.dtpFechaIngresoHasta = new System.Windows.Forms.DateTimePicker();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblFechaHastaIngreso = new System.Windows.Forms.Label();
            this.lblestado = new System.Windows.Forms.Label();
            this.dtpFechaDesdeIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDesdeIngreso = new System.Windows.Forms.Label();
            this.lblnro = new System.Windows.Forms.Label();
            this.txtnro = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwServices)).BeginInit();
            this.panelBarraArriba.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnX);
            this.groupBox7.Controls.Add(this.btnFiltrar);
            this.groupBox7.Controls.Add(this.txtfiltro);
            this.groupBox7.Controls.Add(this.lblfiltro);
            this.groupBox7.Controls.Add(this.dgwServices);
            this.groupBox7.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold);
            this.groupBox7.Location = new System.Drawing.Point(128, 247);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(893, 452);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Resultado";
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Image = global::reparaciones2.Properties.Resources.stop;
            this.btnX.Location = new System.Drawing.Point(829, 15);
            this.btnX.Margin = new System.Windows.Forms.Padding(2);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(52, 30);
            this.btnX.TabIndex = 16;
            this.btnX.UseVisualStyleBackColor = false;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Image = global::reparaciones2.Properties.Resources.viewmag;
            this.btnFiltrar.Location = new System.Drawing.Point(781, 15);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(44, 30);
            this.btnFiltrar.TabIndex = 15;
            this.btnFiltrar.UseVisualStyleBackColor = false;
            // 
            // txtfiltro
            // 
            this.txtfiltro.Location = new System.Drawing.Point(534, 19);
            this.txtfiltro.Margin = new System.Windows.Forms.Padding(2);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(242, 26);
            this.txtfiltro.TabIndex = 14;
            // 
            // lblfiltro
            // 
            this.lblfiltro.AutoSize = true;
            this.lblfiltro.Location = new System.Drawing.Point(482, 21);
            this.lblfiltro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfiltro.Name = "lblfiltro";
            this.lblfiltro.Size = new System.Drawing.Size(54, 19);
            this.lblfiltro.TabIndex = 6;
            this.lblfiltro.Text = "Filtro:";
            // 
            // dgwServices
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 7.6F);
            this.dgwServices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwServices.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgwServices.Location = new System.Drawing.Point(8, 51);
            this.dgwServices.Margin = new System.Windows.Forms.Padding(4);
            this.dgwServices.MultiSelect = false;
            this.dgwServices.Name = "dgwServices";
            this.dgwServices.ReadOnly = true;
            this.dgwServices.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 7.8F);
            this.dgwServices.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwServices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwServices.ShowEditingIcon = false;
            this.dgwServices.Size = new System.Drawing.Size(873, 382);
            this.dgwServices.TabIndex = 50;
            this.dgwServices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwServices_CellContentClick);
            // 
            // panelBarraArriba
            // 
            this.panelBarraArriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.panelBarraArriba.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBarraArriba.Controls.Add(this.label2);
            this.panelBarraArriba.Controls.Add(this.btnApagar);
            this.panelBarraArriba.Location = new System.Drawing.Point(1, 0);
            this.panelBarraArriba.Margin = new System.Windows.Forms.Padding(2);
            this.panelBarraArriba.Name = "panelBarraArriba";
            this.panelBarraArriba.Size = new System.Drawing.Size(1034, 46);
            this.panelBarraArriba.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "CONSULTA DE SERVICE";
            // 
            // btnApagar
            // 
            this.btnApagar.FlatAppearance.BorderSize = 0;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Image = global::reparaciones2.Properties.Resources.exit;
            this.btnApagar.Location = new System.Drawing.Point(957, -10);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(2);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(50, 63);
            this.btnApagar.TabIndex = 22;
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(130)))), ((int)(((byte)(172)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnGenerarRecibo);
            this.panel1.Controls.Add(this.btnExportar);
            this.panel1.Controls.Add(this.btneditardatos);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Location = new System.Drawing.Point(1, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 678);
            this.panel1.TabIndex = 16;
            // 
            // btnGenerarRecibo
            // 
            this.btnGenerarRecibo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnGenerarRecibo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGenerarRecibo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarRecibo.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.btnGenerarRecibo.ForeColor = System.Drawing.Color.White;
            this.btnGenerarRecibo.Image = global::reparaciones2.Properties.Resources.kwrite;
            this.btnGenerarRecibo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGenerarRecibo.Location = new System.Drawing.Point(0, 224);
            this.btnGenerarRecibo.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerarRecibo.Name = "btnGenerarRecibo";
            this.btnGenerarRecibo.Size = new System.Drawing.Size(118, 83);
            this.btnGenerarRecibo.TabIndex = 23;
            this.btnGenerarRecibo.Text = "GEN. RECIBO";
            this.btnGenerarRecibo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGenerarRecibo.UseVisualStyleBackColor = false;
            this.btnGenerarRecibo.Click += new System.EventHandler(this.btnGenerarRecibo_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnExportar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.Image = global::reparaciones2.Properties.Resources._26967_6_excel_picture;
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExportar.Location = new System.Drawing.Point(-1, 151);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(123, 74);
            this.btnExportar.TabIndex = 22;
            this.btnExportar.Text = "EXPORTAR";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExportar.UseVisualStyleBackColor = false;
            // 
            // btneditardatos
            // 
            this.btneditardatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btneditardatos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btneditardatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditardatos.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.btneditardatos.ForeColor = System.Drawing.Color.White;
            this.btneditardatos.Image = global::reparaciones2.Properties.Resources.color_line;
            this.btneditardatos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btneditardatos.Location = new System.Drawing.Point(-1, 86);
            this.btneditardatos.Margin = new System.Windows.Forms.Padding(2);
            this.btneditardatos.Name = "btneditardatos";
            this.btneditardatos.Size = new System.Drawing.Size(118, 68);
            this.btneditardatos.TabIndex = 18;
            this.btneditardatos.Text = "EDITAR";
            this.btneditardatos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btneditardatos.UseVisualStyleBackColor = false;
            this.btneditardatos.Click += new System.EventHandler(this.btneditardatos_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = global::reparaciones2.Properties.Resources.xmag;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.Location = new System.Drawing.Point(-8, 10);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(130, 79);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnXCliente);
            this.tabPage2.Controls.Add(this.txtidcliente);
            this.tabPage2.Controls.Add(this.txtnombrecliente);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.lblcliente);
            this.tabPage2.Controls.Add(this.dtpFechaIngresoHasta);
            this.tabPage2.Controls.Add(this.cmbEstado);
            this.tabPage2.Controls.Add(this.lblFechaHastaIngreso);
            this.tabPage2.Controls.Add(this.lblestado);
            this.tabPage2.Controls.Add(this.dtpFechaDesdeIngreso);
            this.tabPage2.Controls.Add(this.lblFechaDesdeIngreso);
            this.tabPage2.Controls.Add(this.lblnro);
            this.tabPage2.Controls.Add(this.txtnro);
            this.tabPage2.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(887, 152);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Por Nro. de Orden y Estado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnXCliente
            // 
            this.btnXCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnXCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXCliente.Image = global::reparaciones2.Properties.Resources.stop;
            this.btnXCliente.Location = new System.Drawing.Point(733, 109);
            this.btnXCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnXCliente.Name = "btnXCliente";
            this.btnXCliente.Size = new System.Drawing.Size(40, 29);
            this.btnXCliente.TabIndex = 13;
            this.btnXCliente.UseVisualStyleBackColor = false;
            // 
            // txtidcliente
            // 
            this.txtidcliente.Enabled = false;
            this.txtidcliente.Location = new System.Drawing.Point(152, 112);
            this.txtidcliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.Size = new System.Drawing.Size(58, 26);
            this.txtidcliente.TabIndex = 15;
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.Enabled = false;
            this.txtnombrecliente.Location = new System.Drawing.Point(219, 112);
            this.txtnombrecliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.Size = new System.Drawing.Size(460, 26);
            this.txtnombrecliente.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::reparaciones2.Properties.Resources.viewmag1;
            this.button1.Location = new System.Drawing.Point(686, 109);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 29);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Location = new System.Drawing.Point(21, 116);
            this.lblcliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(68, 19);
            this.lblcliente.TabIndex = 11;
            this.lblcliente.Text = "Cliente:";
            // 
            // dtpFechaIngresoHasta
            // 
            this.dtpFechaIngresoHasta.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaIngresoHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaIngresoHasta.Location = new System.Drawing.Point(152, 82);
            this.dtpFechaIngresoHasta.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaIngresoHasta.Name = "dtpFechaIngresoHasta";
            this.dtpFechaIngresoHasta.Size = new System.Drawing.Size(112, 26);
            this.dtpFechaIngresoHasta.TabIndex = 4;
            this.dtpFechaIngresoHasta.Value = new System.DateTime(2017, 9, 10, 0, 0, 0, 0);
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(422, 19);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(351, 26);
            this.cmbEstado.TabIndex = 2;
            // 
            // lblFechaHastaIngreso
            // 
            this.lblFechaHastaIngreso.AutoSize = true;
            this.lblFechaHastaIngreso.Location = new System.Drawing.Point(21, 89);
            this.lblFechaHastaIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaHastaIngreso.Name = "lblFechaHastaIngreso";
            this.lblFechaHastaIngreso.Size = new System.Drawing.Size(109, 19);
            this.lblFechaHastaIngreso.TabIndex = 4;
            this.lblFechaHastaIngreso.Text = "Fecha Hasta:";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(358, 23);
            this.lblestado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(66, 19);
            this.lblestado.TabIndex = 0;
            this.lblestado.Text = "Estado:";
            // 
            // dtpFechaDesdeIngreso
            // 
            this.dtpFechaDesdeIngreso.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaDesdeIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaDesdeIngreso.Location = new System.Drawing.Point(152, 48);
            this.dtpFechaDesdeIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaDesdeIngreso.Name = "dtpFechaDesdeIngreso";
            this.dtpFechaDesdeIngreso.Size = new System.Drawing.Size(112, 26);
            this.dtpFechaDesdeIngreso.TabIndex = 3;
            this.dtpFechaDesdeIngreso.Value = new System.DateTime(2017, 9, 10, 0, 0, 0, 0);
            // 
            // lblFechaDesdeIngreso
            // 
            this.lblFechaDesdeIngreso.AutoSize = true;
            this.lblFechaDesdeIngreso.Location = new System.Drawing.Point(21, 56);
            this.lblFechaDesdeIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaDesdeIngreso.Name = "lblFechaDesdeIngreso";
            this.lblFechaDesdeIngreso.Size = new System.Drawing.Size(116, 19);
            this.lblFechaDesdeIngreso.TabIndex = 2;
            this.lblFechaDesdeIngreso.Text = "Fecha  Desde:";
            // 
            // lblnro
            // 
            this.lblnro.AutoSize = true;
            this.lblnro.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnro.Location = new System.Drawing.Point(17, 21);
            this.lblnro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnro.Name = "lblnro";
            this.lblnro.Size = new System.Drawing.Size(104, 19);
            this.lblnro.TabIndex = 0;
            this.lblnro.Text = "Nro Service:";
            // 
            // txtnro
            // 
            this.txtnro.Location = new System.Drawing.Point(152, 18);
            this.txtnro.Margin = new System.Windows.Forms.Padding(4);
            this.txtnro.Name = "txtnro";
            this.txtnro.Size = new System.Drawing.Size(189, 26);
            this.txtnro.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(126, 58);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(895, 183);
            this.tabControl1.TabIndex = 14;
            // 
            // FrmServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1039, 712);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.panelBarraArriba);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmServices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmServices";
            this.Load += new System.EventHandler(this.FrmServices_Load);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwServices)).EndInit();
            this.panelBarraArriba.ResumeLayout(false);
            this.panelBarraArriba.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtfiltro;
        private System.Windows.Forms.Label lblfiltro;
        private System.Windows.Forms.DataGridView dgwServices;
        private System.Windows.Forms.Panel panelBarraArriba;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btneditardatos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnXCliente;
        private System.Windows.Forms.TextBox txtidcliente;
        private System.Windows.Forms.TextBox txtnombrecliente;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.DateTimePicker dtpFechaIngresoHasta;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblFechaHastaIngreso;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.DateTimePicker dtpFechaDesdeIngreso;
        private System.Windows.Forms.Label lblFechaDesdeIngreso;
        private System.Windows.Forms.Label lblnro;
        private System.Windows.Forms.TextBox txtnro;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnGenerarRecibo;
    }
}