
int entero;

Console.Write("\n\t Escribe un número entero: ");
entero = int.Parse(Console.ReadLine());

if( entero % 7 == 0 )
{
    Console.WriteLine("\n\t El entero es multiplo de 7...");
}
else
{
    Console.WriteLine("\n\t El entero no es múltiplo de 7...");
}