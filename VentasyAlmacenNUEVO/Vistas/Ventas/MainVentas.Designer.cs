namespace Ventas
{
    partial class MainVentas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Salir = new System.Windows.Forms.Button();
            this.controlesAdmin = new System.Windows.Forms.GroupBox();
            this.btn_RevisarPedidoAlmac = new System.Windows.Forms.Button();
            this.btn_EmitirPedidoAlmacen = new System.Windows.Forms.Button();
            this.btn_RevisarVenta = new System.Windows.Forms.Button();
            this.btn_ModificarVenta = new System.Windows.Forms.Button();
            this.controlesEjec = new System.Windows.Forms.GroupBox();
            this.btn_ReporteCliente = new System.Windows.Forms.Button();
            this.btn_ModifCliente = new System.Windows.Forms.Button();
            this.btn_RegCliente = new System.Windows.Forms.Button();
            this.btn_AsignarCliente = new System.Windows.Forms.Button();
            this.btn_ReporteVentas = new System.Windows.Forms.Button();
            this.btn_RegistrarVenta = new System.Windows.Forms.Button();
            this.controlesAdmin.SuspendLayout();
            this.controlesEjec.SuspendLayout();
            this.SuspendLayout();
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(438, 283);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(108, 66);
            this.Salir.TabIndex = 0;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // controlesAdmin
            // 
            this.controlesAdmin.Controls.Add(this.btn_RevisarPedidoAlmac);
            this.controlesAdmin.Controls.Add(this.btn_EmitirPedidoAlmacen);
            this.controlesAdmin.Controls.Add(this.btn_RevisarVenta);
            this.controlesAdmin.Controls.Add(this.btn_ModificarVenta);
            this.controlesAdmin.Location = new System.Drawing.Point(296, 12);
            this.controlesAdmin.Name = "controlesAdmin";
            this.controlesAdmin.Size = new System.Drawing.Size(250, 265);
            this.controlesAdmin.TabIndex = 1;
            this.controlesAdmin.TabStop = false;
            this.controlesAdmin.Text = "Opciones de Administraciòn";
            // 
            // btn_RevisarPedidoAlmac
            // 
            this.btn_RevisarPedidoAlmac.Location = new System.Drawing.Point(7, 138);
            this.btn_RevisarPedidoAlmac.Name = "btn_RevisarPedidoAlmac";
            this.btn_RevisarPedidoAlmac.Size = new System.Drawing.Size(237, 30);
            this.btn_RevisarPedidoAlmac.TabIndex = 3;
            this.btn_RevisarPedidoAlmac.Text = "Revisar Pedido a Almacén";
            this.btn_RevisarPedidoAlmac.UseVisualStyleBackColor = true;
            this.btn_RevisarPedidoAlmac.Click += new System.EventHandler(this.btn_RevisarPedidoAlmac_Click);
            // 
            // btn_EmitirPedidoAlmacen
            // 
            this.btn_EmitirPedidoAlmacen.Location = new System.Drawing.Point(7, 101);
            this.btn_EmitirPedidoAlmacen.Name = "btn_EmitirPedidoAlmacen";
            this.btn_EmitirPedidoAlmacen.Size = new System.Drawing.Size(237, 30);
            this.btn_EmitirPedidoAlmacen.TabIndex = 2;
            this.btn_EmitirPedidoAlmacen.Text = "Emitir Pedido a Almacén";
            this.btn_EmitirPedidoAlmacen.UseVisualStyleBackColor = true;
            this.btn_EmitirPedidoAlmacen.Click += new System.EventHandler(this.btn_EmitirPedidoAlmacen_Click);
            // 
            // btn_RevisarVenta
            // 
            this.btn_RevisarVenta.Location = new System.Drawing.Point(7, 65);
            this.btn_RevisarVenta.Name = "btn_RevisarVenta";
            this.btn_RevisarVenta.Size = new System.Drawing.Size(237, 30);
            this.btn_RevisarVenta.TabIndex = 1;
            this.btn_RevisarVenta.Text = "Revisar Estado de Venta";
            this.btn_RevisarVenta.UseVisualStyleBackColor = true;
            this.btn_RevisarVenta.Click += new System.EventHandler(this.btn_RevisarVenta_Click);
            // 
            // btn_ModificarVenta
            // 
            this.btn_ModificarVenta.Location = new System.Drawing.Point(7, 28);
            this.btn_ModificarVenta.Name = "btn_ModificarVenta";
            this.btn_ModificarVenta.Size = new System.Drawing.Size(237, 30);
            this.btn_ModificarVenta.TabIndex = 0;
            this.btn_ModificarVenta.Text = "Modificar Venta";
            this.btn_ModificarVenta.UseVisualStyleBackColor = true;
            this.btn_ModificarVenta.Click += new System.EventHandler(this.btn_ModificarVenta_Click);
            // 
            // controlesEjec
            // 
            this.controlesEjec.Controls.Add(this.btn_ReporteCliente);
            this.controlesEjec.Controls.Add(this.btn_ModifCliente);
            this.controlesEjec.Controls.Add(this.btn_RegCliente);
            this.controlesEjec.Controls.Add(this.btn_AsignarCliente);
            this.controlesEjec.Controls.Add(this.btn_ReporteVentas);
            this.controlesEjec.Controls.Add(this.btn_RegistrarVenta);
            this.controlesEjec.Location = new System.Drawing.Point(13, 13);
            this.controlesEjec.Name = "controlesEjec";
            this.controlesEjec.Size = new System.Drawing.Size(250, 264);
            this.controlesEjec.TabIndex = 2;
            this.controlesEjec.TabStop = false;
            this.controlesEjec.Text = "Opciones de Ventas";
            // 
            // btn_ReporteCliente
            // 
            this.btn_ReporteCliente.Location = new System.Drawing.Point(7, 210);
            this.btn_ReporteCliente.Name = "btn_ReporteCliente";
            this.btn_ReporteCliente.Size = new System.Drawing.Size(237, 30);
            this.btn_ReporteCliente.TabIndex = 4;
            this.btn_ReporteCliente.Text = "Emitir Reporte de Clientes";
            this.btn_ReporteCliente.UseVisualStyleBackColor = true;
            this.btn_ReporteCliente.Click += new System.EventHandler(this.btn_ReporteCliente_Click);
            // 
            // btn_ModifCliente
            // 
            this.btn_ModifCliente.Location = new System.Drawing.Point(7, 173);
            this.btn_ModifCliente.Name = "btn_ModifCliente";
            this.btn_ModifCliente.Size = new System.Drawing.Size(237, 30);
            this.btn_ModifCliente.TabIndex = 3;
            this.btn_ModifCliente.Text = "Modificar Cliente";
            this.btn_ModifCliente.UseVisualStyleBackColor = true;
            this.btn_ModifCliente.Click += new System.EventHandler(this.btn_ModifCliente_Click);
            // 
            // btn_RegCliente
            // 
            this.btn_RegCliente.Location = new System.Drawing.Point(7, 137);
            this.btn_RegCliente.Name = "btn_RegCliente";
            this.btn_RegCliente.Size = new System.Drawing.Size(237, 30);
            this.btn_RegCliente.TabIndex = 3;
            this.btn_RegCliente.Text = "Registrar Cliente";
            this.btn_RegCliente.UseVisualStyleBackColor = true;
            this.btn_RegCliente.Click += new System.EventHandler(this.btn_RegCliente_Click);
            // 
            // btn_AsignarCliente
            // 
            this.btn_AsignarCliente.Location = new System.Drawing.Point(6, 64);
            this.btn_AsignarCliente.Name = "btn_AsignarCliente";
            this.btn_AsignarCliente.Size = new System.Drawing.Size(238, 30);
            this.btn_AsignarCliente.TabIndex = 2;
            this.btn_AsignarCliente.Text = "Asignar Cliente a Venta";
            this.btn_AsignarCliente.UseVisualStyleBackColor = true;
            this.btn_AsignarCliente.Click += new System.EventHandler(this.btn_AsignarCliente_Click);
            // 
            // btn_ReporteVentas
            // 
            this.btn_ReporteVentas.Location = new System.Drawing.Point(6, 100);
            this.btn_ReporteVentas.Name = "btn_ReporteVentas";
            this.btn_ReporteVentas.Size = new System.Drawing.Size(238, 30);
            this.btn_ReporteVentas.TabIndex = 1;
            this.btn_ReporteVentas.Text = "Emitir Reporte de Ventas";
            this.btn_ReporteVentas.UseVisualStyleBackColor = true;
            this.btn_ReporteVentas.Click += new System.EventHandler(this.btn_ReporteVentas_Click);
            // 
            // btn_RegistrarVenta
            // 
            this.btn_RegistrarVenta.Location = new System.Drawing.Point(6, 27);
            this.btn_RegistrarVenta.Name = "btn_RegistrarVenta";
            this.btn_RegistrarVenta.Size = new System.Drawing.Size(238, 30);
            this.btn_RegistrarVenta.TabIndex = 0;
            this.btn_RegistrarVenta.Text = "Registrar Venta";
            this.btn_RegistrarVenta.UseVisualStyleBackColor = true;
            this.btn_RegistrarVenta.Click += new System.EventHandler(this.btn_RegistrarVenta_Click);
            // 
            // MainVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(558, 361);
            this.Controls.Add(this.controlesEjec);
            this.Controls.Add(this.controlesAdmin);
            this.Controls.Add(this.Salir);
            this.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainVentas";
            this.Text = "Interfaz de Ventas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainVentas_FormClosed);
            this.Load += new System.EventHandler(this.MainVentas_Load);
            this.controlesAdmin.ResumeLayout(false);
            this.controlesEjec.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.GroupBox controlesAdmin;
        private System.Windows.Forms.GroupBox controlesEjec;
        private System.Windows.Forms.Button btn_RegistrarVenta;
        private System.Windows.Forms.Button btn_RevisarPedidoAlmac;
        private System.Windows.Forms.Button btn_EmitirPedidoAlmacen;
        private System.Windows.Forms.Button btn_RevisarVenta;
        private System.Windows.Forms.Button btn_ModificarVenta;
        private System.Windows.Forms.Button btn_AsignarCliente;
        private System.Windows.Forms.Button btn_ReporteVentas;
        private System.Windows.Forms.Button btn_ReporteCliente;
        private System.Windows.Forms.Button btn_ModifCliente;
        private System.Windows.Forms.Button btn_RegCliente;
    }
}

