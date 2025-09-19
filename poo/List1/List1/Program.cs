internal class Program
{
    private static void Main(string[] args)
    {
        List<string> frutas = new List<string>();

        // Agregando elementos
        frutas.Add("Manzana");
        frutas.Add("Naranja");
        frutas.Add("Mango");
        frutas.Add("Kiwi");
        frutas.Add("Fresa");

        // Elimiando un elemento:
        frutas.Remove("Naranja");

        // Usando un foreach
        Console.Write("\n\t Frutas: ");
        foreach(var fruta in  frutas)
        {
            Console.Write(" "+fruta);
        }

        Console.WriteLine($"\n\t Tamaño de la lista: {frutas.Count}");
        Console.WriteLine($"\n\t Primera fruta: {frutas[0]}");
        Console.WriteLine($"\n\t Indice de Kiwi {frutas.IndexOf("Kiwi")}");

        Console.WriteLine();
    }
}