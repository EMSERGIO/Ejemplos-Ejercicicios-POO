using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Primer lote con 10 registros de productos, cada producto tiene:
            //    -Codigo de Articulo (3 digitod no correlaivos)
            //    -Precio
            //    -Codigo de Marca (1 a 10)
            // Segundo lote con las ventas de la semana, cada venta tiene:
            //    -Codigo Articulo
            //    -Cantidad
            //    Codigo de Cliente (1 a 100)
            // Este lote corda con Codigo de Cliente cero



            Articulo[] articulos = new Articulo[10];

            for (int x = 0; x < 10; x++)
            {
                articulos[x] = new Articulo();
                Console.WriteLine("Ingrese Datos del Producto:");
                Console.WriteLine("Codigo: ");
                articulos[x].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio: ");
                articulos[x].Precio = float.Parse(Console.ReadLine());
                Console.WriteLine("Codigo de Marca: ");
                articulos[x].CodigoMarca = int.Parse(Console.ReadLine());

                //cargado el vector con los 10 Articulos
            }
            Venta venta = new Venta();

            Console.WriteLine("Ingrese la Venta:");
            Console.WriteLine("Codigo Cliente: ");
            venta.CodigoCliente = int.Parse(Console.ReadLine());

            while (venta.CodigoCliente > 0 && venta.CodigoCliente < 101)
            {
                
                Console.WriteLine("Codigo Articulo: ");
                venta.CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad: ");
                venta.Cantidad = int.Parse(Console.ReadLine());

                //TRABAJAMOS


                //PIDO NUEVAMENTE EL CODIGO DE CLIENTE
                Console.WriteLine("Ingrese la Venta:");
                Console.WriteLine("Codigo Cliente: ");
                venta.CodigoCliente = int.Parse(Console.ReadLine());
            }

        
        }
    }
}
