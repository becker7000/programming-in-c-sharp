internal class Program
{
    private static void Main(string[] args)
    {

        double precioSinIva;
        double precioConIva;

        Console.Write("\n\t Escribe el precio del producto: $");
        precioSinIva = double.Parse(Console.ReadLine());

        precioConIva = precioSinIva * 1.16; // Se obtiene el 116%

        Console.WriteLine($"\n\t El costo del producto con IVA es: ${precioConIva:F2}");

    }
}