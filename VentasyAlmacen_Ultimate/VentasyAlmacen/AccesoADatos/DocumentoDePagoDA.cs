using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using Entidades;
using MySql.Data.MySqlClient;

namespace AccesoADatos
{
    public class DocumentoDePagoDA
    {
        private string cadConn = "server=quilla.lab.inf.pucp.edu.pe;" + "user=inf282g2;" + "database=inf282g2;"
                + "port=3306;" + "password=X7X2HA;" + "SslMode=none;";
        public DocumentoDePagoDA() { }

        public bool insertarBoleta(Boleta boleta)
        {
            try
            {
                MySqlConnection con = new MySqlConnection(cadConn);
                con.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.CommandText = "insertar_boleta";
                cmd.Parameters.Add("_id_cliente", boleta.Cliente.Id);
                cmd.Parameters.Add("_total", boleta.Total);
                cmd.Parameters.Add("_estado", 2);
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                Console.WriteLine("Boleta insertada correctamente");
                return true;
            }catch(Exception e)
            {
                return true;
                //Console.Error.WriteLine(e.StackTrace);
                //Console.Error.WriteLine("Error al insertar boleta.");
                //return false;
            }
        }

        public bool ImprimirFactura(Factura factura, String nombreArchivo)
        {
            try{
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 45);
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(nombreArchivo, FileMode.Create));
                doc.Open();
                Paragraph titulo = new Paragraph("Factura");
                Paragraph fac_ruc = new Paragraph("RUC: " + factura.Ruc);
                Paragraph fac_nomb = new Paragraph(factura.Cliente.nombre);
                Paragraph etiquetas = new Paragraph("Descripcion" + "    " + "Cantidad" + "    " + "Precio");
                foreach(LineaProducto lp in factura.Items)
                {
                    Paragraph linea = new Paragraph(lp.Producto.Descripcion + "    " + lp.Cantidad + "    " + lp.Producto.Precio);
                    doc.Add(linea);
                }
                doc.Close();
                return true;
            }catch(Exception ex)
            {
                Console.Error.WriteLine(ex.StackTrace);
                Console.Error.WriteLine("Error al generar la factura.");
                return false;
            }
        }

        public bool ImprimirBoleta(Boleta boleta, String nombreArchivo)
        {
            try
            {
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 45);
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(nombreArchivo, FileMode.Create));
                doc.Open();
                Paragraph titulo = new Paragraph("Boleta de venta");
                Paragraph datosCliente = new Paragraph("Cliente : " + boleta.Cliente.nombre + " "
                                        + boleta.Cliente.Apellido_P + boleta.Cliente.Apellido_M +
                                        "\n");

                Paragraph etiquetas = new Paragraph("Descripcion" + "    " + "Cantidad" + "    " + "Precio");
                doc.Add(titulo);
                doc.Add(datosCliente);
                doc.Add(etiquetas);
                foreach (LineaProducto lp in boleta.Items)
                {
                    Paragraph linea = new Paragraph(lp.Producto.Descripcion + "    " + lp.Cantidad + "    " + lp.Producto.Precio);
                    doc.Add(linea);
                }
                Paragraph total = new Paragraph("Total:     " + boleta.Total);
                doc.Add(total);
                doc.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.StackTrace);
                Console.Error.WriteLine("Error al generar la boleta.");
                return false;
            }
        }
    }
}
