namespace Entidades
{
    using System;
    public class SalidaProducto
    {
        private int idSalidaProducto;
        private int idAlmacenEnvia;
        private DateTime fechaSalida;
        private string observaciones;

        public int IdSalidaProducto { get => idSalidaProducto; set => idSalidaProducto = value; }
        public int IdAlmacenEnvia { get => idAlmacenEnvia; set => idAlmacenEnvia = value; }
        public DateTime FechaSalida { get => fechaSalida; set => fechaSalida = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }

        public override string ToString()
        {
            return "Salida # "+idSalidaProducto.ToString()+" enviado por almacen "+idAlmacenEnvia.ToString() + " " +fechaSalida.ToString();
        }
    }
}