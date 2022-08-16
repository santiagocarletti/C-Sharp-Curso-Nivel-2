using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio1
{
    internal class ProgramTEL
    {
        static void Main(string[] args)
        {
            //ENUNCIADO EJERCICIO 1
            //DESAFIO:
            //1. Crear un proyecto de consola .Net Framework.
            //2. Crear la clase Telefono
            //3. Agregale los siguientes atributos:
            //a.Modelo string: Solo lectura. Es decir, solo get.
            //b.Marca string: Solo lectura.
            //c.NumeroTelefonico string: Lectura y escritura.
            //d.CodigoOperador int(1, 2 o 3).: Lectura y escritura.
            //Validar escritura, que solo admita
            //1, 2 o 3, caso contrario escribir un cero.
            //4. Agregale las propiedades correspondientes. Podés hacer
            //el formato largo o el corto.
            //5. Agregar Constructor que reciba Modelo y Marca.
            //6. Crear algunos objetos en el main de Program y probar
            //escribirle datos y mostrar en pantalla el estado del Telefono.
            //7. Agregar método Llamar() sin parámetros que devuelva un
            //string con la leyenda "Realizando llamada...".
            //8. Sobrecargar el método Llamar(string contacto) para que reciba un
            //contacto y devuelva un string con la leyenda "Llamando a " + contacto
            //9. Probar métodos en el main mostrando en pantalla el
            //comportamiento de los objetos.

            Telefono tel1 = new Telefono("1100", "nokia");
            tel1.NumeroTelefonico = "12345678";
            tel1.CodigoOperador = 2;
            
            Console.WriteLine(tel1.Modelo + " (Modelo)");
            Console.ReadKey();
            Console.WriteLine(tel1.Marca + " (Marca)");
            Console.ReadKey();
            Console.WriteLine(tel1.NumeroTelefonico + " (Número telefónico)");
            Console.ReadKey();
            Console.WriteLine(tel1.CodigoOperador + " (Código de operador)");
            Console.ReadKey();

            //9. Probar métodos en el main mostrando en pantalla el
            //comportamiento de los objetos.

            Console.WriteLine(tel1.Bateria());
            Console.ReadKey();

            Console.WriteLine("Conocer nivel de batería? 'si' o 'no'");
            tel1.PorcentBat = Console.ReadLine();
            Console.WriteLine(tel1.Bateria(tel1.PorcentBat));
            Console.ReadKey();
            
            //6. Crear algunos objetos en el main de Program y probar
            //escribirle datos y mostrar en pantalla el estado del Telefono.

            Telefono tel2 = new Telefono("IPhone", "Apple");

            Console.WriteLine(tel2.Modelo + " (Modelo)");
            Console.ReadKey();
            Console.WriteLine(tel2.Marca + " (Marca)");
            Console.ReadKey();
            Console.WriteLine("Ingrese número telefónico");
            tel2.NumeroTelefonico = Console.ReadLine();
            Console.WriteLine("Usted ingresó: " + tel2.NumeroTelefonico);
            Console.ReadKey();
            Console.WriteLine("Ingrese número de operador [1], [2] o [3]");
            tel2.CodigoOperador = int.Parse(Console.ReadLine());

            if (tel2.CodigoOperador != 0)
                Console.WriteLine("Operador: " + tel2.CodigoOperador);
            else
                Console.WriteLine("Operador no admitido");            
            
            Console.ReadKey();

            //7. Agregar método Llamar() sin parámetros que devuelva un
            //string con la leyenda "Realizando llamada...".

            tel2.Llamar();
            Console.WriteLine(tel2.Llamar());
            Console.ReadLine();

            //8. Sobrecargar el método Llamar(string contacto) para que reciba un
            //contacto y devuelva un string con la leyenda "Llamando a " + contacto

            Console.WriteLine("A quién desea llamar?");
            tel2.ContactoLlamado = Console.ReadLine();
            Console.WriteLine(tel2.Llamar(tel2.ContactoLlamado));
            Console.ReadLine();

        }
    }
}
