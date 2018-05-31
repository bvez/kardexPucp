namespace Ventas
{
    partial class Form15BuscaPedido
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.ID_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Pedido,
            this.ID_Venta});
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(489, 172);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(427, 205);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 36);
            this.btn_salir.TabIndex = 1;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(13, 205);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 36);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "Elegir";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // ID_Pedido
            // 
            this.ID_Pedido.DataPropertyName = "id";
            this.ID_Pedido.HeaderText = "ID Pedido";
            this.ID_Pedido.Name = "ID_Pedido";
            this.ID_Pedido.ReadOnly = true;
            // 
            // ID_Venta
            // 
            this.ID_Venta.DataPropertyName = "idVenta";
            this.ID_Venta.HeaderText = "Venta Asociada";
            this.ID_Venta.Name = "ID_Venta";
            this.ID_Venta.ReadOnly = true;
            // 
            // Form15BuscaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 253);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form15BuscaPedido";
            this.Text = "Buscar Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Venta;
    }
}