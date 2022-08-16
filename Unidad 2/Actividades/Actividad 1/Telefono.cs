using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio1
{
    internal class Telefono
    {
        //5. Agregar Constructor que reciba Modelo y Marca.
        public Telefono(string modelo, string marca)
        {
            this.Modelo = modelo;
            this.Marca = marca;
        }

        //a.Modelo string: Solo lectura. Es decir, solo get.
        //b.Marca string: Solo lectura.
        //c.NumeroTelefonico string: Lectura y escritura.
        //d.CodigoOperador int(1, 2 o 3).: Lectura y escritura.
        //Validar escritura, que solo admita
        //1, 2 o 3, caso contrario escribir un cero.

        public string Modelo { get; }

        public string Marca { get; }

        public string NumeroTelefonico { get; set; }

        private int codigoOperador;
        public int CodigoOperador
        {
            get { return codigoOperador; }
            set
            {
                if (value > 0 && value < 4)
                    codigoOperador = value;
                else
                    codigoOperador = 0;
            }
        }

        public string ContactoLlamado { get; set; }

        public string PorcentBat {  get; set; }

        public string Llamar()
        {
            return "Realizando llamada...";
        }

        public string Llamar(string contacto)
        {
            ContactoLlamado = contacto;
            return "Llamando a " + ContactoLlamado + "...";

        }

        public string Bateria()
        {
            return "Batería con carga";
        }

        public string Bateria(string n)
        {
            PorcentBat = n;
            if (PorcentBat == "si")
                return "Nivel de carga de la batería: 82%";
            else
                return "Ok..";
        }

    }
}
