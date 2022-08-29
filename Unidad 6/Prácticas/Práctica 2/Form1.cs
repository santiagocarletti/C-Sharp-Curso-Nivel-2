using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._6DiscosPract1
{
    public partial class Form1 : Form
    {
    private List<Disco> listaDisco;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DiscoDatos datos = new DiscoDatos();
            listaDisco = datos.listar();
            dgvDiscos.DataSource = listaDisco;
            pbxDiscos.Load(listaDisco[0].UrlImagenTapa);
        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            Disco seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagenTapa);
        }
        private void cargarImagen (string imagen)
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
    }
}
