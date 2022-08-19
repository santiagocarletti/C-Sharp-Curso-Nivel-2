using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica5AppWin2
{
    //TEMATICA EJERCICIO 5: APLICACIÓN WINDOWS 2
    //
    //ENUNCIADO:
    //Generar un Formulario con los controles y diseño que se muestran en la siguiente
    //imagen:
    //    Al presionar el botón aceptar se debe validar que los text Apellido, Nombre, Edad y
    //    Dirección tengan datos, en caso de estar vacíos marcarlos de color rojo.
    //    Si pasa la validación los datos se deben escribir en el text de resultado (TextBox
    //    multilínea) con el siguiente formato: 
    //Apellido y Nombre: XXXXXXXXXXXXXXX
    //    Edad: XXX
    //    Dirección: XXXXXXXXXXXXXXXXXXXXX
    //    En el campo Edad solo debe aceptar Números.
    //    En todos los campos limitar la cantidad de caracteres y pasarlos a mayúsculas.
    //
    //    Al presionar el botón Cancelar se debe cerrar la aplicación.

    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
