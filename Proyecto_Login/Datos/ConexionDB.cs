using Microsoft.Data.SqlClient;

namespace Proyecto_Login.Datos
{
    public class ConexionDB
    {
        private string cadenaConexion =
            @"Data Source=localhost;
            Initial Catalog=bd_usuario;
            Integrated Security=True;
            TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}