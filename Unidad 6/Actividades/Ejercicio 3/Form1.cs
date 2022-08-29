﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace U6Proyecto4
{
    public partial class Form1 : Form
    {
        private List<Pais> listaPais;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PaisService service = new PaisService();
            listaPais = service.listar();
            dgvPaises.DataSource = listaPais;
            cargarImagen(listaPais[0].ImagenMapa);
            dgvPaises.Columns["ImagenMapa"].Visible = false;
        }

        private void dgvPaises_SelectionChanged(object sender, EventArgs e)
        {
            Pais seleccionado = (Pais)dgvPaises.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.ImagenMapa);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbxPaises.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxPaises.Load("https://wolper.com.au/wp-content/uploads/2017/10/image-placeholder.jpg");
            }
        }
    }
}
