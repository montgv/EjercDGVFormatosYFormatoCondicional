namespace EjercDGVFormatosYFormatoCondicional
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ColumnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnApellido1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnApellido2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechaAlta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTipoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSumaTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodigo,
            this.ColumnNombre,
            this.ColumnApellido1,
            this.ColumnApellido2,
            this.ColumnLocalidad,
            this.ColumnFechaAlta,
            this.ColumnTipoCliente,
            this.ColumnSumaTotal});
            this.dgv.Location = new System.Drawing.Point(1, 21);
            this.dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(1286, 229);
            this.dgv.TabIndex = 0;
            this.dgv.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellMouseEnter);
            this.dgv.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellMouseLeave);
            // 
            // ColumnCodigo
            // 
            this.ColumnCodigo.HeaderText = "Código";
            this.ColumnCodigo.MinimumWidth = 8;
            this.ColumnCodigo.Name = "ColumnCodigo";
            this.ColumnCodigo.Width = 150;
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.HeaderText = "Nombre";
            this.ColumnNombre.MinimumWidth = 8;
            this.ColumnNombre.Name = "ColumnNombre";
            this.ColumnNombre.Width = 150;
            // 
            // ColumnApellido1
            // 
            this.ColumnApellido1.HeaderText = "Apellido1";
            this.ColumnApellido1.MinimumWidth = 8;
            this.ColumnApellido1.Name = "ColumnApellido1";
            this.ColumnApellido1.Width = 150;
            // 
            // ColumnApellido2
            // 
            this.ColumnApellido2.HeaderText = "Apellido2";
            this.ColumnApellido2.MinimumWidth = 8;
            this.ColumnApellido2.Name = "ColumnApellido2";
            this.ColumnApellido2.Width = 150;
            // 
            // ColumnLocalidad
            // 
            this.ColumnLocalidad.HeaderText = "Localidad";
            this.ColumnLocalidad.MinimumWidth = 8;
            this.ColumnLocalidad.Name = "ColumnLocalidad";
            this.ColumnLocalidad.Width = 150;
            // 
            // ColumnFechaAlta
            // 
            this.ColumnFechaAlta.HeaderText = "Fecha Alta";
            this.ColumnFechaAlta.MinimumWidth = 8;
            this.ColumnFechaAlta.Name = "ColumnFechaAlta";
            this.ColumnFechaAlta.Width = 150;
            // 
            // ColumnTipoCliente
            // 
            this.ColumnTipoCliente.HeaderText = "Tipo Cliente";
            this.ColumnTipoCliente.MinimumWidth = 8;
            this.ColumnTipoCliente.Name = "ColumnTipoCliente";
            this.ColumnTipoCliente.Width = 150;
            // 
            // ColumnSumaTotal
            // 
            this.ColumnSumaTotal.HeaderText = "Suma Total";
            this.ColumnSumaTotal.MinimumWidth = 8;
            this.ColumnSumaTotal.Name = "ColumnSumaTotal";
            this.ColumnSumaTotal.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 292);
            this.Controls.Add(this.dgv);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnApellido1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnApellido2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLocalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFechaAlta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTipoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSumaTotal;
    }
}

