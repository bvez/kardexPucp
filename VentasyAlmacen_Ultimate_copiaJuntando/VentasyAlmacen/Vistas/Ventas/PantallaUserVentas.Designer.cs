namespace Ventas
{
    partial class PantallaUserVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaUserVentas));
            this.btn_regVenta = new System.Windows.Forms.Button();
            this.btn_regCliente = new System.Windows.Forms.Button();
            this.btn_reporteVentas = new System.Windows.Forms.Button();
            this.btn_ModifCliente = new System.Windows.Forms.Button();
            this.labelBienvenidaAdmin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_reporteClientes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_regVenta
            // 
            this.btn_regVenta.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_regVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regVenta.ForeColor = System.Drawing.Color.Black;
            this.btn_regVenta.Location = new System.Drawing.Point(53, 127);
            this.btn_regVenta.Margin = new System.Windows.Forms.Padding(4);
            this.btn_regVenta.Name = "btn_regVenta";
            this.btn_regVenta.Size = new System.Drawing.Size(253, 98);
            this.btn_regVenta.TabIndex = 0;
            this.btn_regVenta.Text = "Registrar Venta";
            this.btn_regVenta.UseVisualStyleBackColor = false;
            this.btn_regVenta.Click += new System.EventHandler(this.btn_regVenta_Click);
            // 
            // btn_regCliente
            // 
            this.btn_regCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_regCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_regCliente.ForeColor = System.Drawing.Color.Black;
            this.btn_regCliente.Location = new System.Drawing.Point(53, 251);
            this.btn_regCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btn_regCliente.Name = "btn_regCliente";
            this.btn_regCliente.Size = new System.Drawing.Size(253, 98);
            this.btn_regCliente.TabIndex = 1;
            this.btn_regCliente.Text = "Registrar Cliente";
            this.btn_regCliente.UseVisualStyleBackColor = false;
            this.btn_regCliente.Click += new System.EventHandler(this.btn_regCliente_Click);
            // 
            // btn_reporteVentas
            // 
            this.btn_reporteVentas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_reporteVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reporteVentas.ForeColor = System.Drawing.Color.Black;
            this.btn_reporteVentas.Location = new System.Drawing.Point(367, 127);
            this.btn_reporteVentas.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reporteVentas.Name = "btn_reporteVentas";
            this.btn_reporteVentas.Size = new System.Drawing.Size(253, 98);
            this.btn_reporteVentas.TabIndex = 2;
            this.btn_reporteVentas.Text = "Emitir Reporte de Ventas";
            this.btn_reporteVentas.UseVisualStyleBackColor = false;
            this.btn_reporteVentas.Click += new System.EventHandler(this.btn_reporteVentas_Click);
            // 
            // btn_ModifCliente
            // 
            this.btn_ModifCliente.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_ModifCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_ModifCliente.ForeColor = System.Drawing.Color.Black;
            this.btn_ModifCliente.Location = new System.Drawing.Point(367, 251);
            this.btn_ModifCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ModifCliente.Name = "btn_ModifCliente";
            this.btn_ModifCliente.Size = new System.Drawing.Size(253, 98);
            this.btn_ModifCliente.TabIndex = 3;
            this.btn_ModifCliente.Text = "Modificar Cliente";
            this.btn_ModifCliente.UseVisualStyleBackColor = false;
            this.btn_ModifCliente.Click += new System.EventHandler(this.btn_ModifCliente_Click);
            // 
            // labelBienvenidaAdmin
            // 
            this.labelBienvenidaAdmin.AutoSize = true;
            this.labelBienvenidaAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelBienvenidaAdmin.ForeColor = System.Drawing.Color.Black;
            this.labelBienvenidaAdmin.Location = new System.Drawing.Point(16, 15);
            this.labelBienvenidaAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBienvenidaAdmin.Name = "labelBienvenidaAdmin";
            this.labelBienvenidaAdmin.Size = new System.Drawing.Size(196, 39);
            this.labelBienvenidaAdmin.TabIndex = 4;
            this.labelBienvenidaAdmin.Text = "Bienvenido ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleccione una opción:";
            // 
            // btn_reporteClientes
            // 
            this.btn_reporteClientes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_reporteClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btn_reporteClientes.ForeColor = System.Drawing.Color.Black;
            this.btn_reporteClientes.Location = new System.Drawing.Point(212, 373);
            this.btn_reporteClientes.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reporteClientes.Name = "btn_reporteClientes";
            this.btn_reporteClientes.Size = new System.Drawing.Size(253, 102);
            this.btn_reporteClientes.TabIndex = 8;
            this.btn_reporteClientes.Text = "Reporte de Clientes";
            this.btn_reporteClientes.UseVisualStyleBackColor = false;
            this.btn_reporteClientes.Click += new System.EventHandler(this.btn_reporteClientes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::FormulariosAlmacenes.Properties.Resources.logoCerrarSesion;
            this.pictureBox1.Location = new System.Drawing.Point(547, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // PantallaUserVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(179)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(672, 489);
            this.Controls.Add(this.btn_reporteClientes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelBienvenidaAdmin);
            this.Controls.Add(this.btn_ModifCliente);
            this.Controls.Add(this.btn_reporteVentas);
            this.Controls.Add(this.btn_regCliente);
            this.Controls.Add(this.btn_regVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "PantallaUserVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de Almacén";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PantallaUserVentas_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_regVenta;
        private System.Windows.Forms.Button btn_regCliente;
        private System.Windows.Forms.Button btn_reporteVentas;
        private System.Windows.Forms.Button btn_ModifCliente;
        private System.Windows.Forms.Label labelBienvenidaAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_reporteClientes;
    }
}