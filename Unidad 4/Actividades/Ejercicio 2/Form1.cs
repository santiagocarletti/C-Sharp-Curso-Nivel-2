using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2ControlButton
{
//PRACTICA 2 (CONTROL BUTTON) 
//1. Agregar un Control Button al Formulario.
//2. Analizamos el archivo Form1.Designer.cs.
//3. Cambiamos el nombre del Control Button, con la propiedad Name. 
//4. Cambiamos la etiqueta del Control Button, con la propiedad Text. (Run)
//5. Cambiamos el color del Control Button, con la propiedad BackColor. (Run)
//6. Cambiamos el estilo del Control Button, con la propiedad FlatStyle. (Run)
//7. Coloco un icono al Control Button, con la propiedad Image. 
//8. Deshabilitar el Control Button, con la propiedad Enabled. 
//9. Manejar el evento Click del Control Button.
//DobleClick sobre el Control Button carga el método del evento Click por defecto.
//private void btnBoton_Click(object sender, EventArgs e)
//    {
//    }
//    Mostramos un Mensaje con MessageBox.Show. (Run)
//private void btnBoton_Click(object sender, EventArgs e)
//    {
//        MessageBox.Show("Se disparo el evento Click", "Atención");
//    } 
//10.Al dispararse el evento Click, se cambie el color del Formulario.
//private void btnBoton_Click(object sender, EventArgs e)
//    {
//        //MessageBox.Show("Se disparo el evento Click", "Atención"); 
//        this.BackColor = Color.Blue;
//    } 
//11.Manejar el evento Click.del Formulario.Determinar que botón del Mouse se pulso.
//private void Form1_Click(object sender, EventArgs e)
//    {
//        MouseEventArgs click = (MouseEventArgs)e;
//        if (click.Button == MouseButtons.Left)
//            MessageBox.Show("Presiono el botón Izquierdo", "Atención");
//        else if (click.Button == MouseButtons.Right)
//            MessageBox.Show("Presiono el Botón Derecho", "Atención");
//        else
//        if (click.Button == MouseButtons.Middle)
//            MessageBox.Show("Presiono el botón del Medio", "Atención");
//    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se disparo el evento Click", "Atención");
            this.BackColor = Color.Blue;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;
            if (click.Button == MouseButtons.Left)
                MessageBox.Show("Presiono el botón Izquierdo", "Atención");
            else if (click.Button == MouseButtons.Right)
                MessageBox.Show("Presiono el Botón Derecho", "Atención");
            else
            if (click.Button == MouseButtons.Middle)
                MessageBox.Show("Presiono el botón del Medio", "Atención");
        }
    }
}
