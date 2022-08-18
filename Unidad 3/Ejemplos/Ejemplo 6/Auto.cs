using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia2
{
    internal class Auto : Vehiculo
    {
        public Auto()
        {
            Chasis = new Chasis();
        }

        public string Año { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }

        //AGREGACION
        public Motor Motor { get; set; }

        //COMPOSICION
        public Chasis Chasis { get; }
    }

}
