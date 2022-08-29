using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U6._3FinallyThrow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //int a, b, r;
            int resultado;
            try
            {
                //a = int.Parse(text1.Text);
                //b = int.Parse(text2.Text);
                //r = a / b;
                resultado = calcular();
                lblResultado.Text = "= " + resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no reconocido. Contacte a su desarrollador");
            }
            finally
            {

            }

        }
        //METODO PRIVADO
        private int calcular()
        {
            int a, b, r;
            try
            {
                a = int.Parse(txt1.Text);
                b = int.Parse(txt2.Text);
                r = a / b;
                lblResultado.Text = "= " + r;
                return r;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
