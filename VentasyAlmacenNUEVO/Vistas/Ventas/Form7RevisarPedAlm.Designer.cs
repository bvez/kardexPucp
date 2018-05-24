namespace Ventas
{
    partial class Form7RevisarPedAlm
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
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_conf_estado = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label_estado = new System.Windows.Forms.Label();
            this.btn_buscaVenta = new System.Windows.Forms.Button();
            this.mT_venta = new System.Windows.Forms.MaskedTextBox();
            this.label_idventa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(195, 86);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 13;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_conf_estado
            // 
            this.btn_conf_estado.Location = new System.Drawing.Point(17, 86);
            this.btn_conf_estado.Name = "btn_conf_estado";
            this.btn_conf_estado.Size = new System.Drawing.Size(150, 23);
            this.btn_conf_estado.TabIndex = 12;
            this.btn_conf_estado.Text = "Confirmar Estado";
            this.btn_conf_estado.UseVisualStyleBackColor = true;
            this.btn_conf_estado.Click += new System.EventHandler(this.btn_conf_estado_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(83, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // label_estado
            // 
            this.label_estado.AutoSize = true;
            this.label_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_estado.Location = new System.Drawing.Point(14, 46);
            this.label_estado.Name = "label_estado";
            this.label_estado.Size = new System.Drawing.Size(52, 17);
            this.label_estado.TabIndex = 10;
            this.label_estado.Text = "Estado";
            // 
            // btn_buscaVenta
            // 
            this.btn_buscaVenta.Location = new System.Drawing.Point(195, 12);
            this.btn_buscaVenta.Name = "btn_buscaVenta";
            this.btn_buscaVenta.Size = new System.Drawing.Size(75, 23);
            this.btn_buscaVenta.TabIndex = 9;
            this.btn_buscaVenta.Text = "Buscar...";
            this.btn_buscaVenta.UseVisualStyleBackColor = true;
            this.btn_buscaVenta.Click += new System.EventHandler(this.btn_buscaVenta_Click);
            // 
            // mT_venta
            // 
            this.mT_venta.Location = new System.Drawing.Point(83, 14);
            this.mT_venta.Name = "mT_venta";
            this.mT_venta.Size = new System.Drawing.Size(105, 22);
            this.mT_venta.TabIndex = 8;
            // 
            // label_idventa
            // 
            this.label_idventa.AutoSize = true;
            this.label_idventa.Location = new System.Drawing.Point(14, 14);
            this.label_idventa.Name = "label_idventa";
            this.label_idventa.Size = new System.Drawing.Size(69, 17);
            this.label_idventa.TabIndex = 7;
            this.label_idventa.Text = "ID Pedido";
            // 
            // Form7RevisarPedAlm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 126);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_conf_estado);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_estado);
            this.Controls.Add(this.btn_buscaVenta);
            this.Controls.Add(this.mT_venta);
            this.Controls.Add(this.label_idventa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form7RevisarPedAlm";
            this.Text = "Revisar Pedido de Almacén";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_conf_estado;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_estado;
        private System.Windows.Forms.Button btn_buscaVenta;
        private System.Windows.Forms.MaskedTextBox mT_venta;
        private System.Windows.Forms.Label label_idventa;
    }
}