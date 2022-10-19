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
using datos;
using System.IO;
using System.Configuration;

namespace presentacion
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;
        public frmAltaArticulo()
        {
            InitializeComponent();
            Text = "Agregar artículo";
        }
        public frmAltaArticulo(Articulo articulo)
        {
            this.articulo = articulo;
            InitializeComponent();
            Text = "Modificar artículo";
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {            
            ArticuloDatos datos = new ArticuloDatos();
            try
            {
                if (validarFiltro())
                {
                    return;
                }

                if (articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.MarcaArticulo = (Marca)cboMarca.SelectedItem;
                articulo.CategoriaArticulo = (Categoria)cboCategoria.SelectedItem;
                articulo.ImagenUrl = txtUrlImagen.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);

                if (articulo.Id == 0)
                {
                    datos.agregar(articulo);
                    MessageBox.Show("Agregado exitosamente");
                }
                else
                {
                    datos.modificar(articulo);
                    MessageBox.Show("Modificado exitosamente");
                }

                if (archivo != null && !(txtUrlImagen.Text.ToUpper().Contains("HTTP")))
                {
                    if (!(archivo.CheckFileExists))
                    {
                        File.Copy(archivo.FileName, ConfigurationManager.AppSettings["CatalagoApp"] + archivo.SafeFileName);
                    }
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private bool validarFiltro()
        {
            if(txtDescripcion.Text == "" || txtPrecio.Text == "" || cboMarca.Text == "" || cboCategoria.Text == "")
            {
                MessageBox.Show("Campos obligatorios incompletos");
                return true;
            }
            if (!(soloNumeros(txtPrecio.Text)))
            {
                MessageBox.Show("Solo números admitidos en el campo 'Precio'");
                return true;
            }
            return false;
        }
        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }
        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaDatos marcaDatos = new MarcaDatos();
            CategoriaDatos categoriaDatos = new CategoriaDatos();
            try
            {
                cboMarca.DataSource = marcaDatos.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";
                cboMarca.SelectedIndex = -1;
                cboCategoria.DataSource = categoriaDatos.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";
                cboCategoria.SelectedIndex = -1;

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtUrlImagen.Text = articulo.ImagenUrl;
                    cargarImagen(articulo.ImagenUrl);
                    txtPrecio.Text = articulo.Precio.ToString();
                    cboMarca.Text = articulo.MarcaArticulo.ToString();
                    cboCategoria.Text = articulo.CategoriaArticulo.ToString();
                }

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
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArticulo.Load("https://wolper.com.au/wp-content/uploads/2017/10/image-placeholder.jpg");
            }
        }
        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }
        private OpenFileDialog archivo = null;
        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if(archivo.ShowDialog() == DialogResult.OK)
            {
                txtUrlImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
        }
    }
}
