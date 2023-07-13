using System.Security.Cryptography.X509Certificates;
using System.Data.OracleClient;
using Oracle.ManagedDataAccess.Client;

namespace ManageRPG;

public partial class Login : Form
{
    public Login()
    {
        InitializeComponent();

        var usuario = this.txtUsuario.Text;
        var contrassena = this.txtContrasenna.Text;


    }


    private void button2_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void btnIniciarSesion_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Esto es un mensaje","Mensaje");
    }

    private void txtContrasenna_TextChanged(object sender, EventArgs e)
    {

    }
}
