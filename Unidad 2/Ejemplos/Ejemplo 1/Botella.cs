using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revEjem1._1
{
    internal class Botella
    {
        //Botella: Capacidad, Color, Material
        private int capacidad;
        private string color;
        private string material;

        //'BOTELLA': FORMA2 (o (Mejor en C#) [PROPIEDAD])
        public int Capacidad
        {
            get { return capacidad;  }
            set { capacidad = value;  }
        }
    }
}
