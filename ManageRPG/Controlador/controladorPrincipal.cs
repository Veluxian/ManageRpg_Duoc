using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageRPG.Vista;
using ManageRPG.Modelo;

namespace ManageRPG.Controlador
{
    internal class controladorPrincipal
    {
        public List<Objeto> ObtenerDatos()
        {
            List<Objeto> tabla = new List<Objeto>();
            Modelo.DatabaseConnection conexiones = Modelo.DatabaseConnection.Instance;
            SqlConnection Sqlconexion = conexiones.GetConnection();
            Sqlconexion.Open();
            string query = "SELECT * FROM OBJETO";
            SqlCommand accion = new SqlCommand(query, Sqlconexion);
            SqlDataReader datos = accion.ExecuteReader();
            while (datos.Read())
            {
                tabla.Add(new Objeto
                {
                    id_objeto = int.Parse(datos["id_objeto"].ToString()),
                    nombre_objeto = datos["nombre_objeto"].ToString(),
                    descripcion_objeto = datos["descripcion_objeto"].ToString(),
                    peso_objeto = int.Parse(datos["peso_objeto"].ToString()),
                    valor_objeto = int.Parse(datos["valor_objeto"].ToString()),
                    cantidad_objeto = int.Parse(datos["cantidad_objeto"].ToString())
                });
            }
            Sqlconexion.Close();
            return tabla;
        }

        public static void AgregarObjeto()
        {

        }

        public static void ModificarObjeto()
        {

        }

        public static void EliminarObjeto()
        {

        }
    }
}
