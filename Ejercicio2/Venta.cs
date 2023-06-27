using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Venta
    {
        // Segundo lote con las ventas de la semana, cada venta tiene:
        //    -Codigo Articulo
        //    -Cantidad
        //    Codigo de Cliente (1 a 100)

        public int CodigoArticulo { get; set; }
        public int Cantidad { get; set; }
        public int CodigoCliente { get; set; }
    }
}
