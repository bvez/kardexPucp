﻿using System;
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
    public partial class PantallaRegIngresosProducto : Form
    {
        public PantallaRegIngresosProducto()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea confirmar el ingreso?", "Confirmacion", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                //productoAlmacenSeleccionado.CantidadAlmacenada = Int32.Parse(NumBoxStock.Value.ToString());
                dataGridStock.Update();
                dataGridStock.Refresh();
                MessageBox.Show("Se registró el ingreso correctamente", "Éxito");
            }
        }

        private void PantallaRegIngresosProducto_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Visible = true;
        }
    }
}
