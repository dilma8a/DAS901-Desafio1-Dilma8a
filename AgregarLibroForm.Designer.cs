namespace DAS901_Desafio1_Dilma8a
{
    partial class AgregarLibroForm
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
            txtId = new TextBox();
            label1 = new Label();
            txtTitulo = new TextBox();
            Titulo = new Label();
            label3 = new Label();
            label4 = new Label();
            txtAutor = new TextBox();
            txtAnio = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            btnActualizar = new Button();
            label2 = new Label();
            cbxEstado = new ComboBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(223, 122);
            txtId.Name = "txtId";
            txtId.Size = new Size(148, 39);
            txtId.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 129);
            label1.Name = "label1";
            label1.Size = new Size(39, 32);
            label1.TabIndex = 1;
            label1.Text = "Id:";
            label1.Click += label1_Click;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(223, 213);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(475, 39);
            txtTitulo.TabIndex = 0;
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Location = new Point(107, 216);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(75, 32);
            Titulo.TabIndex = 2;
            Titulo.Text = "Titulo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 310);
            label3.Name = "label3";
            label3.Size = new Size(73, 32);
            label3.TabIndex = 3;
            label3.Text = "Autor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 386);
            label4.Name = "label4";
            label4.Size = new Size(63, 32);
            label4.TabIndex = 4;
            label4.Text = "Anio";
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(222, 306);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(476, 39);
            txtAutor.TabIndex = 5;
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(224, 380);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(166, 39);
            txtAnio.TabIndex = 6;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(132, 573);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 46);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(580, 573);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 46);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(361, 576);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(150, 46);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 460);
            label2.Name = "label2";
            label2.Size = new Size(84, 32);
            label2.TabIndex = 10;
            label2.Text = "Estado";
            // 
            // cbxEstado
            // 
            cbxEstado.FormattingEnabled = true;
            cbxEstado.Items.AddRange(new object[] { "Disponible", "No Disponible" });
            cbxEstado.Location = new Point(222, 457);
            cbxEstado.Name = "cbxEstado";
            cbxEstado.Size = new Size(242, 40);
            cbxEstado.TabIndex = 11;
            cbxEstado.SelectedIndexChanged += cbxEstado_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label5.Location = new Point(263, 32);
            label5.Name = "label5";
            label5.Size = new Size(375, 51);
            label5.TabIndex = 12;
            label5.Text = "Administrar Libros";
            // 
            // AgregarLibroForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 673);
            Controls.Add(label5);
            Controls.Add(cbxEstado);
            Controls.Add(label2);
            Controls.Add(btnActualizar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtAnio);
            Controls.Add(txtAutor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Titulo);
            Controls.Add(txtTitulo);
            Controls.Add(label1);
            Controls.Add(txtId);
            Name = "AgregarLibroForm";
            Text = "GESTION DE BIBLIOTECA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox txtId;
        private Label label1;
        public TextBox txtTitulo;
        private Label Titulo;
        private Label label3;
        private Label label4;
        public TextBox txtAutor;
        public TextBox txtAnio;
        public Button btnGuardar;
        public Button btnCancelar;
        public Button btnActualizar;
        private Label label2;
        public ComboBox cbxEstado;
        private Label label5;
    }
}