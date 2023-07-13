using System.Drawing.Text;

namespace ManageRPG;

partial class Login
{


    #region Windows Form Designer generated code


    private void InitializeComponent()
    {
        btnIniciarSesion = new Button();
        btnSalir = new Button();
        pBTituloManageRPG = new PictureBox();
        txtUsuario = new TextBox();
        txtContrasenna = new TextBox();
        ((System.ComponentModel.ISupportInitialize)pBTituloManageRPG).BeginInit();
        SuspendLayout();
        // 
        // btnIniciarSesion
        // 
        btnIniciarSesion.BackColor = Color.Transparent;
        btnIniciarSesion.FlatStyle = FlatStyle.Popup;
        btnIniciarSesion.Font = new Font("Monotype Corsiva", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
        btnIniciarSesion.ForeColor = SystemColors.HighlightText;
        btnIniciarSesion.Location = new Point(157, 184);
        btnIniciarSesion.Name = "btnIniciarSesion";
        btnIniciarSesion.Size = new Size(199, 49);
        btnIniciarSesion.TabIndex = 0;
        btnIniciarSesion.Text = "Iniciar Sesión";
        btnIniciarSesion.UseVisualStyleBackColor = false;
        btnIniciarSesion.Click += btnIniciarSesion_Click;
        // 
        // btnSalir
        // 
        btnSalir.BackColor = Color.Transparent;
        btnSalir.FlatStyle = FlatStyle.Popup;
        btnSalir.Font = new Font("Monotype Corsiva", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
        btnSalir.ForeColor = SystemColors.HighlightText;
        btnSalir.Location = new Point(157, 264);
        btnSalir.Name = "btnSalir";
        btnSalir.Size = new Size(199, 49);
        btnSalir.TabIndex = 1;
        btnSalir.Text = "Salir";
        btnSalir.UseVisualStyleBackColor = false;
        btnSalir.Click += button2_Click;
        // 
        // pBTituloManageRPG
        // 
        pBTituloManageRPG.BackColor = Color.Transparent;
        pBTituloManageRPG.BackgroundImage = Properties.Resources.ManageRPG_Titulo;
        pBTituloManageRPG.Location = new Point(116, 12);
        pBTituloManageRPG.Name = "pBTituloManageRPG";
        pBTituloManageRPG.Size = new Size(992, 129);
        pBTituloManageRPG.TabIndex = 2;
        pBTituloManageRPG.TabStop = false;
        // 
        // txtUsuario
        // 
        txtUsuario.BackColor = Color.Silver;
        txtUsuario.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point);
        txtUsuario.Location = new Point(391, 187);
        txtUsuario.Name = "txtUsuario";
        txtUsuario.PlaceholderText = "Usuario";
        txtUsuario.Size = new Size(291, 43);
        txtUsuario.TabIndex = 3;
        txtUsuario.TextChanged += textBox1_TextChanged;
        // 
        // txtContrasenna
        // 
        txtContrasenna.BackColor = SystemColors.ActiveBorder;
        txtContrasenna.BorderStyle = BorderStyle.FixedSingle;
        txtContrasenna.Font = new Font("Monotype Corsiva", 24F, FontStyle.Italic, GraphicsUnit.Point);
        txtContrasenna.Location = new Point(391, 266);
        txtContrasenna.Name = "txtContrasenna";
        txtContrasenna.PasswordChar = '*';
        txtContrasenna.PlaceholderText = "Contraseña";
        txtContrasenna.Size = new Size(291, 43);
        txtContrasenna.TabIndex = 4;
        txtContrasenna.TextChanged += txtContrasenna_TextChanged;
        // 
        // LoginPrincipal
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackgroundImage = Properties.Resources.PantallaPrincipal;
        BackgroundImageLayout = ImageLayout.Stretch;
        ClientSize = new Size(1216, 830);
        ControlBox = false;
        Controls.Add(txtContrasenna);
        Controls.Add(txtUsuario);
        Controls.Add(pBTituloManageRPG);
        Controls.Add(btnSalir);
        Controls.Add(btnIniciarSesion);
        FormBorderStyle = FormBorderStyle.None;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "LoginPrincipal";
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "x1";
        ((System.ComponentModel.ISupportInitialize)pBTituloManageRPG).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private Button btnSalir;
    private Button btnIniciarSesion;

    #endregion

    private PictureBox pBTituloManageRPG;
    private TextBox txtUsuario;
    private TextBox txtContrasenna;

}