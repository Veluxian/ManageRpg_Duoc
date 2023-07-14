using ManageRPG.Modelo;
using ManageRPG.Vista;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ManageRPG.Controlador
{
    internal class metodosAdmin
    {
        public List<Usuario> ObtenerDatos()
        {
            List<Usuario> tabla = new List<Usuario>();
            Modelo.DatabaseConnection conexiones = Modelo.DatabaseConnection.Instance;
            SqlConnection Sqlconexion = conexiones.GetConnection();
            Sqlconexion.Open();
            string query = "SELECT * FROM USUARIO";
            SqlCommand accion = new SqlCommand(query, Sqlconexion);
            SqlDataReader datos = accion.ExecuteReader();
            while (datos.Read())
            {
                tabla.Add(new Usuario
                {
                    id_usuario = int.Parse(datos["id_usuario"].ToString()),
                    usuario = datos["usuario"].ToString(),
                    contrasenna = datos["contrasenna"].ToString(),
                    id_rol = int.Parse(datos["id_rol"].ToString()),
                });
            }
            Sqlconexion.Close();
            return tabla;
        }

        public static void AgregarUsuario(string nombreUsuario, string password1, string password2, int tipo)
        {
            if (password1 == password2)
            {
                Modelo.DatabaseConnection conexiones = Modelo.DatabaseConnection.Instance;
                SqlConnection Sqlconexion = conexiones.GetConnection();
                Sqlconexion.Open();
                string query = "INSERT INTO USUARIO(id_Usuario, Usuario, contrasenna, id_rol) VALUES(next value for seq_usuario, '"+ nombreUsuario +"', '"+ password1 + "', '"+ tipo +"')";
                SqlCommand agregar = new SqlCommand(query, Sqlconexion);
                agregar.ExecuteNonQuery();
                Sqlconexion.Close();
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
                Modelo.DatabaseConnection conexiones = Modelo.DatabaseConnection.Instance;
                SqlConnection Sqlconexion = conexiones.GetConnection();
                Sqlconexion.Open();
                string query = " UPDATE USUARIO SET Usuario = '"+ nombreUsuario +"', contrasenna = '"+ password1 +"', id_rol = '"+ tipo +"' WHERE id_Usuario = '"+ idUsuario +"' ";
                SqlCommand modificar = new SqlCommand(query, Sqlconexion);
                modificar.ExecuteNonQuery();
                Sqlconexion.Close();
            }
            else
            {
                MessageBox.Show("Error de Actualizacion");
            }
        }
        public static void EliminarUsuario(int idUsuario)
        {
                Modelo.DatabaseConnection conexiones = Modelo.DatabaseConnection.Instance;
                SqlConnection Sqlconexion = conexiones.GetConnection();
                Sqlconexion.Open();
                string query = " DELETE FROM USUARIO WHERE id_Usuario = '"+ idUsuario +"'";
                SqlCommand eliminar = new SqlCommand(query, Sqlconexion);
                eliminar.ExecuteNonQuery();
                Sqlconexion.Close();
                
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
