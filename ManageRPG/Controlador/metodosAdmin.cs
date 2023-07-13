using ManageRPG.Clases;
using ManageRPG.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageRPG.Controlador
{
    internal class metodosAdmin
    {
        public static List<Usuario> ObtenerDatos(int tipoUsuario)
        {
            if (tipoUsuario == 1)
            {
                List<Usuario> usuarios = new List<Usuario>();
                Usuario usuario = new Usuario();
                usuario.idUsuario = 1; usuario.usuario = "Joaquin"; usuario.password = "chupalito"; usuario.tipo = 2;
                usuarios.Add(usuario);
                MessageBox.Show("Admin correcto");
                return usuarios;
            }
            else
            {
                MessageBox.Show("Error de tipo de Usuario");
                return null;
            }
        }

        public static void AgregarUsuario(string nombreUsuario, string password1, string password2, int tipo)
        {
            if (password1 == password2)
            {
                string query = "INSERT INTO USUARIO(id_Usuario, Usuario, contrasenna, id_rol) VALUES(next value for seq_usuario, '"+ nombreUsuario +"', '"+ password1 + "', '"+ tipo +"')";
            }
            else
            {
                MessageBox.Show("Error al insertar");
            }
        }

        public static void ModificarUsuario(int idUsuario ,string nombreUsuario, string password1, string password2, int tipo)
        {
            if (password1 == password2)
            {
                string query = " UPDATE USUARIO SET Usuario = '"+ nombreUsuario +"', contrasenna = '"+ password1 +"', id_rol = '"+ tipo +"' WHERE id_Usuario = '"+ idUsuario +"' ";
            }
            else
            {
                MessageBox.Show("Error de Actualizacion");
            }
        }
        public static void EliminarUsuario(int idUsuario, bool confirmacion)
        {
            if (confirmacion == true)
            {
                string query = " DELETE FROM USUARIO WHERE id_Usuario = '"+ idUsuario +"'";
            }
            else
            {
                MessageBox.Show("Error eliminacion");
            }
        }

        public static void Desconectarse()
        {
            Login inicio = new Login();
            inicio.Show();
            Admin cierre = new Admin();
            cierre.Close();
        }
    }
}
