namespace reparaciones2
{
    partial class FrmTemporal
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
            this.dgwItems = new System.Windows.Forms.DataGridView();
            this.btnPresupuesto = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwItems
            // 
            this.dgwItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwItems.Location = new System.Drawing.Point(219, 13);
            this.dgwItems.Name = "dgwItems";
            this.dgwItems.RowTemplate.Height = 24;
            this.dgwItems.Size = new System.Drawing.Size(708, 210);
            this.dgwItems.TabIndex = 22;
            // 
            // btnPresupuesto
            // 
            this.btnPresupuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnPresupuesto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPresupuesto.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.btnPresupuesto.ForeColor = System.Drawing.Color.White;
            this.btnPresupuesto.Image = global::reparaciones2.Properties.Resources.printer;
            this.btnPresupuesto.Location = new System.Drawing.Point(41, 148);
            this.btnPresupuesto.Margin = new System.Windows.Forms.Padding(2);
            this.btnPresupuesto.Name = "btnPresupuesto";
            this.btnPresupuesto.Size = new System.Drawing.Size(142, 58);
            this.btnPresupuesto.TabIndex = 25;
            this.btnPresupuesto.Text = "PRESUPUESTO";
            this.btnPresupuesto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPresupuesto.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.btnBorrar.ForeColor = System.Drawing.Color.White;
            this.btnBorrar.Image = global::reparaciones2.Properties.Resources.trashcan_full;
            this.btnBorrar.Location = new System.Drawing.Point(41, 84);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(142, 58);
            this.btnBorrar.TabIndex = 24;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(102)))), ((int)(((byte)(153)))));
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Arial Black", 8F, System.Drawing.FontStyle.Bold);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = global::reparaciones2.Properties.Resources.edit_add;
            this.btnAgregar.Location = new System.Drawing.Point(41, 22);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(142, 58);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // FrmTemporal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 453);
            this.Controls.Add(this.btnPresupuesto);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgwItems);
            this.Name = "FrmTemporal";
            this.Text = "FrmTemporal";
            ((System.ComponentModel.ISupportInitialize)(this.dgwItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPresupuesto;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgwItems;
    }
}