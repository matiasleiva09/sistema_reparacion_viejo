namespace reparaciones2
{
    partial class FrmConsultarReparaciones
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarReparaciones));
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnX = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            this.lblfiltro = new System.Windows.Forms.Label();
            this.dgwReparaciones = new System.Windows.Forms.DataGridView();
            this.btnGenerarRecibo = new System.Windows.Forms.Button();
            this.btnLlamadas = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.panelBarraArriba = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnApagar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btneditardatos = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmbModelo = new System.Windows.Forms.ComboBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.cmbTipoEquipo = new System.Windows.Forms.ComboBox();
            this.lblTipoEquipo = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnXEquipo = new System.Windows.Forms.Button();
            this.btnXCliente = new System.Windows.Forms.Button();
            this.txtidequipo = new System.Windows.Forms.TextBox();
            this.txtidcliente = new System.Windows.Forms.TextBox();
            this.txtnombreequipocliente = new System.Windows.Forms.TextBox();
            this.txtnombrecliente = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblequipo = new System.Windows.Forms.Label();
            this.lblcliente = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFechaIngresoHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaHastaIngreso = new System.Windows.Forms.Label();
            this.dtpFechaDesdeIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDesdeIngreso = new System.Windows.Forms.Label();
            this.checkTodasIngreso = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpFechaHastaEgreso = new System.Windows.Forms.DateTimePicker();
            this.lblFechaHastaEntrega = new System.Windows.Forms.Label();
            this.dtpFechaDesdeEntrega = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDesdeEntrega = new System.Windows.Forms.Label();
            this.checkTodasEntrega = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtnro = new System.Windows.Forms.TextBox();
            this.lblnro = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwReparaciones)).BeginInit();
            this.panelBarraArriba.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnX);
            this.groupBox7.Controls.Add(this.btnFiltrar);
            this.groupBox7.Controls.Add(this.txtfiltro);
            this.groupBox7.Controls.Add(this.lblfiltro);
            this.groupBox7.Controls.Add(this.dgwReparaciones);
            this.groupBox7.Location = new System.Drawing.Point(121, 296);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(1004, 419);
            this.groupBox7.TabIndex = 1;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Resultado";
            this.groupBox7.Enter += new System.EventHandler(this.groupBox7_Enter);
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
            this.txtfiltro.Size = new System.Drawing.Size(242, 23);
            this.txtfiltro.TabIndex = 14;
            this.txtfiltro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtfiltro_KeyDown);
            // 
            // lblfiltro
            // 
            this.lblfiltro.AutoSize = true;
            this.lblfiltro.Location = new System.Drawing.Point(587, 21);
            this.lblfiltro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfiltro.Name = "lblfiltro";
            this.lblfiltro.Size = new System.Drawing.Size(49, 16);
            this.lblfiltro.TabIndex = 6;
            this.lblfiltro.Text = "Filtro:";
            // 
            // dgwReparaciones
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 7.6F);
            this.dgwReparaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwReparaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwReparaciones.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgwReparaciones.Location = new System.Drawing.Point(8, 51);
            this.dgwReparaciones.Margin = new System.Windows.Forms.Padding(4);
            this.dgwReparaciones.MultiSelect = false;
            this.dgwReparaciones.Name = "dgwReparaciones";
            this.dgwReparaciones.ReadOnly = true;
            this.dgwReparaciones.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 7.8F);
            this.dgwReparaciones.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwReparaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwReparaciones.ShowEditingIcon = false;
            this.dgwReparaciones.Size = new System.Drawing.Size(978, 352);
            this.dgwReparaciones.TabIndex = 50;
            this.dgwReparaciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwReparaciones_CellContentDoubleClick);
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
            this.btnGenerarRecibo.Location = new System.Drawing.Point(-1, 300);
            this.btnGenerarRecibo.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerarRecibo.Name = "btnGenerarRecibo";
            this.btnGenerarRecibo.Size = new System.Drawing.Size(118, 83);
            this.btnGenerarRecibo.TabIndex = 21;
            this.btnGenerarRecibo.Text = "GEN. RECIBO";
            this.btnGenerarRecibo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGenerarRecibo.UseVisualStyleBackColor = false;
            this.btnGenerarRecibo.Click += new System.EventHandler(this.btnGenerarRecibo_Click);
            // 
            // btnLlamadas
            // 
            this.btnLlamadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnLlamadas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLlamadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLlamadas.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.btnLlamadas.ForeColor = System.Drawing.Color.White;
            this.btnLlamadas.Image = global::reparaciones2.Properties.Resources.pda;
            this.btnLlamadas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLlamadas.Location = new System.Drawing.Point(-1, 224);
            this.btnLlamadas.Margin = new System.Windows.Forms.Padding(4);
            this.btnLlamadas.Name = "btnLlamadas";
            this.btnLlamadas.Size = new System.Drawing.Size(118, 79);
            this.btnLlamadas.TabIndex = 20;
            this.btnLlamadas.Text = "LLAMADAS";
            this.btnLlamadas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLlamadas.UseVisualStyleBackColor = false;
            this.btnLlamadas.Click += new System.EventHandler(this.btnLlamadas_Click);
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
            this.panelBarraArriba.Location = new System.Drawing.Point(0, 0);
            this.panelBarraArriba.Margin = new System.Windows.Forms.Padding(2);
            this.panelBarraArriba.Name = "panelBarraArriba";
            this.panelBarraArriba.Size = new System.Drawing.Size(1129, 46);
            this.panelBarraArriba.TabIndex = 13;
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
            this.panel1.Controls.Add(this.btnGenerarRecibo);
            this.panel1.Controls.Add(this.btneditardatos);
            this.panel1.Controls.Add(this.btnLlamadas);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 678);
            this.panel1.TabIndex = 2;
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
            this.btnExportar.Location = new System.Drawing.Point(-1, 381);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(123, 74);
            this.btnExportar.TabIndex = 22;
            this.btnExportar.Text = "EXPORTAR";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
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
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Image = global::reparaciones2.Properties.Resources.printer;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImprimir.Location = new System.Drawing.Point(-1, 149);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(118, 76);
            this.btnImprimir.TabIndex = 19;
            this.btnImprimir.Text = "RE IMPRIMIR";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(1002, 203);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Por Equipo";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmbModelo);
            this.groupBox5.Controls.Add(this.lblModelo);
            this.groupBox5.Controls.Add(this.cmbMarca);
            this.groupBox5.Controls.Add(this.lblMarca);
            this.groupBox5.Controls.Add(this.cmbTipoEquipo);
            this.groupBox5.Controls.Add(this.lblTipoEquipo);
            this.groupBox5.Location = new System.Drawing.Point(8, 16);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(752, 155);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Por Equipo";
            // 
            // cmbModelo
            // 
            this.cmbModelo.FormattingEnabled = true;
            this.cmbModelo.Location = new System.Drawing.Point(111, 101);
            this.cmbModelo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbModelo.Name = "cmbModelo";
            this.cmbModelo.Size = new System.Drawing.Size(613, 24);
            this.cmbModelo.TabIndex = 3;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(9, 106);
            this.lblModelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(65, 16);
            this.lblModelo.TabIndex = 4;
            this.lblModelo.Text = "Modelo:";
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(112, 65);
            this.cmbMarca.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(612, 24);
            this.cmbMarca.TabIndex = 2;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(10, 70);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(55, 16);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca:";
            // 
            // cmbTipoEquipo
            // 
            this.cmbTipoEquipo.FormattingEnabled = true;
            this.cmbTipoEquipo.Location = new System.Drawing.Point(111, 29);
            this.cmbTipoEquipo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoEquipo.Name = "cmbTipoEquipo";
            this.cmbTipoEquipo.Size = new System.Drawing.Size(613, 24);
            this.cmbTipoEquipo.TabIndex = 1;
            // 
            // lblTipoEquipo
            // 
            this.lblTipoEquipo.AutoSize = true;
            this.lblTipoEquipo.Location = new System.Drawing.Point(9, 34);
            this.lblTipoEquipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoEquipo.Name = "lblTipoEquipo";
            this.lblTipoEquipo.Size = new System.Drawing.Size(95, 16);
            this.lblTipoEquipo.TabIndex = 0;
            this.lblTipoEquipo.Text = "Tipo Equipo:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(1002, 203);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Por Cliente y Equipo de Cliente";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnXEquipo);
            this.groupBox3.Controls.Add(this.btnXCliente);
            this.groupBox3.Controls.Add(this.txtidequipo);
            this.groupBox3.Controls.Add(this.txtidcliente);
            this.groupBox3.Controls.Add(this.txtnombreequipocliente);
            this.groupBox3.Controls.Add(this.txtnombrecliente);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.lblequipo);
            this.groupBox3.Controls.Add(this.lblcliente);
            this.groupBox3.Location = new System.Drawing.Point(8, 16);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(752, 136);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Consultar Por Cliente y Equipo";
            // 
            // btnXEquipo
            // 
            this.btnXEquipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnXEquipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXEquipo.Image = global::reparaciones2.Properties.Resources.stop;
            this.btnXEquipo.Location = new System.Drawing.Point(672, 60);
            this.btnXEquipo.Margin = new System.Windows.Forms.Padding(4);
            this.btnXEquipo.Name = "btnXEquipo";
            this.btnXEquipo.Size = new System.Drawing.Size(40, 29);
            this.btnXEquipo.TabIndex = 4;
            this.btnXEquipo.UseVisualStyleBackColor = false;
            this.btnXEquipo.Click += new System.EventHandler(this.btnXEquipo_Click);
            // 
            // btnXCliente
            // 
            this.btnXCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnXCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXCliente.Image = global::reparaciones2.Properties.Resources.stop;
            this.btnXCliente.Location = new System.Drawing.Point(672, 26);
            this.btnXCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnXCliente.Name = "btnXCliente";
            this.btnXCliente.Size = new System.Drawing.Size(40, 29);
            this.btnXCliente.TabIndex = 2;
            this.btnXCliente.UseVisualStyleBackColor = false;
            this.btnXCliente.Click += new System.EventHandler(this.btnXCliente_Click);
            // 
            // txtidequipo
            // 
            this.txtidequipo.Enabled = false;
            this.txtidequipo.Location = new System.Drawing.Point(91, 62);
            this.txtidequipo.Margin = new System.Windows.Forms.Padding(4);
            this.txtidequipo.Name = "txtidequipo";
            this.txtidequipo.Size = new System.Drawing.Size(58, 23);
            this.txtidequipo.TabIndex = 11;
            // 
            // txtidcliente
            // 
            this.txtidcliente.Enabled = false;
            this.txtidcliente.Location = new System.Drawing.Point(91, 29);
            this.txtidcliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtidcliente.Name = "txtidcliente";
            this.txtidcliente.Size = new System.Drawing.Size(58, 23);
            this.txtidcliente.TabIndex = 10;
            // 
            // txtnombreequipocliente
            // 
            this.txtnombreequipocliente.Enabled = false;
            this.txtnombreequipocliente.Location = new System.Drawing.Point(158, 62);
            this.txtnombreequipocliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombreequipocliente.Name = "txtnombreequipocliente";
            this.txtnombreequipocliente.Size = new System.Drawing.Size(459, 23);
            this.txtnombreequipocliente.TabIndex = 9;
            // 
            // txtnombrecliente
            // 
            this.txtnombrecliente.Enabled = false;
            this.txtnombrecliente.Location = new System.Drawing.Point(158, 29);
            this.txtnombrecliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombrecliente.Name = "txtnombrecliente";
            this.txtnombrecliente.Size = new System.Drawing.Size(460, 23);
            this.txtnombrecliente.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::reparaciones2.Properties.Resources.viewmag1;
            this.button2.Location = new System.Drawing.Point(625, 60);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 29);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::reparaciones2.Properties.Resources.viewmag1;
            this.button1.Location = new System.Drawing.Point(625, 26);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 29);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblequipo
            // 
            this.lblequipo.AutoSize = true;
            this.lblequipo.Location = new System.Drawing.Point(9, 68);
            this.lblequipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblequipo.Name = "lblequipo";
            this.lblequipo.Size = new System.Drawing.Size(61, 16);
            this.lblequipo.TabIndex = 2;
            this.lblequipo.Text = "Equipo:";
            // 
            // lblcliente
            // 
            this.lblcliente.AutoSize = true;
            this.lblcliente.Location = new System.Drawing.Point(9, 31);
            this.lblcliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcliente.Name = "lblcliente";
            this.lblcliente.Size = new System.Drawing.Size(62, 16);
            this.lblcliente.TabIndex = 0;
            this.lblcliente.Text = "Cliente:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1002, 203);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Por Nro. de Orden y Estado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFechaIngresoHasta);
            this.groupBox1.Controls.Add(this.lblFechaHastaIngreso);
            this.groupBox1.Controls.Add(this.dtpFechaDesdeIngreso);
            this.groupBox1.Controls.Add(this.lblFechaDesdeIngreso);
            this.groupBox1.Controls.Add(this.checkTodasIngreso);
            this.groupBox1.Location = new System.Drawing.Point(292, 8);
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
            this.dtpFechaIngresoHasta.Size = new System.Drawing.Size(112, 23);
            this.dtpFechaIngresoHasta.TabIndex = 4;
            this.dtpFechaIngresoHasta.Value = new System.DateTime(2017, 9, 10, 0, 0, 0, 0);
            // 
            // lblFechaHastaIngreso
            // 
            this.lblFechaHastaIngreso.AutoSize = true;
            this.lblFechaHastaIngreso.Location = new System.Drawing.Point(9, 91);
            this.lblFechaHastaIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaHastaIngreso.Name = "lblFechaHastaIngreso";
            this.lblFechaHastaIngreso.Size = new System.Drawing.Size(98, 16);
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
            this.dtpFechaDesdeIngreso.Size = new System.Drawing.Size(112, 23);
            this.dtpFechaDesdeIngreso.TabIndex = 3;
            this.dtpFechaDesdeIngreso.Value = new System.DateTime(2017, 9, 10, 0, 0, 0, 0);
            // 
            // lblFechaDesdeIngreso
            // 
            this.lblFechaDesdeIngreso.AutoSize = true;
            this.lblFechaDesdeIngreso.Location = new System.Drawing.Point(9, 58);
            this.lblFechaDesdeIngreso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaDesdeIngreso.Name = "lblFechaDesdeIngreso";
            this.lblFechaDesdeIngreso.Size = new System.Drawing.Size(104, 16);
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
            this.checkTodasIngreso.Size = new System.Drawing.Size(77, 20);
            this.checkTodasIngreso.TabIndex = 1;
            this.checkTodasIngreso.Text = "TODAS";
            this.checkTodasIngreso.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpFechaHastaEgreso);
            this.groupBox2.Controls.Add(this.lblFechaHastaEntrega);
            this.groupBox2.Controls.Add(this.dtpFechaDesdeEntrega);
            this.groupBox2.Controls.Add(this.lblFechaDesdeEntrega);
            this.groupBox2.Controls.Add(this.checkTodasEntrega);
            this.groupBox2.Location = new System.Drawing.Point(555, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(271, 119);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consultar Por Fecha de Entrega";
            // 
            // dtpFechaHastaEgreso
            // 
            this.dtpFechaHastaEgreso.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaHastaEgreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaHastaEgreso.Location = new System.Drawing.Point(120, 85);
            this.dtpFechaHastaEgreso.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaHastaEgreso.Name = "dtpFechaHastaEgreso";
            this.dtpFechaHastaEgreso.Size = new System.Drawing.Size(112, 23);
            this.dtpFechaHastaEgreso.TabIndex = 6;
            this.dtpFechaHastaEgreso.Value = new System.DateTime(2017, 9, 10, 0, 0, 0, 0);
            // 
            // lblFechaHastaEntrega
            // 
            this.lblFechaHastaEntrega.AutoSize = true;
            this.lblFechaHastaEntrega.Location = new System.Drawing.Point(9, 91);
            this.lblFechaHastaEntrega.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaHastaEntrega.Name = "lblFechaHastaEntrega";
            this.lblFechaHastaEntrega.Size = new System.Drawing.Size(98, 16);
            this.lblFechaHastaEntrega.TabIndex = 4;
            this.lblFechaHastaEntrega.Text = "Fecha Hasta:";
            // 
            // dtpFechaDesdeEntrega
            // 
            this.dtpFechaDesdeEntrega.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaDesdeEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaDesdeEntrega.Location = new System.Drawing.Point(120, 51);
            this.dtpFechaDesdeEntrega.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaDesdeEntrega.Name = "dtpFechaDesdeEntrega";
            this.dtpFechaDesdeEntrega.Size = new System.Drawing.Size(112, 23);
            this.dtpFechaDesdeEntrega.TabIndex = 5;
            this.dtpFechaDesdeEntrega.Value = new System.DateTime(2017, 9, 10, 0, 0, 0, 0);
            // 
            // lblFechaDesdeEntrega
            // 
            this.lblFechaDesdeEntrega.AutoSize = true;
            this.lblFechaDesdeEntrega.Location = new System.Drawing.Point(9, 58);
            this.lblFechaDesdeEntrega.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaDesdeEntrega.Name = "lblFechaDesdeEntrega";
            this.lblFechaDesdeEntrega.Size = new System.Drawing.Size(104, 16);
            this.lblFechaDesdeEntrega.TabIndex = 2;
            this.lblFechaDesdeEntrega.Text = "Fecha Desde:";
            // 
            // checkTodasEntrega
            // 
            this.checkTodasEntrega.AutoSize = true;
            this.checkTodasEntrega.Checked = true;
            this.checkTodasEntrega.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkTodasEntrega.Location = new System.Drawing.Point(8, 25);
            this.checkTodasEntrega.Margin = new System.Windows.Forms.Padding(4);
            this.checkTodasEntrega.Name = "checkTodasEntrega";
            this.checkTodasEntrega.Size = new System.Drawing.Size(77, 20);
            this.checkTodasEntrega.TabIndex = 1;
            this.checkTodasEntrega.Text = "TODAS";
            this.checkTodasEntrega.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtnro);
            this.groupBox4.Controls.Add(this.lblnro);
            this.groupBox4.Location = new System.Drawing.Point(12, 8);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(271, 82);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Consultar Por Nro de Orden";
            // 
            // txtnro
            // 
            this.txtnro.Location = new System.Drawing.Point(69, 31);
            this.txtnro.Margin = new System.Windows.Forms.Padding(4);
            this.txtnro.Name = "txtnro";
            this.txtnro.Size = new System.Drawing.Size(189, 23);
            this.txtnro.TabIndex = 1;
            this.txtnro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnro_KeyDown);
            this.txtnro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnro_KeyPress);
            // 
            // lblnro
            // 
            this.lblnro.AutoSize = true;
            this.lblnro.Location = new System.Drawing.Point(9, 38);
            this.lblnro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnro.Name = "lblnro";
            this.lblnro.Size = new System.Drawing.Size(37, 16);
            this.lblnro.TabIndex = 0;
            this.lblnro.Text = "Nro:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cmbEstado);
            this.groupBox6.Controls.Add(this.lblestado);
            this.groupBox6.Location = new System.Drawing.Point(9, 98);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(275, 82);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Consultar Por Estado:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(76, 31);
            this.cmbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(186, 24);
            this.cmbEstado.TabIndex = 2;
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Location = new System.Drawing.Point(8, 36);
            this.lblestado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(60, 16);
            this.lblestado.TabIndex = 0;
            this.lblestado.Text = "Estado:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(119, 58);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1010, 232);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // FrmConsultarReparaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1130, 720);
            this.Controls.Add(this.panelBarraArriba);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox7);
            this.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsultarReparaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONSULTAR REPARACIONES";
            this.Load += new System.EventHandler(this.FrmConsultarReparaciones_Load);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwReparaciones)).EndInit();
            this.panelBarraArriba.ResumeLayout(false);
            this.panelBarraArriba.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dgwReparaciones;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TextBox txtfiltro;
        private System.Windows.Forms.Label lblfiltro;
        private System.Windows.Forms.Button btnLlamadas;
        private System.Windows.Forms.Button btnGenerarRecibo;
        private System.Windows.Forms.Panel panelBarraArriba;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btneditardatos;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cmbModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.ComboBox cmbTipoEquipo;
        private System.Windows.Forms.Label lblTipoEquipo;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnXEquipo;
        private System.Windows.Forms.Button btnXCliente;
        private System.Windows.Forms.TextBox txtidequipo;
        private System.Windows.Forms.TextBox txtidcliente;
        private System.Windows.Forms.TextBox txtnombreequipocliente;
        private System.Windows.Forms.TextBox txtnombrecliente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblequipo;
        private System.Windows.Forms.Label lblcliente;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFechaIngresoHasta;
        private System.Windows.Forms.Label lblFechaHastaIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaDesdeIngreso;
        private System.Windows.Forms.Label lblFechaDesdeIngreso;
        private System.Windows.Forms.CheckBox checkTodasIngreso;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpFechaHastaEgreso;
        private System.Windows.Forms.Label lblFechaHastaEntrega;
        private System.Windows.Forms.DateTimePicker dtpFechaDesdeEntrega;
        private System.Windows.Forms.Label lblFechaDesdeEntrega;
        private System.Windows.Forms.CheckBox checkTodasEntrega;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtnro;
        private System.Windows.Forms.Label lblnro;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}