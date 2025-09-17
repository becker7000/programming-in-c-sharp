
internal class Program
{
    static void MostrarArreglo(int[] arreglo)
    {
        for (int i = 0; i < arreglo.Length; i++)
        {
            Console.Write("  " + arreglo[i]);
        }
        Console.WriteLine();
    }

    static void OrdenarPorBurbuja(int[] arreglo)
    {
        int n = arreglo.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (arreglo[j] > arreglo[j + 1])
                {   // Intercambiamos de posición los elementos:
                    int auxiliar = arreglo[j];
                    arreglo[j] = arreglo[j + 1];
                    arreglo[j + 1] = auxiliar;
                }
            }
        }
    }

    private static void Main(string[] args)
    {
        Random aleatorio = new Random();
        int[] numeros = new int[20];

        // Llenamos el arreglo de aleatorios entre 20 y 80
        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = aleatorio.Next(20, 81);
        }

        // Mostramos el arreglo sin ordenar: 
        Console.Write("\n\t Arreglo sin ordenar: ");
        MostrarArreglo(numeros);

        // Ordenamos por el algortimo de ordenamiento de burbuja
        OrdenarPorBurbuja(numeros);

        // Mostramos el arreglo ya ordenado:
        Console.Write("\n\t Arreglo ordenado: ");
        MostrarArreglo(numeros);

    }
}

/*

    numeros: 7,8,4,9,3,1,2 -> # elementos: 7 (n) -> # comparaciones: 6 (n-1)

    i=0, j=n-1
    # pasada: 0 -> # comp: 6 = n-1-i = 7-1-0 = 6
    7,8,4,9,3,1,2
    7,4,8,9,3,1,2
    7,4,8,9,3,1,2
    7,4,8,3,9,1,2
    7,4,8,3,1,9,2
    7,4,8,3,1,2,9

    # pasada: 1 -> # comp: 5 = n-1-i = 7-1-2 = 5
    4,7,8,3,1,2,9
    4,7,8,3,1,2,9
    4,7,3,8,1,2,9
    4,7,3,1,8,2,9
    4,7,3,1,2,8,9

    # pasada: 2 -> # comp: 4
    4,7,3,1,2,8,9
    4,3,7,1,2,8,9
    4,3,1,7,2,8,9
    4,3,1,2,7,8,9

    # pasada: 3 -> # comp: 3
    3,4,1,2,7,8,9
    3,1,4,2,7,8,9
    3,1,2,4,7,8,9 

    # pasada: 4 -> # comp: 2
    1,3,2,4,7,8,9
    1,2,3,4,7,8,9 

    # pasada: 5 -> # comp: 1
    1,2,3,4,7,8,9

*/