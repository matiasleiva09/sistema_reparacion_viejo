namespace reparaciones2.mapas
{
    partial class FrmMapas
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
            this.btnApagar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panelBarraArriba = new System.Windows.Forms.Panel();
            this.gmapDireccion = new GMap.NET.WindowsForms.GMapControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.panelBarraArriba.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnApagar
            // 
            this.btnApagar.FlatAppearance.BorderSize = 0;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Image = global::reparaciones2.Properties.Resources.exit;
            this.btnApagar.Location = new System.Drawing.Point(1023, 4);
            this.btnApagar.Margin = new System.Windows.Forms.Padding(2);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(50, 50);
            this.btnApagar.TabIndex = 17;
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
            this.label3.Size = new System.Drawing.Size(298, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "UBICACION EN MAPA";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panelBarraArriba
            // 
            this.panelBarraArriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.panelBarraArriba.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBarraArriba.Controls.Add(this.btnApagar);
            this.panelBarraArriba.Controls.Add(this.label3);
            this.panelBarraArriba.Location = new System.Drawing.Point(-3, 0);
            this.panelBarraArriba.Margin = new System.Windows.Forms.Padding(2);
            this.panelBarraArriba.Name = "panelBarraArriba";
            this.panelBarraArriba.Size = new System.Drawing.Size(1085, 58);
            this.panelBarraArriba.TabIndex = 16;
            this.panelBarraArriba.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBarraArriba_Paint);
            // 
            // gmapDireccion
            // 
            this.gmapDireccion.Bearing = 0F;
            this.gmapDireccion.CanDragMap = true;
            this.gmapDireccion.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmapDireccion.GrayScaleMode = false;
            this.gmapDireccion.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
           // this.gmapDireccion.LevelsKeepInMemmory = 5;
            this.gmapDireccion.Location = new System.Drawing.Point(109, 63);
            this.gmapDireccion.MarkersEnabled = true;
            this.gmapDireccion.MaxZoom = 2;
            this.gmapDireccion.MinZoom = 2;
            this.gmapDireccion.MouseWheelZoomEnabled = true;
            this.gmapDireccion.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmapDireccion.Name = "gmapDireccion";
            this.gmapDireccion.NegativeMode = false;
            this.gmapDireccion.PolygonsEnabled = true;
            this.gmapDireccion.RetryLoadTile = 0;
            this.gmapDireccion.RoutesEnabled = true;
            this.gmapDireccion.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmapDireccion.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmapDireccion.ShowTileGridLines = false;
            this.gmapDireccion.Size = new System.Drawing.Size(973, 512);
            this.gmapDireccion.TabIndex = 17;
            this.gmapDireccion.Zoom = 0D;
            this.gmapDireccion.Load += new System.EventHandler(this.gmapDireccion_Load);
            this.gmapDireccion.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gmapDireccion_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(130)))), ((int)(((byte)(172)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnsalir);
            this.panel1.Location = new System.Drawing.Point(-3, 62);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 508);
            this.panel1.TabIndex = 53;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Image = global::reparaciones2.Properties.Resources.apply;
            this.btnGuardar.Location = new System.Drawing.Point(-2, 4);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(124, 73);
            this.btnGuardar.TabIndex = 48;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            this.btnsalir.Location = new System.Drawing.Point(-2, 71);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(124, 67);
            this.btnsalir.TabIndex = 49;
            this.btnsalir.Text = "SALIR";
            this.btnsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // FrmMapas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1082, 574);
            this.Controls.Add(this.panelBarraArriba);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gmapDireccion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMapas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmMapas";
            this.Load += new System.EventHandler(this.FrmMapas_Load);
            this.panelBarraArriba.ResumeLayout(false);
            this.panelBarraArriba.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelBarraArriba;
        private GMap.NET.WindowsForms.GMapControl gmapDireccion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnsalir;
    }
}