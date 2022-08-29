using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U6Proyecto1
{
    public partial class FormPaises : Form
    {
        public FormPaises()
        {
            InitializeComponent();
        }

        private void FormPaises_Load(object sender, EventArgs e)
        {
            PaisService service = new PaisService();
            dgvPaises.DataSource = service.listar();
        }
    }
}
