
int entero;

Console.Write("\n\t Escribe un entero entre 2 y 5: ");
entero = int.Parse(Console.ReadLine());

if( entero >= 2 && entero <= 5 )
{
    Console.WriteLine("\n\t Dentro del rango");
}
else
{
    Console.WriteLine("\n\t Fuera del rango");
}