namespace reparaciones2
{
    partial class FrmParametros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParametros));
            this.txtLeyenda = new System.Windows.Forms.TextBox();
            this.lblleyenda = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.panelBarraArriba = new System.Windows.Forms.Panel();
            this.btnApagar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabgDatos = new System.Windows.Forms.TabControl();
            this.tabDatosEmpresa = new System.Windows.Forms.TabPage();
            this.lblcoordenadas = new System.Windows.Forms.Label();
            this.txtcoordenadas = new System.Windows.Forms.TextBox();
            this.lblEmailEmpresa = new System.Windows.Forms.Label();
            this.txtEmailEmpresa = new System.Windows.Forms.TextBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblhorario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHorario = new System.Windows.Forms.TextBox();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.tabDatosLeyenda = new System.Windows.Forms.TabPage();
            this.lblLeyendaMail = new System.Windows.Forms.Label();
            this.txtLeyendaMail = new System.Windows.Forms.TextBox();
            this.tabDatosMail = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPuertoSMTP = new System.Windows.Forms.Label();
            this.txtPuertoSMTP = new System.Windows.Forms.TextBox();
            this.lblServidorSMTP = new System.Windows.Forms.Label();
            this.txtServidorSMTP = new System.Windows.Forms.TextBox();
            this.lblcontrasena = new System.Windows.Forms.Label();
            this.txtcoMail = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnMapa = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelBarraArriba.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabgDatos.SuspendLayout();
            this.tabDatosEmpresa.SuspendLayout();
            this.tabDatosLeyenda.SuspendLayout();
            this.tabDatosMail.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLeyenda
            // 
            this.txtLeyenda.Location = new System.Drawing.Point(21, 46);
            this.txtLeyenda.Margin = new System.Windows.Forms.Padding(2);
            this.txtLeyenda.Multiline = true;
            this.txtLeyenda.Name = "txtLeyenda";
            this.txtLeyenda.Size = new System.Drawing.Size(686, 181);
            this.txtLeyenda.TabIndex = 5;
            // 
            // lblleyenda
            // 
            this.lblleyenda.AutoSize = true;
            this.lblleyenda.Location = new System.Drawing.Point(18, 24);
            this.lblleyenda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblleyenda.Name = "lblleyenda";
            this.lblleyenda.Size = new System.Drawing.Size(170, 18);
            this.lblleyenda.TabIndex = 12;
            this.lblleyenda.Text = "Leyenda para ordenes:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(130)))), ((int)(((byte)(172)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnguardar);
            this.panel1.Controls.Add(this.btncancelar);
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 496);
            this.panel1.TabIndex = 2;
            // 
            // btnguardar
            // 
            this.btnguardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.Image = global::reparaciones2.Properties.Resources.apply;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnguardar.Location = new System.Drawing.Point(-1, 0);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(138, 78);
            this.btnguardar.TabIndex = 1;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Image = global::reparaciones2.Properties.Resources.cancel;
            this.btncancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncancelar.Location = new System.Drawing.Point(-1, 76);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(138, 71);
            this.btncancelar.TabIndex = 2;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // panelBarraArriba
            // 
            this.panelBarraArriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.panelBarraArriba.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBarraArriba.Controls.Add(this.btnApagar);
            this.panelBarraArriba.Controls.Add(this.label5);
            this.panelBarraArriba.Location = new System.Drawing.Point(0, -2);
            this.panelBarraArriba.Margin = new System.Windows.Forms.Padding(2);
            this.panelBarraArriba.Name = "panelBarraArriba";
            this.panelBarraArriba.Size = new System.Drawing.Size(945, 53);
            this.panelBarraArriba.TabIndex = 3;
            // 
            // btnApagar
            // 
            this.btnApagar.FlatAppearance.BorderSize = 0;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Image = global::reparaciones2.Properties.Resources.exit;
            this.btnApagar.Location = new System.Drawing.Point(872, 2);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(2);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(50, 50);
            this.btnApagar.TabIndex = 1;
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 33);
            this.label5.TabIndex = 3;
            this.label5.Text = "PARAMETROS";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tabgDatos);
            this.panel2.Location = new System.Drawing.Point(134, 51);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(811, 496);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // tabgDatos
            // 
            this.tabgDatos.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabgDatos.Controls.Add(this.tabDatosEmpresa);
            this.tabgDatos.Controls.Add(this.tabDatosLeyenda);
            this.tabgDatos.Controls.Add(this.tabDatosMail);
            this.tabgDatos.Location = new System.Drawing.Point(11, 16);
            this.tabgDatos.Multiline = true;
            this.tabgDatos.Name = "tabgDatos";
            this.tabgDatos.SelectedIndex = 0;
            this.tabgDatos.Size = new System.Drawing.Size(777, 466);
            this.tabgDatos.TabIndex = 0;
            // 
            // tabDatosEmpresa
            // 
            this.tabDatosEmpresa.Controls.Add(this.btnMapa);
            this.tabDatosEmpresa.Controls.Add(this.lblcoordenadas);
            this.tabDatosEmpresa.Controls.Add(this.txtcoordenadas);
            this.tabDatosEmpresa.Controls.Add(this.lblEmailEmpresa);
            this.tabDatosEmpresa.Controls.Add(this.txtEmailEmpresa);
            this.tabDatosEmpresa.Controls.Add(this.lblEmpresa);
            this.tabDatosEmpresa.Controls.Add(this.label9);
            this.tabDatosEmpresa.Controls.Add(this.txtEmpresa);
            this.tabDatosEmpresa.Controls.Add(this.label8);
            this.tabDatosEmpresa.Controls.Add(this.lblhorario);
            this.tabDatosEmpresa.Controls.Add(this.label1);
            this.tabDatosEmpresa.Controls.Add(this.txtHorario);
            this.tabDatosEmpresa.Controls.Add(this.lbltelefono);
            this.tabDatosEmpresa.Controls.Add(this.txtDireccion);
            this.tabDatosEmpresa.Controls.Add(this.label6);
            this.tabDatosEmpresa.Controls.Add(this.txtTelefono);
            this.tabDatosEmpresa.Controls.Add(this.lbldireccion);
            this.tabDatosEmpresa.Location = new System.Drawing.Point(27, 4);
            this.tabDatosEmpresa.Name = "tabDatosEmpresa";
            this.tabDatosEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatosEmpresa.Size = new System.Drawing.Size(746, 458);
            this.tabDatosEmpresa.TabIndex = 0;
            this.tabDatosEmpresa.Text = "Datos Empresa";
            this.tabDatosEmpresa.UseVisualStyleBackColor = true;
            // 
            // lblcoordenadas
            // 
            this.lblcoordenadas.AutoSize = true;
            this.lblcoordenadas.Location = new System.Drawing.Point(19, 233);
            this.lblcoordenadas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcoordenadas.Name = "lblcoordenadas";
            this.lblcoordenadas.Size = new System.Drawing.Size(98, 18);
            this.lblcoordenadas.TabIndex = 33;
            this.lblcoordenadas.Text = "Mapa Coord:";
            // 
            // txtcoordenadas
            // 
            this.txtcoordenadas.Location = new System.Drawing.Point(130, 230);
            this.txtcoordenadas.Margin = new System.Windows.Forms.Padding(2);
            this.txtcoordenadas.Name = "txtcoordenadas";
            this.txtcoordenadas.Size = new System.Drawing.Size(574, 25);
            this.txtcoordenadas.TabIndex = 32;
            // 
            // lblEmailEmpresa
            // 
            this.lblEmailEmpresa.AutoSize = true;
            this.lblEmailEmpresa.Location = new System.Drawing.Point(19, 105);
            this.lblEmailEmpresa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailEmpresa.Name = "lblEmailEmpresa";
            this.lblEmailEmpresa.Size = new System.Drawing.Size(50, 18);
            this.lblEmailEmpresa.TabIndex = 31;
            this.lblEmailEmpresa.Text = "Email:";
            // 
            // txtEmailEmpresa
            // 
            this.txtEmailEmpresa.Location = new System.Drawing.Point(130, 100);
            this.txtEmailEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmailEmpresa.Name = "txtEmailEmpresa";
            this.txtEmailEmpresa.Size = new System.Drawing.Size(574, 25);
            this.txtEmailEmpresa.TabIndex = 30;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(19, 34);
            this.lblEmpresa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(74, 18);
            this.lblEmpresa.TabIndex = 18;
            this.lblEmpresa.Text = "Empresa:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(710, 154);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 18);
            this.label9.TabIndex = 29;
            this.label9.Text = "*";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(130, 26);
            this.txtEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(574, 25);
            this.txtEmpresa.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(712, 111);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 18);
            this.label8.TabIndex = 28;
            this.label8.Text = "*";
            // 
            // lblhorario
            // 
            this.lblhorario.AutoSize = true;
            this.lblhorario.Location = new System.Drawing.Point(19, 185);
            this.lblhorario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblhorario.Name = "lblhorario";
            this.lblhorario.Size = new System.Drawing.Size(65, 18);
            this.lblhorario.TabIndex = 26;
            this.lblhorario.Text = "Horario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(712, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "*";
            // 
            // txtHorario
            // 
            this.txtHorario.Location = new System.Drawing.Point(130, 182);
            this.txtHorario.Margin = new System.Windows.Forms.Padding(2);
            this.txtHorario.Name = "txtHorario";
            this.txtHorario.Size = new System.Drawing.Size(574, 25);
            this.txtHorario.TabIndex = 24;
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Location = new System.Drawing.Point(19, 71);
            this.lbltelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(75, 18);
            this.lbltelefono.TabIndex = 22;
            this.lbltelefono.Text = "Teléfono:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(130, 139);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(574, 25);
            this.txtDireccion.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(712, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 18);
            this.label6.TabIndex = 27;
            this.label6.Text = "*";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(130, 66);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(574, 25);
            this.txtTelefono.TabIndex = 21;
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Location = new System.Drawing.Point(19, 144);
            this.lbldireccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(80, 18);
            this.lbldireccion.TabIndex = 25;
            this.lbldireccion.Text = "Dirección:";
            // 
            // tabDatosLeyenda
            // 
            this.tabDatosLeyenda.Controls.Add(this.lblLeyendaMail);
            this.tabDatosLeyenda.Controls.Add(this.txtLeyendaMail);
            this.tabDatosLeyenda.Controls.Add(this.lblleyenda);
            this.tabDatosLeyenda.Controls.Add(this.txtLeyenda);
            this.tabDatosLeyenda.Location = new System.Drawing.Point(27, 4);
            this.tabDatosLeyenda.Name = "tabDatosLeyenda";
            this.tabDatosLeyenda.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatosLeyenda.Size = new System.Drawing.Size(746, 458);
            this.tabDatosLeyenda.TabIndex = 1;
            this.tabDatosLeyenda.Text = "Leyendas";
            this.tabDatosLeyenda.UseVisualStyleBackColor = true;
            // 
            // lblLeyendaMail
            // 
            this.lblLeyendaMail.AutoSize = true;
            this.lblLeyendaMail.Location = new System.Drawing.Point(18, 252);
            this.lblLeyendaMail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLeyendaMail.Name = "lblLeyendaMail";
            this.lblLeyendaMail.Size = new System.Drawing.Size(239, 18);
            this.lblLeyendaMail.TabIndex = 14;
            this.lblLeyendaMail.Text = "Leyenda para correo automático:";
            // 
            // txtLeyendaMail
            // 
            this.txtLeyendaMail.Location = new System.Drawing.Point(21, 274);
            this.txtLeyendaMail.Margin = new System.Windows.Forms.Padding(2);
            this.txtLeyendaMail.Multiline = true;
            this.txtLeyendaMail.Name = "txtLeyendaMail";
            this.txtLeyendaMail.Size = new System.Drawing.Size(686, 152);
            this.txtLeyendaMail.TabIndex = 13;
            // 
            // tabDatosMail
            // 
            this.tabDatosMail.Controls.Add(this.label12);
            this.tabDatosMail.Controls.Add(this.panel4);
            this.tabDatosMail.Controls.Add(this.label11);
            this.tabDatosMail.Controls.Add(this.panel3);
            this.tabDatosMail.Controls.Add(this.lblPuertoSMTP);
            this.tabDatosMail.Controls.Add(this.txtPuertoSMTP);
            this.tabDatosMail.Controls.Add(this.lblServidorSMTP);
            this.tabDatosMail.Controls.Add(this.txtServidorSMTP);
            this.tabDatosMail.Controls.Add(this.lblcontrasena);
            this.tabDatosMail.Controls.Add(this.txtcoMail);
            this.tabDatosMail.Controls.Add(this.lblemail);
            this.tabDatosMail.Controls.Add(this.txtEmail);
            this.tabDatosMail.Location = new System.Drawing.Point(27, 4);
            this.tabDatosMail.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.tabDatosMail.Name = "tabDatosMail";
            this.tabDatosMail.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatosMail.Size = new System.Drawing.Size(746, 458);
            this.tabDatosMail.TabIndex = 2;
            this.tabDatosMail.Text = "Datos Envio de Mail";
            this.tabDatosMail.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 34);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(263, 18);
            this.label12.TabIndex = 32;
            this.label12.Text = "Datos de la cuenta para enviar mails";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(20, 52);
            this.panel4.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(712, 2);
            this.panel4.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 187);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(196, 18);
            this.label11.TabIndex = 30;
            this.label11.Text = "Configuración de Servidor";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(20, 205);
            this.panel3.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(712, 2);
            this.panel3.TabIndex = 29;
            // 
            // lblPuertoSMTP
            // 
            this.lblPuertoSMTP.AutoSize = true;
            this.lblPuertoSMTP.Location = new System.Drawing.Point(17, 277);
            this.lblPuertoSMTP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPuertoSMTP.Name = "lblPuertoSMTP";
            this.lblPuertoSMTP.Size = new System.Drawing.Size(129, 18);
            this.lblPuertoSMTP.TabIndex = 27;
            this.lblPuertoSMTP.Text = "Puerto de SMTP:";
            // 
            // txtPuertoSMTP
            // 
            this.txtPuertoSMTP.Location = new System.Drawing.Point(161, 270);
            this.txtPuertoSMTP.Margin = new System.Windows.Forms.Padding(2);
            this.txtPuertoSMTP.Name = "txtPuertoSMTP";
            this.txtPuertoSMTP.Size = new System.Drawing.Size(97, 25);
            this.txtPuertoSMTP.TabIndex = 28;
            // 
            // lblServidorSMTP
            // 
            this.lblServidorSMTP.AutoSize = true;
            this.lblServidorSMTP.Location = new System.Drawing.Point(17, 231);
            this.lblServidorSMTP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblServidorSMTP.Name = "lblServidorSMTP";
            this.lblServidorSMTP.Size = new System.Drawing.Size(121, 18);
            this.lblServidorSMTP.TabIndex = 25;
            this.lblServidorSMTP.Text = "Servidor SMTP:";
            // 
            // txtServidorSMTP
            // 
            this.txtServidorSMTP.Location = new System.Drawing.Point(161, 228);
            this.txtServidorSMTP.Margin = new System.Windows.Forms.Padding(2);
            this.txtServidorSMTP.Name = "txtServidorSMTP";
            this.txtServidorSMTP.Size = new System.Drawing.Size(542, 25);
            this.txtServidorSMTP.TabIndex = 26;
            // 
            // lblcontrasena
            // 
            this.lblcontrasena.AutoSize = true;
            this.lblcontrasena.Location = new System.Drawing.Point(17, 123);
            this.lblcontrasena.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcontrasena.Name = "lblcontrasena";
            this.lblcontrasena.Size = new System.Drawing.Size(94, 18);
            this.lblcontrasena.TabIndex = 23;
            this.lblcontrasena.Text = "Contraseña:";
            // 
            // txtcoMail
            // 
            this.txtcoMail.Location = new System.Drawing.Point(161, 116);
            this.txtcoMail.Margin = new System.Windows.Forms.Padding(2);
            this.txtcoMail.Name = "txtcoMail";
            this.txtcoMail.PasswordChar = '*';
            this.txtcoMail.Size = new System.Drawing.Size(542, 25);
            this.txtcoMail.TabIndex = 24;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(17, 84);
            this.lblemail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(50, 18);
            this.lblemail.TabIndex = 21;
            this.lblemail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(161, 77);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(542, 25);
            this.txtEmail.TabIndex = 22;
            // 
            // btnMapa
            // 
            this.btnMapa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnMapa.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMapa.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMapa.ForeColor = System.Drawing.Color.White;
            this.btnMapa.Image = global::reparaciones2.Properties.Resources.map;
            this.btnMapa.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMapa.Location = new System.Drawing.Point(130, 261);
            this.btnMapa.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnMapa.Name = "btnMapa";
            this.btnMapa.Size = new System.Drawing.Size(121, 72);
            this.btnMapa.TabIndex = 34;
            this.btnMapa.Text = "MAPA";
            this.btnMapa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMapa.UseVisualStyleBackColor = false;
            this.btnMapa.Click += new System.EventHandler(this.btnMapa_Click);
            // 
            // FrmParametros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(946, 546);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelBarraArriba);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmParametros";
            this.Text = "Parametros";
            this.Load += new System.EventHandler(this.FrmParametros_Load);
            this.panel1.ResumeLayout(false);
            this.panelBarraArriba.ResumeLayout(false);
            this.panelBarraArriba.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabgDatos.ResumeLayout(false);
            this.tabDatosEmpresa.ResumeLayout(false);
            this.tabDatosEmpresa.PerformLayout();
            this.tabDatosLeyenda.ResumeLayout(false);
            this.tabDatosLeyenda.PerformLayout();
            this.tabDatosMail.ResumeLayout(false);
            this.tabDatosMail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtLeyenda;
        private System.Windows.Forms.Label lblleyenda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Panel panelBarraArriba;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabgDatos;
        private System.Windows.Forms.TabPage tabDatosEmpresa;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblhorario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHorario;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.TabPage tabDatosLeyenda;
        private System.Windows.Forms.TabPage tabDatosMail;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblLeyendaMail;
        private System.Windows.Forms.TextBox txtLeyendaMail;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblPuertoSMTP;
        private System.Windows.Forms.TextBox txtPuertoSMTP;
        private System.Windows.Forms.Label lblServidorSMTP;
        private System.Windows.Forms.TextBox txtServidorSMTP;
        private System.Windows.Forms.Label lblcontrasena;
        private System.Windows.Forms.TextBox txtcoMail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblEmailEmpresa;
        private System.Windows.Forms.TextBox txtEmailEmpresa;
        private System.Windows.Forms.Label lblcoordenadas;
        private System.Windows.Forms.TextBox txtcoordenadas;
        private System.Windows.Forms.Button btnMapa;
    }
}