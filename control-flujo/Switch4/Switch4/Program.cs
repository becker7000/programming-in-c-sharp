string opcion;
double area=0;

Console.WriteLine("\n\t Selecciona un opción para calcular un área: ");
Console.WriteLine("\n\t 1. Círculo ");
Console.WriteLine("\n\t 2. Triángulo ");
Console.WriteLine("\n\t 3. Cuadrado ");
Console.Write("\n\t Opción: ");
opcion = Console.ReadLine();

switch(opcion)
{
    case "1":
        double radio;
        Console.Write("\n\t Escribe el radio del círculo: ");
        radio = double.Parse(Console.ReadLine());
        area = Math.PI * Math.Pow(radio, 2);
        Console.WriteLine($"\n\t El área del círculo es: {area:F3}");
        break;
    case "2":
        double b;
        double altura;
        Console.Write("\n\t Escribe la base: ");
        b = double.Parse(Console.ReadLine());
        Console.Write("\n\t Escribe la altura: ");
        altura = double.Parse(Console.ReadLine());
        area = (b*altura)/2.0;
        Console.WriteLine($"\n\t El área del triángulo es: {area:F3}");
        break;
    case "3":
        double lado;
        Console.Write("\n\t Escribe el lado: ");
        lado = double.Parse(Console.ReadLine());
        area = Math.Pow(lado, 2);
        Console.WriteLine($"\n\t El área del cuadrado es: {area:F3} ");
        break;
    default:
        Console.WriteLine("\n\t Escribe una opción válida del 1 al 3");
        break;
}


