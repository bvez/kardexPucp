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
using LogicaNegocios;

namespace FormulariosAlmacenes.VistasAlmacen
{
    public partial class PantallaIngresosSalidasProducto : Form
    {
        private int idAlmacen;
        private BindingList<ProductoAlmacen> listaProductos = null;
        private AlmacenesBL logicaAlmacenes = null;
        public PantallaIngresosSalidasProducto()
        {
            InitializeComponent();
            listaProductos = new BindingList<ProductoAlmacen>();
            dataGridIngresoSalida.AutoGenerateColumns = false;
            dataGridIngresoSalida.DataSource = listaProductos;
        }

        public PantallaIngresosSalidasProducto(int idAlmacen)
        {
            InitializeComponent();
            radioBtnEnvios.Checked = true;
            this.idAlmacen = idAlmacen;
            listaProductos = new BindingList<ProductoAlmacen>();
            logicaAlmacenes = new AlmacenesBL();

            dataGridIngresoSalida.AutoGenerateColumns = false;
            dataGridIngresoSalida.DataSource = listaProductos;
            

            Almacen almacenActual = logicaAlmacenes.obtenerAlmacen(idAlmacen);

            comboBoxEnvios.DataSource = logicaAlmacenes.obtenerEnviosPendientesAlmacen(idAlmacen);
            comboBoxAreas.DataSource = logicaAlmacenes.obtenerAreas();
            comboBoxAreas2.DataSource = logicaAlmacenes.obtenerAreas();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            
            this.Close();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            int cantidadPedidos = dataGridIngresoSalida.RowCount;

            if (cantidadPedidos > 0)
            {
                string mensajeConf = "Desea confirmar ";
                if (radioBtnIngreso.Checked)
                {
                    mensajeConf += "el ingreso de ";
                }
                else if (radioBtnSalida.Checked)
                {
                    mensajeConf += "la salida de ";
                }

                mensajeConf += cantidadPedidos.ToString() + " producto";
                if (cantidadPedidos > 1)
                {
                    mensajeConf += "s?";
                }

                DialogResult res = MessageBox.Show(mensajeConf, "Confirmacion", MessageBoxButtons.YesNo);

                if (res == DialogResult.Yes)
                {
                    bool valido = true;
                    bool resultado = true;
                    //validar todas las lineas
                    foreach (DataGridViewRow row in dataGridIngresoSalida.Rows)
                    {
                        int cantidadPedido;
                        ProductoAlmacen actual = (ProductoAlmacen)row.DataBoundItem;
                        if (row.Cells["Cantidad"].Value==null || !Int32.TryParse(row.Cells["Cantidad"].Value.ToString(), out cantidadPedido) || cantidadPedido>actual.CantidadAlmacenada)
                        {
                            MessageBox.Show("Ha insertado incorrectamente una cantidad", "Error");
                            dataGridIngresoSalida.CurrentCell = row.Cells["Cantidad"];
                            valido = false;
                            resultado = false;
                            break;
                        }
                    }

                    //registrar pedido ingreso o salida
                    
                    if (valido && radioBtnIngreso.Checked)
                    {
                        Sucursal localSeleccionado = (Sucursal)comboBoxLocales.SelectedItem;
                        int idAreaSeleccionada = ((Area)comboBoxAreas.SelectedItem).IdArea;
                        int idIngreso = logicaAlmacenes.registrarIngresoProductos(this.idAlmacen, idAreaSeleccionada,localSeleccionado.IdLocal, textBoxObservaciones.Text);
                        if (idIngreso > 0)
                        {
                            //registrar todas las lineas
                            int idLinea = 0;
                            foreach (DataGridViewRow row in dataGridIngresoSalida.Rows)
                            {
                                int cantidadPedido = Int32.Parse(row.Cells["Cantidad"].Value.ToString());
                                string observaciones;
                                if (row.Cells["Observaciones"].Value != null)
                                {
                                    observaciones = row.Cells["Observaciones"].Value.ToString();
                                }
                                else
                                {
                                    observaciones = "";
                                }

                                int idProducto = Int32.Parse(row.Cells["Id"].Value.ToString());

                                idLinea = logicaAlmacenes.registrarLineaIngresoProductos(idIngreso, idProducto, cantidadPedido, observaciones);
                                if (idLinea < 0)
                                {
                                    resultado = false;
                                    break;
                                    //ver la forma de regresar, puede ser con un rollback
                                }
                            }
                        }
                    }
                    else if (valido && radioBtnSalida.Checked)
                    {
                        Sucursal localSeleccionado = (Sucursal)comboBoxLocalSalida.SelectedItem;
                        int idAreaSeleccionada = ((Area)comboBoxAreas2.SelectedItem).IdArea;
                        int idSalida = logicaAlmacenes.registrarSalidaProductos(this.idAlmacen, idAreaSeleccionada,localSeleccionado.IdLocal,textBoxObservaciones.Text);
                        if(idSalida > 0)
                        {
                            //registrar todas las lineas
                            int idLinea = 0;
                            foreach (DataGridViewRow row in dataGridIngresoSalida.Rows)
                            {
                                int cantidadPedido = Int32.Parse(row.Cells["Cantidad"].Value.ToString());
                                string observaciones;
                                if (row.Cells["Observaciones"].Value != null)
                                {
                                    observaciones = row.Cells["Observaciones"].Value.ToString();
                                }
                                else
                                {
                                    observaciones = "";
                                }

                                int idProducto = Int32.Parse(row.Cells["Id"].Value.ToString());

                                idLinea = logicaAlmacenes.registrarLineaSalidaProductos(idSalida, idProducto, cantidadPedido, observaciones);
                                if (idLinea < 0)
                                {
                                    resultado = false;
                                    break;
                                    //ver la forma de regresar, puede ser con un rollback
                                }
                            }
                        }
                    }
                    if (valido && resultado)
                    {
                        MessageBox.Show("Transaccion Exitosa", "Exito");
                        this.dataGridIngresoSalida.DataSource = null;
                        dataGridIngresoSalida.Refresh();
                        dataGridIngresoSalida.Update();
                    }
                    else if(valido && !resultado)
                    {
                        MessageBox.Show("Hubo un error al registrar el ingreso/salida. Reinténtelo en un momento.", "Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe registrar mínimo un ingreso/salida", "Error");
            }
            
        }

        private void radioBtnIngreso_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnIngreso.Checked) {
                labelAlmacen.Visible = false;
                comboBoxLocalSalida.Visible = false;
                comboBoxAreas2.Visible = false;

                groupBox3.Visible = true;
                label1.Text = "Observaciones en el ingreso:";
            }
            
        }

