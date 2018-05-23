namespace FormulariosAlmacenes.VistasAlmacen
{
    partial class PantallaIngresosSalidasProducto
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
            this.label6 = new System.Windows.Forms.Label();
            this.radioBtnIngreso = new System.Windows.Forms.RadioButton();
            this.radioBtnSalida = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridPedido = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxEnvios = new System.Windows.Forms.ComboBox();
            this.labelEnvio = new System.Windows.Forms.Label();
            this.labelAlmacen = new System.Windows.Forms.Label();
            this.comboBoxAlmacenes = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(7, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Tipo de Movimiento: ";
            // 
            // radioBtnIngreso
            // 
            this.radioBtnIngreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioBtnIngreso.AutoSize = true;
            this.radioBtnIngreso.Checked = true;
            this.radioBtnIngreso.Location = new System.Drawing.Point(167, 15);
            this.radioBtnIngreso.Name = "radioBtnIngreso";
            this.radioBtnIngreso.Size = new System.Drawing.Size(60, 17);
            this.radioBtnIngreso.TabIndex = 25;
            this.radioBtnIngreso.TabStop = true;
            this.radioBtnIngreso.Text = "Ingreso";
            this.radioBtnIngreso.UseVisualStyleBackColor = true;
            this.radioBtnIngreso.CheckedChanged += new System.EventHandler(this.radioBtnIngreso_CheckedChanged);
            // 
            // radioBtnSalida
            // 
            this.radioBtnSalida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioBtnSalida.AutoSize = true;
            this.radioBtnSalida.Location = new System.Drawing.Point(246, 15);
            this.radioBtnSalida.Name = "radioBtnSalida";
            this.radioBtnSalida.Size = new System.Drawing.Size(54, 17);
            this.radioBtnSalida.TabIndex = 26;
            this.radioBtnSalida.Text = "Salida";
            this.radioBtnSalida.UseVisualStyleBackColor = true;
            this.radioBtnSalida.CheckedChanged += new System.EventHandler(this.radioBtnSalida_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioBtnIngreso);
            this.groupBox2.Controls.Add(this.radioBtnSalida);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(16, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 38);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxAlmacenes);
            this.groupBox1.Controls.Add(this.labelAlmacen);
            this.groupBox1.Controls.Add(this.labelEnvio);
            this.groupBox1.Controls.Add(this.comboBoxEnvios);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dataGridPedido);
            this.groupBox1.Location = new System.Drawing.Point(16, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 386);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(66, 43);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(244, 25);
            this.toolStrip1.TabIndex = 32;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(27, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Productos registrados: ";
            // 
            // dataGridPedido
            // 
            this.dataGridPedido.AllowUserToAddRows = false;
            this.dataGridPedido.AllowUserToDeleteRows = false;
            this.dataGridPedido.AllowUserToResizeColumns = false;
            this.dataGridPedido.AllowUserToResizeRows = false;
            this.dataGridPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridPedido.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CodigoProducto,
            this.Nombre,
            this.Stock,
            this.Cantidad,
            this.Observaciones});
            this.dataGridPedido.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridPedido.Location = new System.Drawing.Point(66, 72);
            this.dataGridPedido.MultiSelect = false;
            this.dataGridPedido.Name = "dataGridPedido";
            this.dataGridPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPedido.Size = new System.Drawing.Size(657, 300);
            this.dataGridPedido.TabIndex = 30;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 41;
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.DataPropertyName = "CodigoProducto";
            this.CodigoProducto.HeaderText = "Codigo";
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.ReadOnly = true;
            this.CodigoProducto.Width = 65;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 69;
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "CantidadAlmacenada";
            this.Stock.HeaderText = "Stock Actual";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 93;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MaxInputLength = 5;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 74;
            // 
            // Observaciones
            // 
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.Width = 103;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::FormulariosAlmacenes.Properties.Resources.btn_anadir_tiny;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(118, 22);
            this.toolStripButton1.Text = "Insertar Producto";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::FormulariosAlmacenes.Properties.Resources.btn_cross_tiny_colored;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(123, 22);
            this.toolStripButton2.Text = "Eliminar Selección";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button2.Image = global::FormulariosAlmacenes.Properties.Resources.btn_cross_tiny_colored;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(671, 477);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 40);
            this.button2.TabIndex = 30;
            this.button2.Text = "Salir";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button1.Image = global::FormulariosAlmacenes.Properties.Resources.btn_Chk_tiny_colored;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(514, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 40);
            this.button1.TabIndex = 23;
            this.button1.Text = "Confirmar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // comboBoxEnvios
            // 
            this.comboBoxEnvios.FormattingEnabled = true;
            this.comboBoxEnvios.Location = new System.Drawing.Point(516, 22);
            this.comboBoxEnvios.Name = "comboBoxEnvios";
            this.comboBoxEnvios.Size = new System.Drawing.Size(207, 21);
            this.comboBoxEnvios.TabIndex = 33;
            this.comboBoxEnvios.Text = "Envios";
            // 
            // labelEnvio
            // 
            this.labelEnvio.AutoSize = true;
            this.labelEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEnvio.Location = new System.Drawing.Point(362, 22);
            this.labelEnvio.Name = "labelEnvio";
            this.labelEnvio.Size = new System.Drawing.Size(148, 20);
            this.labelEnvio.TabIndex = 34;
            this.labelEnvio.Text = "Envíos Pendientes: ";
            // 
            // labelAlmacen
            // 
            this.labelAlmacen.AutoSize = true;
            this.labelAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelAlmacen.Location = new System.Drawing.Point(372, 22);
            this.labelAlmacen.Name = "labelAlmacen";
            this.labelAlmacen.Size = new System.Drawing.Size(138, 20);
            this.labelAlmacen.TabIndex = 35;
            this.labelAlmacen.Text = "Almacén Destino: ";
            this.labelAlmacen.Visible = false;
            // 
            // comboBoxAlmacenes
            // 
            this.comboBoxAlmacenes.FormattingEnabled = true;
            this.comboBoxAlmacenes.Location = new System.Drawing.Point(516, 22);
            this.comboBoxAlmacenes.Name = "comboBoxAlmacenes";
            this.comboBoxAlmacenes.Size = new System.Drawing.Size(207, 21);
            this.comboBoxAlmacenes.TabIndex = 36;
            this.comboBoxAlmacenes.Text = "Almacenes";
            this.comboBoxAlmacenes.Visible = false;
            // 
            // PantallaIngresosSalidasProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Name = "PantallaIngresosSalidasProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PantallaIngresosSalidasProducto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PantallaIngresosSalidasProducto_FormClosed);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioBtnIngreso;
        private System.Windows.Forms.RadioButton radioBtnSalida;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
        private System.Windows.Forms.ComboBox comboBoxAlmacenes;
        private System.Windows.Forms.Label labelAlmacen;
        private System.Windows.Forms.Label labelEnvio;
        private System.Windows.Forms.ComboBox comboBoxEnvios;
    }
}