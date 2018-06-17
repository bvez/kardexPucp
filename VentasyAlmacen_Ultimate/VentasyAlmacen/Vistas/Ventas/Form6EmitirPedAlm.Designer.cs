namespace Ventas
{
    partial class Form6EmitirPedAlm
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
            this.dg_Productos = new System.Windows.Forms.DataGridView();
            this.btn_buscaVenta = new System.Windows.Forms.Button();
            this.mT_venta = new System.Windows.Forms.MaskedTextBox();
            this.label_idventa = new System.Windows.Forms.Label();
            this.btn_QuitarProd = new System.Windows.Forms.Button();
            this.btn_agProd = new System.Windows.Forms.Button();
            this.label_Prod = new System.Windows.Forms.Label();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.NProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Productos)).BeginInit();
            this.SuspendLayout();
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
            this.Cant});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_Productos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg_Productos.Location = new System.Drawing.Point(12, 137);
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
            this.dg_Productos.Size = new System.Drawing.Size(363, 150);
            this.dg_Productos.TabIndex = 3;
            // 
            // btn_buscaVenta
            // 
            this.btn_buscaVenta.Location = new System.Drawing.Point(250, 12);
            this.btn_buscaVenta.Name = "btn_buscaVenta";
            this.btn_buscaVenta.Size = new System.Drawing.Size(75, 23);
            this.btn_buscaVenta.TabIndex = 6;
            this.btn_buscaVenta.Text = "Buscar...";
            this.btn_buscaVenta.UseVisualStyleBackColor = true;
            this.btn_buscaVenta.Click += new System.EventHandler(this.btn_buscaVenta_Click);
            // 
            // mT_venta
            // 
            this.mT_venta.Location = new System.Drawing.Point(139, 12);
            this.mT_venta.Name = "mT_venta";
            this.mT_venta.Size = new System.Drawing.Size(105, 22);
            this.mT_venta.TabIndex = 5;
            this.mT_venta.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mT_venta_MaskInputRejected);
            // 
            // label_idventa
            // 
            this.label_idventa.AutoSize = true;
            this.label_idventa.Location = new System.Drawing.Point(12, 12);
            this.label_idventa.Name = "label_idventa";
            this.label_idventa.Size = new System.Drawing.Size(124, 17);
            this.label_idventa.TabIndex = 4;
            this.label_idventa.Text = "ID Venta Asociada";
            // 
            // btn_QuitarProd
            // 
            this.btn_QuitarProd.Location = new System.Drawing.Point(269, 69);
            this.btn_QuitarProd.Name = "btn_QuitarProd";
            this.btn_QuitarProd.Size = new System.Drawing.Size(106, 48);
            this.btn_QuitarProd.TabIndex = 17;
            this.btn_QuitarProd.Text = "Eliminar Producto";
            this.btn_QuitarProd.UseVisualStyleBackColor = true;
            this.btn_QuitarProd.Click += new System.EventHandler(this.btn_QuitarProd_Click);
            // 
            // btn_agProd
            // 
            this.btn_agProd.Location = new System.Drawing.Point(12, 69);
            this.btn_agProd.Name = "btn_agProd";
            this.btn_agProd.Size = new System.Drawing.Size(110, 48);
            this.btn_agProd.TabIndex = 16;
            this.btn_agProd.Text = "Agregar Producto";
            this.btn_agProd.UseVisualStyleBackColor = true;
            this.btn_agProd.Click += new System.EventHandler(this.btn_agProd_Click);
            // 
            // label_Prod
            // 
            this.label_Prod.AutoSize = true;
            this.label_Prod.Location = new System.Drawing.Point(12, 49);
            this.label_Prod.Name = "label_Prod";
            this.label_Prod.Size = new System.Drawing.Size(72, 17);
            this.label_Prod.TabIndex = 15;
            this.label_Prod.Text = "Productos";
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Location = new System.Drawing.Point(12, 303);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(110, 30);
            this.btn_Registrar.TabIndex = 19;
            this.btn_Registrar.Text = "Registrar";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(269, 303);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(110, 30);
            this.btn_Cancelar.TabIndex = 18;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // NProd
            // 
            this.NProd.DataPropertyName = "producto";
            this.NProd.HeaderText = "Nombre del Producto";
            this.NProd.Name = "NProd";
            this.NProd.ReadOnly = true;
            this.NProd.Width = 200;
            // 
            // Cant
            // 
            this.Cant.DataPropertyName = "cantidad";
            this.Cant.HeaderText = "Cantidad";
            this.Cant.Name = "Cant";
            this.Cant.ReadOnly = true;
            this.Cant.Width = 80;
            // 
            // Form6EmitirPedAlm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 350);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_QuitarProd);
            this.Controls.Add(this.btn_agProd);
            this.Controls.Add(this.label_Prod);
            this.Controls.Add(this.btn_buscaVenta);
            this.Controls.Add(this.mT_venta);
            this.Controls.Add(this.label_idventa);
            this.Controls.Add(this.dg_Productos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form6EmitirPedAlm";
            this.Text = "Emitir Pedido a Almacén";
            ((System.ComponentModel.ISupportInitialize)(this.dg_Productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_Productos;
        private System.Windows.Forms.Button btn_buscaVenta;
        private System.Windows.Forms.MaskedTextBox mT_venta;
        private System.Windows.Forms.Label label_idventa;
        private System.Windows.Forms.Button btn_QuitarProd;
        private System.Windows.Forms.Button btn_agProd;
        private System.Windows.Forms.Label label_Prod;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant;
    }
}