﻿using System;
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
    public partial class FormDiscos : Form
    {
        private List<Disco> listaDiscos;
        public FormDiscos()
        {
            InitializeComponent();
        }

        private void FormDiscos_Load(object sender, EventArgs e)
        {
            cargar();
        }
        private void cargar()
        {
            DiscoDatos datos = new DiscoDatos();
            try
            {
                listaDiscos = datos.listar();
                dgvDiscos.DataSource = listaDiscos;
                cargarImagen(listaDiscos[0].UrlImagenTapa);
                dgvDiscos.Columns["UrlImagenTapa"].Visible = false;
                dgvDiscos.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            Disco seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagenTapa);
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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaDisco alta = new frmAltaDisco();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Disco seleccionado;
            seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem; 

            frmAltaDisco modificar = new frmAltaDisco(seleccionado);

            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            DiscoDatos datos = new DiscoDatos();
            Disco seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Está seguro de eliminar?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
                    datos.eliminar(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
