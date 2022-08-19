using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemplosControles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elem = txtNombre.Text;
            lwElementos.Items.Add(elem);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CboColorFavorito.Items.Add("Rojo");
            CboColorFavorito.Items.Add("Verde");
            CboColorFavorito.Items.Add("Negro");
        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFechaNacimiento.Value;
            
            //OPERADOR TERNARIO
            string chocolate = ckbChocolate.Checked == true ? " Le gusta el chocolate" : " Odia el chocolate";
            string tipo;
            if (rbtMuggle.Checked)
                tipo = "Muggle";
            else if (rbtWizard.Checked)
                tipo = "Wizard";
            else
                tipo = "Squibs";
            string colorFavorito = CboColorFavorito.SelectedItem.ToString();
            string numeroFavorito = numNumeroFavorito.Value.ToString();

            string mensaje = "Nombre: " + nombre + ". Fecha de nacimiento: " + fecha + "." + chocolate + ". Es " + tipo + ". Su color favorito es el " + colorFavorito + " y su número favorito es el " + numeroFavorito;
            MessageBox.Show(mensaje);

        }

    }
}
