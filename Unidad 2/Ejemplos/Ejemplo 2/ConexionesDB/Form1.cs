using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionesDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int resultado;
            try
            {
                resultado = calcular();
                lblResultado.Text = "= " + resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error no reconocido, contacte a su dev");
            }
            finally
            {

            }
            }
            
            private int calcular()
            {
                int a, b, r;
                try
                {
                    a = int.Parse(txtUno.Text);
                    b = int.Parse(txtDos.Text);
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
