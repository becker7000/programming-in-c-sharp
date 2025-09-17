
int opcion;

do
{
    Console.Write("\n\t Escribe un numero del 1 al 5: ");
    opcion = int.Parse(Console.ReadLine());
}
while (opcion < 1 || opcion > 5);

Console.WriteLine("\n\t Opción válida!");


