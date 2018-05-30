namespace FormulariosAlmacenes
{
    partial class PantallaAdministradorAlmacén
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaAdministradorAlmacén));
            this.btnActualizarAlmacenes = new System.Windows.Forms.Button();
            this.btnModificarStock = new System.Windows.Forms.Button();
            this.btnAddProducto = new System.Windows.Forms.Button();
            this.btnProductosDisponibl = new System.Windows.Forms.Button();
            this.labelBienvenidaAdmin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizarAlmacenes
            // 
            this.btnActualizarAlmacenes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnActualizarAlmacenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarAlmacenes.ForeColor = System.Drawing.Color.Black;
            this.btnActualizarAlmacenes.Location = new System.Drawing.Point(40, 103);
            this.btnActualizarAlmacenes.Name = "btnActualizarAlmacenes";
            this.btnActualizarAlmacenes.Size = new System.Drawing.Size(190, 80);
            this.btnActualizarAlmacenes.TabIndex = 0;
            this.btnActualizarAlmacenes.Text = "Actualizar Almacenes";
            this.btnActualizarAlmacenes.UseVisualStyleBackColor = false;
            this.btnActualizarAlmacenes.Click += new System.EventHandler(this.btnActualizarAlmacenes_Click);
            // 
            // btnModificarStock
            // 
            this.btnModificarStock.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModificarStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarStock.ForeColor = System.Drawing.Color.Black;
            this.btnModificarStock.Location = new System.Drawing.Point(40, 204);
            this.btnModificarStock.Name = "btnModificarStock";
            this.btnModificarStock.Size = new System.Drawing.Size(190, 80);
            this.btnModificarStock.TabIndex = 1;
            this.btnModificarStock.Text = "Modificar Stock de Almacén";
            this.btnModificarStock.UseVisualStyleBackColor = false;
            this.btnModificarStock.Click += new System.EventHandler(this.btnModificarStock_Click);
            this.btnModificarStock.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnModificarStock_MouseClick);
            // 
            // btnAddProducto
            // 
            this.btnAddProducto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProducto.ForeColor = System.Drawing.Color.Black;
            this.btnAddProducto.Location = new System.Drawing.Point(275, 103);
            this.btnAddProducto.Name = "btnAddProducto";
            this.btnAddProducto.Size = new System.Drawing.Size(190, 80);
            this.btnAddProducto.TabIndex = 2;
            this.btnAddProducto.Text = "Añadir Producto a Almacén";
            this.btnAddProducto.UseVisualStyleBackColor = false;
            this.btnAddProducto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnAnadirProducto_MouseClick);
            // 
            // btnProductosDisponibl
            // 
            this.btnProductosDisponibl.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnProductosDisponibl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnProductosDisponibl.ForeColor = System.Drawing.Color.Black;
            this.btnProductosDisponibl.Location = new System.Drawing.Point(275, 204);
            this.btnProductosDisponibl.Name = "btnProductosDisponibl";
            this.btnProductosDisponibl.Size = new System.Drawing.Size(190, 80);
            this.btnProductosDisponibl.TabIndex = 3;
            this.btnProductosDisponibl.Text = "Disponibilidad de Productos";
            this.btnProductosDisponibl.UseVisualStyleBackColor = false;
            this.btnProductosDisponibl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnProductosDisponibles_MouseClick);
            // 
            // labelBienvenidaAdmin
            // 
            this.labelBienvenidaAdmin.AutoSize = true;
            this.labelBienvenidaAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelBienvenidaAdmin.ForeColor = System.Drawing.Color.Black;
            this.labelBienvenidaAdmin.Location = new System.Drawing.Point(12, 12);
            this.labelBienvenidaAdmin.Name = "labelBienvenidaAdmin";
            this.labelBienvenidaAdmin.Size = new System.Drawing.Size(155, 31);
            this.labelBienvenidaAdmin.TabIndex = 4;
            this.labelBienvenidaAdmin.Text = "Bienvenido ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleccione una opción:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(159, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 83);
            this.button1.TabIndex = 8;
            this.button1.Text = "Reporte por fechas";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::FormulariosAlmacenes.Properties.Resources.logoCerrarSesion;
            this.pictureBox1.Location = new System.Drawing.Point(410, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(82, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // PantallaAdministradorAlmacén
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(179)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(504, 397);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelBienvenidaAdmin);
            this.Controls.Add(this.btnProductosDisponibl);
            this.Controls.Add(this.btnAddProducto);
            this.Controls.Add(this.btnModificarStock);
            this.Controls.Add(this.btnActualizarAlmacenes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PantallaAdministradorAlmacén";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de Almacén";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PantallaAdministradorAlmacén_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnActualizarAlmacenes;
        private System.Windows.Forms.Button btnModificarStock;
        private System.Windows.Forms.Button btnAddProducto;
        private System.Windows.Forms.Button btnProductosDisponibl;
        private System.Windows.Forms.Label labelBienvenidaAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}