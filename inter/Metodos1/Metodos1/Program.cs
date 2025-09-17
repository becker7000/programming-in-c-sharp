internal class Program
{
    static void Saludar(string nombre)
    {
        Console.WriteLine($"\n\t Hola, buenos días {nombre}");
    }

    private static void Main(string[] args)
    {
        Saludar("Antonio");
        Saludar("Laura");
        Saludar("Marcos");
    }
}