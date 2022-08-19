using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1MiPrueba
{
    internal class Usuario : Persona, Presentable
    {
        public string Edad { get; set; }
        public string PreferenciaLugar { get; set; }

        public string presentarse()
        {
            return "El usuario se llama " + Nombre + ". Tiene " + Edad + " años y prefiere " + PreferenciaLugar + " para vivir a gusto";
        }

    }
}
