using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herenciaPrueba
{
    //PRACTICA 1 TEMATICA: HERENCIA
    internal class Program
    {
        static void Main(string[] args)
        {
            Departamento d1 = new Departamento();
            d1.NroDpto = "9B";
            d1.Calle = "tucuman";

            Casa c1 = new Casa();
            c1.Numeracion = 123;
            c1.Piso = "planta baja";

            Vivienda v1 = new Vivienda();
            v1.Provincia = "Buenos Aires";
            

            

        }
    }
}
