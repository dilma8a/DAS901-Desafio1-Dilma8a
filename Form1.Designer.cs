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
            label1 = new Label();
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            btnLibros = new Button();
            panelPrincipal = new Panel();
            btnAgregarLibro = new Button();
            panel2 = new Panel();
            btnEliminar = new Button();
            btnEditar = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(494, 39);
            label1.Name = "label1";
            label1.Size = new Size(614, 65);
            label1.TabIndex = 0;
            label1.Text = "GESTION DE BIBLIOTECA";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnLibros);
            panel1.Location = new Point(12, 122);
            panel1.Name = "panel1";
            panel1.Size = new Size(286, 495);
            panel1.TabIndex = 1;
            // 
            // button3
            // 
            button3.Location = new Point(53, 237);
            button3.Name = "button3";
            button3.Size = new Size(147, 52);
            button3.TabIndex = 2;
            button3.Text = "Préstamos";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(50, 151);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 1;
            button2.Text = "Usuarios";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnLibros
            // 
            btnLibros.Location = new Point(50, 75);
            btnLibros.Name = "btnLibros";
            btnLibros.Size = new Size(150, 46);
            btnLibros.TabIndex = 0;
            btnLibros.Text = "Libros";
            btnLibros.UseVisualStyleBackColor = true;
            btnLibros.Click += button1_Click;
            // 
            // panelPrincipal
            // 
            panelPrincipal.Location = new Point(345, 122);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1173, 550);
            panelPrincipal.TabIndex = 2;
            panelPrincipal.Paint += panelPrincipal_Paint;
            // 
            // btnAgregarLibro
            // 
            btnAgregarLibro.Location = new Point(28, 25);
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
            panel2.Location = new Point(345, 697);
            panel2.Name = "panel2";
            panel2.Size = new Size(996, 92);
            panel2.TabIndex = 3;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(461, 25);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 46);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(246, 26);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(150, 46);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1637, 823);
            Controls.Add(panel2);
            Controls.Add(panelPrincipal);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button button2;
        private Button btnLibros;
        private Button button3;
        private Panel panelPrincipal;
        private Button btnAgregarLibro;
        private Panel panel2;
        private Button btnEditar;
        private Button btnEliminar;
    }
}
