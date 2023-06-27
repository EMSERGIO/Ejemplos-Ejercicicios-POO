using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Articulo
    {
        //    -Codigo de Articulo (3 digitod no correlaivos)
        //    -Precio
        //    -Codigo de Marca (1 a 10)

        //private int codArticulo;
        //ESCRIBIR DIRECTAMENTA LA PROPIEDAD CON "prop"
        public int CodigoArticulo { get; set; }

        //private float precio;
        public float Precio { get; set; }

        private int codMarca;
        public int CodigoMarca
        {
            get { return codMarca; }
            set 
            {
                if (value == 0 && value < 11)
                    codMarca = value;
                else
                    codMarca = -1;
            }
        }
    }
}
