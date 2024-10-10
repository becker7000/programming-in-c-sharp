using PruebaBD;
using System.Diagnostics;

public class Program
{
    static void Main(string[] args)
    {

        var bd = new ConexionBD("localhost", "usuarios_bd","root","toor");
        var productoRepositorio = new ProductoRepositorio(bd);

        while(true)
        {
            Console.Clear();
            Console.WriteLine("\n\t Selecciona una opción:");
            Console.WriteLine("\t 1. Crear un producto nuevo");
            Console.WriteLine("\t 2. Listar productos");
            Console.WriteLine("\t 3. Actualizar un producto");
            Console.WriteLine("\t 4. Eliminar un producto");
            Console.WriteLine("\t 5. Salir");
            Console.Write("\t Opción: ");
            var opcion = Console.ReadLine();

            switch(opcion)
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
                    Console.WriteLine("\n\t SALIENDO EL GESTOR DE PRODUCTOS");
                    return;
                default:
                    Console.WriteLine("\n\t Opción no válida, intente de nuevo");
                    break;
            }

            Console.WriteLine("\n\t DA [ENTER] PARA CONTINUAR");
            Console.ReadKey(); // Ponemos una pausa antes de continuar...
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
        Console.WriteLine("\n\t PRODUCTO CREADO EXISTOSAMENTE");

    }

    private static void ListarProductos(ProductoRepositorio productoRepositorio)
    {
        Console.WriteLine("\n\t LISTANDO TODOS LOS PRODUCTOS");
        var productos = productoRepositorio.Listar();
        Console.WriteLine("\n\t Lista de productos");

        foreach (Producto producto in productos)
        {
            producto.Mostrar();
        }
    }

    private static void ActualizarProducto(ProductoRepositorio productoRepositorio)
    {
        Console.WriteLine("\n\t ACTUALIZANDO UN PRODUCTO");
        Console.Write("\n\t Escribe el id: ");
        var id = int.Parse(Console.ReadLine());
        var producto = new Producto { Id = id }; // Se ajusta unicamente el id

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
        var id = int.Parse( Console.ReadLine());
        productoRepositorio.Eliminar(id);
        Console.WriteLine("\n\t PRODUCTO ELIMINAR CON EXITO");
    }


}