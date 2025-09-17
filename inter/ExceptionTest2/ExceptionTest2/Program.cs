
int a;
int b;

try
{
    Console.Write("\n\t Escribe a: ");
    a = int.Parse(Console.ReadLine());

    Console.Write("\n\t Escribe b: ");
    b = int.Parse(Console.ReadLine());

    int resultado = a / b;
    Console.WriteLine($"\n\t El resultado de {a}/{b} = {resultado}");
}
catch(DivideByZeroException exception)
{
    Console.WriteLine("\n\t La división por cero no está permitida...");
    Console.WriteLine("\n\t "+exception.Message);
}
catch(FormatException exception)
{
    Console.WriteLine("\n\t a y b deben ser números");
    Console.WriteLine("\n\t " + exception.Message);
}