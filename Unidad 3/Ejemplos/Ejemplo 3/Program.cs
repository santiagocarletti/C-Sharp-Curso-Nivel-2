using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia2
{
    //TEMATICA EJEMPLO 3: COLECCIONES
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehiculo v1 = new Vehiculo();  
            Camioneta c1 = new Camioneta();
            Camioneta c2 = new Camioneta();
            Camioneta c3 = new Camioneta();

            //EJEMPLOS
            //Vehiculo v2;
            //v2 = new Camioneta();
            //LO ANTERIOR SERIA LO MISMO QUE:
            //Vehiculo v2 = new Camioneta(); <<< (VALIDO)

            c1.Color = "amarilla";
            c2.Color = "roja";
            c3.Color = "blanca";

            List<Camioneta> listaCamionetas = new List<Camioneta>();
            listaCamionetas.Add(c1);
            listaCamionetas.Add(c2);
            listaCamionetas.Add(c3);

            //DE LA SIGUIENTE MANERA SE LEEN LOS OBJETOS, UNO A UNO
            //
            //Console.WriteLine("La cantidad de camionetas es " + listaCamionetas.Count);
            //listaCamionetas[1].Color = "negra";
            //c2.Color = "verde";
            //Console.WriteLine("El color de la camioneta es " + listaCamionetas[1].Color);
            //listaCamionetas.Remove(c3);
            //Console.WriteLine("La cantidad de camionetas es " + listaCamionetas.Count);
            //
            //Console.ReadKey();

            //PARA LEER TODOS LOS OBJETOS:
            foreach (Camioneta item in listaCamionetas)
            {
                Console.WriteLine("Color " + item.Color);
            }

            Console.ReadKey();

        }
    }
}
