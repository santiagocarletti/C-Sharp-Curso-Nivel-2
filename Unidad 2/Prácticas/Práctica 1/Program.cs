using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DESCRIPCION PRACTICA 1
            //OBJETIVOS:
            //1. CALCULADORA BASICA CON FUNCION SUMAR, RESTAR, MULTIPLICAR Y DIVIDIR
            //2. CALCULADORA 'PRO' CON FUNCIONES:
            //a. DETERMINAR INGRESO CRECIENTE O DECRECIENTE
            //b. DETERMINAR SI LOS NUMEROS INGRESADOS SON IGUALES O DISTINTOS
            //c. RAIZ CUADRADA
            //d. RAIZ CUBICA

            Calculadora basica = new Calculadora("básica", "casio", "b1");
            Calculadora pro = new Calculadora("pro", "panasonic", "p1");

            Console.WriteLine("Calculadora básica [Presione '1']");
            Console.WriteLine("Calculadora pro [Presione '2']");
            int opcion = int.Parse(Console.ReadLine());

            if(opcion == 1)
            {
                Console.WriteLine("Tipo: " + basica.Tipo);
                Console.ReadKey();
                Console.WriteLine("Marca: " + basica.Marca);
                Console.ReadKey();
                Console.WriteLine("Modelo: " + basica.Modelo);
                Console.ReadKey();

            
            Console.WriteLine("Ingrese 1º Número");
            basica.Num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Escoja operación [+] [-] [*] [/]");
            basica.Operacion = (Console.ReadLine());

            Console.WriteLine("Ingrese 2º Número");
            basica.Num2 = float.Parse(Console.ReadLine());

                switch (basica.Operacion)
            {
                case "+":
                    {
                        Console.WriteLine(basica.Sumar());
                        Console.ReadKey();
                    }
                    break;
                case "-":
                    {
                        Console.WriteLine(basica.Restar());
                        Console.ReadKey();
                    }
                    break;
                case "*":
                    {
                        Console.WriteLine(basica.Multiplicar());
                        Console.ReadKey();
                    }
                    break;
                case "/":
                    {
                        Console.WriteLine(basica.Dividir());
                        Console.ReadKey();
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Operación inválida");
                        Console.ReadKey();
                    }
                    break;
            
            }
            }
            if (opcion == 2)
            {
                Console.WriteLine("Tipo: " + pro.Tipo);
                Console.ReadKey();
                Console.WriteLine("Marca: " + pro.Marca);
                Console.ReadKey();
                Console.WriteLine("Modelo: " + pro.Modelo);
                Console.ReadKey();


                Console.WriteLine("Ingrese Número");
                pro.Num1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Escoja operación: [mayor o menor] / [igual o distinto] / [al cuadrado] / [al cubo]");
                pro.Operacion = (Console.ReadLine());

                if (pro.Operacion == "mayor o menor" || pro.Operacion == "igual o distinto")
                {
                    Console.WriteLine("Ingrese otro Número");
                    pro.Num2 = float.Parse(Console.ReadLine());
                }

                switch (pro.Operacion)
                {
                    case "mayor o menor":
                        {
                            Console.WriteLine(pro.MayorMenor());
                            Console.ReadKey();
                        }
                        break;
                    case "igual o distinto":
                        {
                            Console.WriteLine(pro.IgualDistinto());
                            Console.ReadKey();
                        }
                        break;
                    case "al cuadrado":
                        {
                            Console.WriteLine(pro.Cuad());
                            Console.ReadKey();
                        }
                        break;
                    case "al cubo":
                        {
                            Console.WriteLine(pro.Cubo());
                            Console.ReadKey();
                        }
                        break;
                    default:
                        {
                            Console.WriteLine("Operación inválida");
                            Console.ReadKey();
                        }
                        break;
                }
            }


        }
    }
}
