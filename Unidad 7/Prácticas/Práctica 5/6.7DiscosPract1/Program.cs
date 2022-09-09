using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._7DiscosPract1
{
    //TEMATICA PRACTICA 5: INSERT ESTILO Y TIPO DE EDICION - PARAMETROS DEL COMANDO
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
            Application.Run(new FormDiscos());
        }
    }
}
