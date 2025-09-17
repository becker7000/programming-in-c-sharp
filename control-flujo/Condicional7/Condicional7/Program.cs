
int entero;

Console.Write("\n\t Escribe un entero entre 5 y 7 o entre 10 y 12: ");
entero = int.Parse(Console.ReadLine());

if( entero >= 5 && entero <= 7 || entero >= 10 && entero <= 12 )
{
    Console.WriteLine("\n\t Dentro del rango...");
}
else
{
    Console.WriteLine("\n\t Fuera del rango...");
}