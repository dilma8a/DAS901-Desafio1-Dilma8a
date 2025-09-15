using System.ComponentModel;
using System.Windows.Forms;

namespace DAS901_Desafio1_Dilma8a
{
    public partial class Form1 : Form
    {
        BindingList<Libro> listaLibro = new BindingList<Libro>();
        BindingList<Usuario> listaUsuarios = new BindingList<Usuario>();
        BindingList<PrestamoLibro> listaPrestamos = new BindingList<PrestamoLibro>();
        DataGridView dataGridView = new DataGridView();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            lblTituloPrincipal.Text = "GESTION DE BIBLIOTECA - LIBROS";
            mostrarLibros();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            lblTituloPrincipal.Text = "GESTION DE BIBLIOTECA - USUARIOS";
            mostrarUsuarios();
        }

        private void btnAgregarLibro_Click_1(object sender, EventArgs e)
        {

            if (dataGridView.DataSource == listaLibro)
            {
                AgregarLibroForm formAgregar = new AgregarLibroForm();
                formAgregar.btnActualizar.Enabled = false;
                formAgregar.btnGuardar.Enabled = true;
                formAgregar.cbxEstado.SelectedItem = "Disponible";
                if (formAgregar.ShowDialog() == DialogResult.OK)
                {
                    Libro nuevo = formAgregar.NuevoLibro;
                    listaLibro.Add(nuevo);

                    dataGridView.DataSource = listaLibro;
                    panelPrincipal.Controls.Clear();
                    panelPrincipal.Controls.Add(dataGridView);
                    MessageBox.Show("Libro guardado exitosamente!");
                }

            }
            else if (dataGridView.DataSource == listaUsuarios)
            {
                UsuarioForm usuarioForm = new UsuarioForm();
                usuarioForm.btnActualizar.Enabled = false;
                usuarioForm.btnGuardar.Enabled = true;
                if (usuarioForm.ShowDialog() == DialogResult.OK)
                {
                    Usuario nuevo = usuarioForm.NuevoUsuario;
                    listaUsuarios.Add(nuevo);

                    dataGridView.DataSource = listaUsuarios;
                    panelPrincipal.Controls.Clear();
                    panelPrincipal.Controls.Add(dataGridView);
                    MessageBox.Show("Usuario guardado exitosamente!");
                }

            }
            else
            {
                string index = cbxUsuario.SelectedItem.ToString();
                if (index != "-- Seleccione Usuario --")
                {
                    PrestamoLibroForm prestamoLibroForm = new PrestamoLibroForm();
                    prestamoLibroForm.btnActualizar.Enabled = false;
                    prestamoLibroForm.btnGuardar.Enabled = true;
                    prestamoLibroForm.txtUsuario.Text = index;
                    prestamoLibroForm.cbxEsDevolucion.Visible = false;
                    prestamoLibroForm.lblEsDevoluacion.Visible = false;
                    //prestamoLibroForm.cbxLibro = new ComboBox();
                    prestamoLibroForm.cbxLibro.Items.Clear();
                    prestamoLibroForm.cbxLibro.Items.Add("-- Seleccione un Libro --");

                    foreach (var libro in listaLibro)
                    {
                        if (libro.Estado.Equals("Disponible"))
                        {
                            prestamoLibroForm.cbxLibro.Items.Add(libro.Id + "-" + libro.Titulo);
                        }
                    }
                    prestamoLibroForm.cbxLibro.SelectedIndex = 0;


                    if (prestamoLibroForm.ShowDialog() == DialogResult.OK)
                    {
                        PrestamoLibro nuevoPrestamo = new PrestamoLibro();
                        nuevoPrestamo.IdPrestamo = listaPrestamos.Count() + 1;
                        nuevoPrestamo.IdUsuario = index.Split("-")[0];

                        foreach (var libro in listaLibro)
                        {
                            if (libro.Id == prestamoLibroForm.idLibroAPrestar)
                            {
                                nuevoPrestamo.Id = libro.Id;
                                nuevoPrestamo.Titulo = libro.Titulo;
                                nuevoPrestamo.Autor = libro.Autor;
                                nuevoPrestamo.Anio = libro.Anio;
                                nuevoPrestamo.FechaPrestamo = DateOnly.FromDateTime(DateTime.Now).ToString("yyyy-MM-dd");
                                nuevoPrestamo.FechaDevolucion = string.Empty;
                                libro.Estado = "No Disponible";
                            }
                        }
                        listaPrestamos.Add(nuevoPrestamo);

                        mostrarPrestamos(filtrarPrestamos(index.Split("-")[0]), cbxUsuario.SelectedIndex);
                        MessageBox.Show("Prestamo guardado exitosamente!");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Primero seleccione un usuario.");
                }
            }


        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inizializarData();
            lblTituloPrincipal.Text = "GESTION DE BIBLIOTECA - PRESTAMOS";
            mostrarPrestamos(new BindingList<DatosPrestamo>(), 0);
        }

        private void inizializarData()
        {
            listaUsuarios.Add(new Usuario
            {
                Id = "001",
                Nombre = "Maria Jose Fernandez",
                Correo = "maria.jose@gmail.com"
            });
            listaUsuarios.Add(new Usuario
            {
                Id = "002",
                Nombre = "Juan Carlos Alvarado",
                Correo = "juan.alvarado@gmail.com"
            });
            listaUsuarios.Add(new Usuario
            {
                Id = "003",
                Nombre = "Pedro Alberto Hernandez",
                Correo = "pedro.hernandez@gmail.com"
            });

            listaLibro.Add(new Libro
            {
                Id = "001",
                Titulo = "El Principito",
                Autor = "Maria Aguilar",
                Anio = 1995,
                Estado = "Disponible"
            });

            listaLibro.Add(new Libro
            {
                Id = "002",
                Titulo = "Jicaras Tristes",
                Autor = "Alfredo Espino",
                Anio = 1990,
                Estado = "Disponible"
            });

            listaLibro.Add(new Libro
            {
                Id = "003",
                Titulo = "Cien años de soledad",
                Autor = "Gabriel Garcia Marquez",
                Anio = 1967,
                Estado = "Disponible"
            });
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {

                if (dataGridView.DataSource == listaLibro)
                {
                    AgregarLibroForm formAgregar = new AgregarLibroForm();
                    formAgregar.btnGuardar.Enabled = false;
                    formAgregar.btnActualizar.Enabled = true;
                    formAgregar.txtId.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
                    formAgregar.txtTitulo.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
                    formAgregar.txtAutor.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();
                    formAgregar.txtAnio.Text = dataGridView.CurrentRow.Cells[3].Value.ToString();
                    formAgregar.cbxEstado.SelectedItem = dataGridView.CurrentRow.Cells[4].Value.ToString();

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
                    dataGridView.DataSource = listaLibro;
                }
                else if (dataGridView.DataSource == listaUsuarios)
                {
                    UsuarioForm usuarioForm = new UsuarioForm();
                    usuarioForm.btnGuardar.Enabled = false;
                    usuarioForm.btnActualizar.Enabled = true;
                    usuarioForm.txtId.Text = dataGridView.CurrentRow.Cells[0].Value.ToString();
                    usuarioForm.txtNombre.Text = dataGridView.CurrentRow.Cells[1].Value.ToString();
                    usuarioForm.txtCorreo.Text = dataGridView.CurrentRow.Cells[2].Value.ToString();

                    if (usuarioForm.ShowDialog() == DialogResult.OK)
                    {
                        Usuario usuarioEditado = usuarioForm.NuevoUsuario;

                        foreach (Usuario usuario in listaUsuarios)
                        {
                            if (usuario.Id == usuarioEditado.Id)
                            {
                                usuario.Nombre = usuarioEditado.Nombre;
                                usuario.Correo = usuarioEditado.Correo;
                            }
                        }

                        panelPrincipal.Controls.Clear();
                        dataGridView.DataSource = listaUsuarios;
                        MessageBox.Show("Usuario actualizado exitosamente.");
                    }


                }
                else
                {
                    string index = cbxUsuario.SelectedItem.ToString();
                    if (index != "-- Seleccione Usuario --")
                    {
                        PrestamoLibroForm prestamoLibroForm = new PrestamoLibroForm();
                        prestamoLibroForm.btnActualizar.Enabled = true;
                        prestamoLibroForm.btnGuardar.Enabled = false;
                        prestamoLibroForm.txtUsuario.Text = index;
                        prestamoLibroForm.cbxEsDevolucion.Visible = true;
                        prestamoLibroForm.lblEsDevoluacion.Visible = true;
                        //prestamoLibroForm.cbxLibro = new ComboBox();
                        prestamoLibroForm.cbxLibro.Items.Clear();
                        prestamoLibroForm.cbxLibro.Items.Add("-- Seleccione un Libro --");


                        string idLibro = string.Empty;
                        foreach (var prestamoLibro in listaPrestamos)
                        {
                            if (Int32.Parse(dataGridView.CurrentRow.Cells[0].Value.ToString()) == prestamoLibro.IdPrestamo)
                            {
                                idLibro = prestamoLibro.Id;
                            }
                        }

                        string tituloLibro = string.Empty;
                        foreach (var libro in listaLibro)
                        {
                            if (libro.Estado.Equals("Disponible") || libro.Id == idLibro)
                            {
                                prestamoLibroForm.cbxLibro.Items.Add(libro.Id + "-" + libro.Titulo);
                                if (libro.Id == idLibro)
                                {
                                    tituloLibro = libro.Titulo;
                                }
                            }
                        }

                        prestamoLibroForm.cbxLibro.SelectedItem = idLibro + "-" + tituloLibro;


                        if (prestamoLibroForm.ShowDialog() == DialogResult.OK)
                        {
                            int indexLibro = -1, i = 0;
                            foreach (var libro in listaLibro)
                            {
                                if (libro.Id == idLibro)
                                {
                                    libro.Estado = "Disponible";
                                }
                                if (libro.Id == prestamoLibroForm.idLibroAPrestar)
                                {
                                    if (prestamoLibroForm.esDevolucion == "SI")
                                    {
                                        libro.Estado = "Disponible";
                                    }
                                    else
                                    {
                                        libro.Estado = "No Disponible";
                                    }
                                    indexLibro = i;
                                }
                                i++;
                            }

                            //MessageBox.Show("Id de la tabla original: " + idLibro+ ",  " );

                            foreach (PrestamoLibro prestamoLibro in listaPrestamos)
                            {
                                if (Int32.Parse(dataGridView.CurrentRow.Cells[0].Value.ToString()) == prestamoLibro.IdPrestamo)
                                {
                                    if (indexLibro > -1)
                                    {
                                        prestamoLibro.Id = listaLibro[indexLibro].Id;
                                        prestamoLibro.Titulo = listaLibro[indexLibro].Titulo;
                                        prestamoLibro.Autor = listaLibro[indexLibro].Autor;
                                        prestamoLibro.Anio = listaLibro[indexLibro].Anio;
                                    }
                                    if (prestamoLibroForm.esDevolucion == "SI")
                                    {
                                        prestamoLibro.FechaDevolucion = DateOnly.FromDateTime(DateTime.Now).ToString("yyyy-MM-dd");
                                    }
                                }
                            }

                            mostrarPrestamos(filtrarPrestamos(index.Split("-")[0]), cbxUsuario.SelectedIndex);
                            MessageBox.Show("Prestamo actualizado exitosamente!");
                        }


                    }
                    else
                    {
                        MessageBox.Show("Primero seleccione un usuario.");
                    }
                }

                panelPrincipal.Controls.Add(dataGridView);

            }
            else
            {
                MessageBox.Show("No ha seleccionado ningun registro todavia");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {

                string id = dataGridView.CurrentRow.Cells[0].Value.ToString();
                var resultado = MessageBox.Show("Esta seguro de que quiere eliminar el registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                Console.WriteLine(resultado);
                if (resultado == DialogResult.Yes)
                {
                    if (dataGridView.DataSource == listaLibro)
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
                        dataGridView.DataSource = listaLibro;
                    }
                    else if (dataGridView.DataSource == listaUsuarios)
                    {
                        int indiceAEliminar = -1, i = 0;
                        foreach (Usuario usuario in listaUsuarios)
                        {
                            if (usuario.Id == id)
                            {
                                indiceAEliminar = i;
                            }
                            i++;
                        }

                        listaUsuarios.RemoveAt(indiceAEliminar);

                        dataGridView.DataSource = listaUsuarios;
                    }
                    panelPrincipal.Controls.Clear();
                    panelPrincipal.Controls.Add(dataGridView);
                }


            }
            else
            {
                MessageBox.Show("No ha seleccionado ningun registro todavia");
            }
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            lblTituloPrincipal.Text = "GESTION DE BIBLIOTECA - PRESTAMOS";
            mostrarPrestamos(new BindingList<DatosPrestamo>(), 0);
        }

        private void mostrarLibros()
        {
            panelPrincipal.Controls.Clear();

            dataGridView.Dock = DockStyle.Fill;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoGenerateColumns = true;
            dataGridView.DataSource = listaLibro;

            if (dataGridView.Columns.Count >= 5)
            {
                dataGridView.Columns[0].HeaderText = "ID";
                dataGridView.Columns[1].HeaderText = "Título";
                dataGridView.Columns[2].HeaderText = "Autor";
                dataGridView.Columns[3].HeaderText = "Año";
                dataGridView.Columns[4].HeaderText = "Estado";
            }

            panelPrincipal.Controls.Add(dataGridView);

            panelUsuario.Visible = false;
        }

        private void mostrarUsuarios()
        {
            panelPrincipal.Controls.Clear();

            dataGridView.Dock = DockStyle.Fill;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoGenerateColumns = true;
            dataGridView.DataSource = listaUsuarios;

            if (dataGridView.Columns.Count >= 3)
            {
                dataGridView.Columns[0].HeaderText = "ID";
                dataGridView.Columns[1].HeaderText = "Nombre";
                dataGridView.Columns[2].HeaderText = "Correo Electrónico";
            }

            panelPrincipal.Controls.Add(dataGridView);

            panelUsuario.Visible = false;
        }

        private void mostrarPrestamos(BindingList<DatosPrestamo> prestamosUsuario, int selectedIndex)
        {
            panelPrincipal.Controls.Clear();

            dataGridView.Dock = DockStyle.Fill;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.Margin = new Padding(0, 30, 0, 0);

            Label lblUsuario = new Label();
            lblUsuario.Text = "Usuario:";
            lblUsuario.AutoSize = true;
            lblUsuario.TextAlign = ContentAlignment.MiddleLeft;
            lblUsuario.Location = new Point(10, 25);

            cbxUsuario = new ComboBox();
            cbxUsuario.Items.Clear();
            cbxUsuario.Items.Add("-- Seleccione Usuario --");
            foreach (Usuario usuario in listaUsuarios)
            {
                cbxUsuario.Items.Add(usuario.Id + "-" + usuario.Nombre);
            }
            cbxUsuario.SelectedIndex = selectedIndex;
            cbxUsuario.SelectedIndexChanged -= cbxUsuario_SelectedIndexChanged;
            cbxUsuario.SelectedIndexChanged += cbxUsuario_SelectedIndexChanged;
            cbxUsuario.Size = new Size(450, 40);
            int espacioEntreControles = 30;
            cbxUsuario.Location = new Point(lblUsuario.Location.X + lblUsuario.Width + espacioEntreControles, 20);

            dataGridView.AutoGenerateColumns = true;
            dataGridView.DataSource = prestamosUsuario;

            if (dataGridView.Columns.Count >= 4)
            {
                dataGridView.Columns[0].HeaderText = "ID";
                dataGridView.Columns[1].HeaderText = "Libro";
                dataGridView.Columns[2].HeaderText = "Fecha de Préstamo";
                dataGridView.Columns[3].HeaderText = "Fecha de Devolución";
            }

            panelPrincipal.Controls.Add(dataGridView);

            panelUsuario.Controls.Clear();
            panelUsuario.Controls.Add(lblUsuario);
            panelUsuario.Controls.Add(cbxUsuario);
            panelUsuario.Visible = true;
        }

        private void cbxUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            string index = cbxUsuario.SelectedItem.ToString();
            if (index != "-- Seleccione Usuario --")
            {
                string[] usuarioSeleccionado = index.Split("-");

                mostrarPrestamos(filtrarPrestamos(usuarioSeleccionado[0]), cbxUsuario.SelectedIndex);


            }
            else
            {
                mostrarPrestamos(new BindingList<DatosPrestamo>(), 0);
            }
        }

        private BindingList<DatosPrestamo> filtrarPrestamos(string idUsuario)
        {
            BindingList<DatosPrestamo> prestamosUsuario = new BindingList<DatosPrestamo>();
            foreach (PrestamoLibro prestamo in listaPrestamos)
            {
                if (idUsuario == prestamo.IdUsuario)
                {
                    string fechaPrestamo = "";
                    string fechaDevolucion = "";
                    if (prestamo.FechaPrestamo != null)
                    {
                        fechaPrestamo = prestamo.FechaPrestamo;
                    }
                    if (prestamo.FechaDevolucion != null)
                    {
                        fechaDevolucion = prestamo.FechaDevolucion;
                    }
                    prestamosUsuario.Add(new DatosPrestamo
                    {
                        Id = prestamo.IdPrestamo,
                        Libro = prestamo.Titulo,
                        FechaPrestamo = fechaPrestamo,
                        FechaDevolucion = fechaDevolucion
                    });
                }
            }
            return prestamosUsuario;
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {

        }
    }
}
