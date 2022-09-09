using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace _6._7DiscosPract1
{
    public partial class frmAltaDisco : Form
    {
        public frmAltaDisco()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Disco disco = new Disco();
            DiscoDatos datos = new DiscoDatos();
            try
            {
                disco.Titulo = txtTitulo.Text;
                disco.FechaLanzamiento = DateTime.Parse(txtFechaLanzamiento.Text);
                disco.CantidadCanciones = int.Parse(txtCantidadCanciones.Text);
                disco.UrlImagenTapa = txtUrlImagen.Text;
                disco.EstiloDisco = (Estilo)cboEstilo.SelectedItem;
                disco.TipoEdicion = (Edicion)cboTipoEdicion.SelectedItem;

                datos.agregar(disco);
                MessageBox.Show("Agregado exitosamente");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaDisco_Load(object sender, EventArgs e)
        {
            EstiloDatos estiloDatos = new EstiloDatos();
            EdicionDatos edicionDatos = new EdicionDatos();
            try
            {
                cboEstilo.DataSource = estiloDatos.listar();
                cboTipoEdicion.DataSource = edicionDatos.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void cargarImagen(string imagen)
        {
            try
            {

                pbxDiscos.Load(imagen);
            }
            catch (Exception ex)
            {

                pbxDiscos.Load("https://th.bing.com/th/id/OIP.pk3cptcdmnusyGuq627x6gHaF6?pid=ImgDet&rs=1");
            }
        }
        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }
    }
}
