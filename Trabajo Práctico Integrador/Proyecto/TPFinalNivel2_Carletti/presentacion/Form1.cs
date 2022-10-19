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

namespace presentacion
{
    public partial class Form1 : Form
    {
        private List<Articulo> listaArticulo;
        public Form1()
        {
            InitializeComponent();
            Text = "Artículos - Principal";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargar();
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Precio");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Artículo");
        }
        private void cargar()
        {
            ArticuloDatos datos = new ArticuloDatos();
            try
            {
                listaArticulo = datos.listar();
                dgvArticulos.DataSource = listaArticulo;

                ocultarColumnas();

                cargarImagen(listaArticulo[0].ImagenUrl);
            }
                catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void ocultarColumnas()
        {
                dgvArticulos.Columns["ImagenUrl"].Visible = false;
                dgvArticulos.Columns["Id"].Visible = false;
                dgvArticulos.Columns["Codigo"].Visible = false;
                dgvArticulos.Columns["Descripcion"].Visible = false;
        }
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.ImagenUrl);
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
        private void btnOpcionesAvanzadas_Click(object sender, EventArgs e)
        {
            Form2 avanzadas = new Form2();
            avanzadas.ShowDialog();
            cargar();
        }
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtFiltro.Text;

            List<Articulo> listaFiltrada;

            if(filtro != "")
            {
                if(txtFiltroAvanzado.Text != "")
                {
                    txtFiltroAvanzado.Text = "";
                }
                
                listaFiltrada = listaArticulo.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Precio.ToString().Contains(filtro) || x.MarcaArticulo.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.CategoriaArticulo.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulo;
            }
 
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            if (dgvArticulos.CurrentRow == null)
            {
                pbxArticulo.Load("https://wolper.com.au/wp-content/uploads/2017/10/image-placeholder.jpg");
            }
            ocultarColumnas();
        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if(opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }

        string campo;
        private void btnFiltro_Click(object sender, EventArgs e)
        {
            ArticuloDatos datos = new ArticuloDatos();
            try
            {
                if(txtFiltro.Text != "")
                {
                    txtFiltro.Text = "";
                }
                if (validarFiltro())
                {
                    return;
                }
                
                if(cboCampo.Text == "Marca")
                {
                    campo = "M.Descripcion";
                }
                else if(cboCampo.Text == "Artículo")
                {
                    campo = "C.Descripcion";
                }
                else
                {
                    campo = cboCampo.SelectedItem.ToString();
                }

                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;
                dgvArticulos.DataSource = datos.filtrar(campo, criterio, filtro);
                if (dgvArticulos.CurrentRow == null)
                {
                    pbxArticulo.Load("https://wolper.com.au/wp-content/uploads/2017/10/image-placeholder.jpg");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private bool validarFiltro()
        {
            if (string.IsNullOrEmpty(txtFiltroAvanzado.Text) || cboCampo.SelectedIndex < 0 || cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Búsqueda incompleta o valores incorrectos");
                return true;
            }
            if (cboCampo.SelectedItem.ToString() == "Precio")
            {
                if (!(soloNumeros(txtFiltroAvanzado.Text)))
                {
                    MessageBox.Show("Solo números permitidos para esta opción de búsqueda");
                    return true;
                }
            }            
            return false;
        }
        private bool soloNumeros(string cadena)
        {
            foreach(char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private void txtFiltroAvanzado_TextChanged(object sender, EventArgs e)
        {
            if(txtFiltroAvanzado.Text == "")
            {
                dgvArticulos.DataSource = listaArticulo;
            }
        }
    }
}
