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
    public partial class Form9ModifCliente : Form
    {
        public Form9ModifCliente()
        {
            InitializeComponent();
            tab2Natural.Enabled = false;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La venta ha sido modificada exitosamente", "Modificar Venta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
