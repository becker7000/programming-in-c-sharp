
int entero;

Console.Write("\n\t Escribe un número entero: ");
entero = int.Parse(Console.ReadLine());

if ( entero > 0)
{
    Console.WriteLine("\n\t El número entero es positivo...");
}

if ( entero < 0 )
{
    Console.WriteLine("\n\t El número entero es negativo...");
}

if ( entero == 0 )
{
    Console.WriteLine("\n\t El número entero es cero...");
}