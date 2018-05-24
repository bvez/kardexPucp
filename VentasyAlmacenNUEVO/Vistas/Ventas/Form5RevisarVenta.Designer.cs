namespace Ventas
{
    partial class Form5RevisarVenta
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
            this.label_idventa = new System.Windows.Forms.Label();
            this.mT_venta = new System.Windows.Forms.MaskedTextBox();
            this.btn_buscaVenta = new System.Windows.Forms.Button();
            this.label_estado = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_conf_estado = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_idventa
            // 
            this.label_idventa.AutoSize = true;
            this.label_idventa.Location = new System.Drawing.Point(13, 13);
            this.label_idventa.Name = "label_idventa";
            this.label_idventa.Size = new System.Drawing.Size(62, 17);
            this.label_idventa.TabIndex = 0;
            this.label_idventa.Text = "ID Venta";
            // 
            // mT_venta
            // 
            this.mT_venta.Location = new System.Drawing.Point(82, 13);
            this.mT_venta.Name = "mT_venta";
            this.mT_venta.Size = new System.Drawing.Size(105, 22);
            this.mT_venta.TabIndex = 1;
            // 
            // btn_buscaVenta
            // 
            this.btn_buscaVenta.Location = new System.Drawing.Point(194, 11);
            this.btn_buscaVenta.Name = "btn_buscaVenta";
            this.btn_buscaVenta.Size = new System.Drawing.Size(75, 23);
            this.btn_buscaVenta.TabIndex = 2;
            this.btn_buscaVenta.Text = "Buscar...";
            this.btn_buscaVenta.UseVisualStyleBackColor = true;
            this.btn_buscaVenta.Click += new System.EventHandler(this.btn_buscaVenta_Click);
            // 
            // label_estado
            // 
            this.label_estado.AutoSize = true;
            this.label_estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_estado.Location = new System.Drawing.Point(13, 45);
            this.label_estado.Name = "label_estado";
            this.label_estado.Size = new System.Drawing.Size(52, 17);
            this.label_estado.TabIndex = 3;
            this.label_estado.Text = "Estado";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(82, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(187, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // btn_conf_estado
            // 
            this.btn_conf_estado.Location = new System.Drawing.Point(16, 85);
            this.btn_conf_estado.Name = "btn_conf_estado";
            this.btn_conf_estado.Size = new System.Drawing.Size(150, 23);
            this.btn_conf_estado.TabIndex = 5;
            this.btn_conf_estado.Text = "Confirmar Estado";
            this.btn_conf_estado.UseVisualStyleBackColor = true;
            this.btn_conf_estado.Click += new System.EventHandler(this.btn_conf_estado_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(194, 85);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 6;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Form5RevisarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 129);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_conf_estado);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_estado);
            this.Controls.Add(this.btn_buscaVenta);
            this.Controls.Add(this.mT_venta);
            this.Controls.Add(this.label_idventa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form5RevisarVenta";
            this.Text = "Revisar Venta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_idventa;
        private System.Windows.Forms.MaskedTextBox mT_venta;
        private System.Windows.Forms.Button btn_buscaVenta;
        private System.Windows.Forms.Label label_estado;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_conf_estado;
        private System.Windows.Forms.Button btn_salir;
    }
}