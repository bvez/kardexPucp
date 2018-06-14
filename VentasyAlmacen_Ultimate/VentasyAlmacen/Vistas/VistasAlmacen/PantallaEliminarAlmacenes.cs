﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocios;
using Entidades;

namespace FormulariosAlmacenes
{
    public partial class PantallaEliminarAlmacenes : Form
    {
        AlmacenesBL logicaAlmacenes;
        public PantallaEliminarAlmacenes()
        {
            logicaAlmacenes = new AlmacenesBL();
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = logicaAlmacenes.obtenerAlmacenesTodos();
        }

        private void PantallaEliminarAlmacenes_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea confirmar la actualización?", "Confirmacion", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                //deshabilitar almacenes
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    Almacen almacenActual = (Almacen)row.DataBoundItem;
                    if(!logicaAlmacenes.actualizarAlmacenHabilitado(almacenActual.IdAlmacen, almacenActual.Habilitado))
                    {
                        MessageBox.Show("Error en la conexion con el servidor. Inténtelo nuevamente.", "Error");
                        return;
                    }
                }

                MessageBox.Show("Se han deshabilitado los almacenes satisfactoriamente", "Exito");
                this.Owner.Visible = true;
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea cerrar y perder los cambios?", "Confirmacion", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
