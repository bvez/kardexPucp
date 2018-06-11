using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ventas;

namespace FormulariosAlmacenes
{
    public partial class PantallaInicio : Form
    {
        public PantallaInicio()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            LoginForm pant = new LoginForm();
            pant.Owner = this;
            this.Visible = false;
            pant.ShowDialog();
            pant.Dispose();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            FormularioPrincipal pant = new FormularioPrincipal();
            this.Visible = false;
            pant.Owner = this;
            pant.ShowDialog();
            pant.Dispose();
        }
    }
}
