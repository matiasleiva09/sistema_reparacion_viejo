namespace reparaciones2.caja
{
    partial class ConsultarCobros
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
            this.dwgIngresos = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panelBarraArriba = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnApagar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExportar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbMedioPago = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnXCliente = new System.Windows.Forms.Button();
            this.txtidcliente = new System.Windows.Forms.TextBox();
            this.txtnombrecliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.lblcliente = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFechaIngresoHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaHastaIngreso = new System.Windows.Forms.Label();
            this.dtpFechaDesdeIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDesdeIngreso = new System.Windows.Forms.Label();
            this.checkTodasIngreso = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtservice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtreparacion = new System.Windows.Forms.TextBox();
            this.lblnro = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dwgIngresos)).BeginInit();
            this.panelBarraArriba.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnX);
            this.groupBox7.Controls.Add(this.btnFiltrar);
            this.groupBox7.Controls.Add(this.txtfiltro);
            this.groupBox7.Controls.Add(this.lblfiltro);
            this.groupBox7.Controls.Add(this.dwgIngresos);
            this.groupBox7.Location = new System.Drawing.Point(132, 296);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(1004, 419);
            this.groupBox7.TabIndex = 15;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Resultado";
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Image = global::reparaciones2.Properties.Resources.stop;
            this.btnX.Location = new System.Drawing.Point(934, 15);
            this.btnX.Margin = new System.Windows.Forms.Padding(2);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(52, 30);
            this.btnX.TabIndex = 16;
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Image = global::reparaciones2.Properties.Resources.viewmag;
            this.btnFiltrar.Location = new System.Drawing.Point(886, 15);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(44, 30);
            this.btnFiltrar.TabIndex = 15;
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // txtfiltro
            // 
            this.txtfiltro.Location = new System.Drawing.Point(639, 19);
            this.txtfiltro.Margin = new System.Windows.Forms.Padding(2);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(242, 22);
            this.txtfiltro.TabIndex = 14;
            // 
            // lblfiltro
            // 
            this.lblfiltro.AutoSize = true;
            this.lblfiltro.Location = new System.Drawing.Point(587, 21);
            this.lblfiltro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfiltro.Name = "lblfiltro";
            this.lblfiltro.Size = new System.Drawing.Size(43, 17);
            this.lblfiltro.TabIndex = 6;
            this.lblfiltro.Text = "Filtro:";
            // 
            // dwgIngresos
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 7.6F);
            this.dwgIngresos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dwgIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dwgIngresos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dwgIngresos.Location = new System.Drawing.Point(8, 51);
            this.dwgIngresos.Margin = new System.Windows.Forms.Padding(4);
            this.dwgIngresos.MultiSelect = false;
            this.dwgIngresos.Name = "dwgIngresos";
            this.dwgIngresos.ReadOnly = true;
            this.dwgIngresos.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 7.8F);
            this.dwgIngresos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dwgIngresos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dwgIngresos.ShowEditingIcon = false;
            this.dwgIngresos.Size = new System.Drawing.Size(978, 352);
            this.dwgIngresos.TabIndex = 50;
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
            // panelBarraArriba
            // 
            this.panelBarraArriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.panelBarraArriba.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBarraArriba.Controls.Add(this.label2);
            this.panelBarraArriba.Controls.Add(this.btnApagar);
            this.panelBarraArriba.Location = new System.Drawing.Point(11, 0);
            this.panelBarraArriba.Margin = new System.Windows.Forms.Padding(2);
            this.panelBarraArriba.Name = "panelBarraArriba";
            this.panelBarraArriba.Size = new System.Drawing.Size(1129, 46);
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
            this.label2.Size = new System.Drawing.Size(295, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "CONSULTA DE REPARACIONES";
            // 
            // btnApagar
            // 
            this.btnApagar.FlatAppearance.BorderSize = 0;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Image = global::reparaciones2.Properties.Resources.exit;
            this.btnApagar.Location = new System.Drawing.Point(1071, -7);
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
            this.panel1.Controls.Add(this.btnExportar);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Location = new System.Drawing.Point(11, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 678);
            this.panel1.TabIndex = 16;
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
            this.btnExportar.Location = new System.Drawing.Point(-1, 88);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(123, 74);
            this.btnExportar.TabIndex = 22;
            this.btnExportar.Text = "EXPORTAR";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1002, 203);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Por Nro. de Orden y Estado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbMedioPago);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(621, 6);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(331, 119);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Medio de pago";
            // 
            // cmbMedioPago
            // 
            this.cmbMedioPago.FormattingEnabled = true;
            this.cmbMedioPago.Location = new System.Drawing.Point(66, 38);
            this.cmbMedioPago.Name = "cmbMedioPago";
            this.cmbMedioPago.Size = new System.Drawing.Size(248, 24);
            this.cmbMedioPago.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Medio:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnXCliente);
            this.groupBox3.Controls.Add(this.txtidcliente);
            this.groupBox3.Controls.Add(this.txtnombrecliente);
            this.groupBox3.Controls.Add(this.btnBuscarCliente);
            this.groupBox3.Controls.Add(this.lblcliente);
            this.groupBox3.Location = new System.Drawing.Point(8, 125);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(988, 74);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consultar Por Cliente y Equipo";
            // 
            // btnXCliente
            // 
            this.btnXCliente.Image = global::reparaciones2.Properties.Resources.stop;
            this.btnXCliente.Location = new System.Drawing.Point(672, 26);
            this.btnXCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnXCliente.Name = "btnXCliente";
            this.btnXCliente.Size = new System.Drawing.Size(40, 29);
            this.btnXCliente.TabIndex = 2;
            this.btnXCliente.UseVisualStyleBackColor = true;
            this.btnXCliente.Click += new System.EventHandler(this.btnXCliente_Click);
            // 
            // txtidcliente
            // 
            this.txtidcliente.Enabled = false;
            this.txtidcliente.Location = new System.Drawing.Point(91, 29);
            this.txtidcliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.Size = new System.Drawing.Size(58, 22);
            this.txtidcliente.TabIndex = 10;
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.Enabled = false;
            this.txtnombrecliente.Location = new System.Drawing.Point(158, 29);
            this.txtnombrecliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.Size = new System.Drawing.Size(460, 22);
            this.txtnombrecliente.TabIndex = 2;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Image = global::reparaciones2.Properties.Resources.viewmag1;
            this.btnBuscarCliente.Location = new System.Drawing.Point(625, 26);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(40, 29);
            this.btnBuscarCliente.TabIndex = 1;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Location = new System.Drawing.Point(9, 31);
            this.lblcliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(55, 17);
            this.lblcliente.TabIndex = 0;
            this.lblcliente.Text = "Cliente:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFechaIngresoHasta);
            this.groupBox1.Controls.Add(this.lblFechaHastaIngreso);
            this.groupBox1.Controls.Add(this.dtpFechaDesdeIngreso);
            this.groupBox1.Controls.Add(this.lblFechaDesdeIngreso);
            this.groupBox1.Controls.Add(this.checkTodasIngreso);
            this.groupBox1.Location = new System.Drawing.Point(8, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(255, 119);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Consultar Por Fecha de Ingreso";
            // 
            // dtpFechaIngresoHasta
            // 
            this.dtpFechaIngresoHasta.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaIngresoHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaIngresoHasta.Location = new System.Drawing.Point(120, 85);
            this.dtpFechaIngresoHasta.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaIngresoHasta.Name = "dtpFechaIngresoHasta";
            this.dtpFechaIngresoHasta.Size = new System.Drawing.Size(112, 22);
            this.dtpFechaIngresoHasta.TabIndex = 4;
            this.dtpFechaIngresoHasta.Value = new System.DateTime(2017, 9, 10, 0, 0, 0, 0);
            // 
            // lblFechaHastaIngreso
            // 
            this.lblFechaHastaIngreso.AutoSize = true;
            this.lblFechaHastaIngreso.Location = new System.Drawing.Point(9, 91);
            this.lblFechaHastaIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaHastaIngreso.Name = "lblFechaHastaIngreso";
            this.lblFechaHastaIngreso.Size = new System.Drawing.Size(92, 17);
            this.lblFechaHastaIngreso.TabIndex = 4;
            this.lblFechaHastaIngreso.Text = "Fecha Hasta:";
            // 
            // dtpFechaDesdeIngreso
            // 
            this.dtpFechaDesdeIngreso.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaDesdeIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaDesdeIngreso.Location = new System.Drawing.Point(120, 51);
            this.dtpFechaDesdeIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaDesdeIngreso.Name = "dtpFechaDesdeIngreso";
            this.dtpFechaDesdeIngreso.Size = new System.Drawing.Size(112, 22);
            this.dtpFechaDesdeIngreso.TabIndex = 3;
            this.dtpFechaDesdeIngreso.Value = new System.DateTime(2017, 9, 10, 0, 0, 0, 0);
            // 
            // lblFechaDesdeIngreso
            // 
            this.lblFechaDesdeIngreso.AutoSize = true;
            this.lblFechaDesdeIngreso.Location = new System.Drawing.Point(9, 58);
            this.lblFechaDesdeIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaDesdeIngreso.Name = "lblFechaDesdeIngreso";
            this.lblFechaDesdeIngreso.Size = new System.Drawing.Size(96, 17);
            this.lblFechaDesdeIngreso.TabIndex = 2;
            this.lblFechaDesdeIngreso.Text = "Fecha Desde:";
            // 
            // checkTodasIngreso
            // 
            this.checkTodasIngreso.AutoSize = true;
            this.checkTodasIngreso.Checked = true;
            this.checkTodasIngreso.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkTodasIngreso.Location = new System.Drawing.Point(8, 25);
            this.checkTodasIngreso.Margin = new System.Windows.Forms.Padding(4);
            this.checkTodasIngreso.Name = "checkTodasIngreso";
            this.checkTodasIngreso.Size = new System.Drawing.Size(78, 21);
            this.checkTodasIngreso.TabIndex = 1;
            this.checkTodasIngreso.Text = "TODAS";
            this.checkTodasIngreso.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtservice);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtreparacion);
            this.groupBox4.Controls.Add(this.lblnro);
            this.groupBox4.Location = new System.Drawing.Point(271, 4);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(331, 119);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Por reparación o service";
            // 
            // txtservice
            // 
            this.txtservice.Location = new System.Drawing.Point(55, 72);
            this.txtservice.Margin = new System.Windows.Forms.Padding(4);
            this.txtservice.Name = "txtservice";
            this.txtservice.Size = new System.Drawing.Size(189, 22);
            this.txtservice.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Serv:";
            // 
            // txtreparacion
            // 
            this.txtreparacion.Location = new System.Drawing.Point(55, 33);
            this.txtreparacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtreparacion.Name = "txtreparacion";
            this.txtreparacion.Size = new System.Drawing.Size(189, 22);
            this.txtreparacion.TabIndex = 1;
            // 
            // lblnro
            // 
            this.lblnro.AutoSize = true;
            this.lblnro.Location = new System.Drawing.Point(9, 38);
            this.lblnro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnro.Name = "lblnro";
            this.lblnro.Size = new System.Drawing.Size(38, 17);
            this.lblnro.TabIndex = 0;
            this.lblnro.Text = "Rep:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(130, 58);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1010, 232);
            this.tabControl1.TabIndex = 14;
            // 
            // ConsultarCobros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1143, 706);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.panelBarraArriba);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarCobros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarCobros";
            this.Load += new System.EventHandler(this.ConsultarCobros_Load);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dwgIngresos)).EndInit();
            this.panelBarraArriba.ResumeLayout(false);
            this.panelBarraArriba.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtfiltro;
        private System.Windows.Forms.Label lblfiltro;
        private System.Windows.Forms.DataGridView dwgIngresos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel panelBarraArriba;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnXCliente;
        private System.Windows.Forms.TextBox txtidcliente;
        private System.Windows.Forms.TextBox txtnombrecliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFechaIngresoHasta;
        private System.Windows.Forms.Label lblFechaHastaIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaDesdeIngreso;
        private System.Windows.Forms.Label lblFechaDesdeIngreso;
        private System.Windows.Forms.CheckBox checkTodasIngreso;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtservice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtreparacion;
        private System.Windows.Forms.Label lblnro;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbMedioPago;
        private System.Windows.Forms.Label label4;
    }
}