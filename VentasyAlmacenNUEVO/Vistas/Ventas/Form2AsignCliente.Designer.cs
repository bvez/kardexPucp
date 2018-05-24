namespace Ventas
{
    partial class Form2AsignCliente
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
            this.label_ID_Cliente = new System.Windows.Forms.Label();
            this.mTB_IDVenta = new System.Windows.Forms.MaskedTextBox();
            this.mTB_IDCliente = new System.Windows.Forms.MaskedTextBox();
            this.btn_buscaVenta = new System.Windows.Forms.Button();
            this.btn_BuscaCliente = new System.Windows.Forms.Button();
            this.btn_asignar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Venta";
            // 
            // label_ID_Cliente
            // 
            this.label_ID_Cliente.AutoSize = true;
            this.label_ID_Cliente.Location = new System.Drawing.Point(12, 48);
            this.label_ID_Cliente.Name = "label_ID_Cliente";
            this.label_ID_Cliente.Size = new System.Drawing.Size(68, 17);
            this.label_ID_Cliente.TabIndex = 2;
            this.label_ID_Cliente.Text = "ID Cliente";
            // 
            // mTB_IDVenta
            // 
            this.mTB_IDVenta.Location = new System.Drawing.Point(81, 13);
            this.mTB_IDVenta.Name = "mTB_IDVenta";
            this.mTB_IDVenta.Size = new System.Drawing.Size(100, 22);
            this.mTB_IDVenta.TabIndex = 3;
            // 
            // mTB_IDCliente
            // 
            this.mTB_IDCliente.Location = new System.Drawing.Point(81, 45);
            this.mTB_IDCliente.Name = "mTB_IDCliente";
            this.mTB_IDCliente.Size = new System.Drawing.Size(100, 22);
            this.mTB_IDCliente.TabIndex = 4;
            // 
            // btn_buscaVenta
            // 
            this.btn_buscaVenta.Location = new System.Drawing.Point(188, 9);
            this.btn_buscaVenta.Name = "btn_buscaVenta";
            this.btn_buscaVenta.Size = new System.Drawing.Size(75, 26);
            this.btn_buscaVenta.TabIndex = 5;
            this.btn_buscaVenta.Text = "Buscar";
            this.btn_buscaVenta.UseVisualStyleBackColor = true;
            this.btn_buscaVenta.Click += new System.EventHandler(this.btn_buscaVenta_Click);
            // 
            // btn_BuscaCliente
            // 
            this.btn_BuscaCliente.Location = new System.Drawing.Point(188, 45);
            this.btn_BuscaCliente.Name = "btn_BuscaCliente";
            this.btn_BuscaCliente.Size = new System.Drawing.Size(75, 23);
            this.btn_BuscaCliente.TabIndex = 6;
            this.btn_BuscaCliente.Text = "Buscar";
            this.btn_BuscaCliente.UseVisualStyleBackColor = true;
            this.btn_BuscaCliente.Click += new System.EventHandler(this.btn_BuscaCliente_Click);
            // 
            // btn_asignar
            // 
            this.btn_asignar.Location = new System.Drawing.Point(15, 87);
            this.btn_asignar.Name = "btn_asignar";
            this.btn_asignar.Size = new System.Drawing.Size(110, 51);
            this.btn_asignar.TabIndex = 7;
            this.btn_asignar.Text = "Asignar Cliente";
            this.btn_asignar.UseVisualStyleBackColor = true;
            this.btn_asignar.Click += new System.EventHandler(this.btn_asignar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(153, 87);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(110, 51);
            this.btn_cancelar.TabIndex = 8;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // Form2AsignCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 165);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_asignar);
            this.Controls.Add(this.btn_BuscaCliente);
            this.Controls.Add(this.btn_buscaVenta);
            this.Controls.Add(this.mTB_IDCliente);
            this.Controls.Add(this.mTB_IDVenta);
            this.Controls.Add(this.label_ID_Cliente);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2AsignCliente";
            this.Text = "Asignar Cliente a Venta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_ID_Cliente;
        private System.Windows.Forms.MaskedTextBox mTB_IDVenta;
        private System.Windows.Forms.MaskedTextBox mTB_IDCliente;
        private System.Windows.Forms.Button btn_buscaVenta;
        private System.Windows.Forms.Button btn_BuscaCliente;
        private System.Windows.Forms.Button btn_asignar;
        private System.Windows.Forms.Button btn_cancelar;
    }
}