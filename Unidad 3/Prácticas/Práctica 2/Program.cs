using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herenciaPrueba2
{
    //PRACTICA 2 TEMATICA: COLECCIONES, HERENCIA
    internal class Program
    {
        static void Main(string[] args)
        {
            Utensilio u1 = new Utensilio();
            Mate m1 = new Mate();
            Mate m2 = new Mate();
            Mate m3 = new Mate();

            m1.Uso = "bebidas";
            m3.Uso = "invitado especial";

            m1.MaterialVirola = "acero inoxidable";
            m2.MaterialVirola = "aluminio";
            m3.MaterialVirola = "plata";

            List<Mate> listaMates = new List<Mate>();
            listaMates.Add(m1);
            listaMates.Add(m2);
            listaMates.Add(m3);

            Console.WriteLine("Cantidad de items en la lista: " + listaMates.Count);
            Console.ReadLine();
            
            Console.WriteLine("Luego de eliminar mate con virola de " + listaMates[1].MaterialVirola + "...");
            Console.ReadLine();

            listaMates.Remove(m2);

            Console.WriteLine("... La cantidad de items en la lista es: " + listaMates.Count);
            Console.ReadLine();

            foreach (Mate item in listaMates)
            {
                Console.WriteLine("Virola de " + item.MaterialVirola);
            }
            Console.ReadLine();

            foreach (Mate item in listaMates)
            {
                Console.WriteLine("Uso de mate con virola de " + item.MaterialVirola + " : " + item.Uso);
            }
            Console.ReadKey();
        }
    }
}
