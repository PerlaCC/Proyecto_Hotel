
using MySql.Data.MySqlClient;
namespace Proyecto_Hotel
{
    class ConexionBD
    {
        private static string cadenaConexion = "server=localhost;database=hotel;user=root;password=;";

        public static MySqlConnection ObtenerConexion()
        {
            var Conexion = new MySqlConnection(cadenaConexion);
            Conexion.Open();
            return Conexion;
        }
    }
}
