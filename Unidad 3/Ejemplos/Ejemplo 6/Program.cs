using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia2
{
    //TEMATICA EJEMPLO 6: ASOCIACION
    internal class Program
    {
        static void Main(string[] args)
        {

            Auto a1 = new Auto();

            a1.Motor = new Motor();
        
        }
    }
}
