using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecicio1
{
    internal class Perro
    {
        //Perro: Nombre, Color, Origen
        private string nombre;
        private string color;
        private string origen;

        public void setNombre(string n)
        {
            nombre = n;
        }
        public string getNombre()
        {
            return nombre;
        }
        public void setColor(string c)
        {
            color = c;
        }
        public string getColor()
        {
            return color;
        }
        public void setOrigen(string o)
        {
            origen = o;
        }
        public string getOrigen()
        {
            return origen;
        }


    }
}
