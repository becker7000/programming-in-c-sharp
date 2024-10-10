using MySql.Data.MySqlClient;

namespace PruebaBD
{
    public class ProductoRepositorio
    {
        private readonly ConexionBD databaseConnection;

        public ProductoRepositorio(ConexionBD databaseConnection)
        {
            this.databaseConnection = databaseConnection;
        }

        public void CrearProducto(Producto producto)
        {
            using (var conn = databaseConnection.GetConnection())
            {
                conn.Open();
                var query = "INSERT INTO productos(nombre,precio,existencias,categoria) VALUES (@nombre,@precio,@existencias,@categoria)";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", producto.Nombre);
                    cmd.Parameters.AddWithValue("@precio", producto.Precio);
                    cmd.Parameters.AddWithValue("@existencias", producto.Existencias);
                    cmd.Parameters.AddWithValue("@categoria", producto.Categoria);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Producto> Listar()
        {
            var productos = new List<Producto>();

            using (var conn = databaseConnection.GetConnection())
            {
                conn.Open();
                var query = "SELECT * FROM productos";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var producto = new Producto
                            {
                                Id = reader.GetInt32("id"),
                                Nombre = reader.GetString("nombre"),
                                Precio = reader.GetDouble("precio"),
                                Existencias = reader.GetInt32("existencias"),
                                Categoria = reader.GetString("categoria")
                            };
                            productos.Add(producto);
                        }
                    }
                }

            }
            return productos;
        }

        public void ActualizarProducto(Producto producto)
        {
            using (var conn = databaseConnection.GetConnection())
            {
                conn.Open();
                var query = "UPDATE productos SET nombre = @nombre, precio = @precio, existencias = @existencias, categoria = @categoria WHERE id = @id";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", producto.Id);
                    cmd.Parameters.AddWithValue("@nombre", producto.Nombre);
                    cmd.Parameters.AddWithValue("@precio", producto.Precio);
                    cmd.Parameters.AddWithValue("@existencias", producto.Existencias);
                    cmd.Parameters.AddWithValue("@categoria",producto.Categoria);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void Eliminar(int id)
        {
            using (var conn = databaseConnection.GetConnection())
            {
                conn.Open();
                var query = "DELETE FROM productos WHERE id = @id";
                using (var cmd = new MySqlCommand(query,conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }


    }
}
