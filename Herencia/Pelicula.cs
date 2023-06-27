using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Pelicula
    {
        private string nombre;
        private string fechaInaguracion;
        public string Nombre 
        { 
            get {return nombre;}
            set { nombre = value; } 
        }
        public string FechaInaguracion
        {
            get { return fechaInaguracion; }
            set { fechaInaguracion = value; }
        }
    }
}
