internal class Program
{

    static double ConvertirDolaresPesos(double dolares)
    {
        return 19.47*dolares;
    }

    private static void Main(string[] args)
    {
        double pesos;
        double dolares;

        Console.Write("\n\t Escribe los dolares: ");
        dolares = double.Parse(Console.ReadLine());

        pesos = ConvertirDolaresPesos(dolares);
        Console.WriteLine($"\n\t {dolares} dolares equivalen a: {pesos:F2} pesos");
        
    }
}