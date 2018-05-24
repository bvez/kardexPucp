namespace Ventas
{
    partial class Form11BuscaVenta
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
            this.label_ModifVenta = new System.Windows.Forms.Label();
            this.dG_ModifVentas = new System.Windows.Forms.DataGridView();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_conf_busc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dG_ModifVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // label_ModifVenta
            // 
            this.label_ModifVenta.AutoSize = true;
            this.label_ModifVenta.Location = new System.Drawing.Point(12, 9);
            this.label_ModifVenta.Name = "label_ModifVenta";
            this.label_ModifVenta.Size = new System.Drawing.Size(118, 17);
            this.label_ModifVenta.TabIndex = 4;
            this.label_ModifVenta.Text = "Selecciona Venta";
            // 
            // dG_ModifVentas
            // 
            this.dG_ModifVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dG_ModifVentas.Location = new System.Drawing.Point(12, 29);
            this.dG_ModifVentas.Name = "dG_ModifVentas";
            this.dG_ModifVentas.RowTemplate.Height = 24;
            this.dG_ModifVentas.Size = new System.Drawing.Size(431, 186);
            this.dG_ModifVentas.TabIndex = 3;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(368, 226);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 17;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_conf_busc
            // 
            this.btn_conf_busc.Location = new System.Drawing.Point(12, 226);
            this.btn_conf_busc.Name = "btn_conf_busc";
            this.btn_conf_busc.Size = new System.Drawing.Size(80, 23);
            this.btn_conf_busc.TabIndex = 16;
            this.btn_conf_busc.Text = "Confirmar";
            this.btn_conf_busc.UseVisualStyleBackColor = true;
            this.btn_conf_busc.Click += new System.EventHandler(this.btn_conf_busc_Click);
            // 
            // Form11BuscaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 261);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_conf_busc);
            this.Controls.Add(this.label_ModifVenta);
            this.Controls.Add(this.dG_ModifVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form11BuscaVenta";
            this.Text = "Buscar Venta";
            ((System.ComponentModel.ISupportInitialize)(this.dG_ModifVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ModifVenta;
        private System.Windows.Forms.DataGridView dG_ModifVentas;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_conf_busc;
    }
}