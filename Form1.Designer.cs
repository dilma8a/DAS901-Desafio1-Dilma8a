namespace DAS901_Desafio1_Dilma8a
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTituloPrincipal = new Label();
            panel1 = new Panel();
            btnPrestamos = new Button();
            btnUsuarios = new Button();
            btnLibros = new Button();
            panelPrincipal = new Panel();
            btnAgregarLibro = new Button();
            panel2 = new Panel();
            btnEliminar = new Button();
            btnEditar = new Button();
            panelUsuario = new Panel();
            btnEstadisticas = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblTituloPrincipal
            // 
            lblTituloPrincipal.AutoSize = true;
            lblTituloPrincipal.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloPrincipal.ImageAlign = ContentAlignment.TopCenter;
            lblTituloPrincipal.Location = new Point(494, 39);
            lblTituloPrincipal.Name = "lblTituloPrincipal";
            lblTituloPrincipal.Size = new Size(833, 65);
            lblTituloPrincipal.TabIndex = 0;
            lblTituloPrincipal.Text = "GESTION DE BIBLIOTECA - LIBROS";
            lblTituloPrincipal.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnEstadisticas);
            panel1.Controls.Add(btnPrestamos);
            panel1.Controls.Add(btnUsuarios);
            panel1.Controls.Add(btnLibros);
            panel1.Location = new Point(12, 122);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 455);
            panel1.TabIndex = 1;
            // 
            // btnPrestamos
            // 
            btnPrestamos.Location = new Point(53, 237);
            btnPrestamos.Name = "btnPrestamos";
            btnPrestamos.Size = new Size(147, 52);
            btnPrestamos.TabIndex = 2;
            btnPrestamos.Text = "Préstamos";
            btnPrestamos.UseVisualStyleBackColor = true;
            btnPrestamos.Click += btnPrestamos_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.Location = new Point(50, 151);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(150, 46);
            btnUsuarios.TabIndex = 1;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnLibros
            // 
            btnLibros.Location = new Point(50, 75);
            btnLibros.Name = "btnLibros";
            btnLibros.Size = new Size(150, 46);
            btnLibros.TabIndex = 0;
            btnLibros.Text = "Libros";
            btnLibros.UseVisualStyleBackColor = true;
            btnLibros.Click += btnLibros_Click;
            // 
            // panelPrincipal
            // 
            panelPrincipal.Location = new Point(345, 226);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1173, 550);
            panelPrincipal.TabIndex = 2;
            panelPrincipal.Paint += panelPrincipal_Paint;
            // 
            // btnAgregarLibro
            // 
            btnAgregarLibro.Location = new Point(250, 25);
            btnAgregarLibro.Name = "btnAgregarLibro";
            btnAgregarLibro.Size = new Size(150, 46);
            btnAgregarLibro.TabIndex = 3;
            btnAgregarLibro.Text = "Añadir";
            btnAgregarLibro.UseVisualStyleBackColor = true;
            btnAgregarLibro.Click += btnAgregarLibro_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnEliminar);
            panel2.Controls.Add(btnEditar);
            panel2.Controls.Add(btnAgregarLibro);
            panel2.Location = new Point(345, 806);
            panel2.Name = "panel2";
            panel2.Size = new Size(1173, 92);
            panel2.TabIndex = 3;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(822, 25);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 46);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(543, 25);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(150, 46);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // panelUsuario
            // 
            panelUsuario.Location = new Point(345, 139);
            panelUsuario.Name = "panelUsuario";
            panelUsuario.Size = new Size(1173, 81);
            panelUsuario.TabIndex = 4;
            // 
            // btnEstadisticas
            // 
            btnEstadisticas.Location = new Point(58, 337);
            btnEstadisticas.Name = "btnEstadisticas";
            btnEstadisticas.Size = new Size(150, 46);
            btnEstadisticas.TabIndex = 3;
            btnEstadisticas.Text = "Estadisticas";
            btnEstadisticas.UseVisualStyleBackColor = true;
            btnEstadisticas.Click += btnEstadisticas_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1637, 1016);
            Controls.Add(panelUsuario);
            Controls.Add(panel2);
            Controls.Add(panelPrincipal);
            Controls.Add(panel1);
            Controls.Add(lblTituloPrincipal);
            Name = "Form1";
            Text = "GESTION DE BIBLIOTECA";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloPrincipal;
        private Panel panel1;
        private Button btnUsuarios;
        private Button btnLibros;
        private Button btnPrestamos;
        private Panel panelPrincipal;
        private Button btnAgregarLibro;
        private Panel panel2;
        private Button btnEditar;
        private Button btnEliminar;
        private ComboBox cbxUsuario;
        private Panel panelUsuario;
        private Button btnEstadisticas;
    }
}
