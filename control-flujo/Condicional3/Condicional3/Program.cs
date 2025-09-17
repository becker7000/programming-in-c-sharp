
string codigoPostal;

Console.Write("\n\t Escribe tu código postal: ");
codigoPostal = Console.ReadLine();

if( codigoPostal.Length == 5 )
{
    Console.WriteLine("\n\t El código postal tiene 5 caracteres");
}
else
{
    Console.WriteLine("\n\t El código postal no es válido...");
}