namespace Entidades
{
    using System;
    public class IngresoSalidaProducto
    {
        private int idIngresoSalidaProducto;
        private int idAreaOrigen;
        private int idSedeOrigen;
        private int idAreaDestino;
        private int idSedeDestino;
        private DateTime fechaSalida;
        private string observaciones;

        public int IdIngresoSalidaProducto { get => idIngresoSalidaProducto; set => idIngresoSalidaProducto = value; }
        public int IdAreaOrigen { get => idAreaOrigen; set => idAreaOrigen = value; }
        public int IdSedeOrigen { get => idSedeOrigen; set => idSedeOrigen = value; }
        public int IdAreaDestino { get => idAreaDestino; set => idAreaDestino = value; }
        public int IdSedeDestino { get => idSedeDestino; set => idSedeDestino = value; }
        public DateTime FechaSalida { get => fechaSalida; set => fechaSalida = value; }
        public string Observaciones { get => observaciones; set => observaciones = value; }
        

        public override string ToString()
        {
            return "Salida # "+ idIngresoSalidaProducto.ToString()+" enviado por almacen "+ idSedeOrigen.ToString() + " " +fechaSalida.ToString();
        }
    }
}