namespace reparaciones2
{
    partial class FrmReparacionPorAnio
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAnioDesde = new System.Windows.Forms.ComboBox();
            this.cmbAnioHasta = new System.Windows.Forms.ComboBox();
            this.lblAnioHasta = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.chartResultado = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgwResultado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chartResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Desde:";
            // 
            // cmbAnioDesde
            // 
            this.cmbAnioDesde.FormattingEnabled = true;
            this.cmbAnioDesde.Location = new System.Drawing.Point(103, 30);
            this.cmbAnioDesde.Name = "cmbAnioDesde";
            this.cmbAnioDesde.Size = new System.Drawing.Size(96, 24);
            this.cmbAnioDesde.TabIndex = 2;
            // 
            // cmbAnioHasta
            // 
            this.cmbAnioHasta.FormattingEnabled = true;
            this.cmbAnioHasta.Location = new System.Drawing.Point(315, 30);
            this.cmbAnioHasta.Name = "cmbAnioHasta";
            this.cmbAnioHasta.Size = new System.Drawing.Size(96, 24);
            this.cmbAnioHasta.TabIndex = 4;
            // 
            // lblAnioHasta
            // 
            this.lblAnioHasta.AutoSize = true;
            this.lblAnioHasta.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnioHasta.Location = new System.Drawing.Point(243, 30);
            this.lblAnioHasta.Name = "lblAnioHasta";
            this.lblAnioHasta.Size = new System.Drawing.Size(64, 22);
            this.lblAnioHasta.TabIndex = 3;
            this.lblAnioHasta.Text = "Hasta:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::reparaciones2.Properties.Resources.xmag;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBuscar.Location = new System.Drawing.Point(432, 23);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(147, 39);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // chartResultado
            // 
            chartArea1.Name = "ChartArea1";
            this.chartResultado.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartResultado.Legends.Add(legend1);
            this.chartResultado.Location = new System.Drawing.Point(7, 80);
            this.chartResultado.Name = "chartResultado";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartResultado.Series.Add(series1);
            this.chartResultado.Size = new System.Drawing.Size(864, 238);
            this.chartResultado.TabIndex = 0;
            this.chartResultado.Text = "chartResultado";
            // 
            // dgwResultado
            // 
            this.dgwResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwResultado.Location = new System.Drawing.Point(7, 337);
            this.dgwResultado.Name = "dgwResultado";
            this.dgwResultado.RowTemplate.Height = 24;
            this.dgwResultado.Size = new System.Drawing.Size(864, 272);
            this.dgwResultado.TabIndex = 13;
            // 
            // FrmReparacionPorAnio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 716);
            this.Controls.Add(this.dgwResultado);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbAnioHasta);
            this.Controls.Add(this.lblAnioHasta);
            this.Controls.Add(this.cmbAnioDesde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chartResultado);
            this.Name = "FrmReparacionPorAnio";
            this.Text = "FrmReparacionPorAnio";
            this.Load += new System.EventHandler(this.FrmReparacionPorAnio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAnioDesde;
        private System.Windows.Forms.ComboBox cmbAnioHasta;
        private System.Windows.Forms.Label lblAnioHasta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResultado;
        private System.Windows.Forms.DataGridView dgwResultado;
    }
}