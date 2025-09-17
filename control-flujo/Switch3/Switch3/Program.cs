
int dado;
Random aleatorio = new Random();

dado = aleatorio.Next(1, 7);

switch (dado)
{
    case 1:
        Console.WriteLine("\n\t UNO");
        break;
    case 2:
        Console.WriteLine("\n\t DOS");
        break;
    case 3:
        Console.WriteLine("\n\t TRES");
        break;
    case 4:
        Console.WriteLine("\n\t CUATRO");
        break;
    case 5:
        Console.WriteLine("\n\t CINCO");
        break;
    case 6:
        Console.WriteLine("\n\t SIES");
        break;
}