        private void radioBtnSalida_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnSalida.Checked)
            {
                groupBox3.Visible = false;

                groupBox1.Enabled = true;
                comboBoxAreas2.Visible = true;
                labelAlmacen.Visible = true;
                comboBoxLocalSalida.Visible = true;
                label1.Text = "Observaciones en la salida:";
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            /*Mostrar los productos */
            ProductoAlmacen nuevoProducto;
            PantallaSeleccionarProducto newPant = new PantallaSeleccionarProducto(this.idAlmacen);
            newPant.ShowDialog();
            nuevoProducto = newPant.ProductoSeleccionado;
            if (nuevoProducto != null)
            {
                ((BindingList<ProductoAlmacen>)dataGridIngresoSalida.DataSource).Add(nuevoProducto);
                dataGridIngresoSalida.Refresh();
                dataGridIngresoSalida.Update();
            }
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (dataGridIngresoSalida.CurrentRow != null)
            {
                ProductoAlmacen productoSeleccionado = (ProductoAlmacen)dataGridIngresoSalida.CurrentRow.DataBoundItem;
                BindingList<ProductoAlmacen> lista = (BindingList<ProductoAlmacen>)dataGridIngresoSalida.DataSource;
                lista.Remove(productoSeleccionado);
                dataGridIngresoSalida.Refresh();
                dataGridIngresoSalida.Update();
            }
        }

        private void PantallaIngresosSalidasProducto_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (dataGridIngresoSalida.RowCount > 0)
            {
                DialogResult res = MessageBox.Show("Desea salir y eliminar los cambios?", "Confirmación", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    this.Dispose();
                }
            }
            else
            {
                this.Dispose();
            }
        }

        private void radioBtnEnvios_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnEnvios.Checked)
            {
                comboBoxLocales.Enabled = false;
                comboBoxAreas.Enabled = false;
                comboBoxEnvios.Enabled = true;
                

                if(comboBoxEnvios.SelectedItem != null)
                {
                    IngresoSalidaProducto salida = (IngresoSalidaProducto)comboBoxEnvios.SelectedItem;
                    dataGridIngresoSalida.DataSource = logicaAlmacenes.obtenerProductosSalida(salida.IdIngresoSalidaProducto);
                    dataGridIngresoSalida.Refresh();
                    dataGridIngresoSalida.Update();
                }

                //dataGridIngresoSalida.ClearSelection();
                bloquearTabla();

            }
        }

        private void radioBtnLocal_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnLocal.Checked)
            {
                comboBoxEnvios.Enabled = false;
                comboBoxLocales.Enabled = true;
                comboBoxAreas.Enabled = true;
                dataGridIngresoSalida.Enabled = true;
            }
            desbloquearTabla();
        }

        private void bloquearTabla()
        {
            groupBox1.Enabled = false;
        }

        private void desbloquearTabla()
        {
            groupBox1.Enabled = true;
        }

        private void comboBoxAreas_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBoxLocales.DataSource = ;
        }

        private void comboBoxAreas2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBoxLocalSalida.DataSource = ;
        }
    }
}
