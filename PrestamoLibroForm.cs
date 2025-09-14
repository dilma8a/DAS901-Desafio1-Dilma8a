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
    public partial class PrestamoLibroForm : Form
    {
        public PrestamoLibro prestamoLibro { get; set; }
        public String idLibroAPrestar { get; set; }
        public String esDevolucion { get; set; }

        public PrestamoLibroForm()
        {
            InitializeComponent();
            // Permitir solo una selección en cbxEsDevolucion
            cbxEsDevolucion.CheckOnClick = true;
            cbxEsDevolucion.ItemCheck += (s, e) =>
            {
                if (e.NewValue == CheckState.Checked)
                {
                    for (int i = 0; i < cbxEsDevolucion.Items.Count; i++)
                    {
                        if (i != e.Index)
                            cbxEsDevolucion.SetItemChecked(i, false);
                    }
                }
            };
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cbxLibro.SelectedIndex > 0)
            {
                idLibroAPrestar = cbxLibro.SelectedItem.ToString().Split("-")[0];
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione el libro a prestar.");
            }
        }

        private void lblFechaDevoluacion_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (cbxLibro.SelectedIndex > 0)
            {
                idLibroAPrestar = cbxLibro.SelectedItem.ToString().Split("-")[0];
                if (cbxEsDevolucion.CheckedItems.Count > 0)
                    esDevolucion = cbxEsDevolucion.CheckedItems[0].ToString();
                
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione el libro a prestar.");
            }
        }
    }
}
