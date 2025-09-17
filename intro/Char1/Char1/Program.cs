
char letra;

Console.Write("\n\t Escribe una letra: ");
letra = Console.ReadKey().KeyChar;

Console.WriteLine($"\n\t La letra {letra} en minuscula es: {(char)(letra+32)}");