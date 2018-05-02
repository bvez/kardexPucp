using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FormulariosAlmacenes
{
    public partial class PantallaProductosAlmacen : Form
    {
        
        public PantallaProductosAlmacen()
        {
            InitializeComponent();
            
        }

        //inicializacion con lista de productos
        public PantallaProductosAlmacen(Almacen almacen)
        {
            //BindingList<string> enteros = new BindingList<string>();
            InitializeComponent();
            tablaProductosAlmacen.AutoGenerateColumns = false;
            //tablaProductosAlmacen.DataSource = almacen.Productos;
            
        }

        //Lo que sucede cuando se cierra el formulario
        private void PantallaProductosAlmacen_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
