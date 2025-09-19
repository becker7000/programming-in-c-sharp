using MySql.Data.MySqlClient;

namespace GestorProductos
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
            using(var conn = databaseConnection.GetConnection())
            {
                conn.Open();
                var query = "INSERT INTO productos(nombre,precio,existencias,categoria) VALUES (@nombre,@precio,@existencias,@categoria)";
                using(var cmd = new MySqlCommand(query,conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", producto.Nombre);
                    cmd.Parameters.AddWithValue("@precio", producto.Precio);
                    cmd.Parameters.AddWithValue("@existencias",producto.Existencias);
                    cmd.Parameters.AddWithValue("@categoria",producto.Categoria);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Producto> ListarProductos()
        {
            var productos = new List<Producto>();
            using(var conn = databaseConnection.GetConnection())
            {
                conn.Open();
                var query = "SELECT * FROM productos";
                using(var cmd = new MySqlCommand(query, conn))
                {
                    using(var lector = cmd.ExecuteReader())
                    {
                        while(lector.Read())
                        {
                            var producto = new Producto
                            {
                                Id = lector.GetInt32("id"),
                                Nombre = lector.GetString("nombre"),
                                Precio = lector.GetDouble("precio"),
                                Existencias = lector.GetInt32("existencias"),
                                Categoria = lector.GetString("categoria")
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
                var query = "UPDATE productos SET nombre=@nombre,precio=@precio,existencias=@existencias,categoria=@categoria WHERE id=@id";
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

        public void EliminarProducto(int id)
        {
            using(var conn = databaseConnection.GetConnection())
            {
                conn.Open();
                var query = "DELETE FROM productos WHERE id=@id";
                using(var cmd = new MySqlCommand(query,conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
