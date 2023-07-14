using ManageRPG.Controlador;
using ManageRPG.Modelo;
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
            MostrarListaUsuarios();
        }
        private void MostrarListaUsuarios()
        {
            List<Usuario> tabla = new metodosAdmin().ObtenerDatos();
            dataGridUsuarios.DataSource = null;
            dataGridUsuarios.Columns.Clear();
            dataGridUsuarios.Rows.Clear();
            dataGridUsuarios.Refresh();

            dataGridUsuarios.DataSource = tabla;
            dataGridUsuarios.Columns["id_usuario"].Visible = false;

        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            MostrarListaUsuarios();
        }

        private void botonModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(id_usuario.Text);
            string usuario = nombreUsuario.Text;
            string pass1 = password1.Text;
            string pass2 = password2.Text;
            int tipo = tipoUsuario.SelectedIndex;
            metodosAdmin.ModificarUsuario(id, usuario, pass1, pass2, tipo);

        }

        private void botonDesconectarse_Click(object sender, EventArgs e)
        {
            metodosAdmin.Desconectarse();
        }

        private void listaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Usuario parametroUsuario = (Usuario)dataGridUsuarios.SelectedRows[0].DataBoundItem;
            id_usuario.Text = parametroUsuario.id_usuario.ToString();
            nombreUsuario.Text = parametroUsuario.usuario.ToString();
            password1.Text = parametroUsuario.contrasenna.ToString();
            password2.Text = parametroUsuario.contrasenna.ToString();
            tipoUsuario.SelectedIndex = int.Parse(parametroUsuario.id_rol.ToString());
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
