namespace FormulariosAlmacenes
{
    partial class PantallaActualizarAlmacenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaActualizarAlmacenes));
            this.btnInsertAlmacen = new System.Windows.Forms.Button();
            this.btnInhabilitarAlmacen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInsertAlmacen
            // 
            this.btnInsertAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnInsertAlmacen.Location = new System.Drawing.Point(50, 38);
            this.btnInsertAlmacen.Name = "btnInsertAlmacen";
            this.btnInsertAlmacen.Size = new System.Drawing.Size(217, 87);
            this.btnInsertAlmacen.TabIndex = 0;
            this.btnInsertAlmacen.Text = "Insertar Almacén";
            this.btnInsertAlmacen.UseVisualStyleBackColor = true;
            this.btnInsertAlmacen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnInsertAlmacen_MouseClick);
            // 
            // btnInhabilitarAlmacen
            // 
            this.btnInhabilitarAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnInhabilitarAlmacen.Location = new System.Drawing.Point(359, 38);
            this.btnInhabilitarAlmacen.Name = "btnInhabilitarAlmacen";
            this.btnInhabilitarAlmacen.Size = new System.Drawing.Size(211, 87);
            this.btnInhabilitarAlmacen.TabIndex = 1;
            this.btnInhabilitarAlmacen.Text = "Inhabilitar Almacén";
            this.btnInhabilitarAlmacen.UseVisualStyleBackColor = true;
            this.btnInhabilitarAlmacen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnInhabilitarAlmacen_MouseClick);
            // 
            // PantallaActualizarAlmacenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 156);
            this.Controls.Add(this.btnInhabilitarAlmacen);
            this.Controls.Add(this.btnInsertAlmacen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PantallaActualizarAlmacenes";
            this.Text = "Actualizar Almacenes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PantallaActualizarAlmacenes_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInsertAlmacen;
        private System.Windows.Forms.Button btnInhabilitarAlmacen;
    }
}