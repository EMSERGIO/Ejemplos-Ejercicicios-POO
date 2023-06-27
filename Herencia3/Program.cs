using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //AnimalDomestico a1 = new AnimalDomestico();
            //a1.Nombre = "Pepe";

            //Console.WriteLine(a1.ToString());

            Gato g1 = new Gato();
            g1.Nombre = "PEPE";

            Perro p1 = new Perro();
            p1.Nombre = "FIRULAY";


            List<Animal> animales = new List<Animal>();
            animales.Add(g1);
            animales.Add(p1);
            animales.Add(new Pez());
            animales.Add(new Gato());
            animales.Add(new Aguila());
            animales.Add(new Canario());

            //CASTEO EXPLICITO: para afirmarlrle al compilador que hay dentro de la variable la que se esta afirmando
            //Animal a1 = g1;
            //Gato g8 = (Gato)a1;
            //--------------------------------------------------------------------------------------------

            foreach (Animal item in animales)
            {
                Console.WriteLine(item.comunicarse());
            }

            //Console.WriteLine(g1.comunicarse());
            //Console.WriteLine(p1.comunicarse());

            //POLIMORFISMO: Es la caracteristica que tienen los objestos que
            //frente el mismo estimulo responder de maneras distintas.

            Console.ReadKey();
        }
    }
}
