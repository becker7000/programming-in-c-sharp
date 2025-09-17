
char letra;

Console.Write("\n\t Escribe una letra: ");
letra = char.Parse(Console.ReadLine());

switch (letra)
{
    case 'a': 
    case 'A':
        Console.WriteLine("\n\t PRIMERA VOCAL");
        break;
    case 'e':
    case 'E':
        Console.WriteLine("\n\t SEGUNDA VOCAL");
        break;
    case 'i':
    case 'I':
        Console.WriteLine("\n\t TERCERA VOCAL");
        break;
    case 'o':
    case 'O':
        Console.WriteLine("\n\t CUARTA VOCAL");
        break;
    case 'u':
    case 'U':
        Console.WriteLine("\n\t QUINTA VOCAL");
        break;
    default:
        Console.WriteLine("\n\t NINGUNA VOCAL");
        break;
}