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
    public partial class UsuarioForm : Form
    {
        public Usuario NuevoUsuario { get; set; }

        public UsuarioForm()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            NuevoUsuario = new Usuario
            {
                Id = txtId.Text,
                Nombre = txtNombre.Text,
                Correo = txtCorreo.Text
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            NuevoUsuario = new Usuario
            {
                Id = txtId.Text,
                Nombre = txtNombre.Text,
                Correo = txtCorreo.Text
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
