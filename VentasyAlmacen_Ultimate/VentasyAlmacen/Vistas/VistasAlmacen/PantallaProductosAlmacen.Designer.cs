﻿namespace FormulariosAlmacenes
{
    partial class PantallaProductosAlmacen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaProductosAlmacen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNumResultados = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.stockActualSeleccionado = new System.Windows.Forms.Label();
            this.nombreSeleccionado = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nuevoStockNumBox = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btnModificarStock = new System.Windows.Forms.Button();
            this.btnInsertarProducto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCargando = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numStockMax = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numStockMin = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tablaProductosAlmacen = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuevoStockNumBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStockMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductosAlmacen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNumResultados);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.btnInsertarProducto);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.tablaProductosAlmacen);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 435);
            this.panel1.TabIndex = 0;
            // 
            // txtNumResultados
            // 
            this.txtNumResultados.AutoSize = true;
            this.txtNumResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtNumResultados.Location = new System.Drawing.Point(368, 21);
            this.txtNumResultados.Name = "txtNumResultados";
            this.txtNumResultados.Size = new System.Drawing.Size(60, 13);
            this.txtNumResultados.TabIndex = 16;
            this.txtNumResultados.Text = "Resultados";
            this.txtNumResultados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtNumResultados.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.stockActualSeleccionado);
            this.groupBox2.Controls.Add(this.nombreSeleccionado);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.nuevoStockNumBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnModificarStock);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.groupBox2.Location = new System.Drawing.Point(484, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 212);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar Stock";
            // 
            // stockActualSeleccionado
            // 
            this.stockActualSeleccionado.AutoSize = true;
            this.stockActualSeleccionado.Location = new System.Drawing.Point(137, 77);
            this.stockActualSeleccionado.Name = "stockActualSeleccionado";
            this.stockActualSeleccionado.Size = new System.Drawing.Size(0, 24);
            this.stockActualSeleccionado.TabIndex = 19;
            // 
            // nombreSeleccionado
            // 
            this.nombreSeleccionado.AutoSize = true;
            this.nombreSeleccionado.Location = new System.Drawing.Point(137, 42);
            this.nombreSeleccionado.Name = "nombreSeleccionado";
            this.nombreSeleccionado.Size = new System.Drawing.Size(0, 24);
            this.nombreSeleccionado.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(20, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Nombre:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(20, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Stock Actual:";
            // 
            // nuevoStockNumBox
            // 
            this.nuevoStockNumBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.nuevoStockNumBox.Location = new System.Drawing.Point(137, 117);
            this.nuevoStockNumBox.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nuevoStockNumBox.Name = "nuevoStockNumBox";
            this.nuevoStockNumBox.Size = new System.Drawing.Size(98, 29);
            this.nuevoStockNumBox.TabIndex = 11;
            this.nuevoStockNumBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nuevoStockNumBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(20, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Nuevo Stock:";
            // 
            // btnModificarStock
            // 
            this.btnModificarStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnModificarStock.Image = global::FormulariosAlmacenes.Properties.Resources.btn_salirTiny;
            this.btnModificarStock.Location = new System.Drawing.Point(57, 155);
            this.btnModificarStock.Name = "btnModificarStock";
            this.btnModificarStock.Size = new System.Drawing.Size(211, 40);
            this.btnModificarStock.TabIndex = 12;
            this.btnModificarStock.Text = "   Modificar Stock ";
            this.btnModificarStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarStock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificarStock.UseVisualStyleBackColor = true;
            this.btnModificarStock.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnInsertarProducto
            // 
            this.btnInsertarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnInsertarProducto.Image = global::FormulariosAlmacenes.Properties.Resources.btn_anadir_tiny;
            this.btnInsertarProducto.Location = new System.Drawing.Point(541, 25);
            this.btnInsertarProducto.Name = "btnInsertarProducto";
            this.btnInsertarProducto.Size = new System.Drawing.Size(211, 40);
            this.btnInsertarProducto.TabIndex = 10;
            this.btnInsertarProducto.Text = "   Insertar Producto";
            this.btnInsertarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInsertarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInsertarProducto.UseVisualStyleBackColor = true;
            this.btnInsertarProducto.Click += new System.EventHandler(this.btnInsertarProducto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(9, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stock de los productos de este almacén:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCargando);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.numStockMax);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numStockMin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 235);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(439, 180);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Producto";
            // 
            // txtCargando
            // 
            this.txtCargando.AutoSize = true;
            this.txtCargando.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtCargando.Location = new System.Drawing.Point(347, 162);
            this.txtCargando.Name = "txtCargando";
            this.txtCargando.Size = new System.Drawing.Size(62, 13);
            this.txtCargando.TabIndex = 15;
            this.txtCargando.Text = "Cargando...";
            this.txtCargando.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label10.Location = new System.Drawing.Point(61, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "(Solo números)";
            // 
            // numStockMax
            // 
            this.numStockMax.Location = new System.Drawing.Point(246, 124);
            this.numStockMax.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numStockMax.Name = "numStockMax";
            this.numStockMax.Size = new System.Drawing.Size(68, 29);
            this.numStockMax.TabIndex = 8;
            this.numStockMax.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numStockMax.ValueChanged += new System.EventHandler(this.numStockMax_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(126, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "De";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(226, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "a";
            // 
            // numStockMin
            // 
            this.numStockMin.Location = new System.Drawing.Point(155, 124);
            this.numStockMin.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.numStockMin.Name = "numStockMin";
            this.numStockMin.Size = new System.Drawing.Size(68, 29);
            this.numStockMin.TabIndex = 7;
            this.numStockMin.ValueChanged += new System.EventHandler(this.numStockMin_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(10, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rango de Stock:";
            // 
            // textBoxId
            // 
            this.textBoxId.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxId.Location = new System.Drawing.Point(129, 31);
            this.textBoxId.MaxLength = 5;
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(177, 29);
            this.textBoxId.TabIndex = 5;
            this.textBoxId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxId_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(100, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Id:";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(129, 77);
            this.textBoxNombre.MaxLength = 102;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(177, 29);
            this.textBoxNombre.TabIndex = 6;
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(61, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // button1
            // 
            this.button1.Image = global::FormulariosAlmacenes.Properties.Resources.btn_search_tiny;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(320, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "Buscar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tablaProductosAlmacen
            // 
            this.tablaProductosAlmacen.AllowUserToAddRows = false;
            this.tablaProductosAlmacen.AllowUserToDeleteRows = false;
            this.tablaProductosAlmacen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tablaProductosAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaProductosAlmacen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3,
            this.Precio,
            this.Descripcion});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaProductosAlmacen.DefaultCellStyle = dataGridViewCellStyle1;
            this.tablaProductosAlmacen.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.tablaProductosAlmacen.Location = new System.Drawing.Point(13, 37);
            this.tablaProductosAlmacen.Name = "tablaProductosAlmacen";
            this.tablaProductosAlmacen.ReadOnly = true;
            this.tablaProductosAlmacen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaProductosAlmacen.Size = new System.Drawing.Size(432, 192);
            this.tablaProductosAlmacen.TabIndex = 0;
            this.tablaProductosAlmacen.SelectionChanged += new System.EventHandler(this.tablaProductosAlmacen_SelectionChanged);
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Id";
            this.Column2.HeaderText = "Id";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 41;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Nombre";
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 69;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "CantidadAlmacenada";
            this.Column3.HeaderText = "Stock";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 60;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio de Venta";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 99;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 88;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button2.Image = global::FormulariosAlmacenes.Properties.Resources.btn_back_tiny;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(352, 433);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 41);
            this.button2.TabIndex = 13;
            this.button2.Text = "Atrás";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button3.Location = new System.Drawing.Point(57, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 40);
            this.button3.TabIndex = 13;
            this.button3.Text = " Modificar Stock ";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PantallaProductosAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 484);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PantallaProductosAlmacen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock de Productos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PantallaProductosAlmacen_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuevoStockNumBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numStockMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStockMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductosAlmacen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView tablaProductosAlmacen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numStockMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numStockMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnInsertarProducto;
        private System.Windows.Forms.Button btnModificarStock;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nuevoStockNumBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label stockActualSeleccionado;
        private System.Windows.Forms.Label nombreSeleccionado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label txtCargando;
        private System.Windows.Forms.Label txtNumResultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}