internal class Program
{
    private static void Main(string[] args)
    {
        int minutos;
        int segundos;

        Console.Write("\n\t Escribe los segundos: ");
        segundos = int.Parse(Console.ReadLine());

        Console.Write($"\n\t {segundos} son equivalentes a");

        minutos = segundos / 60;
        segundos = segundos % 60;

        Console.WriteLine($"\n\t {minutos} minutos con {segundos} segundos");

    }
}