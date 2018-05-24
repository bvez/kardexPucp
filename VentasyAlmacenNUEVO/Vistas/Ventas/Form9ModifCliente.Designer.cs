namespace Ventas
{
    partial class Form9ModifCliente
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
            this.label_ModifReg = new System.Windows.Forms.Label();
            this.dG_ModifVentas = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab1Juridica = new System.Windows.Forms.TabPage();
            this.label_giroNeg = new System.Windows.Forms.Label();
            this.tB_giroNegocio = new System.Windows.Forms.TextBox();
            this.label_ruc = new System.Windows.Forms.Label();
            this.mtB_RUC = new System.Windows.Forms.MaskedTextBox();
            this.tB_RazSoc = new System.Windows.Forms.TextBox();
            this.label_razon_social = new System.Windows.Forms.Label();
            this.tab2Natural = new System.Windows.Forms.TabPage();
            this.rB_M = new System.Windows.Forms.RadioButton();
            this.rB_H = new System.Windows.Forms.RadioButton();
            this.label1_Sexo = new System.Windows.Forms.Label();
            this.mTB_DNI = new System.Windows.Forms.MaskedTextBox();
            this.label_dni = new System.Windows.Forms.Label();
            this.labelapm = new System.Windows.Forms.Label();
            this.label_app = new System.Windows.Forms.Label();
            this.label_Nomb = new System.Windows.Forms.Label();
            this.tB_ApM = new System.Windows.Forms.TextBox();
            this.tB_ApP = new System.Windows.Forms.TextBox();
            this.tB_Nombres = new System.Windows.Forms.TextBox();
            this.label_Datos = new System.Windows.Forms.Label();
            this.label_correo = new System.Windows.Forms.Label();
            this.label_tlfn = new System.Windows.Forms.Label();
            this.label_direccion = new System.Windows.Forms.Label();
            this.tB_correo = new System.Windows.Forms.MaskedTextBox();
            this.tB_Nro = new System.Windows.Forms.MaskedTextBox();
            this.tB_Dir = new System.Windows.Forms.TextBox();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dG_ModifVentas)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tab1Juridica.SuspendLayout();
            this.tab2Natural.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_ModifReg
            // 
            this.label_ModifReg.AutoSize = true;
            this.label_ModifReg.Location = new System.Drawing.Point(12, 13);
            this.label_ModifReg.Name = "label_ModifReg";
            this.label_ModifReg.Size = new System.Drawing.Size(207, 17);
            this.label_ModifReg.TabIndex = 4;
            this.label_ModifReg.Text = "Selecciona Registro a Modificar";
            // 
            // dG_ModifVentas
            // 
            this.dG_ModifVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dG_ModifVentas.Location = new System.Drawing.Point(12, 33);
            this.dG_ModifVentas.Name = "dG_ModifVentas";
            this.dG_ModifVentas.RowTemplate.Height = 24;
            this.dG_ModifVentas.Size = new System.Drawing.Size(446, 148);
            this.dG_ModifVentas.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab1Juridica);
            this.tabControl1.Controls.Add(this.tab2Natural);
            this.tabControl1.Location = new System.Drawing.Point(12, 217);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(446, 187);
            this.tabControl1.TabIndex = 5;
            // 
            // tab1Juridica
            // 
            this.tab1Juridica.Controls.Add(this.label_giroNeg);
            this.tab1Juridica.Controls.Add(this.tB_giroNegocio);
            this.tab1Juridica.Controls.Add(this.label_ruc);
            this.tab1Juridica.Controls.Add(this.mtB_RUC);
            this.tab1Juridica.Controls.Add(this.tB_RazSoc);
            this.tab1Juridica.Controls.Add(this.label_razon_social);
            this.tab1Juridica.Location = new System.Drawing.Point(4, 25);
            this.tab1Juridica.Name = "tab1Juridica";
            this.tab1Juridica.Padding = new System.Windows.Forms.Padding(3);
            this.tab1Juridica.Size = new System.Drawing.Size(438, 158);
            this.tab1Juridica.TabIndex = 0;
            this.tab1Juridica.Text = "Persona Jurídica";
            this.tab1Juridica.UseVisualStyleBackColor = true;
            // 
            // label_giroNeg
            // 
            this.label_giroNeg.AutoSize = true;
            this.label_giroNeg.Location = new System.Drawing.Point(7, 65);
            this.label_giroNeg.Name = "label_giroNeg";
            this.label_giroNeg.Size = new System.Drawing.Size(114, 17);
            this.label_giroNeg.TabIndex = 5;
            this.label_giroNeg.Text = "Giro del Negocio";
            // 
            // tB_giroNegocio
            // 
            this.tB_giroNegocio.Location = new System.Drawing.Point(127, 65);
            this.tB_giroNegocio.Name = "tB_giroNegocio";
            this.tB_giroNegocio.Size = new System.Drawing.Size(309, 22);
            this.tB_giroNegocio.TabIndex = 4;
            // 
            // label_ruc
            // 
            this.label_ruc.AutoSize = true;
            this.label_ruc.Location = new System.Drawing.Point(9, 36);
            this.label_ruc.Name = "label_ruc";
            this.label_ruc.Size = new System.Drawing.Size(37, 17);
            this.label_ruc.TabIndex = 3;
            this.label_ruc.Text = "RUC";
            // 
            // mtB_RUC
            // 
            this.mtB_RUC.Location = new System.Drawing.Point(127, 36);
            this.mtB_RUC.Name = "mtB_RUC";
            this.mtB_RUC.Size = new System.Drawing.Size(309, 22);
            this.mtB_RUC.TabIndex = 2;
            // 
            // tB_RazSoc
            // 
            this.tB_RazSoc.Location = new System.Drawing.Point(127, 7);
            this.tB_RazSoc.Name = "tB_RazSoc";
            this.tB_RazSoc.Size = new System.Drawing.Size(309, 22);
            this.tB_RazSoc.TabIndex = 1;
            // 
            // label_razon_social
            // 
            this.label_razon_social.AutoSize = true;
            this.label_razon_social.Location = new System.Drawing.Point(6, 7);
            this.label_razon_social.Name = "label_razon_social";
            this.label_razon_social.Size = new System.Drawing.Size(91, 17);
            this.label_razon_social.TabIndex = 0;
            this.label_razon_social.Text = "Razón Social";
            // 
            // tab2Natural
            // 
            this.tab2Natural.Controls.Add(this.rB_M);
            this.tab2Natural.Controls.Add(this.rB_H);
            this.tab2Natural.Controls.Add(this.label1_Sexo);
            this.tab2Natural.Controls.Add(this.mTB_DNI);
            this.tab2Natural.Controls.Add(this.label_dni);
            this.tab2Natural.Controls.Add(this.labelapm);
            this.tab2Natural.Controls.Add(this.label_app);
            this.tab2Natural.Controls.Add(this.label_Nomb);
            this.tab2Natural.Controls.Add(this.tB_ApM);
            this.tab2Natural.Controls.Add(this.tB_ApP);
            this.tab2Natural.Controls.Add(this.tB_Nombres);
            this.tab2Natural.Location = new System.Drawing.Point(4, 25);
            this.tab2Natural.Name = "tab2Natural";
            this.tab2Natural.Padding = new System.Windows.Forms.Padding(3);
            this.tab2Natural.Size = new System.Drawing.Size(438, 158);
            this.tab2Natural.TabIndex = 1;
            this.tab2Natural.Text = "Persona Natural";
            this.tab2Natural.UseVisualStyleBackColor = true;
            // 
            // rB_M
            // 
            this.rB_M.AutoSize = true;
            this.rB_M.Location = new System.Drawing.Point(245, 123);
            this.rB_M.Name = "rB_M";
            this.rB_M.Size = new System.Drawing.Size(64, 21);
            this.rB_M.TabIndex = 10;
            this.rB_M.TabStop = true;
            this.rB_M.Text = "Mujer";
            this.rB_M.UseVisualStyleBackColor = true;
            // 
            // rB_H
            // 
            this.rB_H.AutoSize = true;
            this.rB_H.Location = new System.Drawing.Point(160, 123);
            this.rB_H.Name = "rB_H";
            this.rB_H.Size = new System.Drawing.Size(79, 21);
            this.rB_H.TabIndex = 9;
            this.rB_H.TabStop = true;
            this.rB_H.Text = "Hombre";
            this.rB_H.UseVisualStyleBackColor = true;
            // 
            // label1_Sexo
            // 
            this.label1_Sexo.AutoSize = true;
            this.label1_Sexo.Location = new System.Drawing.Point(10, 125);
            this.label1_Sexo.Name = "label1_Sexo";
            this.label1_Sexo.Size = new System.Drawing.Size(39, 17);
            this.label1_Sexo.TabIndex = 8;
            this.label1_Sexo.Text = "Sexo";
            // 
            // mTB_DNI
            // 
            this.mTB_DNI.Location = new System.Drawing.Point(160, 94);
            this.mTB_DNI.Name = "mTB_DNI";
            this.mTB_DNI.Size = new System.Drawing.Size(276, 22);
            this.mTB_DNI.TabIndex = 7;
            // 
            // label_dni
            // 
            this.label_dni.AutoSize = true;
            this.label_dni.Location = new System.Drawing.Point(10, 97);
            this.label_dni.Name = "label_dni";
            this.label_dni.Size = new System.Drawing.Size(31, 17);
            this.label_dni.TabIndex = 6;
            this.label_dni.Text = "DNI";
            // 
            // labelapm
            // 
            this.labelapm.AutoSize = true;
            this.labelapm.Location = new System.Drawing.Point(10, 68);
            this.labelapm.Name = "labelapm";
            this.labelapm.Size = new System.Drawing.Size(114, 17);
            this.labelapm.TabIndex = 5;
            this.labelapm.Text = "Apellido Materno";
            // 
            // label_app
            // 
            this.label_app.AutoSize = true;
            this.label_app.Location = new System.Drawing.Point(10, 39);
            this.label_app.Name = "label_app";
            this.label_app.Size = new System.Drawing.Size(112, 17);
            this.label_app.TabIndex = 4;
            this.label_app.Text = "Apellido Paterno";
            // 
            // label_Nomb
            // 
            this.label_Nomb.AutoSize = true;
            this.label_Nomb.Location = new System.Drawing.Point(10, 10);
            this.label_Nomb.Name = "label_Nomb";
            this.label_Nomb.Size = new System.Drawing.Size(65, 17);
            this.label_Nomb.TabIndex = 3;
            this.label_Nomb.Text = "Nombres";
            // 
            // tB_ApM
            // 
            this.tB_ApM.Location = new System.Drawing.Point(160, 65);
            this.tB_ApM.Name = "tB_ApM";
            this.tB_ApM.Size = new System.Drawing.Size(276, 22);
            this.tB_ApM.TabIndex = 2;
            // 
            // tB_ApP
            // 
            this.tB_ApP.Location = new System.Drawing.Point(160, 36);
            this.tB_ApP.Name = "tB_ApP";
            this.tB_ApP.Size = new System.Drawing.Size(276, 22);
            this.tB_ApP.TabIndex = 1;
            // 
            // tB_Nombres
            // 
            this.tB_Nombres.Location = new System.Drawing.Point(160, 7);
            this.tB_Nombres.Name = "tB_Nombres";
            this.tB_Nombres.Size = new System.Drawing.Size(276, 22);
            this.tB_Nombres.TabIndex = 0;
            // 
            // label_Datos
            // 
            this.label_Datos.AutoSize = true;
            this.label_Datos.Location = new System.Drawing.Point(12, 194);
            this.label_Datos.Name = "label_Datos";
            this.label_Datos.Size = new System.Drawing.Size(194, 17);
            this.label_Datos.TabIndex = 6;
            this.label_Datos.Text = "Modificar los datos del cliente";
            // 
            // label_correo
            // 
            this.label_correo.AutoSize = true;
            this.label_correo.Location = new System.Drawing.Point(22, 472);
            this.label_correo.Name = "label_correo";
            this.label_correo.Size = new System.Drawing.Size(125, 17);
            this.label_correo.TabIndex = 12;
            this.label_correo.Text = "Correo Electrónico";
            // 
            // label_tlfn
            // 
            this.label_tlfn.AutoSize = true;
            this.label_tlfn.Location = new System.Drawing.Point(22, 442);
            this.label_tlfn.Name = "label_tlfn";
            this.label_tlfn.Size = new System.Drawing.Size(64, 17);
            this.label_tlfn.TabIndex = 11;
            this.label_tlfn.Text = "Teléfono";
            // 
            // label_direccion
            // 
            this.label_direccion.AutoSize = true;
            this.label_direccion.Location = new System.Drawing.Point(22, 414);
            this.label_direccion.Name = "label_direccion";
            this.label_direccion.Size = new System.Drawing.Size(67, 17);
            this.label_direccion.TabIndex = 10;
            this.label_direccion.Text = "Dirección";
            // 
            // tB_correo
            // 
            this.tB_correo.Location = new System.Drawing.Point(156, 469);
            this.tB_correo.Name = "tB_correo";
            this.tB_correo.Size = new System.Drawing.Size(292, 22);
            this.tB_correo.TabIndex = 9;
            // 
            // tB_Nro
            // 
            this.tB_Nro.Location = new System.Drawing.Point(156, 439);
            this.tB_Nro.Name = "tB_Nro";
            this.tB_Nro.Size = new System.Drawing.Size(292, 22);
            this.tB_Nro.TabIndex = 8;
            // 
            // tB_Dir
            // 
            this.tB_Dir.Location = new System.Drawing.Point(156, 411);
            this.tB_Dir.Name = "tB_Dir";
            this.tB_Dir.Size = new System.Drawing.Size(292, 22);
            this.tB_Dir.TabIndex = 7;
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.Location = new System.Drawing.Point(16, 507);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(110, 30);
            this.btn_Registrar.TabIndex = 14;
            this.btn_Registrar.Text = "Registrar";
            this.btn_Registrar.UseVisualStyleBackColor = true;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(348, 507);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(110, 30);
            this.btn_Cancelar.TabIndex = 13;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // Form9ModifCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 549);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.label_correo);
            this.Controls.Add(this.label_tlfn);
            this.Controls.Add(this.label_direccion);
            this.Controls.Add(this.tB_correo);
            this.Controls.Add(this.tB_Nro);
            this.Controls.Add(this.tB_Dir);
            this.Controls.Add(this.label_Datos);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label_ModifReg);
            this.Controls.Add(this.dG_ModifVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form9ModifCliente";
            this.Text = "Modificar Registro de Cliente";
            ((System.ComponentModel.ISupportInitialize)(this.dG_ModifVentas)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tab1Juridica.ResumeLayout(false);
            this.tab1Juridica.PerformLayout();
            this.tab2Natural.ResumeLayout(false);
            this.tab2Natural.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ModifReg;
        private System.Windows.Forms.DataGridView dG_ModifVentas;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab1Juridica;
        private System.Windows.Forms.Label label_giroNeg;
        private System.Windows.Forms.TextBox tB_giroNegocio;
        private System.Windows.Forms.Label label_ruc;
        private System.Windows.Forms.MaskedTextBox mtB_RUC;
        private System.Windows.Forms.TextBox tB_RazSoc;
        private System.Windows.Forms.Label label_razon_social;
        private System.Windows.Forms.TabPage tab2Natural;
        private System.Windows.Forms.RadioButton rB_M;
        private System.Windows.Forms.RadioButton rB_H;
        private System.Windows.Forms.Label label1_Sexo;
        private System.Windows.Forms.MaskedTextBox mTB_DNI;
        private System.Windows.Forms.Label label_dni;
        private System.Windows.Forms.Label labelapm;
        private System.Windows.Forms.Label label_app;
        private System.Windows.Forms.Label label_Nomb;
        private System.Windows.Forms.TextBox tB_ApM;
        private System.Windows.Forms.TextBox tB_ApP;
        private System.Windows.Forms.TextBox tB_Nombres;
        private System.Windows.Forms.Label label_Datos;
        private System.Windows.Forms.Label label_correo;
        private System.Windows.Forms.Label label_tlfn;
        private System.Windows.Forms.Label label_direccion;
        private System.Windows.Forms.MaskedTextBox tB_correo;
        private System.Windows.Forms.MaskedTextBox tB_Nro;
        private System.Windows.Forms.TextBox tB_Dir;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}