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
    public partial class Form8RegCliente : Form
    {
        public Form8RegCliente()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El cliente ha sido registrado exitosamente", "Registrar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
