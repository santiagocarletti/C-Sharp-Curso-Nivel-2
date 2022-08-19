using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3LabelYLinkLabel
{    
    //TEMATICA EJERCICIO 3: CONTROL LABEL Y LINKLABEL
    //
    //ENUNCIADO:
    //1. Agregar un Label al Formulario.
    //2. Analizamos el archivo Form1.Designer.cs.
    //3. Cambiamos el nombre del Label, con la propiedad Name. 
    //4. Cambiamos el Texto del Label con la propiedad Text.
    //5. Desplegamos el Cuadro de Dialogo de la propiedad Font y cambiamos Tipo Letra,
    //Tamaño y estilo.
    //6. Cambiamos el color del Texto, desplegando la paleta de colores personalizados de
    //la propiedad ForeColor. 
    //7. Aplicamos un borde 3D con la propiedad BorderStyle. 
    //8. Manejar el evento MouseMove del Control Label.En la ventana de eventos elijo
    //MouseMove.
    //private void lblEtiqueta_MouseMove(object sender, MouseEventArgs e)
    //    {
    //    } 
    //9. Cambiamos el color de la propiedad BackColor.
    //private void lblEtiqueta_MouseMove(object sender, MouseEventArgs e)
    //    {
    //        lblEtiqueta.BackColor = Color.Cyan;
    //    } 
    //10.Al dispararse el evento MouseLeave, se restablezca el color de fondo de la etiqueta.
    //private void lblEtiqueta_MouseLeave(object sender, EventArgs e)
    //    {
    //        lblEtiqueta.BackColor = System.Drawing.SystemColors.Control;
    //    } 
    //11.Cambiar el estilo del cursor al dispararse los eventos MouseMove y MouseLeave.
    //private void lblEtiqueta_MouseMove(object sender, MouseEventArgs e)
    //    {
    //        lblEtiqueta.BackColor = Color.Cyan;
    //        lblEtiqueta.Cursor = Cursors.Hand;
    //    }
    //    private void lblEtiqueta_MouseLeave(object sender, EventArgs e)
    //    {
    //        lblEtiqueta.BackColor = System.Drawing.SystemColors.Control;
    //        lblEtiqueta.Cursor = Cursors.Arrow;
    //    }
    
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
