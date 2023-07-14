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
            metodosAdmin metodosAdmin = new metodosAdmin();
            DataTable listaUsuario = metodosAdmin.ObtenerDatos();
            listaUsuarios.DataSource = listaUsuario;
        }

        private void botonModificar_Click(object sender, EventArgs e)
        {
            int id_usuario = 1;
            string usuario = nombreUsuario.Text;
            string pass1 = password1.Text;
            string pass2 = password2.Text;
            int tipo = tipoUsuario.SelectedIndex;
            metodosAdmin.ModificarUsuario(id_usuario, usuario, pass1, pass2, tipo);

        }

        private void botonDesconectarse_Click(object sender, EventArgs e)
        {
            metodosAdmin.Desconectarse();
        }

        private void listaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            string usuario = nombreUsuario.Text;
            string pass1 = password1.Text;
            string pass2 = password2.Text;
            int tipo = tipoUsuario.SelectedIndex;
            metodosAdmin.AgregarUsuario(usuario, pass1, pass2, tipo);
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            int id_usuario = 1;
            metodosAdmin.EliminarUsuario(id_usuario);
        }
    }
}
