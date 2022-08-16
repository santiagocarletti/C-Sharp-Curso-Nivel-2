using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revEjem2_1
{
    internal class Articulo
    {
        //ARTICULO
        //-Código Artículo (3 dígitos no correlativos)
        //-Precio
        //-Código de Marca (1 a 10)

        public int CodigoArticulo { get; set; }

        public float Precio { get; set; }

        private int codMarca;
        public int CodMarca
        {
            get { return codMarca; }
            set
            {
                if (value > 0 && value < 11)
                    codMarca = value;
                else
                    codMarca = -1;
            }
        }
    }
}
