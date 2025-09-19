using GestorProductos;

internal class Program
{
    private static void Main(string[] args)
    {
        var conexionBD = new ConexionBD("localhost", "csharp_cst_bd", "root", "toor");
        var productoRepositorio = new ProductoRepositorio(conexionBD);

        while (true)
        {
            Console.Clear();
            Console.Write("\n\t Selecciona una opción: ");
            Console.Write("\n\t 1. Crear un producto");
            Console.Write("\n\t 2. Listar productos");
            Console.Write("\n\t 3. Modificar un producto");
            Console.Write("\n\t 4. Eliminar un producto");
            Console.Write("\n\t 5. Salir");
            Console.Write("\n\t Opción: ");
            var opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    CrearProducto(productoRepositorio);
                    break;
                case "2":
                    ListarProductos(productoRepositorio);
                    break;
                case "3":
                    ActualizarProducto(productoRepositorio);
                    break;
                case "4":
                    EliminarProducto(productoRepositorio);
                    break;
                case "5":
                    Console.WriteLine("\n\t SALIENDO DEL GESTOR DE PRODUCTOS");
                    return;
                default:
                    Console.WriteLine("\n\t OPCIÓN NO VÁLIDA");
                    break;
            }

            Console.WriteLine("\n\t DA [ENTER] PARA CONTINUAR");
            Console.ReadKey();

        }
    }

    private static void CrearProducto(ProductoRepositorio productoRepositorio)
    {
        Console.WriteLine("\n\t CREANDO UN PRODUCTO");
        var producto = new Producto();

        Console.Write("\n\t Nombre: ");
        producto.Nombre = Console.ReadLine();

        Console.Write("\n\t Precio: $ ");
        producto.Precio = double.Parse(Console.ReadLine());

        Console.Write("\n\t Existencias: ");
        producto.Existencias = int.Parse(Console.ReadLine());

        Console.Write("\n\t Categoria: ");
        producto.Categoria = Console.ReadLine();

        productoRepositorio.CrearProducto(producto);
        Console.WriteLine("\n\t PRODUCTO GUARDADO CORRECTAMENTE");

    }

    private static void ListarProductos(ProductoRepositorio productoRepositorio)
    {
        Console.WriteLine("\n\t LISTANDO PRODUCTOS");
        var productos = productoRepositorio.ListarProductos();
        Console.WriteLine("\n\t Lista de productos: ");
        foreach (Producto producto in productos)
        {
            producto.Mostrar();
        }
    }

    private static void ActualizarProducto(ProductoRepositorio productoRepositorio)
    {
        Console.WriteLine("\n\t ACTUALIZANDO UN PRODUCTO");
        Console.Write("\n\t Escribe el id del producto a modificar: ");
        var id = int.Parse(Console.ReadLine());
        var producto = new Producto { Id = id };

        Console.Write("\n\t Nuevo nombre: ");
        producto.Nombre = Console.ReadLine();

        Console.Write("\n\t Nuevo precio: $ ");
        producto.Precio = double.Parse(Console.ReadLine());

        Console.Write("\n\t Nuevas existencias: ");
        producto.Existencias = int.Parse(Console.ReadLine());

        Console.Write("\n\t Nueva categoria: ");
        producto.Categoria = Console.ReadLine();

        productoRepositorio.ActualizarProducto(producto);
        Console.WriteLine("\n\t PRODUCTO ACTUALIZADO CORRECTAMENTE");

    }

    private static void EliminarProducto(ProductoRepositorio productoRepositorio)
    {
        Console.WriteLine("\n\t ELIMINANDO UN PRODUCTO");
        Console.Write("\n\t Escribe el id del producto a eliminar: ");
        var id = int.Parse(Console.ReadLine());
        productoRepositorio.EliminarProducto(id);
        Console.WriteLine("\n\t PRODUCTO ELIMINADO ");
    }

}