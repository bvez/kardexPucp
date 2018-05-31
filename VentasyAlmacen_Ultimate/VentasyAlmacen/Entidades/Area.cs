using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Area
    {
        private int idArea;
        private string nombre;

        public int IdArea { get => idArea; set => idArea = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public override string ToString()
        {
            return idArea.ToString() + " " + nombre ;
        }
    }
}
