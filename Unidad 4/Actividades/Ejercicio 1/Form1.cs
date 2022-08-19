using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerAplicacion
{
    //    PRACTICA 1 (FORM) 
    //1. Creamos un Proyecto nuevo con el nombre MiPrimerAplicacion.
    //2. Analizamos los archivos que nos creo el Proyecto. 
    //3. Cambiamos el nombre del Form1, con la propiedad Name. 
    //4. Cambiamos el titulo del Formulario, con la propiedad Text.
    //5. Cambiamos el color de fondo del Formulario, con la propiedad BackColor.
    //6. Cambiamos la posición del Formulario, con la propiedad StartPosition.
    //7. Cambiamos la vista inicial del Formulario (Normal, Minimizado o Maximizado), con
    //la propiedad WindowState.
    //8. Manejar el evento Load del Formulario. 
    //1. DobleClick sobre el Formulario carga el método del evento Load por defecto. 
    //private void Form1_Load(object sender, EventArgs e)
    //    {
    //    } 
    //2. Mostramos un Mensaje con MessageBox.Show.
    //private void Form1_Load(object sender, EventArgs e)
    //    {
    //        MessageBox.Show("Bienvenidos a C#");
    //    }    
    //9. Manejar el evento FormClosed del Formulario.
    //1. Mostramos un Mensaje con MessageBox.Show.
    //private void Form1_FormClosed(object sender, FormClosedEventArgs e)
    //    {
    //        MessageBox.Show("Chau Chau ...");
    //    }     
    //10.No mostrar el botón de minimizar.del Formulario.
    //11.No mostrar el botón de maximizar del Formulario. 
    //12.Modificar el valor de la propiedad Opacity.
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();
        }

        private void Formulario1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a C#");
        }

        private void Formulario1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Chau Chau ...");
        }
    }
}
