using ManageRPG.Vista;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageRPG.Controlador
{
    internal class controladorObjetos
    {
        public static void AgregarObjeto(string nombreObjeto, string descripcionObjeto, int pesoObjeto, int valorObjeto, int cantidadObjeto)
        {
            Modelo.DatabaseConnection conexiones = Modelo.DatabaseConnection.Instance;
            SqlConnection Sqlconexion = conexiones.GetConnection();
            Sqlconexion.Open();
            string query = "INSERT INTO OBJETO(ID_OBJETO, NOMBRE_OBJETO, DESCRIPCION_OBJETO,PESO_OBJETO, VALOR_OBJETO, CANTIDAD_OBJETO) VALUES(next value for seq_objeto, '" + nombreObjeto + "', '" + descripcionObjeto + "', '" + pesoObjeto + "', '" + valorObjeto + "', '" + cantidadObjeto + "')";
            SqlCommand agregar = new SqlCommand(query, Sqlconexion);
            agregar.ExecuteNonQuery();
            Sqlconexion.Close();
        }

        public static void ModificarObjeto(int id_objeto, string nombreObjeto, string descripcionObjeto, int pesoObjeto, int valorObjeto, int cantidadObjeto)
        {
            Modelo.DatabaseConnection conexiones = Modelo.DatabaseConnection.Instance;
            SqlConnection Sqlconexion = conexiones.GetConnection();
            Sqlconexion.Open();
            string query = "UPDATE OBJETO SET NOMBRE_OBJETO = '" + nombreObjeto + "', DESCRIPCION_OBJETO = '" + descripcionObjeto + "',PESO_OBJETO = '" + pesoObjeto + "', VALOR_OBJETO = '" + valorObjeto + "' , CANTIDAD_OBJETO = '" + cantidadObjeto + "' WHERE ID_OBJETO = '"+ id_objeto +"'";
            SqlCommand modificar = new SqlCommand(query, Sqlconexion);
            modificar.ExecuteNonQuery();
            Sqlconexion.Close();
        }

        public static void EliminarObjeto(int id_objeto)
        {
            Modelo.DatabaseConnection conexiones = Modelo.DatabaseConnection.Instance;
            SqlConnection Sqlconexion = conexiones.GetConnection();
            Sqlconexion.Open();
            string query = "DELETE FROM OBJETO WHERE ID_OBJETO = '"+ id_objeto +"'";
            SqlCommand eliminar = new SqlCommand(query, Sqlconexion);
            eliminar.ExecuteNonQuery();
            Sqlconexion.Close();
        }

        public static void Cancelar()
        {

        }
    }

}