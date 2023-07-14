namespace ManageRPG.Vista
{
    partial class Vista_Modificar
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
            botonGuardar = new Button();
            botonCancelar = new Button();
            nombreObjeto = new TextBox();
            label_nombre = new Label();
            Label_desc = new Label();
            Label_peso = new Label();
            Label_precio = new Label();
            Label_Cantidad = new Label();
            descripcionObjeto = new RichTextBox();
            pesoObjeto = new TextBox();
            precioObjeto = new TextBox();
            cantidadObjeto = new TextBox();
            id_objeto = new TextBox();
            SuspendLayout();
            // 
            // botonGuardar
            // 
            botonGuardar.Location = new Point(360, 320);
            botonGuardar.Name = "botonGuardar";
            botonGuardar.Size = new Size(75, 23);
            botonGuardar.TabIndex = 0;
            botonGuardar.Text = "Guardar";
            botonGuardar.UseVisualStyleBackColor = true;
            botonGuardar.Click += botonGuardar_Click;
            // 
            // botonCancelar
            // 
            botonCancelar.Location = new Point(244, 320);
            botonCancelar.Name = "botonCancelar";
            botonCancelar.Size = new Size(75, 23);
            botonCancelar.TabIndex = 1;
            botonCancelar.Text = "Cancelar";
            botonCancelar.UseVisualStyleBackColor = true;
            // 
            // nombreObjeto
            // 
            nombreObjeto.Location = new Point(141, 32);
            nombreObjeto.Name = "nombreObjeto";
            nombreObjeto.Size = new Size(100, 23);
            nombreObjeto.TabIndex = 2;
            // 
            // label_nombre
            // 
            label_nombre.AutoSize = true;
            label_nombre.Location = new Point(45, 32);
            label_nombre.Name = "label_nombre";
            label_nombre.Size = new Size(76, 15);
            label_nombre.TabIndex = 3;
            label_nombre.Text = "Nombre Obj.";
            // 
            // Label_desc
            // 
            Label_desc.AutoSize = true;
            Label_desc.Location = new Point(45, 85);
            Label_desc.Name = "Label_desc";
            Label_desc.Size = new Size(69, 15);
            Label_desc.TabIndex = 4;
            Label_desc.Text = "Descripcion";
            // 
            // Label_peso
            // 
            Label_peso.AutoSize = true;
            Label_peso.Location = new Point(45, 168);
            Label_peso.Name = "Label_peso";
            Label_peso.Size = new Size(32, 15);
            Label_peso.TabIndex = 5;
            Label_peso.Text = "Peso";
            // 
            // Label_precio
            // 
            Label_precio.AutoSize = true;
            Label_precio.Location = new Point(45, 220);
            Label_precio.Name = "Label_precio";
            Label_precio.Size = new Size(40, 15);
            Label_precio.TabIndex = 6;
            Label_precio.Text = "Precio";
            // 
            // Label_Cantidad
            // 
            Label_Cantidad.AutoSize = true;
            Label_Cantidad.Location = new Point(45, 261);
            Label_Cantidad.Name = "Label_Cantidad";
            Label_Cantidad.Size = new Size(55, 15);
            Label_Cantidad.TabIndex = 7;
            Label_Cantidad.Text = "Cantidad";
            // 
            // descripcionObjeto
            // 
            descripcionObjeto.Location = new Point(141, 85);
            descripcionObjeto.Name = "descripcionObjeto";
            descripcionObjeto.Size = new Size(316, 69);
            descripcionObjeto.TabIndex = 8;
            descripcionObjeto.Text = "";
            // 
            // pesoObjeto
            // 
            pesoObjeto.Location = new Point(141, 168);
            pesoObjeto.Name = "pesoObjeto";
            pesoObjeto.Size = new Size(100, 23);
            pesoObjeto.TabIndex = 9;
            // 
            // precioObjeto
            // 
            precioObjeto.Location = new Point(141, 220);
            precioObjeto.Name = "precioObjeto";
            precioObjeto.Size = new Size(100, 23);
            precioObjeto.TabIndex = 10;
            precioObjeto.TextChanged += textBox3_TextChanged;
            // 
            // cantidadObjeto
            // 
            cantidadObjeto.Location = new Point(141, 261);
            cantidadObjeto.Name = "cantidadObjeto";
            cantidadObjeto.Size = new Size(100, 23);
            cantidadObjeto.TabIndex = 11;
            // 
            // id_objeto
            // 
            id_objeto.Location = new Point(391, 12);
            id_objeto.Name = "id_objeto";
            id_objeto.Size = new Size(100, 23);
            id_objeto.TabIndex = 12;
            id_objeto.Visible = false;
            // 
            // Vista_Modificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 355);
            Controls.Add(id_objeto);
            Controls.Add(cantidadObjeto);
            Controls.Add(precioObjeto);
            Controls.Add(pesoObjeto);
            Controls.Add(descripcionObjeto);
            Controls.Add(Label_Cantidad);
            Controls.Add(Label_precio);
            Controls.Add(Label_peso);
            Controls.Add(Label_desc);
            Controls.Add(label_nombre);
            Controls.Add(nombreObjeto);
            Controls.Add(botonCancelar);
            Controls.Add(botonGuardar);
            Name = "Vista_Modificar";
            Text = "Vista_Modificar";
            Load += Vista_Modificar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button botonGuardar;
        private Button botonCancelar;
        private TextBox nombreObjeto;
        private Label label_nombre;
        private Label Label_desc;
        private Label Label_peso;
        private Label Label_precio;
        private Label Label_Cantidad;
        private RichTextBox descripcionObjeto;
        private TextBox pesoObjeto;
        private TextBox precioObjeto;
        private TextBox cantidadObjeto;
        private TextBox id_objeto;
    }
}