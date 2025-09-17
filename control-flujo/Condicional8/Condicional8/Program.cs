
int anio;

Console.Write("\n\t Escribe un año: ");
anio = int.Parse(Console.ReadLine());

if ( anio % 4 == 0 && anio % 100 != 0 || anio % 400 == 0 )
{
    Console.WriteLine($"\n\t El año {anio} es bisiesto");
}
else
{
    Console.WriteLine($"\n\t El año {anio} no es bisiesto");
}