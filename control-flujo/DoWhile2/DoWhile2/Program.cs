
int entero;

do
{
    Console.Write("\n\t Escribe un entero entre 1 y 3 o entre 7 y 9: ");
    entero = int.Parse(Console.ReadLine());
} 
while (entero < 1 || entero > 3 && entero < 7 || entero > 9);

Console.WriteLine("\n\t Opción válida...");