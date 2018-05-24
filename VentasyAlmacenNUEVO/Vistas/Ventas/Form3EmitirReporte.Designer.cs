namespace Ventas
{
    partial class Form3EmitirReporte
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
            this.rB_rangoFechas = new System.Windows.Forms.RadioButton();
            this.rB_historico = new System.Windows.Forms.RadioButton();
            this.label_fInicio = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_folder = new System.Windows.Forms.Button();
            this.btn_genera = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rB_rangoFechas
            // 
            this.rB_rangoFechas.AutoSize = true;
            this.rB_rangoFechas.Location = new System.Drawing.Point(12, 13);
            this.rB_rangoFechas.Name = "rB_rangoFechas";
            this.rB_rangoFechas.Size = new System.Drawing.Size(141, 21);
            this.rB_rangoFechas.TabIndex = 0;
            this.rB_rangoFechas.TabStop = true;
            this.rB_rangoFechas.Text = "Rango de Fechas";
            this.rB_rangoFechas.UseVisualStyleBackColor = true;
            this.rB_rangoFechas.CheckedChanged += new System.EventHandler(this.rB_rangoFechas_CheckedChanged);
            // 
            // rB_historico
            // 
            this.rB_historico.AutoSize = true;
            this.rB_historico.Location = new System.Drawing.Point(161, 13);
            this.rB_historico.Name = "rB_historico";
            this.rB_historico.Size = new System.Drawing.Size(139, 21);
            this.rB_historico.TabIndex = 1;
            this.rB_historico.TabStop = true;
            this.rB_historico.Text = "Reporte Histórico";
            this.rB_historico.UseVisualStyleBackColor = true;
            this.rB_historico.CheckedChanged += new System.EventHandler(this.rB_historico_CheckedChanged);
            // 
            // label_fInicio
            // 
            this.label_fInicio.AutoSize = true;
            this.label_fInicio.Location = new System.Drawing.Point(13, 41);
            this.label_fInicio.Name = "label_fInicio";
            this.label_fInicio.Size = new System.Drawing.Size(103, 17);
            this.label_fInicio.TabIndex = 2;
            this.label_fInicio.Text = "Fecha de Inicio";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(284, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha de Final";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(16, 111);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(284, 22);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Elige la carpeta en la que se generará el reporte";
            // 
            // btn_folder
            // 
            this.btn_folder.Location = new System.Drawing.Point(12, 145);
            this.btn_folder.Name = "btn_folder";
            this.btn_folder.Size = new System.Drawing.Size(288, 30);
            this.btn_folder.TabIndex = 6;
            this.btn_folder.Text = "Elegir carpeta de salida";
            this.btn_folder.UseVisualStyleBackColor = true;
            this.btn_folder.Click += new System.EventHandler(this.btn_folder_Click);
            // 
            // btn_genera
            // 
            this.btn_genera.Location = new System.Drawing.Point(12, 181);
            this.btn_genera.Name = "btn_genera";
            this.btn_genera.Size = new System.Drawing.Size(120, 45);
            this.btn_genera.TabIndex = 7;
            this.btn_genera.Text = "Generar Reporte...";
            this.btn_genera.UseVisualStyleBackColor = true;
            this.btn_genera.Click += new System.EventHandler(this.btn_genera_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(180, 181);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(120, 45);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Form3EmitirReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 238);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_genera);
            this.Controls.Add(this.btn_folder);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label_fInicio);
            this.Controls.Add(this.rB_historico);
            this.Controls.Add(this.rB_rangoFechas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form3EmitirReporte";
            this.Text = "Emitir Reportes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rB_rangoFechas;
        private System.Windows.Forms.RadioButton rB_historico;
        private System.Windows.Forms.Label label_fInicio;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_folder;
        private System.Windows.Forms.Button btn_genera;
        private System.Windows.Forms.Button btn_cancel;
    }
}