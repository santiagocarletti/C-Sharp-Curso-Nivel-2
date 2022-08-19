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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtBox1.Text == "")
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
