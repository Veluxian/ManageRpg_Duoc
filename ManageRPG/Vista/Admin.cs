using ManageRPG.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageRPG.Vista
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            var usuario = 1; //aqui va el login que debe retornar el tipo de usuario
            if (usuario == 1)
            {
                metodosAdmin metodosAdmin = new metodosAdmin();
                DataTable listaUsuario = metodosAdmin.ObtenerDatos(usuario);
                listaUsuarios.DataSource = listaUsuario;
            }   
            else
            {
                MessageBox.Show("error de usuario");
            }
        }

        private void botonModificar_Click(object sender, EventArgs e)
        {

        }

        private void botonDesconectarse_Click(object sender, EventArgs e)
        {
            metodosAdmin.Desconectarse();
        }
    }
}
