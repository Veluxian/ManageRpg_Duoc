namespace ManageRPG.Vista
{
    partial class Vista_principal
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
            botonAgregar = new Button();
            botonEliminar = new Button();
            botonModificar = new Button();
            dataGridObjetos = new DataGridView();
            botonActualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridObjetos).BeginInit();
            SuspendLayout();
            // 
            // botonAgregar
            // 
            botonAgregar.Location = new Point(32, 74);
            botonAgregar.Name = "botonAgregar";
            botonAgregar.Size = new Size(86, 32);
            botonAgregar.TabIndex = 0;
            botonAgregar.Text = "Agregar";
            botonAgregar.UseVisualStyleBackColor = true;
            // 
            // botonEliminar
            // 
            botonEliminar.Location = new Point(161, 74);
            botonEliminar.Name = "botonEliminar";
            botonEliminar.Size = new Size(86, 32);
            botonEliminar.TabIndex = 1;
            botonEliminar.Text = "Eliminar";
            botonEliminar.UseVisualStyleBackColor = true;
            botonEliminar.Click += botonEliminar_Click;
            // 
            // botonModificar
            // 
            botonModificar.Location = new Point(292, 74);
            botonModificar.Name = "botonModificar";
            botonModificar.Size = new Size(86, 32);
            botonModificar.TabIndex = 2;
            botonModificar.Text = "Modificar";
            botonModificar.UseVisualStyleBackColor = true;
            // 
            // dataGridObjetos
            // 
            dataGridObjetos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridObjetos.Location = new Point(32, 139);
            dataGridObjetos.Name = "dataGridObjetos";
            dataGridObjetos.RowTemplate.Height = 25;
            dataGridObjetos.Size = new Size(715, 377);
            dataGridObjetos.TabIndex = 3;
            dataGridObjetos.CellContentClick += dataGridObjetos_CellContentClick;
            // 
            // botonActualizar
            // 
            botonActualizar.Location = new Point(672, 110);
            botonActualizar.Name = "botonActualizar";
            botonActualizar.Size = new Size(75, 23);
            botonActualizar.TabIndex = 4;
            botonActualizar.Text = "Actualizar";
            botonActualizar.UseVisualStyleBackColor = true;
            // 
            // Vista_principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 570);
            Controls.Add(botonActualizar);
            Controls.Add(dataGridObjetos);
            Controls.Add(botonModificar);
            Controls.Add(botonEliminar);
            Controls.Add(botonAgregar);
            Name = "Vista_principal";
            Text = "Vista_principal";
            Load += Vista_principal_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridObjetos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button botonAgregar;
        private Button botonEliminar;
        private Button botonModificar;
        private DataGridView dataGridObjetos;
        private Button botonActualizar;
    }
}