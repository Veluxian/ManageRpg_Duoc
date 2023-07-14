namespace ManageRPG.Vista
{
    partial class Admin
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
            nombreUsuario = new TextBox();
            password1 = new TextBox();
            botonAgregar = new Button();
            botonModificar = new Button();
            botonEliminar = new Button();
            actualizar = new Button();
            tipoUsuario = new ComboBox();
            password2 = new TextBox();
            Nombre = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            botonDesconectarse = new Button();
            dataGridUsuarios = new DataGridView();
            id_usuario = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridUsuarios).BeginInit();
            SuspendLayout();
            // 
            // nombreUsuario
            // 
            nombreUsuario.Location = new Point(43, 249);
            nombreUsuario.Name = "nombreUsuario";
            nombreUsuario.Size = new Size(153, 23);
            nombreUsuario.TabIndex = 0;
            // 
            // password1
            // 
            password1.Location = new Point(43, 298);
            password1.Name = "password1";
            password1.Size = new Size(153, 23);
            password1.TabIndex = 1;
            // 
            // botonAgregar
            // 
            botonAgregar.Location = new Point(69, 72);
            botonAgregar.Name = "botonAgregar";
            botonAgregar.Size = new Size(100, 33);
            botonAgregar.TabIndex = 3;
            botonAgregar.Text = "Agregar";
            botonAgregar.UseVisualStyleBackColor = true;
            botonAgregar.Click += botonAgregar_Click;
            // 
            // botonModificar
            // 
            botonModificar.Location = new Point(69, 128);
            botonModificar.Name = "botonModificar";
            botonModificar.Size = new Size(100, 33);
            botonModificar.TabIndex = 4;
            botonModificar.Text = "Modificar";
            botonModificar.UseVisualStyleBackColor = true;
            botonModificar.Click += botonModificar_Click;
            // 
            // botonEliminar
            // 
            botonEliminar.Location = new Point(69, 185);
            botonEliminar.Name = "botonEliminar";
            botonEliminar.RightToLeft = RightToLeft.Yes;
            botonEliminar.Size = new Size(100, 33);
            botonEliminar.TabIndex = 5;
            botonEliminar.Text = "Eliminar";
            botonEliminar.UseVisualStyleBackColor = true;
            botonEliminar.Click += botonEliminar_Click;
            // 
            // actualizar
            // 
            actualizar.Location = new Point(472, 12);
            actualizar.Name = "actualizar";
            actualizar.Size = new Size(75, 23);
            actualizar.TabIndex = 6;
            actualizar.Text = "Actualizar";
            actualizar.UseVisualStyleBackColor = true;
            actualizar.Click += actualizar_Click;
            // 
            // tipoUsuario
            // 
            tipoUsuario.FormattingEnabled = true;
            tipoUsuario.Location = new Point(43, 403);
            tipoUsuario.Name = "tipoUsuario";
            tipoUsuario.Size = new Size(153, 23);
            tipoUsuario.TabIndex = 8;
            // 
            // password2
            // 
            password2.Location = new Point(43, 350);
            password2.Name = "password2";
            password2.Size = new Size(153, 23);
            password2.TabIndex = 9;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(43, 231);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(94, 15);
            Nombre.TabIndex = 10;
            Nombre.Text = "Nombre Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 280);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 11;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 332);
            label3.Name = "label3";
            label3.Size = new Size(103, 15);
            label3.TabIndex = 12;
            label3.Text = "Repita Contraseña";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 385);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 13;
            label4.Text = "Tipo Usuario";
            // 
            // botonDesconectarse
            // 
            botonDesconectarse.Location = new Point(691, 498);
            botonDesconectarse.Name = "botonDesconectarse";
            botonDesconectarse.Size = new Size(98, 29);
            botonDesconectarse.TabIndex = 14;
            botonDesconectarse.Text = "Desconectarse";
            botonDesconectarse.UseVisualStyleBackColor = true;
            botonDesconectarse.Click += botonDesconectarse_Click;
            // 
            // dataGridUsuarios
            // 
            dataGridUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUsuarios.Location = new Point(231, 41);
            dataGridUsuarios.Name = "dataGridUsuarios";
            dataGridUsuarios.RowTemplate.Height = 25;
            dataGridUsuarios.Size = new Size(557, 408);
            dataGridUsuarios.TabIndex = 15;
            dataGridUsuarios.CellContentClick += listaUsuarios_CellContentClick;
            // 
            // id_usuario
            // 
            id_usuario.Location = new Point(10, 502);
            id_usuario.Name = "id_usuario";
            id_usuario.Size = new Size(100, 23);
            id_usuario.TabIndex = 16;
            id_usuario.Visible = false;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 532);
            Controls.Add(id_usuario);
            Controls.Add(dataGridUsuarios);
            Controls.Add(botonDesconectarse);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Nombre);
            Controls.Add(password2);
            Controls.Add(tipoUsuario);
            Controls.Add(actualizar);
            Controls.Add(botonEliminar);
            Controls.Add(botonModificar);
            Controls.Add(botonAgregar);
            Controls.Add(password1);
            Controls.Add(nombreUsuario);
            Name = "Admin";
            Text = "Admin";
            Load += Admin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nombreUsuario;
        private TextBox password1;
        private Button botonAgregar;
        private Button botonModificar;
        private Button botonEliminar;
        private Button actualizar;
        private ComboBox tipoUsuario;
        private TextBox password2;
        private Label Nombre;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button botonDesconectarse;
        private DataGridView dataGridUsuarios;
        private TextBox id_usuario;
    }
}