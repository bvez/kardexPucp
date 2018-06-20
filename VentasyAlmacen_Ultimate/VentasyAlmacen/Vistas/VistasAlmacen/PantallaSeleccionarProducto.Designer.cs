namespace FormulariosAlmacenes.VistasAlmacen
{
    partial class PantallaSeleccionarProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridProductos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSelectAlmacenSgte = new System.Windows.Forms.Button();
            this.btnSelectAlmacenAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione un producto:";
            // 
            // dataGridProductos
            // 
            this.dataGridProductos.AllowUserToAddRows = false;
            this.dataGridProductos.AllowUserToDeleteRows = false;
            this.dataGridProductos.AllowUserToOrderColumns = true;
            this.dataGridProductos.AllowUserToResizeColumns = false;
            this.dataGridProductos.AllowUserToResizeRows = false;
            this.dataGridProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.DescripcionProducto,
            this.Stock});
            this.dataGridProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridProductos.Location = new System.Drawing.Point(12, 69);
            this.dataGridProductos.MultiSelect = false;
            this.dataGridProductos.Name = "dataGridProductos";
            this.dataGridProductos.ReadOnly = true;
            this.dataGridProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProductos.Size = new System.Drawing.Size(559, 345);
            this.dataGridProductos.TabIndex = 31;
            this.dataGridProductos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridProductos_MouseDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 41;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 69;
            // 
            // DescripcionProducto
            // 
            this.DescripcionProducto.DataPropertyName = "Descripcion";
            this.DescripcionProducto.HeaderText = "Descripcion";
            this.DescripcionProducto.Name = "DescripcionProducto";
            this.DescripcionProducto.ReadOnly = true;
            this.DescripcionProducto.Width = 88;
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "CantidadAlmacenada";
            this.Stock.HeaderText = "Stock Actual";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 93;
            // 
            // btnSelectAlmacenSgte
            // 
            this.btnSelectAlmacenSgte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectAlmacenSgte.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnSelectAlmacenSgte.Location = new System.Drawing.Point(330, 438);
            this.btnSelectAlmacenSgte.Name = "btnSelectAlmacenSgte";
            this.btnSelectAlmacenSgte.Size = new System.Drawing.Size(138, 39);
            this.btnSelectAlmacenSgte.TabIndex = 32;
            this.btnSelectAlmacenSgte.Text = "Seleccionar";
            this.btnSelectAlmacenSgte.UseVisualStyleBackColor = true;
            this.btnSelectAlmacenSgte.Click += new System.EventHandler(this.btnSelectAlmacenSgte_Click);
            // 
            // btnSelectAlmacenAtras
            // 
            this.btnSelectAlmacenAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnSelectAlmacenAtras.Location = new System.Drawing.Point(474, 438);
            this.btnSelectAlmacenAtras.Name = "btnSelectAlmacenAtras";
            this.btnSelectAlmacenAtras.Size = new System.Drawing.Size(97, 39);
            this.btnSelectAlmacenAtras.TabIndex = 33;
            this.btnSelectAlmacenAtras.Text = "Atrás";
            this.btnSelectAlmacenAtras.UseVisualStyleBackColor = true;
            this.btnSelectAlmacenAtras.Click += new System.EventHandler(this.btnSelectAlmacenAtras_Click);
            // 
            // PantallaSeleccionarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 489);
            this.Controls.Add(this.btnSelectAlmacenAtras);
            this.Controls.Add(this.btnSelectAlmacenSgte);
            this.Controls.Add(this.dataGridProductos);
            this.Controls.Add(this.label1);
            this.Name = "PantallaSeleccionarProducto";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridProductos;
        private System.Windows.Forms.Button btnSelectAlmacenSgte;
        private System.Windows.Forms.Button btnSelectAlmacenAtras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
    }
}