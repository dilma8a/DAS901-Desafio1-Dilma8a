namespace DAS901_Desafio1_Dilma8a
{
    partial class PrestamoLibroForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel1 = new Panel();
            cbxEsDevolucion = new CheckedListBox();
            lblEsDevoluacion = new Label();
            cbxLibro = new ComboBox();
            label3 = new Label();
            txtUsuario = new TextBox();
            label2 = new Label();
            btnGuardar = new Button();
            btnActualizar = new Button();
            btnCancelar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(388, 37);
            label1.Name = "label1";
            label1.Size = new Size(388, 50);
            label1.TabIndex = 1;
            label1.Text = "Gestionar Biblioteca";
            // 
            // panel1
            // 
            panel1.Controls.Add(cbxEsDevolucion);
            panel1.Controls.Add(lblEsDevoluacion);
            panel1.Controls.Add(cbxLibro);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(138, 134);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 387);
            panel1.TabIndex = 2;
            // 
            // cbxEsDevolucion
            // 
            cbxEsDevolucion.FormattingEnabled = true;
            cbxEsDevolucion.Items.AddRange(new object[] { "SI", "NO" });
            cbxEsDevolucion.Location = new Point(282, 216);
            cbxEsDevolucion.Name = "cbxEsDevolucion";
            cbxEsDevolucion.Size = new Size(240, 76);
            cbxEsDevolucion.TabIndex = 6;
            // 
            // lblEsDevoluacion
            // 
            lblEsDevoluacion.AutoSize = true;
            lblEsDevoluacion.Location = new Point(65, 216);
            lblEsDevoluacion.Name = "lblEsDevoluacion";
            lblEsDevoluacion.Size = new Size(169, 32);
            lblEsDevoluacion.TabIndex = 5;
            lblEsDevoluacion.Text = "Es Devolucion:";
            lblEsDevoluacion.Click += lblFechaDevoluacion_Click;
            // 
            // cbxLibro
            // 
            cbxLibro.FormattingEnabled = true;
            cbxLibro.Location = new Point(225, 125);
            cbxLibro.Name = "cbxLibro";
            cbxLibro.Size = new Size(600, 40);
            cbxLibro.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 130);
            label3.Name = "label3";
            label3.Size = new Size(72, 32);
            label3.TabIndex = 3;
            label3.Text = "Libro:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(222, 42);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.ReadOnly = true;
            txtUsuario.Size = new Size(603, 39);
            txtUsuario.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 36);
            label2.Name = "label2";
            label2.Size = new Size(99, 32);
            label2.TabIndex = 1;
            label2.Text = "Usuario:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(292, 548);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 46);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(536, 548);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(150, 46);
            btnActualizar.TabIndex = 4;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(785, 548);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 46);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // PrestamoLibroForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 653);
            Controls.Add(btnCancelar);
            Controls.Add(btnActualizar);
            Controls.Add(btnGuardar);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "PrestamoLibroForm";
            Text = "PrestamoLibroForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        public TextBox txtUsuario;
        public ComboBox cbxLibro;
        public Button btnGuardar;
        public Button btnActualizar;
        public Button btnCancelar;
        public Label lblEsDevoluacion;
        public CheckedListBox cbxEsDevolucion;
    }
}