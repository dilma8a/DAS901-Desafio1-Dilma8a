using System.Windows.Forms;

namespace DAS901_Desafio1_Dilma8a
{
    public partial class Form1 : Form
    {
        List<Libro> listaLibro = new List<Libro>();
        DataGridView dgvLibros = new DataGridView();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();

            dgvLibros.Dock = DockStyle.Fill;
            dgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            panelPrincipal.Controls.Add(dgvLibros);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarLibro_Click_1(object sender, EventArgs e)
        {
            AgregarLibroForm formAgregar = new AgregarLibroForm();
            formAgregar.btnActualizar.Enabled = false;
            formAgregar.btnGuardar.Enabled = true;
            if (formAgregar.ShowDialog() == DialogResult.OK)
            {
                Libro nuevo = formAgregar.NuevoLibro;
                listaLibro.Add(nuevo);
            }

            panelPrincipal.Controls.Clear();
            dgvLibros.DataSource = listaLibro;
            panelPrincipal.Controls.Add(dgvLibros);
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();

            dgvLibros.Dock = DockStyle.Fill;
            dgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            Libro libro1 = new Libro();
            libro1.Id = "1";
            libro1.Titulo = "ADSFASDF dadsfasd";
            libro1.Autor = "aksljd";
            libro1.Anio = 2020;
            Libro libro2 = new Libro();
            libro2.Id = "2";
            libro2.Titulo = "tgsfg fasdf";
            libro2.Autor = "aksljd";
            libro2.Anio = 2020;
            listaLibro.Add(libro1);
            listaLibro.Add(libro2);
            dgvLibros.DataSource = listaLibro;

            panelPrincipal.Controls.Add(dgvLibros);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvLibros.CurrentRow != null)
            {
                Console.WriteLine(dgvLibros.CurrentRow);

                AgregarLibroForm formAgregar = new AgregarLibroForm();
                formAgregar.btnGuardar.Enabled = false;
                formAgregar.btnActualizar.Enabled = true;
                formAgregar.txtId.Text = dgvLibros.CurrentRow.Cells[0].Value.ToString();
                formAgregar.txtTitulo.Text = dgvLibros.CurrentRow.Cells[1].Value.ToString();
                formAgregar.txtAutor.Text = dgvLibros.CurrentRow.Cells[2].Value.ToString();
                formAgregar.txtAnio.Text = dgvLibros.CurrentRow.Cells[3].Value.ToString();

                if (formAgregar.ShowDialog() == DialogResult.OK)
                {
                    Libro libroEditado = formAgregar.NuevoLibro;

                    foreach (Libro libro in listaLibro)
                    {
                        if (libro.Id == libroEditado.Id)
                        {
                            libro.Titulo = libroEditado.Titulo;
                            libro.Autor = libroEditado.Autor;
                            libro.Anio = libroEditado.Anio;
                        }
                    }
                    MessageBox.Show("Libro actualizado exitosamente.");

                }

                panelPrincipal.Controls.Clear();
                dgvLibros.DataSource = listaLibro;
                panelPrincipal.Controls.Add(dgvLibros);

            }
            else
            {
                MessageBox.Show("No ha seleccionado ningun registro todavia");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvLibros.CurrentRow != null)
            {
                string id = dgvLibros.CurrentRow.Cells[0].Value.ToString();
                var resultado = MessageBox.Show("¿Estás seguro de que quiere eliminar el registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                Console.WriteLine(resultado);
                if (resultado == DialogResult.Yes)
                {
                    int indiceAEliminar = -1, i = 0;
                    foreach (Libro libro in listaLibro)
                    {
                        if (libro.Id == id)
                        {
                            indiceAEliminar = i;
                        }
                        i++;
                    }

                    listaLibro.RemoveAt(indiceAEliminar);
                    panelPrincipal.Controls.Clear();
                    dgvLibros.DataSource = listaLibro;
                    panelPrincipal.Controls.Add(dgvLibros);
                }
            }
            else
            {
                MessageBox.Show("No ha seleccionado ningun registro todavia");
            }
        }
    }
}
