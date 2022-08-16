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

        //CONSTRUCTOR o SOBRECARGA DEL MISMO
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        //PROPIEDADES 'Geter/Seter' (PSEUDO FUNCIONES o PSEUDO METODOS)
        public void setEdad(int e)
        {
            edad = e;
        }

        public int getEdad()
        {
            return edad;
        }

        public string saludar()
        {
            return "Hola! Soy " + nombre;
        }
    }
}
