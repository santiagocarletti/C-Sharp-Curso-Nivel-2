using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._5DiscosPract1
{
    public partial class FormDisco : Form
    {
        public FormDisco()
        {
            InitializeComponent();
        }

        private void FormDisco_Load(object sender, EventArgs e)
        {
            DiscoDatos datos = new DiscoDatos();
            dgvDisco.DataSource = datos.listar();
        }
    }
}
