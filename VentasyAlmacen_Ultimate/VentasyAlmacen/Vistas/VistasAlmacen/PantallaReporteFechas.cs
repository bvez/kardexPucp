﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulariosAlmacenes.VistasAlmacen
{
    public partial class PantallaReporteFechas : Form
    {
        public PantallaReporteFechas()
        {
            InitializeComponent();
        }

        private void dateTimePickerInicial_ValueChanged(object sender, EventArgs e)
        {
            if(dateTimePickerInicial.Value > dateTimePickerFinal.Value)
            {
                dateTimePickerFinal.Value = dateTimePickerInicial.Value;
            }
        }

        private void dateTimePickerFinal_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerFinal.Value < dateTimePickerInicial.Value)
            {
                dateTimePickerInicial.Value = dateTimePickerFinal.Value;
            }
        }

        private void PantallaReporteFechas_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Visible = true;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("El reporte se generó satisfactoriamente", "Reporte generado");
            this.Close();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            PantallaVistaPreviaReporte newPant = new PantallaVistaPreviaReporte();
            newPant.ShowDialog();
        }
    }
}