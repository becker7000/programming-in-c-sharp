
string nombre;
string apellido;

Console.Write("\n\t Escribre tu nombre: ");
nombre = Console.ReadLine();

Console.Write("\n\t Escribe tu apellido: ");
apellido = Console.ReadLine();

Console.WriteLine("\n\t Buen día " + nombre + " " + apellido);
Console.WriteLine($"\n\t Tu nombre tiene {nombre.Length} letras");
Console.WriteLine($"\n\t Tu inicial es: {nombre[0]}");


// H o l a 
// 0 1 2 3