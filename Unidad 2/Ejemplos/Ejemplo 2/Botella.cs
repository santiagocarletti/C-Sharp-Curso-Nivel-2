using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Botella
    {
        public Botella(string color, string material)
        {
            this.color = color;
            this.material = material;
        }
        //SOBRECARGAR EL CONSTRUCTOR
        public Botella() { }

        //DESTRUCTOR
        ~Botella()
        { 
            //AQUI LA LOGICA
        }

        //Botella: Capacidad, Color, Material
        private int capacidad;
        private string color;
        private string material;

        public string Material
        {
            get { return material; }
        }

        //PROPIEDAD
        public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }
    }
}
