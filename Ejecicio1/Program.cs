using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Persona: Edad, Sueldo, Nombre
            //int edad;
            //int sueldo;
            //int nombre;

            //Persona p1 = new Persona("Sergio");
            //p1.setEdad(20);
            //Console.WriteLine(p1.saludar());
            //Console.WriteLine(p1.saludar("MAXI"));
            //Console.WriteLine("La Edad de la persona es: " + p1.getEdad());

            //Perro a1 = new Perro();
            //Console.WriteLine("Ingrese el nombre del Perro: ");
            //a1.setNombre(Console.ReadLine());

            //Console.WriteLine("Ingrese el color: ");
            //a1.setColor(Console.ReadLine());

            //Console.WriteLine("Ingrese el origen: ");
            //a1.setOrigen(Console.ReadLine());

            //Console.WriteLine("Tu Perro se llama: " + a1.getNombre());
            //Console.WriteLine("SU Color es: " + a1.getColor());
            //Console.WriteLine("Con Origen en: " + a1.getOrigen());

            Botella b1 = new Botella("Rojo", "Plastico");

            //b1.Capacidad = 200;
            //// ej de guardad ese capacidad 200 en una variable
            //int algo = b1.Capacidad;
            ////SOBRECARGA DEL CONSTRUCTOR
            //Botella b2 = new Botella();


            Console.WriteLine("Capacidad botella: " + b1.Capacidad);
            Console.WriteLine("La cantidad actual es: " + b1.CantidadActual);

            b1.recargar(20);
            Console.WriteLine("Capacidad botella: " + b1.CantidadActual);

            b1.recargar();
            Console.WriteLine("Capacidad botella: " + b1.CantidadActual);

            Console.ReadKey();
        }
    }
}
