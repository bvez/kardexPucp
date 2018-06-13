namespace FormulariosAlmacenes
{
    partial class PantallaUsuarioAlmacen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaUsuarioAlmacen));
            this.labelBienvenidaUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStock = new System.Windows.Forms.Button();
            this.buttonIngreso = new System.Windows.Forms.Button();
            this.buttonRegPedidos = new System.Windows.Forms.Button();
            this.buttonReporteFechas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelAlmacen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBienvenidaUsuario
            // 
            this.labelBienvenidaUsuario.AutoSize = true;
            this.labelBienvenidaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBienvenidaUsuario.Location = new System.Drawing.Point(12, 41);
            this.labelBienvenidaUsuario.Name = "labelBienvenidaUsuario";
            this.labelBienvenidaUsuario.Size = new System.Drawing.Size(166, 31);
            this.labelBienvenidaUsuario.TabIndex = 5;
            this.labelBienvenidaUsuario.Text = "Bienvenido ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seleccione una opción:";
            // 
            // buttonStock
            // 
            this.buttonStock.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonStock.Location = new System.Drawing.Point(73, 169);
            this.buttonStock.Name = "buttonStock";
            this.buttonStock.Size = new System.Drawing.Size(189, 74);
            this.buttonStock.TabIndex = 7;
            this.buttonStock.Text = "Revisar Stock";
            this.buttonStock.UseVisualStyleBackColor = false;
            this.buttonStock.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonStock_MouseClick);
            // 
            // buttonIngreso
            // 
            this.buttonIngreso.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonIngreso.Location = new System.Drawing.Point(364, 169);
            this.buttonIngreso.Name = "buttonIngreso";
            this.buttonIngreso.Size = new System.Drawing.Size(189, 74);
            this.buttonIngreso.TabIndex = 8;
            this.buttonIngreso.Text = "Registrar Ingresos/Salidas";
            this.buttonIngreso.UseVisualStyleBackColor = false;
            this.buttonIngreso.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonIngreso_MouseClick);
            // 
            // buttonRegPedidos
            // 
            this.buttonRegPedidos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRegPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonRegPedidos.Location = new System.Drawing.Point(364, 268);
            this.buttonRegPedidos.Name = "buttonRegPedidos";
            this.buttonRegPedidos.Size = new System.Drawing.Size(189, 74);
            this.buttonRegPedidos.TabIndex = 10;
            this.buttonRegPedidos.Text = "Registrar Pedido a Producción";
            this.buttonRegPedidos.UseVisualStyleBackColor = false;
            this.buttonRegPedidos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonRegPedidos_MouseClick);
            // 
            // buttonReporteFechas
            // 
            this.buttonReporteFechas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonReporteFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonReporteFechas.Location = new System.Drawing.Point(73, 268);
            this.buttonReporteFechas.Name = "buttonReporteFechas";
            this.buttonReporteFechas.Size = new System.Drawing.Size(189, 74);
            this.buttonReporteFechas.TabIndex = 12;
            this.buttonReporteFechas.Text = "Reporte por Fechas";
            this.buttonReporteFechas.UseVisualStyleBackColor = false;
            this.buttonReporteFechas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonReporteFechas_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::FormulariosAlmacenes.Properties.Resources.logoCerrarSesion;
            this.pictureBox1.Location = new System.Drawing.Point(493, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // labelAlmacen
            // 
            this.labelAlmacen.AutoSize = true;
            this.labelAlmacen.BackColor = System.Drawing.Color.Transparent;
            this.labelAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.labelAlmacen.Location = new System.Drawing.Point(480, 422);
            this.labelAlmacen.Name = "labelAlmacen";
            this.labelAlmacen.Size = new System.Drawing.Size(95, 25);
            this.labelAlmacen.TabIndex = 13;
            this.labelAlmacen.Text = "Almacen";
            // 
            // PantallaUsuarioAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(179)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(602, 450);
            this.Controls.Add(this.labelAlmacen);
            this.Controls.Add(this.buttonReporteFechas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonRegPedidos);
            this.Controls.Add(this.buttonIngreso);
            this.Controls.Add(this.buttonStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelBienvenidaUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PantallaUsuarioAlmacen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PantallaUsuarioAlmacen_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBienvenidaUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStock;
        private System.Windows.Forms.Button buttonIngreso;
        private System.Windows.Forms.Button buttonRegPedidos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonReporteFechas;
        private System.Windows.Forms.Label labelAlmacen;
    }
}