internal class Program
{
    private static void Main(string[] args)
    {
        int a;
        int b;

        Console.Write("\n\t Escribe el valor de a: ");
        a = int.Parse(Console.ReadLine());

        Console.Write("\n\t Escribe el valor de b: ");
        b = int.Parse(Console.ReadLine());

        // Atajo: ctrl+d
        Console.WriteLine($"\n\t {a} + {b} = {a+b}");
        Console.WriteLine($"\n\t {a} - {b} = {a-b}");
        Console.WriteLine($"\n\t {a} * {b} = {a*b}");
        Console.WriteLine($"\n\t {a} / {b} = {a/b}");

    }
}

/*
    
    50 % 17 = 16
    10 % 3 = 1
    20 % 11 = 9
    140 % 50 = 40

    200 segundos ->  3 minutos con 20 segundos

 */