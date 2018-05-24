namespace Ventas
{
    partial class Form12BuscaCliente
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
            this.dG_Naturales = new System.Windows.Forms.DataGridView();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_conf_busc = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dG_Juridicos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dG_Naturales)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dG_Juridicos)).BeginInit();
            this.SuspendLayout();
            // 
            // label_ModifVenta
            // 
            this.label_ModifVenta.AutoSize = true;
            this.label_ModifVenta.Location = new System.Drawing.Point(6, 3);
            this.label_ModifVenta.Name = "label_ModifVenta";
            this.label_ModifVenta.Size = new System.Drawing.Size(174, 17);
            this.label_ModifVenta.TabIndex = 4;
            this.label_ModifVenta.Text = "Selecciona Cliente Natural";
            // 
            // dG_Naturales
            // 
            this.dG_Naturales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dG_Naturales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this._nombre});
            this.dG_Naturales.Location = new System.Drawing.Point(6, 23);
            this.dG_Naturales.Name = "dG_Naturales";
            this.dG_Naturales.RowTemplate.Height = 24;
            this.dG_Naturales.Size = new System.Drawing.Size(470, 217);
            this.dG_Naturales.TabIndex = 3;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(427, 294);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 15;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_conf_busc
            // 
            this.btn_conf_busc.Location = new System.Drawing.Point(12, 294);
            this.btn_conf_busc.Name = "btn_conf_busc";
            this.btn_conf_busc.Size = new System.Drawing.Size(80, 23);
            this.btn_conf_busc.TabIndex = 14;
            this.btn_conf_busc.Text = "Confirmar";
            this.btn_conf_busc.UseVisualStyleBackColor = true;
            this.btn_conf_busc.Click += new System.EventHandler(this.btn_conf_busc_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(490, 275);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dG_Naturales);
            this.tabPage1.Controls.Add(this.label_ModifVenta);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(482, 246);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cliente Natural";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dG_Juridicos);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(482, 246);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cliente Jurídico";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selecciona Cliente Natural";
            // 
            // dG_Juridicos
            // 
            this.dG_Juridicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dG_Juridicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dG_Juridicos.Location = new System.Drawing.Point(6, 23);
            this.dG_Juridicos.Name = "dG_Juridicos";
            this.dG_Juridicos.RowTemplate.Height = 24;
            this.dG_Juridicos.Size = new System.Drawing.Size(470, 217);
            this.dG_Juridicos.TabIndex = 4;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // _nombre
            // 
            this._nombre.DataPropertyName = "nombre";
            this._nombre.HeaderText = "Nombre";
            this._nombre.Name = "_nombre";
            this._nombre.ReadOnly = true;
            this._nombre.Width = 200;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // Form12BuscaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 329);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_conf_busc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form12BuscaCliente";
            this.Text = "Busca Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dG_Naturales)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dG_Juridicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_ModifVenta;
        private System.Windows.Forms.DataGridView dG_Naturales;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_conf_busc;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dG_Juridicos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn _nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}