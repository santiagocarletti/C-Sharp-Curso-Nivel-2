using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revEjem1._1
{
    internal class Perro
    {
        //Perro: Nombre, Color, Origen
        private string nombre;
        private string color;
        private string origen;

        //FORMA2(C#)
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        //FORMA1
        public void setColor(string c)
        {
            color = c;
        }
        public string getColor()
        {
            return color;
        }
    }
}
