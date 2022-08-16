using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revEjem2_1
{
    //TEMATICA EJEMPLO 5
    //CLASES Y OBJETOS
    internal class Program
    {
        static void Main(string[] args)
        {
            //ENUNCIADO EJEMPLO 2
            //Primer lote con 10 registros de productos, cada producto tiene:
            //-Código Artículo (3 dígitos no correlativos)
            //-Precio
            //-Código de Marca (1 a 10)
            //Segundo lote con las ventas de la semana. Cada venta tiene:
            //-Código Artículo
            //-Cantidad
            //-Código Cliente (1 a 100)
            //Este lote corta con Código de Cliente cero.

            Articulo[] articulos = new Articulo[10];

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese los datos del producto");
                Console.WriteLine("Ingrese código");
                articulos[x].CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese precio");
                articulos[x].Precio = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese marca (1 a 10)");
                articulos[x].CodMarca = int.Parse(Console.ReadLine());
            }
            //CARGADO EL VECTOR COMPLETO CON LOS 10 ARTICULOS
            Venta venta = new Venta();

            Console.WriteLine("Ingrese la venta");
            Console.WriteLine("Ingrese el código de cliente:");
            venta.CodigoCliente = int.Parse(Console.ReadLine());

            while (venta.CodigoCliente != 0)
            { 
            Console.WriteLine("Ingrese código de artículo:");
            venta.CodigoArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cantidad:");
            venta.Cantidad = int.Parse(Console.ReadLine());

            //PROCESA
            //VUELVO A PEDIR CLIENTE

            Console.WriteLine("Ingrese la venta");
            Console.WriteLine("Ingrese el código de cliente:");
            venta.CodigoCliente = int.Parse(Console.ReadLine());
            }
        }
    }
}
