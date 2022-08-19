using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1MiPrueba
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public string Nacimiento { get; set; }
        public string TipoComida { get; set; }

        public string presentarse()
        {
            return "Hola! Mi nombre es " + Nombre + ". Nací el " + Nacimiento + " y me gustan las " + TipoComida;
        }


    }
}
