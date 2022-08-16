using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revEjem1._1
{
    internal class Persona
    {
        //Persona: Edad, Sueldo, Nombre
        //ATRIBUTOS o MIEMBROS
        private int edad;
        private float sueldo;
        private string nombre;

        //FORMA1
        public void setEdad(int e)
        {
            edad = e;
        }
        public int getEdad()
        {
            return edad;
        }

    }
}
