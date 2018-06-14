namespace Ventas
{
    partial class Form1RegVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.dg_Productos = new System.Windows.Forms.DataGridView();
            this.NProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_dcto = new System.Windows.Forms.Label();
            this.label_cpto_dcto = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_precio_final = new System.Windows.Forms.Label();
            this.label_precio = new System.Windows.Forms.Label();
            this.label_cliente = new System.Windows.Forms.Label();
            this.label_Prod = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_buscaCl = new System.Windows.Forms.Button();
            this.btn_agProd = new System.Windows.Forms.Button();
            this.btn_QuitarProd = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_regCliente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(250, 328);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(82, 24);
            this.btn_Cancelar.TabIndex = 0;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Location = new System.Drawing.Point(9, 328);
            this.btn_Registrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(82, 24);
            this.btn_Registrar.TabIndex = 1;
            this.btn_Registrar.Text = "Registrar";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // dg_Productos
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_Productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dg_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NProd,
            this.Precio,
            this.Cant});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_Productos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg_Productos.Location = new System.Drawing.Point(9, 108);
            this.dg_Productos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dg_Productos.Name = "dg_Productos";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_Productos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dg_Productos.RowTemplate.Height = 24;
            this.dg_Productos.Size = new System.Drawing.Size(323, 122);
            this.dg_Productos.TabIndex = 2;
            // 
            // NProd
            // 
            this.NProd.DataPropertyName = "Producto";
            this.NProd.HeaderText = "Nombre del Producto";
            this.NProd.Name = "NProd";
            this.NProd.ReadOnly = true;
            this.NProd.Width = 200;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Producto.precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 68;
            // 
            // Cant
            // 
            this.Cant.DataPropertyName = "Cantidad";
            this.Cant.HeaderText = "Cantidad";
            this.Cant.Name = "Cant";
            this.Cant.ReadOnly = true;
            this.Cant.Width = 80;
            // 
            // label_dcto
            // 
            this.label_dcto.AutoSize = true;
            this.label_dcto.Location = new System.Drawing.Point(10, 255);
            this.label_dcto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_dcto.Name = "label_dcto";
            this.label_dcto.Size = new System.Drawing.Size(123, 13);
            this.label_dcto.TabIndex = 3;
            this.label_dcto.Text = "Descuento (del 0 al 100)";
            // 
            // label_cpto_dcto
            // 
            this.label_cpto_dcto.AutoSize = true;
            this.label_cpto_dcto.Location = new System.Drawing.Point(10, 278);
            this.label_cpto_dcto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_cpto_dcto.Name = "label_cpto_dcto";
            this.label_cpto_dcto.Size = new System.Drawing.Size(108, 13);
            this.label_cpto_dcto.TabIndex = 4;
            this.label_cpto_dcto.Text = "Concepto Descuento";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 275);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label_precio_final
            // 
            this.label_precio_final.AutoSize = true;
            this.label_precio_final.Location = new System.Drawing.Point(10, 301);
            this.label_precio_final.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_precio_final.Name = "label_precio_final";
            this.label_precio_final.Size = new System.Drawing.Size(89, 13);
            this.label_precio_final.TabIndex = 7;
            this.label_precio_final.Text = "Precio Final: 0.00";
            // 
            // label_precio
            // 
            this.label_precio.AutoSize = true;
            this.label_precio.Location = new System.Drawing.Point(10, 232);
            this.label_precio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_precio.Name = "label_precio";
            this.label_precio.Size = new System.Drawing.Size(91, 13);
            this.label_precio.TabIndex = 8;
            this.label_precio.Text = "Precio Total: 0.00";
            // 
            // label_cliente
            // 
            this.label_cliente.AutoSize = true;
            this.label_cliente.Location = new System.Drawing.Point(9, 13);
            this.label_cliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_cliente.Name = "label_cliente";
            this.label_cliente.Size = new System.Drawing.Size(39, 13);
            this.label_cliente.TabIndex = 9;
            this.label_cliente.Text = "Cliente";
            // 
            // label_Prod
            // 
            this.label_Prod.AutoSize = true;
            this.label_Prod.Location = new System.Drawing.Point(9, 48);
            this.label_Prod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Prod.Name = "label_Prod";
            this.label_Prod.Size = new System.Drawing.Size(55, 13);
            this.label_Prod.TabIndex = 10;
            this.label_Prod.Text = "Productos";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(56, 11);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 20);
            this.textBox2.TabIndex = 11;
            // 
            // btn_buscaCl
            // 
            this.btn_buscaCl.Location = new System.Drawing.Point(142, 7);
            this.btn_buscaCl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_buscaCl.Name = "btn_buscaCl";
            this.btn_buscaCl.Size = new System.Drawing.Size(56, 24);
            this.btn_buscaCl.TabIndex = 12;
            this.btn_buscaCl.Text = "Buscar...";
            this.btn_buscaCl.UseVisualStyleBackColor = true;
            this.btn_buscaCl.Click += new System.EventHandler(this.btn_buscaCl_Click);
            // 
            // btn_agProd
            // 
            this.btn_agProd.Location = new System.Drawing.Point(9, 64);
            this.btn_agProd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_agProd.Name = "btn_agProd";
            this.btn_agProd.Size = new System.Drawing.Size(82, 39);
            this.btn_agProd.TabIndex = 13;
            this.btn_agProd.Text = "Agregar Producto";
            this.btn_agProd.UseVisualStyleBackColor = true;
            this.btn_agProd.Click += new System.EventHandler(this.btn_agProd_Click);
            // 
            // btn_QuitarProd
            // 
            this.btn_QuitarProd.Location = new System.Drawing.Point(252, 64);
            this.btn_QuitarProd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_QuitarProd.Name = "btn_QuitarProd";
            this.btn_QuitarProd.Size = new System.Drawing.Size(80, 39);
            this.btn_QuitarProd.TabIndex = 14;
            this.btn_QuitarProd.Text = "Eliminar Producto";
            this.btn_QuitarProd.UseVisualStyleBackColor = true;
            this.btn_QuitarProd.Click += new System.EventHandler(this.btn_QuitarProd_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(142, 255);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(56, 20);
            this.numericUpDown1.TabIndex = 15;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btn_regCliente
            // 
            this.btn_regCliente.Location = new System.Drawing.Point(202, 7);
            this.btn_regCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_regCliente.Name = "btn_regCliente";
            this.btn_regCliente.Size = new System.Drawing.Size(100, 24);
            this.btn_regCliente.TabIndex = 16;
            this.btn_regCliente.Text = "Registrar nuevo...";
            this.btn_regCliente.UseVisualStyleBackColor = true;
            this.btn_regCliente.Click += new System.EventHandler(this.btn_regCliente_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 328);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 24);
            this.button1.TabIndex = 17;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1RegVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 362);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_regCliente);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btn_QuitarProd);
            this.Controls.Add(this.btn_agProd);
            this.Controls.Add(this.btn_buscaCl);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label_Prod);
            this.Controls.Add(this.label_cliente);
            this.Controls.Add(this.label_precio);
            this.Controls.Add(this.label_precio_final);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_cpto_dcto);
            this.Controls.Add(this.label_dcto);
            this.Controls.Add(this.dg_Productos);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.btn_Cancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1RegVentas";
            this.Text = "Registro de Venta";
            ((System.ComponentModel.ISupportInitialize)(this.dg_Productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.DataGridView dg_Productos;
        private System.Windows.Forms.Label label_dcto;
        private System.Windows.Forms.Label label_cpto_dcto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_precio_final;
        private System.Windows.Forms.Label label_precio;
        private System.Windows.Forms.Label label_cliente;
        private System.Windows.Forms.Label label_Prod;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_buscaCl;
        private System.Windows.Forms.Button btn_agProd;
        private System.Windows.Forms.Button btn_QuitarProd;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant;
        private System.Windows.Forms.Button btn_regCliente;
        private System.Windows.Forms.Button button1;
    }
}