internal class Program
{

    static void ImprimirMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            Console.WriteLine("\n");
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write($"\t {matriz[i, j]}");
            }
        }

        Console.WriteLine("\n");
    }

    private static void Main(string[] args)
    {
        Random aleatorio = new Random();
        int n;

        Console.Write("\n\t Escribe el valor de n: ");
        n = int.Parse(Console.ReadLine());

        // Matriz cuadrada de nxn
        int[,] matriz = new int[n, n];

        // Llenamos la matriz de enteros aleatorios entre 10 y 30:
        for (int i = 0; i < matriz.GetLength(0); i++) // Filas
        {
            for (int j = 0; j < matriz.GetLength(1); j++) // Columnas
            {
                matriz[i, j] = aleatorio.Next(10, 31);
            }
        }

        // Mostramos los elementos en la matriz
        Console.WriteLine("\n\t Matriz generada: \n");
        ImprimirMatriz(matriz);

    }
}