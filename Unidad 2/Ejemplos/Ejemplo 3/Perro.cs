using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Perro
    {
        //Perro: Nombre, Color, Origen
        private string nombre;
        private string color;
        private string origen;

        //1ª FORMA
        public void setNombre(string n)
        {
            nombre = n;
        }

        public string getNombre()
        {
            return nombre; 
        }
    
        //2ª FORMA
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
    
    }
}
