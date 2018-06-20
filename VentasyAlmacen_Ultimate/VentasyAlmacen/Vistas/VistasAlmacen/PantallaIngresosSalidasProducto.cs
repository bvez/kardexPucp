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
        private BindingList<Almacen> listaAlmacenes = null;
        //private bool posibleEnvioPendiente = false;
        //faltan locales de venta y produccion

        public PantallaIngresosSalidasProducto()
        {
            InitializeComponent();
            listaProductos = new BindingList<ProductoAlmacen>();
            dataGridIngresoSalida.AutoGenerateColumns = false;
            dataGridIngresoSalida.DataSource = listaProductos;
        }

        public PantallaIngresosSalidasProducto(int idAlmacen)
        {
            //BindingList<IngresoSalidaProducto> listaEnviosPendientes;

            InitializeComponent();
            //radioBtnEnvios.Checked = true;
            this.idAlmacen = idAlmacen;
            listaProductos = new BindingList<ProductoAlmacen>();
            logicaAlmacenes = new AlmacenesBL();

            dataGridIngresoSalida.AutoGenerateColumns = false;
            dataGridIngresoSalida.DataSource = listaProductos;
            

            Almacen almacenActual = logicaAlmacenes.obtenerAlmacen(idAlmacen);

            /*

            listaEnviosPendientes = logicaAlmacenes.obtenerEnviosPendientesAlmacen(idAlmacen);
            
            if (listaEnviosPendientes != null && listaEnviosPendientes.Count>0)
            {
                comboBoxEnvios.DataSource = listaEnviosPendientes;
                posibleEnvioPendiente = true;
            }
            else
            {
                comboBoxEnvios.Text = "No hay envíos pendientes";
                comboBoxEnvios.Enabled = false;
                radioBtnEnvios.Enabled = false;
                radioBtnLocal.Checked = true;
                posibleEnvioPendiente = false;
            }
            */

            listaAlmacenes = logicaAlmacenes.obtenerAlmacenesHabilitados();

            comboBoxAreas.DataSource = logicaAlmacenes.obtenerAreas();
            comboBoxAreas2.DataSource = logicaAlmacenes.obtenerAreas();
            comboBoxLocales.DataSource = listaAlmacenes;
            comboBoxLocalSalida.DataSource = logicaAlmacenes.obtenerAlmacenesHabilitados();

            comboBoxLocales.SelectedIndex = 0;
            comboBoxLocalSalida.SelectedIndex = 0;

            (new AlmacenProductosBL()).actualizarAlmacenPedidoProd();
        }

        private void radioBtnIngreso_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnIngreso.Checked) {
                /*
                labelAlmacen.Visible = false;
                comboBoxLocalSalida.Visible = false;
                comboBoxAreas2.Visible = false;

                groupBox3.Visible = true;
                */
                labelAlmacen.Visible = false;
                comboBoxAreas2.Visible = false;
                comboBoxLocalSalida.Visible = false;

                labelOrigen.Visible = true;
                comboBoxAreas.Visible = true;
                comboBoxLocales.Visible = true;
                label1.Text = "Observaciones en el ingreso:";
            }
            
        }

        private void radioBtnSalida_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnSalida.Checked)
            {
                /*
                groupBox3.Visible = false;

                groupBox1.Enabled = true;
                comboBoxAreas2.Visible = true;
                labelAlmacen.Visible = true;
                comboBoxLocalSalida.Visible = true;
                */

                labelAlmacen.Visible = true;
                comboBoxAreas2.Visible = true;
                comboBoxLocalSalida.Visible = true;

                labelOrigen.Visible = false;
                comboBoxAreas.Visible = false;
                comboBoxLocales.Visible = false;
                label1.Text = "Observaciones en la salida:";
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
            if (comboBoxAreas.SelectedItem != null && ((Area)comboBoxAreas.SelectedItem).Nombre == "Almacen")
            {
                comboBoxLocales.DataSource = listaAlmacenes;
                comboBoxLocales.SelectedIndex = -1;
                if (listaAlmacenes != null && listaAlmacenes.Count == 0)
                {
                    comboBoxLocales.Text = "No hay locales de Almacen disponibles";
                }
                else if(listaAlmacenes != null && listaAlmacenes.Count >= 1)
                {
                    comboBoxLocales.SelectedIndex = 0;
                }
                //comboBoxLocales.Text = "Almacenes";
                comboBoxLocales.Update();
                comboBoxLocales.Refresh();
            }
            else if (((Area)comboBoxAreas.SelectedItem).Nombre == "Ventas")
            {
                //lista de locales de ventas
                comboBoxLocales.Text = "No hay locales de Ventas disponibles";
                comboBoxLocales.SelectedIndex = -1;
                comboBoxLocales.DataSource = null;
                comboBoxLocales.Update();
                comboBoxLocales.Refresh();
            }
            else if (((Area)comboBoxAreas.SelectedItem).Nombre == "Produccion")
            {
                //lista de locales de Produccion
                comboBoxLocales.Text = "No hay locales de Produccion disponibles";
                comboBoxLocales.SelectedIndex = -1;
                comboBoxLocales.DataSource = null;
                comboBoxLocales.Update();
                comboBoxLocales.Refresh();
            }
        }

        private void comboBoxAreas2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBoxLocalSalida.DataSource = ;
            if(comboBoxAreas2.SelectedItem != null && ((Area)comboBoxAreas2.SelectedItem).Nombre == "Almacen")
            {
                comboBoxLocalSalida.DataSource = listaAlmacenes;
                comboBoxLocalSalida.SelectedIndex = -1;
                if (listaAlmacenes != null && listaAlmacenes.Count == 0)
                {
                    comboBoxLocalSalida.Text = "No hay locales de Almacen disponibles";
                }
                else if (listaAlmacenes != null && listaAlmacenes.Count >= 1)
                {
                    comboBoxLocalSalida.SelectedIndex = 0;
                }
                comboBoxLocalSalida.Update();
                comboBoxLocalSalida.Refresh();
            }
            else if( ((Area)comboBoxAreas2.SelectedItem).Nombre == "Ventas")
            {
                //lista de locales de ventas
                comboBoxLocalSalida.Text = "No hay locales de Ventas disponibles";
                comboBoxLocalSalida.SelectedIndex = -1;
                comboBoxLocalSalida.DataSource = null;
                comboBoxLocalSalida.Update();
                comboBoxLocalSalida.Refresh();
            }
            else if( ((Area)comboBoxAreas2.SelectedItem).Nombre == "Produccion")
            {
                //lista de locales de Produccion
                comboBoxLocalSalida.Text = "No hay locales de Produccion disponibles";
                comboBoxLocalSalida.SelectedIndex = -1;
                comboBoxLocalSalida.DataSource = null;
                comboBoxLocalSalida.Update();
                comboBoxLocalSalida.Refresh();
            }
        }

        private void comboBoxLocalSalida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelAlmacen_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cantidadPedidos = dataGridIngresoSalida.RowCount;

            if(cantidadPedidos<= 0)
            {
                MessageBox.Show("Debe registrar mínimo un ingreso/salida", "Error");
                return;
            }

            bool resultado = true;

            //validar todas las lineas
            foreach (DataGridViewRow row in dataGridIngresoSalida.Rows)
            {
                int cantidadPedido;
                ProductoAlmacen actual = (ProductoAlmacen)row.DataBoundItem;
                if (row.Cells["Cantidad"].Value == null || !Int32.TryParse(row.Cells["Cantidad"].Value.ToString(), out cantidadPedido) )
                {
                    MessageBox.Show("Ha insertado incorrectamente una cantidad", "Error");
                    dataGridIngresoSalida.CurrentCell = row.Cells["Cantidad"];
                    resultado = false;
                    return;//debe ir esto en vez de un break con trabajo de variable valido
                }
                else if (radioBtnSalida.Checked && cantidadPedido > actual.CantidadAlmacenada)
                {
                    MessageBox.Show("Está registrando una salida con cantidad mayor al stock actual", "Error");
                    dataGridIngresoSalida.CurrentCell = row.Cells["Cantidad"];
                    resultado = false;
                    return;//debe ir esto en vez de un break con trabajo de variable valido
                }
            }
            //fin validacion



            //inicio mensaje confirmacion
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
                mensajeConf += "s";
            }
            mensajeConf += "?";
            //fin mensaje confirmacion

            DialogResult res = MessageBox.Show(mensajeConf, "Confirmacion", MessageBoxButtons.YesNo);
            if (res == DialogResult.No)
                return;



            //registrar pedido ingreso o salida
            if (radioBtnIngreso.Checked)
            {
                //Sucursal localSeleccionado = (Sucursal)comboBoxLocales.SelectedItem;
                int idAreaSeleccionada = ((Area)comboBoxAreas.SelectedItem).IdArea;
                int sedeOrigen = -1;
                if(idAreaSeleccionada == 1)
                {
                    Almacen localSeleccionado = (Almacen)comboBoxLocales.SelectedItem;
                    sedeOrigen = localSeleccionado.IdAlmacen;
                }
                //Console.WriteLine("Se va a insertar " + this.idAlmacen.ToString() + " " +idAreaSeleccionada.ToString() + " " + sedeOrigen.ToString());
                int idIngreso = logicaAlmacenes.registrarIngresoProductos(this.idAlmacen, idAreaSeleccionada, sedeOrigen, textBoxObservaciones.Text);
                if (idIngreso > 0)
                {
                    //registrar todas las lineas
                    int idLinea = 0;
                    foreach (DataGridViewRow row in dataGridIngresoSalida.Rows)
                    {
                        int cantidadPedido = Int32.Parse(row.Cells["Cantidad"].Value.ToString());
                        string observaciones;
                        //se obtienen las observaciones
                        if (row.Cells["Observaciones"].Value != null)
                        {
                            observaciones = row.Cells["Observaciones"].Value.ToString();
                        }
                        else
                        {
                            observaciones = "";
                        }
                        //fin observaciones

                        int idProducto = Int32.Parse(row.Cells["Id"].Value.ToString());

                        //se registra una linea de ingreso
                        idLinea = logicaAlmacenes.registrarLineaIngresoProductos(idIngreso, idProducto, cantidadPedido, observaciones);

                        //en el caso de error al registrar la linea
                        if (idLinea < 0)
                        {
                            resultado = false;
                            break;
                            //ver la forma de regresar, puede ser con un rollback
                        }
                    }
                }
            }
            else if (radioBtnSalida.Checked)
            {
                //Sucursal localSeleccionado = (Sucursal)comboBoxLocalSalida.SelectedItem;
                int idAreaSeleccionada = ((Area)comboBoxAreas2.SelectedItem).IdArea;
                int idSedeDestino = -1;
                if(idAreaSeleccionada == 1)
                {
                    Almacen almacenDestino = (Almacen)comboBoxLocalSalida.SelectedItem;
                    idSedeDestino = almacenDestino.IdAlmacen;
                }
                int idSalida = logicaAlmacenes.registrarSalidaProductos(this.idAlmacen, idAreaSeleccionada, idSedeDestino, textBoxObservaciones.Text);
                if (idSalida > 0)
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

            if (resultado)
            {
                MessageBox.Show("Transaccion Exitosa", "Exito");
                this.dataGridIngresoSalida.DataSource = new BindingList<ProductoAlmacen>();
                this.textBoxObservaciones.Text = "";
                dataGridIngresoSalida.Refresh();
                dataGridIngresoSalida.Update();
            }
            else
            {
                MessageBox.Show("Hubo un error al registrar el ingreso/salida. Reinténtelo en un momento.", "Error");
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
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

        private void toolStripButton2_Click_1(object sender, EventArgs e)
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

        private void dataGridIngresoSalida_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column3_KeyPress);
            if(dataGridIngresoSalida.CurrentCell.ColumnIndex == 3)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column3_KeyPress);
                }
            }
        }

        private void Column3_KeyPress(object sender,KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
