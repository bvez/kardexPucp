namespace Ventas
{
    partial class Form13BuscaProducto
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Descripción,
            this.Precio});
            this.dataGridView1.Location = new System.Drawing.Point(11, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(478, 193);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(401, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cantidad";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(85, 211);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 6;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "id";
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Descripción
            // 
            this.Descripción.DataPropertyName = "descripcion";
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.Name = "Descripción";
            this.Descripción.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Form13BuscaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 276);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form13BuscaProducto";
            this.Text = "Form13BuscaProducto";
            this.Load += new System.EventHandler(this.Form13BuscaProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
    }
}