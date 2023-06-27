using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Terror t1 = new Terror();
            //Console.WriteLine("Que Fecha se Inauguro la Pelicula: ");
            //t1.FechaInaguracion = Console.ReadLine();
            //Console.WriteLine("La fecha de inaguracion es: " + t1.FechaInaguracion);
            Suspenso s1 = new Suspenso();
            Comedia c1 = new Comedia();
            t1.Nombre = "Profecia";
            s1.Nombre = "Termineitor";
            c1.Nombre = "CasadosConHijos";

            // LIST: TIPO DE COLECCION
            List<Pelicula> listaPeliculas = new List<Pelicula>();
            listaPeliculas.Add(t1);
            listaPeliculas.Add(s1);
            listaPeliculas.Add(c1);

            Console.WriteLine("La cantidad de peliculas son: " + listaPeliculas.Count);//CONTAR LA LISTA
            listaPeliculas.Remove(t1);//REMOVER DE LA LISTA
            Console.WriteLine("La pelicula es: " + listaPeliculas[0].Nombre);

            //RECORRER LA LISTA
            foreach (Pelicula list in listaPeliculas) 
            {
                Console.WriteLine("nombre: " + list.Nombre);
            }




            Console.ReadKey();
        }
    }
}
