internal class Program
{
    static int Sumar(int a, int b)
    {
        return a + b;
    }

    static int Restar(int a, int b)
    {
        return a - b;
    }

    static int Multiplicar(int a, int b)
    {
        return a * b;
    }

    static int Dividir(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("\n\t No se puede dividir por cero");
            return 0;
        }
        return a / b;
    }

    private static void Main(string[] args)
    {
        int a, b;

        Console.Write("\n\t Escribe el valor de a: ");
        a = int.Parse(Console.ReadLine());

        Console.Write("\n\t Escribe el valor de b: ");
        b = int.Parse(Console.ReadLine());

        Console.WriteLine($"\n\t {a} + {b} = {Sumar(a, b)} ");
        Console.WriteLine($"\n\t {a} - {b} = {Restar(a, b)} ");
        Console.WriteLine($"\n\t {a} * {b} = {Multiplicar(a, b)} ");
        Console.WriteLine($"\n\t {a} / {b} = {Dividir(a, b)} ");

    }
}