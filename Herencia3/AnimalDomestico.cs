using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    internal class AnimalDomestico : Animal
    {
        public string Nombre { get; set; }

        //SOBRE ESCRITURA DE METODO EJ ToString con OVERRIDE

        public override string ToString()
        {
            return "Aminal Domestico:" +  Nombre;
        }
    }
}
