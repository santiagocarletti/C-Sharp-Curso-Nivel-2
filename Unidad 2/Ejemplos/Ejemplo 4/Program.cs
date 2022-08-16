using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    //TEMATICA EJEMPLO 4
    //SOBRECARGA DE METODOS
    internal class Program
    {
        static void Main(string[] args)
        {
            Botella b1 = new Botella("Rojo", "Plástico");
            //b1.Capacidad = 200;

            //Botella b2 = new Botella();

            Console.WriteLine("Capacidad botella: " + b1.Capacidad);
            Console.WriteLine("La cantidad actual es: " + b1.CantidadActual);

            b1.recargar(20);
            Console.WriteLine("Luego de recargar, la cantidad es: " + b1.CantidadActual);

            b1.recargar();
            Console.WriteLine("Luego de recargar, la cantidad es: " + b1.CantidadActual);

            Console.ReadKey();

        }
    }
}
