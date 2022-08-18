using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia3
{
    //TEMATICA EJEMPLO 4: SOBREESCRITURA DE METODOS, POLIMORFISMO
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalDomestico a1 = new AnimalDomestico();

            Gato g1 = new Gato();
            g1.Nombre = "Pepe";
            
            Perro p1 = new Perro();
            p1.Nombre = "Negrito";

            List<Animal> animales = new List<Animal>();
            animales.Add(p1);
            animales.Add(new Pez());
            animales.Add(new Canario());
            animales.Add(g1);
            animales.Add(new Aguila());
            animales.Add(new Gato());

            foreach (Animal item in animales)
            {
                Console.WriteLine(item.comunicarse());
            }
            
            Console.ReadKey();

        }
    }
}
