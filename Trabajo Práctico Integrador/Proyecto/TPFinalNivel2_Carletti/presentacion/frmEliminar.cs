using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using datos;

namespace presentacion
{
    public partial class frmEliminar : Form
    {
        private Articulo articulo;
        public frmEliminar(Articulo articulo)
        {
            this.articulo = articulo;
            InitializeComponent();
            Text = "Artículo - Detalles / Eliminar";
        }

        private void frmEliminar_Load(object sender, EventArgs e)
        {
            txtId.Text = articulo.Id.ToString();
            txtCodigo.Text = articulo.Codigo;
            txtNombre.Text = articulo.Nombre;
            txtDescripcion.Text = articulo.Descripcion;
            txtPrecio.Text = articulo.Precio.ToString();
            txtMarca.Text = articulo.MarcaArticulo.Descripcion;
            txtCategoria.Text = articulo.CategoriaArticulo.Descripcion;
            cargarImagen(articulo.ImagenUrl);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArticulo.Load("https://wolper.com.au/wp-content/uploads/2017/10/image-placeholder.jpg");
            }
        }

        private void btnConfirmarEliminacion_Click(object sender, EventArgs e)
        {
            ArticuloDatos datos = new ArticuloDatos();
            try
            {
                datos.eliminar(articulo.Id);
                MessageBox.Show("Artículo eliminado");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
