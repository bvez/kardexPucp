using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Entidades;
using LogicaNegocios.Ventas;

namespace Ventas
{
    public partial class Form3EmitirReporte : Form
    {
        private string filePath = string.Empty;
        private VentasVentaBL logicaNegocios;

        public Form3EmitirReporte()
        {
            InitializeComponent();
            logicaNegocios = new VentasVentaBL();
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
            if (filePath != String.Empty)
            {
                string fileName = "reporte.txt";
                string pathString = System.IO.Path.Combine(filePath, fileName);
                //BindingList<Venta> ventas = logicaNegocios.listarVentas();
                Venta v1 = new Venta(1, DateTime.Today);
                Venta v2 = new Venta(2, DateTime.Today);
                Venta v3 = new Venta(3, DateTime.Today);
                Venta v4 = new Venta(4, DateTime.Today);
                Venta v5 = new Venta(5, DateTime.Today);
                BindingList<Venta> ventas = new BindingList<Venta>();
                ventas.Add(v1);
                ventas.Add(v2);
                ventas.Add(v3);
                ventas.Add(v4);
                ventas.Add(v5);
                System.IO.File.Create(pathString);
                FileStream archivo = new FileStream(pathString, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(archivo);
                if  (rB_historico.Checked == true)
                {
                    foreach (Venta v in ventas)
                    {
                        sw.WriteLine(v);
                    }
                } else
                {
                    foreach (Venta v in ventas)
                    {
                        if ((DateTime.Compare(v.FechaRegistro, dateTimePicker1.Value) > 0) && (DateTime.Compare(v.FechaRegistro, dateTimePicker1.Value) < 0))
                        {
                            sw.WriteLine(v);
                        }
                    }
                }
                sw.Close();
                archivo.Close();
                MessageBox.Show("El reporte ha sido generado en la dirección especificada", "Emitir Reporte", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else MessageBox.Show("Por favor, elija una dirección", "Emitir Reporte", MessageBoxButtons.OK, MessageBoxIcon.Stop);


        }

        private void rB_historico_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
        }

        private void rB_rangoFechas_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }
    }
}
