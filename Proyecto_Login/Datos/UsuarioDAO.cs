using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Proyecto_Login.Datos
{
    internal class UsuarioDAO
    {
        private readonly ConexionDB conexionDB = new ConexionDB();

        public bool ValidarAcceso(string usuario, string contrasena)
        {
            string consulta = @"SELECT COUNT(*) FROM usuario WHERE usuario=@usuario AND contrasena=@contrasena AND activo=1";
            using (SqlConnection conexion = conexionDB.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.Add("@usuario", SqlDbType.VarChar, 100).Value = usuario;
                    comando.Parameters.Add("@contrasena", SqlDbType.VarChar, 100).Value = contrasena;

                    conexion.Open();

                    int cantidad = Convert.ToInt32(comando.ExecuteScalar());

                    return cantidad > 0;
                }
            }
        }
    }
}