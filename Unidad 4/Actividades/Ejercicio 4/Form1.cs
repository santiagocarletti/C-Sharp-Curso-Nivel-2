using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica4TextBox
{
//PRACTICA 4 (CONTROL TEXTBOX) 
//1. Agregar un Control TextBox al Formulario.
//2. Analizamos el archivo Form1.Designer.cs.
//3. Cambiamos el nombre del Control TextBox, con la propiedad Name. 
//4. Cambiamos la cantidad de Caracteres que acepta el Control TextBox, con la
//propiedad MaxLength.
//5. Cambiamos la propiedad CharacterCasing del Control TextBox, para que cambie a
//mayúsculas los caracteres que se ingresan.
//6. En el evento Click del botón creado anteriormente, cancelamos las líneas de código
//anteriores y colocamos el código para cambiar el color de fondo del TextBox
//(Propiedad BackColor) si el TextBox se encuentra vació.
//private void btnBoton_Click(object sender, EventArgs e)
//    {
//        //MessageBox.Show("Se disparo el evento Click", "Atención");
//        //this.BackColor = Color.Blue; 
//        if (txtApellido.Text == "")
//            txtApellido.BackColor = Color.Red;
//        else
//            txtApellido.BackColor = System.Drawing.SystemColors.Control;
//    } 
//7. Manejar el evento KeyPress, para ingresar solo Números
//private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
//    {
//        if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
//            e.Handled = true;
//    } 
//8. Agregar otro Control TextBox, cambiar la propiedad Name.
//9. Colocar en True la propiedad Multiline del nuevo Control TextBox. (Run)
//10.Cambiar la propiedad ScrollBars del nuevo Control TextBox. (Run)
//11.Manejar el evento Leave del nuevo Control TextBox.Para mostrar cuantos
//caracteres se ingresaron una vez que el control pierde el foco.
//private void txtNuevo_Leave(object sender, EventArgs e)
//    {
//        MessageBox.Show("Tiene " + txtNuevo.Text.Length + " Caracteres");
//    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text == "CARLETTI")
                txtBox1.BackColor = Color.Red;
            else
                txtBox1.BackColor = System.Drawing.SystemColors.Control;
        }

        private void txtBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                    e.Handled = true;
            }
        }

        private void txtBox2_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + txtBox2.Text.Length + " caracteres");
        }
    }
}
