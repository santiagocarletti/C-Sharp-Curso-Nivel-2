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
            capacidad = 100;
            cantidadActual = 0;
        }

        //SOBRECARGAR EL CONSTRUCTOR
        public Botella() { }

        //DESTRUCTOR
        ~Botella()
        { 
            //LA LOGICA..
        }

        //Botella: Capacidad, Color, Material
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

        public string Material
        {
            get { return material; }
        }

        //METODO
        public float recargar()
        {
            if(cantidadActual > 0)
            {
                int dif = capacidad - cantidadActual;
                float monto = dif * 50 / 100;
                cantidadActual += dif;
                return monto;
            }
            cantidadActual = 100;
            return 50;
        }
        
    }
}
