
string sSueldo = "45000ytzdfghnj";

try{
    double dSueldo = double.Parse(sSueldo);
    Console.WriteLine($"\n\t El sueldo es: $ {dSueldo:F2}");
}
catch(FormatException exception)
{
    Console.WriteLine("\n\t El formato del sueldo no es válido: \n\t "+exception.Message);
}
finally
{
    Console.WriteLine("\n\t Fin del programa...");
}