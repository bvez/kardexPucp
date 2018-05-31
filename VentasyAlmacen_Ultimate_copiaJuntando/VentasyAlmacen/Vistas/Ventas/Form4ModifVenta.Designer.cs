namespace Ventas
{
    partial class Form4ModifVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dG_ModifVentas = new System.Windows.Forms.DataGridView();
            this.btn_salir = new System.Windows.Forms.Button();
            this.label_ModifVenta = new System.Windows.Forms.Label();
            this.dg_Productos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_Prods = new System.Windows.Forms.Label();
            this.label_Cliente = new System.Windows.Forms.Label();
            this.label_precio = new System.Windows.Forms.Label();
            this.label_precio_final = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label_cpto_dcto = new System.Windows.Forms.Label();
            this.label_dcto = new System.Windows.Forms.Label();
            this.btn_reg_camb = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dG_ModifVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Productos)).BeginInit();
            this.SuspendLayout();
            // 
            // dG_ModifVentas
            // 
            this.dG_ModifVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dG_ModifVentas.Location = new System.Drawing.Point(12, 29);
            this.dG_ModifVentas.Name = "dG_ModifVentas";
            this.dG_ModifVentas.RowTemplate.Height = 24;
            this.dG_ModifVentas.Size = new System.Drawing.Size(431, 186);
            this.dG_ModifVentas.TabIndex = 0;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(368, 576);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 1;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // label_ModifVenta
            // 
            this.label_ModifVenta.AutoSize = true;
            this.label_ModifVenta.Location = new System.Drawing.Point(12, 9);
            this.label_ModifVenta.Name = "label_ModifVenta";
            this.label_ModifVenta.Size = new System.Drawing.Size(191, 17);
            this.label_ModifVenta.TabIndex = 2;
            this.label_ModifVenta.Text = "Selecciona Venta a Modificar";
            // 
            // dg_Productos
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_Productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dg_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Productos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NProd,
            this.Cant,
            this.Precio});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_Productos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dg_Productos.Location = new System.Drawing.Point(12, 279);
            this.dg_Productos.Name = "dg_Productos";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg_Productos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dg_Productos.RowTemplate.Height = 24;
            this.dg_Productos.Size = new System.Drawing.Size(431, 146);
            this.dg_Productos.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 40;
            // 
            // NProd
            // 
            this.NProd.HeaderText = "Nombre del Producto";
            this.NProd.Name = "NProd";
            this.NProd.ReadOnly = true;
            this.NProd.Width = 200;
            // 
            // Cant
            // 
            this.Cant.HeaderText = "Cantidad";
            this.Cant.Name = "Cant";
            this.Cant.ReadOnly = true;
            this.Cant.Width = 80;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 68;
            // 
            // label_Prods
            // 
            this.label_Prods.AutoSize = true;
            this.label_Prods.Location = new System.Drawing.Point(15, 259);
            this.label_Prods.Name = "label_Prods";
            this.label_Prods.Size = new System.Drawing.Size(225, 17);
            this.label_Prods.TabIndex = 4;
            this.label_Prods.Text = "Modifica los productos de la Venta";
            // 
            // label_Cliente
            // 
            this.label_Cliente.AutoSize = true;
            this.label_Cliente.Location = new System.Drawing.Point(12, 232);
            this.label_Cliente.Name = "label_Cliente";
            this.label_Cliente.Size = new System.Drawing.Size(55, 17);
            this.label_Cliente.TabIndex = 5;
            this.label_Cliente.Text = "Cliente:";
            // 
            // label_precio
            // 
            this.label_precio.AutoSize = true;
            this.label_precio.Location = new System.Drawing.Point(9, 441);
            this.label_precio.Name = "label_precio";
            this.label_precio.Size = new System.Drawing.Size(120, 17);
            this.label_precio.TabIndex = 14;
            this.label_precio.Text = "Precio Total: 0.00";
            // 
            // label_precio_final
            // 
            this.label_precio_final.AutoSize = true;
            this.label_precio_final.Location = new System.Drawing.Point(9, 528);
            this.label_precio_final.Name = "label_precio_final";
            this.label_precio_final.Size = new System.Drawing.Size(118, 17);
            this.label_precio_final.TabIndex = 19;
            this.label_precio_final.Text = "Precio Final: 0.00";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(185, 497);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(253, 22);
            this.textBox2.TabIndex = 18;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(185, 467);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(86, 22);
            this.maskedTextBox1.TabIndex = 17;
            // 
            // label_cpto_dcto
            // 
            this.label_cpto_dcto.AutoSize = true;
            this.label_cpto_dcto.Location = new System.Drawing.Point(9, 497);
            this.label_cpto_dcto.Name = "label_cpto_dcto";
            this.label_cpto_dcto.Size = new System.Drawing.Size(140, 17);
            this.label_cpto_dcto.TabIndex = 16;
            this.label_cpto_dcto.Text = "Concepto Descuento";
            // 
            // label_dcto
            // 
            this.label_dcto.AutoSize = true;
            this.label_dcto.Location = new System.Drawing.Point(9, 467);
            this.label_dcto.Name = "label_dcto";
            this.label_dcto.Size = new System.Drawing.Size(164, 17);
            this.label_dcto.TabIndex = 15;
            this.label_dcto.Text = "Descuento (del 0 al 100)";
            // 
            // btn_reg_camb
            // 
            this.btn_reg_camb.Location = new System.Drawing.Point(12, 554);
            this.btn_reg_camb.Name = "btn_reg_camb";
            this.btn_reg_camb.Size = new System.Drawing.Size(125, 45);
            this.btn_reg_camb.TabIndex = 21;
            this.btn_reg_camb.Text = "Registrar Cambios";
            this.btn_reg_camb.UseVisualStyleBackColor = true;
            this.btn_reg_camb.Click += new System.EventHandler(this.btn_reg_camb_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 229);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(370, 22);
            this.textBox1.TabIndex = 22;
            // 
            // Form4ModifVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 611);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_reg_camb);
            this.Controls.Add(this.label_precio_final);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label_cpto_dcto);
            this.Controls.Add(this.label_dcto);
            this.Controls.Add(this.label_precio);
            this.Controls.Add(this.label_Cliente);
            this.Controls.Add(this.label_Prods);
            this.Controls.Add(this.dg_Productos);
            this.Controls.Add(this.label_ModifVenta);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.dG_ModifVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form4ModifVenta";
            this.Text = "Modificar Venta";
            ((System.ComponentModel.ISupportInitialize)(this.dG_ModifVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dG_ModifVentas;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label label_ModifVenta;
        private System.Windows.Forms.DataGridView dg_Productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Label label_Prods;
        private System.Windows.Forms.Label label_Cliente;
        private System.Windows.Forms.Label label_precio;
        private System.Windows.Forms.Label label_precio_final;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label_cpto_dcto;
        private System.Windows.Forms.Label label_dcto;
        private System.Windows.Forms.Button btn_reg_camb;
        private System.Windows.Forms.TextBox textBox1;
    }
}