using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ventas
{
    public partial class Form10EmitirReporteCl : Form
    {
        private string filePath = string.Empty;

        public Form10EmitirReporteCl()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_folder_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog1.ShowNewFolderButton = true;
            DialogResult result = this.folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                filePath = this.folderBrowserDialog1.SelectedPath;
            }
        }

        private void btn_genera_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El reporte ha sido generado en la dirección especificada", "Emitir Reporte", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
