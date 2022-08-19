using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica5AppWin2
{
    //[HAY PUNTOS PENDIENTES (1)]
    //PRÁCTICA 5 (APLICACIÓN WINDOWS 2) 
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

//    Al presionar el botón Cancelar se debe cerrar la aplicación. [FALTA ESTO]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int validacion = 0;
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                textBox1.BackColor = Color.Red;
            else
            {
                textBox1.BackColor = System.Drawing.SystemColors.Control;
                validacion++;
            }
            if (textBox2.Text == "")
                textBox2.BackColor = Color.Red;
            else
            {
                textBox2.BackColor = System.Drawing.SystemColors.Control;
                validacion++;
            }
            if (textBox3.Text == "")
                textBox3.BackColor = Color.Red;
            else
            {
                textBox3.BackColor = System.Drawing.SystemColors.Control;
                validacion++;
            }
            if (textBox4.Text == "")
                textBox4.BackColor = Color.Red;          
            else
            {
                textBox4.BackColor = System.Drawing.SystemColors.Control;
                validacion++;
            }
            if (validacion == 4)
            {
                textBox5.Text = ("Apellido y Nombre: " + textBox1.Text + ", " + textBox2.Text + Environment.NewLine + "Edad: " + textBox4.Text + Environment.NewLine + "Dirección: " + textBox3.Text);
            }

        }


    }
}
