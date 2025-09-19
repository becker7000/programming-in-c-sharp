using MySql.Data.MySqlClient;

namespace GestorProductos
{
    public class ConexionBD
    {
        private readonly String conexion;

        public ConexionBD(string server, string database,string username,string password)
        {
            conexion = $"Server={server};Database={database};User ID={username};Password={password}";
        }

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(conexion);
        }

    }
}
