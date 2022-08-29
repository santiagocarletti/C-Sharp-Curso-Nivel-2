using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U6._2ManejoExcepciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int a, b, r;
            try
            {
                a = int.Parse(txt1.Text);
                b = int.Parse(txt2.Text);
                r = a / b;
                lblResultado.Text = "= " + r;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Por favor, cargar solo números");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("No se puede dividir por cero");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no reconocido. Contacte a su desarrollador");
            }
        }
    }
}
