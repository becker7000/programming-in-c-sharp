
Random aleatorio = new Random();
int n;

Console.Write("\n\t Escribe el valor de n: ");
n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine("\n");
    for (int j = 0; j < n; j++)
    {
        Console.Write($"\t {aleatorio.Next(10, 51)}");
    }
}

Console.WriteLine("\n");