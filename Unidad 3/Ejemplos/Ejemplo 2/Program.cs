using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia2
{
    //TEMATICA EJEMPLO 2: HERENCIA
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vehiculo > Auto > AutoDeportivo > AutoUrbano
            //>Camioneta
            //>Moto

            Vehiculo v1 = new Vehiculo();  
            Camioneta c1 = new Camioneta();

            Vehiculo v2;
            v2 = new AutoDeportivo();
            //LO ANTERIOR SERIA TAN VALIDO COMO LO SIGUIENTE:
            //Vehiculo v2 = new AutoDeportivo();
            
            //LO SIGUIENTE ES INCORRECTO
            //Camioneta c2 = new Auto();
            
        }
    }
}
