namespace reparaciones2
{
    partial class FrmAdminContacto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminContacto));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbldatosemail = new System.Windows.Forms.Label();
            this.lbldatoscelular = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lblcelular = new System.Windows.Forms.Label();
            this.lbldatostelefono = new System.Windows.Forms.Label();
            this.lbldatosdireccion = new System.Windows.Forms.Label();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.lbldatosnombre = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabCuentaCorriente = new System.Windows.Forms.TabPage();
            this.btnNotaCD = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.lbldatosMontoAdeudado = new System.Windows.Forms.Label();
            this.lblMontoAdeudado = new System.Windows.Forms.Label();
            this.dgwCuentaCorriente = new System.Windows.Forms.DataGridView();
            this.tabctacte = new System.Windows.Forms.TabPage();
            this.dgwequipos = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnLlamadas = new System.Windows.Forms.Button();
            this.btnAgregarReparacion = new System.Windows.Forms.Button();
            this.dgwreparaciones = new System.Windows.Forms.DataGridView();
            this.tabService = new System.Windows.Forms.TabPage();
            this.btnAgregarService = new System.Windows.Forms.Button();
            this.dgwService = new System.Windows.Forms.DataGridView();
            this.panelBarraArriba = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEnviarMail = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btneditardatos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tab.SuspendLayout();
            this.tabCuentaCorriente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCuentaCorriente)).BeginInit();
            this.tabctacte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwequipos)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwreparaciones)).BeginInit();
            this.tabService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwService)).BeginInit();
            this.panelBarraArriba.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbldatosemail);
            this.groupBox1.Controls.Add(this.lbldatoscelular);
            this.groupBox1.Controls.Add(this.lblemail);
            this.groupBox1.Controls.Add(this.lblcelular);
            this.groupBox1.Controls.Add(this.lbldatostelefono);
            this.groupBox1.Controls.Add(this.lbldatosdireccion);
            this.groupBox1.Controls.Add(this.lbltelefono);
            this.groupBox1.Controls.Add(this.lbldireccion);
            this.groupBox1.Controls.Add(this.lbldatosnombre);
            this.groupBox1.Controls.Add(this.lblnombre);
            this.groupBox1.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(163, 61);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1045, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbldatosemail
            // 
            this.lbldatosemail.AutoSize = true;
            this.lbldatosemail.Location = new System.Drawing.Point(809, 88);
            this.lbldatosemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldatosemail.Name = "lbldatosemail";
            this.lbldatosemail.Size = new System.Drawing.Size(37, 22);
            this.lbldatosemail.TabIndex = 14;
            this.lbldatosemail.Text = "S/D";
            // 
            // lbldatoscelular
            // 
            this.lbldatoscelular.AutoSize = true;
            this.lbldatoscelular.Location = new System.Drawing.Point(484, 88);
            this.lbldatoscelular.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldatoscelular.Name = "lbldatoscelular";
            this.lbldatoscelular.Size = new System.Drawing.Size(37, 22);
            this.lbldatoscelular.TabIndex = 13;
            this.lbldatoscelular.Text = "S/D";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(754, 88);
            this.lblemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(61, 22);
            this.lblemail.TabIndex = 12;
            this.lblemail.Text = "Email:";
            // 
            // lblcelular
            // 
            this.lblcelular.AutoSize = true;
            this.lblcelular.Location = new System.Drawing.Point(411, 88);
            this.lblcelular.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcelular.Name = "lblcelular";
            this.lblcelular.Size = new System.Drawing.Size(75, 22);
            this.lblcelular.TabIndex = 11;
            this.lblcelular.Text = "Celular:";
            // 
            // lbldatostelefono
            // 
            this.lbldatostelefono.AutoSize = true;
            this.lbldatostelefono.Location = new System.Drawing.Point(110, 88);
            this.lbldatostelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldatostelefono.Name = "lbldatostelefono";
            this.lbldatostelefono.Size = new System.Drawing.Size(37, 22);
            this.lbldatostelefono.TabIndex = 6;
            this.lbldatostelefono.Text = "S/D";
            // 
            // lbldatosdireccion
            // 
            this.lbldatosdireccion.AutoSize = true;
            this.lbldatosdireccion.Location = new System.Drawing.Point(110, 60);
            this.lbldatosdireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldatosdireccion.Name = "lbldatosdireccion";
            this.lbldatosdireccion.Size = new System.Drawing.Size(37, 22);
            this.lbldatosdireccion.TabIndex = 5;
            this.lbldatosdireccion.Text = "S/D";
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Location = new System.Drawing.Point(8, 88);
            this.lbltelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(86, 22);
            this.lbltelefono.TabIndex = 4;
            this.lbltelefono.Text = "Teléfono:";
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Location = new System.Drawing.Point(8, 60);
            this.lbldireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(94, 22);
            this.lbldireccion.TabIndex = 2;
            this.lbldireccion.Text = "Dirección:";
            // 
            // lbldatosnombre
            // 
            this.lbldatosnombre.AutoSize = true;
            this.lbldatosnombre.Location = new System.Drawing.Point(110, 32);
            this.lbldatosnombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldatosnombre.Name = "lbldatosnombre";
            this.lbldatosnombre.Size = new System.Drawing.Size(37, 22);
            this.lbldatosnombre.TabIndex = 1;
            this.lbldatosnombre.Text = "S/D";
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(8, 32);
            this.lblnombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(80, 22);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Nombre:";
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabCuentaCorriente);
            this.tab.Controls.Add(this.tabctacte);
            this.tab.Controls.Add(this.tabPage2);
            this.tab.Controls.Add(this.tabService);
            this.tab.Location = new System.Drawing.Point(163, 179);
            this.tab.Margin = new System.Windows.Forms.Padding(4);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(1035, 452);
            this.tab.TabIndex = 1;
            // 
            // tabCuentaCorriente
            // 
            this.tabCuentaCorriente.Controls.Add(this.btnNotaCD);
            this.tabCuentaCorriente.Controls.Add(this.btnExportar);
            this.tabCuentaCorriente.Controls.Add(this.lbldatosMontoAdeudado);
            this.tabCuentaCorriente.Controls.Add(this.lblMontoAdeudado);
            this.tabCuentaCorriente.Controls.Add(this.dgwCuentaCorriente);
            this.tabCuentaCorriente.Location = new System.Drawing.Point(4, 27);
            this.tabCuentaCorriente.Name = "tabCuentaCorriente";
            this.tabCuentaCorriente.Padding = new System.Windows.Forms.Padding(3);
            this.tabCuentaCorriente.Size = new System.Drawing.Size(1027, 421);
            this.tabCuentaCorriente.TabIndex = 2;
            this.tabCuentaCorriente.Text = "Cuenta Corriente";
            this.tabCuentaCorriente.UseVisualStyleBackColor = true;
            // 
            // btnNotaCD
            // 
            this.btnNotaCD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnNotaCD.FlatAppearance.BorderSize = 0;
            this.btnNotaCD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotaCD.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotaCD.ForeColor = System.Drawing.Color.White;
            this.btnNotaCD.Image = global::reparaciones2.Properties.Resources.papel;
            this.btnNotaCD.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNotaCD.Location = new System.Drawing.Point(4, 108);
            this.btnNotaCD.Margin = new System.Windows.Forms.Padding(4);
            this.btnNotaCD.Name = "btnNotaCD";
            this.btnNotaCD.Size = new System.Drawing.Size(138, 65);
            this.btnNotaCD.TabIndex = 10;
            this.btnNotaCD.Text = "NOTAS CD";
            this.btnNotaCD.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNotaCD.UseVisualStyleBackColor = false;
            this.btnNotaCD.Click += new System.EventHandler(this.btnNotaCD_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnExportar.FlatAppearance.BorderSize = 0;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportar.ForeColor = System.Drawing.Color.White;
            this.btnExportar.Image = global::reparaciones2.Properties.Resources._26967_6_excel_picture;
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExportar.Location = new System.Drawing.Point(4, 35);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(138, 65);
            this.btnExportar.TabIndex = 9;
            this.btnExportar.Text = "EXPORTAR";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExportar.UseVisualStyleBackColor = false;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // lbldatosMontoAdeudado
            // 
            this.lbldatosMontoAdeudado.AutoSize = true;
            this.lbldatosMontoAdeudado.Location = new System.Drawing.Point(284, 328);
            this.lbldatosMontoAdeudado.Name = "lbldatosMontoAdeudado";
            this.lbldatosMontoAdeudado.Size = new System.Drawing.Size(36, 18);
            this.lbldatosMontoAdeudado.TabIndex = 8;
            this.lbldatosMontoAdeudado.Text = "0.00";
            // 
            // lblMontoAdeudado
            // 
            this.lblMontoAdeudado.AutoSize = true;
            this.lblMontoAdeudado.Location = new System.Drawing.Point(147, 328);
            this.lblMontoAdeudado.Name = "lblMontoAdeudado";
            this.lblMontoAdeudado.Size = new System.Drawing.Size(131, 18);
            this.lblMontoAdeudado.TabIndex = 7;
            this.lblMontoAdeudado.Text = "Monto Adeudado:";
            // 
            // dgwCuentaCorriente
            // 
            this.dgwCuentaCorriente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCuentaCorriente.Location = new System.Drawing.Point(150, 35);
            this.dgwCuentaCorriente.Margin = new System.Windows.Forms.Padding(4);
            this.dgwCuentaCorriente.Name = "dgwCuentaCorriente";
            this.dgwCuentaCorriente.RowHeadersWidth = 51;
            this.dgwCuentaCorriente.Size = new System.Drawing.Size(856, 279);
            this.dgwCuentaCorriente.TabIndex = 6;
            // 
            // tabctacte
            // 
            this.tabctacte.Controls.Add(this.dgwequipos);
            this.tabctacte.Location = new System.Drawing.Point(4, 27);
            this.tabctacte.Margin = new System.Windows.Forms.Padding(4);
            this.tabctacte.Name = "tabctacte";
            this.tabctacte.Padding = new System.Windows.Forms.Padding(4);
            this.tabctacte.Size = new System.Drawing.Size(1027, 421);
            this.tabctacte.TabIndex = 0;
            this.tabctacte.Text = "Equipos";
            this.tabctacte.UseVisualStyleBackColor = true;
            // 
            // dgwequipos
            // 
            this.dgwequipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwequipos.Location = new System.Drawing.Point(9, 26);
            this.dgwequipos.Margin = new System.Windows.Forms.Padding(4);
            this.dgwequipos.Name = "dgwequipos";
            this.dgwequipos.RowHeadersWidth = 51;
            this.dgwequipos.Size = new System.Drawing.Size(984, 279);
            this.dgwequipos.TabIndex = 5;
            this.dgwequipos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwequipos_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnLlamadas);
            this.tabPage2.Controls.Add(this.btnAgregarReparacion);
            this.tabPage2.Controls.Add(this.dgwreparaciones);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1027, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reparaciones";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLlamadas
            // 
            this.btnLlamadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnLlamadas.FlatAppearance.BorderSize = 0;
            this.btnLlamadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLlamadas.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLlamadas.ForeColor = System.Drawing.Color.White;
            this.btnLlamadas.Image = global::reparaciones2.Properties.Resources.pda;
            this.btnLlamadas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLlamadas.Location = new System.Drawing.Point(8, 93);
            this.btnLlamadas.Margin = new System.Windows.Forms.Padding(4);
            this.btnLlamadas.Name = "btnLlamadas";
            this.btnLlamadas.Size = new System.Drawing.Size(138, 65);
            this.btnLlamadas.TabIndex = 4;
            this.btnLlamadas.Text = "LLAMADAS";
            this.btnLlamadas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLlamadas.UseVisualStyleBackColor = false;
            this.btnLlamadas.Click += new System.EventHandler(this.btnLlamadas_Click);
            // 
            // btnAgregarReparacion
            // 
            this.btnAgregarReparacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnAgregarReparacion.FlatAppearance.BorderSize = 0;
            this.btnAgregarReparacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarReparacion.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarReparacion.ForeColor = System.Drawing.Color.White;
            this.btnAgregarReparacion.Image = global::reparaciones2.Properties.Resources.edit_add;
            this.btnAgregarReparacion.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarReparacion.Location = new System.Drawing.Point(8, 20);
            this.btnAgregarReparacion.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarReparacion.Name = "btnAgregarReparacion";
            this.btnAgregarReparacion.Size = new System.Drawing.Size(138, 65);
            this.btnAgregarReparacion.TabIndex = 3;
            this.btnAgregarReparacion.Text = "AGREGAR";
            this.btnAgregarReparacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarReparacion.UseVisualStyleBackColor = false;
            this.btnAgregarReparacion.Click += new System.EventHandler(this.btnAgregarReparacion_Click);
            // 
            // dgwreparaciones
            // 
            this.dgwreparaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwreparaciones.Location = new System.Drawing.Point(154, 20);
            this.dgwreparaciones.Margin = new System.Windows.Forms.Padding(4);
            this.dgwreparaciones.Name = "dgwreparaciones";
            this.dgwreparaciones.ReadOnly = true;
            this.dgwreparaciones.RowHeadersWidth = 51;
            this.dgwreparaciones.Size = new System.Drawing.Size(845, 282);
            this.dgwreparaciones.TabIndex = 0;
            this.dgwreparaciones.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwreparaciones_CellContentClick);
            // 
            // tabService
            // 
            this.tabService.Controls.Add(this.btnAgregarService);
            this.tabService.Controls.Add(this.dgwService);
            this.tabService.Location = new System.Drawing.Point(4, 27);
            this.tabService.Name = "tabService";
            this.tabService.Size = new System.Drawing.Size(1027, 421);
            this.tabService.TabIndex = 3;
            this.tabService.Text = "Services";
            this.tabService.UseVisualStyleBackColor = true;
            // 
            // btnAgregarService
            // 
            this.btnAgregarService.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnAgregarService.FlatAppearance.BorderSize = 0;
            this.btnAgregarService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarService.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarService.ForeColor = System.Drawing.Color.White;
            this.btnAgregarService.Image = global::reparaciones2.Properties.Resources.edit_add;
            this.btnAgregarService.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAgregarService.Location = new System.Drawing.Point(12, 23);
            this.btnAgregarService.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarService.Name = "btnAgregarService";
            this.btnAgregarService.Size = new System.Drawing.Size(138, 65);
            this.btnAgregarService.TabIndex = 6;
            this.btnAgregarService.Text = "AGREGAR";
            this.btnAgregarService.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarService.UseVisualStyleBackColor = false;
            this.btnAgregarService.Click += new System.EventHandler(this.btnAgregarService_Click);
            // 
            // dgwService
            // 
            this.dgwService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwService.Location = new System.Drawing.Point(158, 23);
            this.dgwService.Margin = new System.Windows.Forms.Padding(4);
            this.dgwService.Name = "dgwService";
            this.dgwService.ReadOnly = true;
            this.dgwService.RowHeadersWidth = 51;
            this.dgwService.Size = new System.Drawing.Size(845, 282);
            this.dgwService.TabIndex = 5;
            // 
            // panelBarraArriba
            // 
            this.panelBarraArriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.panelBarraArriba.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBarraArriba.Controls.Add(this.button1);
            this.panelBarraArriba.Controls.Add(this.btnApagar);
            this.panelBarraArriba.Controls.Add(this.label2);
            this.panelBarraArriba.Location = new System.Drawing.Point(0, 0);
            this.panelBarraArriba.Name = "panelBarraArriba";
            this.panelBarraArriba.Size = new System.Drawing.Size(1212, 54);
            this.panelBarraArriba.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::reparaciones2.Properties.Resources.exit;
            this.button1.Location = new System.Drawing.Point(1157, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.FlatAppearance.BorderSize = 0;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Image = global::reparaciones2.Properties.Resources.exit;
            this.btnApagar.Location = new System.Drawing.Point(1360, -1);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(50, 50);
            this.btnApagar.TabIndex = 4;
            this.btnApagar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(421, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "ADMINISTRACION DE CLIENTE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(130)))), ((int)(((byte)(172)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnEnviarMail);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btneditardatos);
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 580);
            this.panel1.TabIndex = 12;
            // 
            // btnEnviarMail
            // 
            this.btnEnviarMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnEnviarMail.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEnviarMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarMail.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarMail.ForeColor = System.Drawing.Color.White;
            this.btnEnviarMail.Image = global::reparaciones2.Properties.Resources.mail_send;
            this.btnEnviarMail.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEnviarMail.Location = new System.Drawing.Point(-1, 69);
            this.btnEnviarMail.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnviarMail.Name = "btnEnviarMail";
            this.btnEnviarMail.Size = new System.Drawing.Size(138, 68);
            this.btnEnviarMail.TabIndex = 8;
            this.btnEnviarMail.Text = "ENVIAR MAIL";
            this.btnEnviarMail.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEnviarMail.UseVisualStyleBackColor = false;
            this.btnEnviarMail.Click += new System.EventHandler(this.btnEnviarMail_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = global::reparaciones2.Properties.Resources.cancel;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalir.Location = new System.Drawing.Point(-1, 136);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(138, 68);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btneditardatos
            // 
            this.btneditardatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btneditardatos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btneditardatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneditardatos.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneditardatos.ForeColor = System.Drawing.Color.White;
            this.btneditardatos.Image = global::reparaciones2.Properties.Resources.color_line;
            this.btneditardatos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btneditardatos.Location = new System.Drawing.Point(-1, 2);
            this.btneditardatos.Margin = new System.Windows.Forms.Padding(2);
            this.btneditardatos.Name = "btneditardatos";
            this.btneditardatos.Size = new System.Drawing.Size(138, 68);
            this.btneditardatos.TabIndex = 6;
            this.btneditardatos.Text = "EDITAR";
            this.btneditardatos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btneditardatos.UseVisualStyleBackColor = false;
            this.btneditardatos.Click += new System.EventHandler(this.btneditardatos_Click_1);
            // 
            // FrmAdminContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1211, 631);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.panelBarraArriba);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAdminContacto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos del Cliente";
            this.Load += new System.EventHandler(this.FrmAdminContacto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tab.ResumeLayout(false);
            this.tabCuentaCorriente.ResumeLayout(false);
            this.tabCuentaCorriente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCuentaCorriente)).EndInit();
            this.tabctacte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwequipos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwreparaciones)).EndInit();
            this.tabService.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwService)).EndInit();
            this.panelBarraArriba.ResumeLayout(false);
            this.panelBarraArriba.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.Label lbldatosnombre;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabctacte;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgwreparaciones;
        private System.Windows.Forms.Label lbldatostelefono;
        private System.Windows.Forms.Label lbldatosdireccion;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.DataGridView dgwequipos;
        private System.Windows.Forms.Label lblcelular;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lbldatosemail;
        private System.Windows.Forms.Label lbldatoscelular;
        private System.Windows.Forms.Button btnAgregarReparacion;
        private System.Windows.Forms.Button btnLlamadas;
        private System.Windows.Forms.Panel panelBarraArriba;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btneditardatos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEnviarMail;
        private System.Windows.Forms.TabPage tabCuentaCorriente;
        private System.Windows.Forms.DataGridView dgwCuentaCorriente;
        private System.Windows.Forms.Label lbldatosMontoAdeudado;
        private System.Windows.Forms.Label lblMontoAdeudado;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnNotaCD;
        private System.Windows.Forms.TabPage tabService;
        private System.Windows.Forms.Button btnAgregarService;
        private System.Windows.Forms.DataGridView dgwService;
    }
}