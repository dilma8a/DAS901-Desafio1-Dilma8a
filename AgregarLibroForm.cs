using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAS901_Desafio1_Dilma8a
{
    public partial class AgregarLibroForm : Form
    {
        public Libro NuevoLibro { get; set; }

        public AgregarLibroForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            NuevoLibro = new Libro
            {
                Id = txtId.Text,
                Titulo = txtTitulo.Text,
                Autor = txtAutor.Text,
                Anio = int.Parse(txtAnio.Text),
                Estado = cbxEstado.SelectedItem?.ToString()
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            NuevoLibro = new Libro
            {
                Id = txtId.Text,
                Titulo = txtTitulo.Text,
                Autor = txtAutor.Text,
                Anio = int.Parse(txtAnio.Text),
                Estado = cbxEstado.SelectedItem?.ToString()
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cbxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
