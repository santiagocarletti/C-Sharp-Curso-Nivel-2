using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1MiPrueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Carnes");
            comboBox1.Items.Add("Pastas");
        }

        Persona persona1 = new Persona();
        private void btnPresentacion_Click(object sender, EventArgs e)
        {
            persona1.Nombre = txtNombre.Text;
            persona1.Nacimiento = dtpNacimiento.Value.ToString();
            persona1.TipoComida = comboBox1.SelectedItem.ToString();

            MessageBox.Show(persona1.presentarse());
        }

        Usuario usuario1 = new Usuario();
        private void btnPresentacionUsuario_Click(object sender, EventArgs e)
        {
            usuario1.Nombre = txtNombreUsuario.Text;
            usuario1.Edad = nudEdadUsuario.Value.ToString();
            string lugar;
            if (rbCiudad.Checked)
                lugar = "ciudad";
            else
                lugar = "campo";
            usuario1.PreferenciaLugar = lugar;

            MessageBox.Show(usuario1.presentarse());
        }
    }

}
