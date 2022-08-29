using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U6Proyecto1
{
    //ENUNCIADO ACTIVIDAD UNIDAD 6:
    //Hora de poner manos a la obra.
    //A partir de la DB que te di en la unidad anterior, la idea es que crees tu propio proyecto
    //.Net Framework en el que de a poco vayas aplicando lo que estamos viendo en esta unidad.
    //No hay más consigna que esa, y unidad tras unidad, las novedades que vayamos viendo, 
    //deberás ir aplicándolas a tu proyecto.
    //A meterle. Cualquier duda en el camino, ya sabés!
    //Saludos.
    //
    //TEMATICA PRACTICA: PICTUREBOX - MOSTRAR IMAGEN DESDE DB
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
            Application.Run(new FormPaises());
        }
    }
}
