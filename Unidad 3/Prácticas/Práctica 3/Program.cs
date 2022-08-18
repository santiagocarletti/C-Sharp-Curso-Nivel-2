using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PRACTICA 2 TEMATICA: PROGRAMA OBJETO MOUSE
            //
            //DESCRIPCION PROYECTO:
            //PROGRAMA QUE SOLICITA NOMBRE AL USUARIO, PERMITE SELECCIONAR ENTRE 
            //DOS MOUSES, VALIDANDO CON WHILE Y SWITCH, EN CASO DE SELECCION INCORRECTA, 
            //VUELVE A MOSTRAR OPCIONES.
            //EL MOUSE SELECCIONADO SALUDA AL USUARIO POR SU NOMBRE Y DE SER SOLICITADO,
            //INFORMA SUS ATRIBUTOS. SE PUEDEN EJECUTAR DOS CLICS, IMPRIMIENDO EN
            //PARTALLA UN MENSAJE EN FUNCION DE CADA SELECCION POR PARTE DEL USUARIO.

            MouseBorrador logitech = new MouseBorrador("inalambrica", "optico", "pila");
            MouseBorrador genius = new MouseBorrador("cable", "mecanico", "usb");

            Console.WriteLine("INGRESE NOMBRE DE USUARIO");
            string usuario = Console.ReadLine();

            string selMouse;

            Console.WriteLine("INGRESE MARCA DE MOUSE");
            Console.WriteLine("'logitech' o 'genius'");
            selMouse = Console.ReadLine();
            int selClic;
            int bandera = 0;

        while (bandera == 0)
        {
                while ((selMouse == "logitech" || selMouse == "genius") && bandera == 0)
                {

                    if (selMouse == "logitech")
                    {
                        bandera = 1;
                        Console.WriteLine(logitech.Presentarse(usuario));
                        Console.ReadKey();

                        Console.WriteLine("DESEAS CONOCER MIS CARACTERISTICAS?");
                        Console.WriteLine("'si' o 'no'");
                        string selCat = Console.ReadLine();
                        if (selCat == "si")
                        {
                            Console.WriteLine("TIPO DE CONEXION: " + logitech.Conexion);
                            Console.WriteLine("TIPO DE SENSOR: " + logitech.Sensor);
                            Console.WriteLine("ALIMENTACIÓN (Energía): " + logitech.Alimentacion);
                            Console.ReadKey();
                        }

                    }
                    else if (selMouse == "genius")
                    {
                        Console.WriteLine(genius.Presentarse(usuario));
                        Console.ReadKey();

                        Console.WriteLine("DESEAS CONOCER MIS CARACTERISTICAS?");
                        Console.WriteLine("'si' o 'no'");
                        string selCat = Console.ReadLine();

                        if (selCat == "si")
                        {
                            Console.WriteLine("TIPO DE CONEXION: " + genius.Conexion);
                            Console.WriteLine("TIPO DE SENSOR: " + genius.Sensor);
                            Console.WriteLine("ALIMENTACIÓN (Energía): " + genius.Alimentacion);
                            Console.ReadKey();
                        }
                    }
                    bandera = 1;
                }
                if (bandera == 0)
                {
                    Console.WriteLine("INCORRECTO. VUELVA A INTENTAR");
                    Console.WriteLine("INGRESE MARCA DE MOUSE");
                    Console.WriteLine("'logitech' o 'genius'");
                    selMouse = Console.ReadLine();

                }


        }

            Console.WriteLine("Clic primario [1]");
            Console.WriteLine("Clic secundario [2]");
            selClic = int.Parse(Console.ReadLine());
            switch (selClic)
            {
                case 1:
                    {
                        Console.WriteLine(logitech.Clic());
                        Console.ReadKey();
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine(logitech.Mas());
                        Console.ReadKey();
                    }
                    break;
                default:
                    {
                        Console.WriteLine("OPCION INCORRECTA");
                        Console.ReadKey();
                    }
                    break;
            }




        }
    }
}
