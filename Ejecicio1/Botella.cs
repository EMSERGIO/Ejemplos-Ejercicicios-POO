using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecicio1
{
    internal class Botella
    {
        //Capacidad maxima de: 100
        //cantidadActual : inicia desde cero
        //metodo recarga: carga al 100 y devuelve el costo de recarga. 50 cada 100

        //Ej de CONSTRUCTOR
        public Botella(string color, string material)
        {
            this.color = color;
            this.material = material;
            capacidad = 100;
            cantidadActual = 0;
        }
        //SOBRECARGA DEL CONSTRUCTOR
        public Botella() { }

        //DESTRUCTOR
        ~Botella()
        {
            //La logica...
        }



        //Botella : Capacidad, Color, Material.
        private int capacidad;
        private string color;
        private string material;
        private int cantidadActual;

        public int Capacidad
        {
            get { return capacidad; }
        }
        public int CantidadActual
        {
            get { return cantidadActual; }
        }
        //PROPIEDAD
        //public int Capacidad
        //{
        //    get { return capacidad; }
        //    set{ capacidad = value; }

        //}

        //METODO
        public float recargar()
        {
            if (cantidadActual > 0)
            {
                int dif = capacidad - cantidadActual;
                //100 50
                //dif
                float monto = dif * 50 / 100;
                cantidadActual += dif;
                return monto;
            }

            cantidadActual = 100;
            return 50;
        }
        //SOBRECARGA DEL METODO
        public float recargar(int cantidad)
        {
            cantidadActual += cantidad;
            return cantidad * 50 / 100;
            // 100 =  50
            // cantidad = x?
        }

    }


}


