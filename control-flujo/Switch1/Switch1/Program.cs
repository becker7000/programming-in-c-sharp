
int opcion;

Console.Write("\n\t Selecciona  una opción: ");
Console.Write("\n\t 1. Ver la lista de productos ");
Console.Write("\n\t 2. Crear un producto nuevo ");
Console.Write("\n\t 3. Buscar un producto ");
Console.Write("\n\t 4. Modificar un producto ");
Console.Write("\n\t 5. Eliminar un producto ");
Console.Write("\n\t 6. Salir del gestor de productos ");
Console.Write("\n\t Opción: ");

opcion = int.Parse(Console.ReadLine());

switch (opcion)
{
    case 1:
        Console.WriteLine("\n\t LISTANDO PRODUCTOS");
        break;
    case 2:
        Console.WriteLine("\n\t CREANDO UN PRODUCTO NUEVO");
        break;
    case 3:
        Console.WriteLine("\n\t BUSCANDO UN PRODUCTO");
        break;
    case 4:
        Console.WriteLine("\n\t MODIFICANDO UN PRODUCTO");
        break;
    case 5:
        Console.WriteLine("\n\t MODIFICANDO UN PRODUCTO");
        break;
    case 6:
        Console.WriteLine("\n\t SALIENDO DEL GESTOR");
        break;
    default:
        Console.WriteLine("\n\t OPCION NO CONTEMPLADA");
        break;
}