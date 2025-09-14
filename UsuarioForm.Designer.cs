namespace DAS901_Desafio1_Dilma8a
{
    partial class UsuarioForm
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
            txtNombre = new TextBox();
            txtCorreo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnGuardar = new Button();
            btnActualizar = new Button();
            btnCancelar = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtId
            // 
            txtId.Location = new Point(346, 128);
            txtId.Name = "txtId";
            txtId.Size = new Size(200, 39);
            txtId.TabIndex = 0;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(346, 198);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(463, 39);
            txtNombre.TabIndex = 1;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(346, 257);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(463, 39);
            txtCorreo.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 135);
            label1.Name = "label1";
            label1.Size = new Size(37, 32);
            label1.TabIndex = 3;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(113, 205);
            label2.Name = "label2";
            label2.Size = new Size(102, 32);
            label2.TabIndex = 4;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 264);
            label3.Name = "label3";
            label3.Size = new Size(210, 32);
            label3.TabIndex = 5;
            label3.Text = "Correo Electrónico";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(155, 393);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 46);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(346, 393);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(150, 46);
            btnActualizar.TabIndex = 7;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnEditar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(567, 393);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 46);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnEliminar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label4.Location = new Point(243, 37);
            label4.Name = "label4";
            label4.Size = new Size(421, 51);
            label4.TabIndex = 9;
            label4.Text = "Administrar Usuarios";
            label4.Click += label4_Click;
            // 
            // UsuarioForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(963, 529);
            Controls.Add(label4);
            Controls.Add(btnCancelar);
            Controls.Add(btnActualizar);
            Controls.Add(btnGuardar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCorreo);
            Controls.Add(txtNombre);
            Controls.Add(txtId);
            Name = "UsuarioForm";
            Text = "GESTION DE BIBLIOTECA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox txtId;
        public TextBox txtNombre;
        public TextBox txtCorreo;
        private Label label1;
        private Label label2;
        private Label label3;
        public Button btnGuardar;
        public Button btnActualizar;
        private Button btnCancelar;
        private Label label4;
    }
}