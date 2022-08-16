using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revEjem1._1
{
    //TEMATICA EJEMPLO 1
    //CLASES, OBJETOS, PROPIEDADES, ENCAPSULAMIENTO
    internal class Program
    {
        static void Main(string[] args)
        {

            Persona p1 = new Persona();
            //FORMA1
            p1.setEdad(20);
            Console.WriteLine("La edad de la persona es: " + p1.getEdad());
            Console.ReadKey();

            //'BOTELLA': FORMA2 (o (Mejor para C#) [PROPIEDAD])
            Botella b1 = new Botella();
            b1.Capacidad = 200;
            int cap = b1.Capacidad;
            Console.WriteLine("La capacidad es: " + cap);
            Console.ReadKey();

            //FORMA2
            Perro can1 = new Perro();
            can1.Nombre = "boby";
            //SE PUEDE LEER ASI (SIG. EJEMPLO)
            //string seLlama = can1.Nombre;
            //Console.WriteLine("Nombre: " + seLlama);

            ////o SE PUEDE LEER ASI (SIG. EJEMPLO)
            Console.WriteLine("Se llama " + can1.Nombre);
            Console.ReadKey();

            //FORMA1
            can1.setColor("blanco");
            Console.WriteLine("El color del perro es: " + can1.getColor());
            Console.ReadKey();
        }
    }
}
