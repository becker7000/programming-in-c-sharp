using CifradorArchivo;
using System.Linq.Expressions;

internal class Program
{
    private static void Main(string[] args)
    {

        string textoOriginal;
        string textoCifrado;

        Console.Write("\n\t Escribe un texto: ");
        textoOriginal = Console.ReadLine();

        Cifrador cifrador = new Cifrador(textoOriginal);
        textoCifrado = cifrador.TextoCifrado;

        Console.Write($"\n\t Texto cifrado: {textoCifrado}");

        EscritorArchivo escritorArchivo = new EscritorArchivo("texto_oculto.txt");
        escritorArchivo.Escribir(textoCifrado);

    }
}