using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    //TEMATICA EJEMPLO 7: TIPOS DE CLASES, MODIFICADORES DE VISIBILIDAD
    internal class Program
    {
        static void Main(string[] args)
        {

            //TIPOS DE CLASES / MODIFICADORES DE VISIBILIDAD DE CLASES
            //[Abstract, Static, Sealed.]

            //ABSTRACT
            //En {Main} no se pueden crear nuevas instancias, obligaría a heredar
            //Ejemplo desarrollado en clase 'Persona'

            //SEALED
            //No permite heredar
            //Ejemplo desarrollado en clase 'Lider'

            //STATIC
            //No se puede instanciar ni heredar. Se puede usar como clase 'helper', donde habrán algunos
            //métodos. No abusar, por que esta clase se auto instancia y se carga en memoria durante toda
            //la ejecución del programa.
            //Ejemplo desarrollado en clase 'Tester'

            Developer d1 = new Developer();
            Lider l1 = new Lider();
            Tester.algo();
            
        }
    }
}
