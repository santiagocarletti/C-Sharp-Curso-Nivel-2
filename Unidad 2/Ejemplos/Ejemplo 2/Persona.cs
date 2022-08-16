using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Persona
    {

        //Persona: Edad, Sueldo, Nombre
        //ATRIBUTOS O MIEMBROS
        private int edad;
        private float sueldo;
        private string nombre;

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
