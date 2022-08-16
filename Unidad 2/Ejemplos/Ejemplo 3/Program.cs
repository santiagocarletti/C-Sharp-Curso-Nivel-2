using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    //TEMATICA EJEMPLO 3
    //METODOS
    internal class Program
    {
        static void Main(string[] args)
        {

            Botella b1 = new Botella("Rojo", "Plástico");

            Console.WriteLine("Capacidad botella: " + b1.Capacidad);
            Console.WriteLine("La cantidad actual es: " + b1.CantidadActual);

            b1.recargar();
            Console.WriteLine("Luego de recargar, la cantidad es: " + b1.CantidadActual);

            Console.ReadKey();

            Perro perr1 = new Perro();
            perr1.setNombre("toby");
            Console.WriteLine("Su nombre es " + perr1.getNombre());
            perr1.Color = "marron";
            Console.WriteLine("El color es " + perr1.Color);

            Console.ReadKey();

        }
    }
}
