﻿namespace FormulariosAlmacenes
{
    partial class PantallaSeleccionarAlmacen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaSeleccionarAlmacen));
            this.DataGridSelectAlmacen = new System.Windows.Forms.DataGridView();
            this.IdAlmacen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectAlmacenSgte = new System.Windows.Forms.Button();
            this.btnSelectAlmacenAtras = new System.Windows.Forms.Button();
            this.nombreSelected = new System.Windows.Forms.Label();
            this.btnActualizarAlmacenes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSelectAlmacen)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridSelectAlmacen
            // 
            this.DataGridSelectAlmacen.AllowUserToAddRows = false;
            this.DataGridSelectAlmacen.AllowUserToDeleteRows = false;
            this.DataGridSelectAlmacen.AllowUserToOrderColumns = true;
            this.DataGridSelectAlmacen.AllowUserToResizeColumns = false;
            this.DataGridSelectAlmacen.AllowUserToResizeRows = false;
            this.DataGridSelectAlmacen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DataGridSelectAlmacen.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridSelectAlmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridSelectAlmacen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdAlmacen,
            this.Direccion,
            this.Telefono});
            this.DataGridSelectAlmacen.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGridSelectAlmacen.Location = new System.Drawing.Point(31, 42);
            this.DataGridSelectAlmacen.MultiSelect = false;
            this.DataGridSelectAlmacen.Name = "DataGridSelectAlmacen";
            this.DataGridSelectAlmacen.ReadOnly = true;
            this.DataGridSelectAlmacen.Size = new System.Drawing.Size(728, 321);
            this.DataGridSelectAlmacen.TabIndex = 0;
            // 
            // IdAlmacen
            // 
            this.IdAlmacen.DataPropertyName = "IdAlmacen";
            this.IdAlmacen.HeaderText = "Id de Almacen";
            this.IdAlmacen.Name = "IdAlmacen";
            this.IdAlmacen.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 77;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            this.Telefono.Width = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(28, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 100;
            this.label1.Text = "Seleccione el almacén:";
            // 
            // btnSelectAlmacenSgte
            // 
            this.btnSelectAlmacenSgte.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSelectAlmacenSgte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnSelectAlmacenSgte.Location = new System.Drawing.Point(486, 369);
            this.btnSelectAlmacenSgte.Name = "btnSelectAlmacenSgte";
            this.btnSelectAlmacenSgte.Size = new System.Drawing.Size(149, 61);
            this.btnSelectAlmacenSgte.TabIndex = 2;
            this.btnSelectAlmacenSgte.Text = "Seleccionar";
            this.btnSelectAlmacenSgte.UseVisualStyleBackColor = true;
            this.btnSelectAlmacenSgte.Click += new System.EventHandler(this.btnSelectAlmacenSgte_Click);
            // 
            // btnSelectAlmacenAtras
            // 
            this.btnSelectAlmacenAtras.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSelectAlmacenAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnSelectAlmacenAtras.Location = new System.Drawing.Point(654, 369);
            this.btnSelectAlmacenAtras.Name = "btnSelectAlmacenAtras";
            this.btnSelectAlmacenAtras.Size = new System.Drawing.Size(105, 61);
            this.btnSelectAlmacenAtras.TabIndex = 3;
            this.btnSelectAlmacenAtras.Text = "Atrás";
            this.btnSelectAlmacenAtras.UseVisualStyleBackColor = true;
            this.btnSelectAlmacenAtras.Click += new System.EventHandler(this.btnSelectAlmacenAtras_Click);
            // 
            // nombreSelected
            // 
            this.nombreSelected.AutoSize = true;
            this.nombreSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.nombreSelected.Location = new System.Drawing.Point(193, 381);
            this.nombreSelected.Name = "nombreSelected";
            this.nombreSelected.Size = new System.Drawing.Size(0, 25);
            this.nombreSelected.TabIndex = 4;
            // 
            // btnActualizarAlmacenes
            // 
            this.btnActualizarAlmacenes.BackColor = System.Drawing.Color.Transparent;
            this.btnActualizarAlmacenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarAlmacenes.ForeColor = System.Drawing.Color.Black;
            this.btnActualizarAlmacenes.Location = new System.Drawing.Point(31, 369);
            this.btnActualizarAlmacenes.Name = "btnActualizarAlmacenes";
            this.btnActualizarAlmacenes.Size = new System.Drawing.Size(239, 61);
            this.btnActualizarAlmacenes.TabIndex = 1;
            this.btnActualizarAlmacenes.Text = "Actualizar Almacenes";
            this.btnActualizarAlmacenes.UseVisualStyleBackColor = false;
            this.btnActualizarAlmacenes.Click += new System.EventHandler(this.btnActualizarAlmacenes_Click);
            // 
            // PantallaSeleccionarAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnActualizarAlmacenes);
            this.Controls.Add(this.nombreSelected);
            this.Controls.Add(this.btnSelectAlmacenAtras);
            this.Controls.Add(this.btnSelectAlmacenSgte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridSelectAlmacen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PantallaSeleccionarAlmacen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccionar Almacen";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSelectAlmacen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridSelectAlmacen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectAlmacenSgte;
        private System.Windows.Forms.Button btnSelectAlmacenAtras;

        private Entidades.Almacen almacenSeleccionado;
        private System.Windows.Forms.Label nombreSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdAlmacen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.Button btnActualizarAlmacenes;
    }
}