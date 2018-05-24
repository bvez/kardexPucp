﻿namespace FormulariosAlmacenes.VistasAlmacen
{
    partial class PantallaIngresosSalidasProducto
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
            this.label6 = new System.Windows.Forms.Label();
            this.radioBtnIngreso = new System.Windows.Forms.RadioButton();
            this.radioBtnSalida = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxLocales = new System.Windows.Forms.ComboBox();
            this.radioBtnLocal = new System.Windows.Forms.RadioButton();
            this.radioBtnEnvios = new System.Windows.Forms.RadioButton();
            this.comboBoxEnvios = new System.Windows.Forms.ComboBox();
            this.comboBoxAlmacenes = new System.Windows.Forms.ComboBox();
            this.labelAlmacen = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridIngresoSalida = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Observaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIngresoSalida)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(7, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 20);
            this.label6.TabIndex = 24;
            this.label6.Text = "Tipo de Movimiento: ";
            // 
            // radioBtnIngreso
            // 
            this.radioBtnIngreso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioBtnIngreso.AutoSize = true;
            this.radioBtnIngreso.Checked = true;
            this.radioBtnIngreso.Location = new System.Drawing.Point(167, 15);
            this.radioBtnIngreso.Name = "radioBtnIngreso";
            this.radioBtnIngreso.Size = new System.Drawing.Size(60, 17);
            this.radioBtnIngreso.TabIndex = 25;
            this.radioBtnIngreso.TabStop = true;
            this.radioBtnIngreso.Text = "Ingreso";
            this.radioBtnIngreso.UseVisualStyleBackColor = true;
            this.radioBtnIngreso.CheckedChanged += new System.EventHandler(this.radioBtnIngreso_CheckedChanged);
            // 
            // radioBtnSalida
            // 
            this.radioBtnSalida.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioBtnSalida.AutoSize = true;
            this.radioBtnSalida.Location = new System.Drawing.Point(246, 15);
            this.radioBtnSalida.Name = "radioBtnSalida";
            this.radioBtnSalida.Size = new System.Drawing.Size(54, 17);
            this.radioBtnSalida.TabIndex = 26;
            this.radioBtnSalida.Text = "Salida";
            this.radioBtnSalida.UseVisualStyleBackColor = true;
            this.radioBtnSalida.CheckedChanged += new System.EventHandler(this.radioBtnSalida_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioBtnIngreso);
            this.groupBox2.Controls.Add(this.radioBtnSalida);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(16, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 38);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.comboBoxAlmacenes);
            this.groupBox1.Controls.Add(this.labelAlmacen);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dataGridIngresoSalida);
            this.groupBox1.Location = new System.Drawing.Point(16, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(751, 398);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxLocales);
            this.groupBox3.Controls.Add(this.radioBtnLocal);
            this.groupBox3.Controls.Add(this.radioBtnEnvios);
            this.groupBox3.Controls.Add(this.comboBoxEnvios);
            this.groupBox3.Location = new System.Drawing.Point(313, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(410, 64);
            this.groupBox3.TabIndex = 37;
            this.groupBox3.TabStop = false;
            // 
            // comboBoxLocales
            // 
            this.comboBoxLocales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxLocales.FormattingEnabled = true;
            this.comboBoxLocales.Location = new System.Drawing.Point(179, 38);
            this.comboBoxLocales.Name = "comboBoxLocales";
            this.comboBoxLocales.Size = new System.Drawing.Size(207, 21);
            this.comboBoxLocales.TabIndex = 39;
            this.comboBoxLocales.Text = "Locales";
            // 
            // radioBtnLocal
            // 
            this.radioBtnLocal.AutoSize = true;
            this.radioBtnLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioBtnLocal.Location = new System.Drawing.Point(7, 34);
            this.radioBtnLocal.Name = "radioBtnLocal";
            this.radioBtnLocal.Size = new System.Drawing.Size(161, 24);
            this.radioBtnLocal.TabIndex = 38;
            this.radioBtnLocal.Text = "Ingreso indefinido: ";
            this.radioBtnLocal.UseVisualStyleBackColor = true;
            this.radioBtnLocal.CheckedChanged += new System.EventHandler(this.radioBtnLocal_CheckedChanged);
            // 
            // radioBtnEnvios
            // 
            this.radioBtnEnvios.AutoSize = true;
            this.radioBtnEnvios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioBtnEnvios.Location = new System.Drawing.Point(7, 11);
            this.radioBtnEnvios.Name = "radioBtnEnvios";
            this.radioBtnEnvios.Size = new System.Drawing.Size(166, 24);
            this.radioBtnEnvios.TabIndex = 37;
            this.radioBtnEnvios.Text = "Envíos Pendientes: ";
            this.radioBtnEnvios.UseVisualStyleBackColor = true;
            this.radioBtnEnvios.CheckedChanged += new System.EventHandler(this.radioBtnEnvios_CheckedChanged);
            // 
            // comboBoxEnvios
            // 
            this.comboBoxEnvios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxEnvios.FormattingEnabled = true;
            this.comboBoxEnvios.Location = new System.Drawing.Point(179, 15);
            this.comboBoxEnvios.Name = "comboBoxEnvios";
            this.comboBoxEnvios.Size = new System.Drawing.Size(207, 21);
            this.comboBoxEnvios.TabIndex = 35;
            this.comboBoxEnvios.Text = "Envios";
            // 
            // comboBoxAlmacenes
            // 
            this.comboBoxAlmacenes.FormattingEnabled = true;
            this.comboBoxAlmacenes.Location = new System.Drawing.Point(516, 22);
            this.comboBoxAlmacenes.Name = "comboBoxAlmacenes";
            this.comboBoxAlmacenes.Size = new System.Drawing.Size(207, 21);
            this.comboBoxAlmacenes.TabIndex = 36;
            this.comboBoxAlmacenes.Text = "Almacenes";
            this.comboBoxAlmacenes.Visible = false;
            // 
            // labelAlmacen
            // 
            this.labelAlmacen.AutoSize = true;
            this.labelAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelAlmacen.Location = new System.Drawing.Point(372, 22);
            this.labelAlmacen.Name = "labelAlmacen";
            this.labelAlmacen.Size = new System.Drawing.Size(138, 20);
            this.labelAlmacen.TabIndex = 35;
            this.labelAlmacen.Text = "Almacén Destino: ";
            this.labelAlmacen.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(66, 54);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(244, 25);
            this.toolStrip1.TabIndex = 32;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::FormulariosAlmacenes.Properties.Resources.btn_anadir_tiny;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(118, 22);
            this.toolStripButton1.Text = "Insertar Producto";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::FormulariosAlmacenes.Properties.Resources.btn_cross_tiny_colored;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(123, 22);
            this.toolStripButton2.Text = "Eliminar Selección";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(27, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Productos registrados: ";
            // 
            // dataGridIngresoSalida
            // 
            this.dataGridIngresoSalida.AllowUserToAddRows = false;
            this.dataGridIngresoSalida.AllowUserToDeleteRows = false;
            this.dataGridIngresoSalida.AllowUserToResizeColumns = false;
            this.dataGridIngresoSalida.AllowUserToResizeRows = false;
            this.dataGridIngresoSalida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridIngresoSalida.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridIngresoSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridIngresoSalida.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CodigoProducto,
            this.Nombre,
            this.Cantidad,
            this.Observaciones});
            this.dataGridIngresoSalida.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridIngresoSalida.Location = new System.Drawing.Point(66, 85);
            this.dataGridIngresoSalida.MultiSelect = false;
            this.dataGridIngresoSalida.Name = "dataGridIngresoSalida";
            this.dataGridIngresoSalida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridIngresoSalida.Size = new System.Drawing.Size(657, 300);
            this.dataGridIngresoSalida.TabIndex = 30;
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button2.Image = global::FormulariosAlmacenes.Properties.Resources.btn_cross_tiny_colored;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(671, 477);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 40);
            this.button2.TabIndex = 30;
            this.button2.Text = "Salir";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button2_MouseClick);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button1.Image = global::FormulariosAlmacenes.Properties.Resources.btn_Chk_tiny_colored;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(514, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 40);
            this.button1.TabIndex = 23;
            this.button1.Text = "Confirmar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 41;
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.DataPropertyName = "CodigoProducto";
            this.CodigoProducto.HeaderText = "Codigo";
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.ReadOnly = true;
            this.CodigoProducto.Width = 65;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 69;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MaxInputLength = 5;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 74;
            // 
            // Observaciones
            // 
            this.Observaciones.HeaderText = "Observaciones";
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.Width = 103;
            // 
            // PantallaIngresosSalidasProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 553);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Name = "PantallaIngresosSalidasProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PantallaIngresosSalidasProducto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PantallaIngresosSalidasProducto_FormClosed);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridIngresoSalida)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioBtnIngreso;
        private System.Windows.Forms.RadioButton radioBtnSalida;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridIngresoSalida;
        private System.Windows.Forms.ComboBox comboBoxAlmacenes;
        private System.Windows.Forms.Label labelAlmacen;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxLocales;
        private System.Windows.Forms.RadioButton radioBtnLocal;
        private System.Windows.Forms.RadioButton radioBtnEnvios;
        private System.Windows.Forms.ComboBox comboBoxEnvios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Observaciones;
    }
}