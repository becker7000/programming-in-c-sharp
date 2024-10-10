using System;
using System.IO;
using System.Text;

public class Cifrador
{
    private string clave = "K"; // Clave interna

    // Constructor que recibe el texto a cifrar
    public Cifrador(string texto)
    {
        TextoCifrado = Cifrar(texto);
    }

    public string TextoCifrado { get; private set; }

    private string Cifrar(string texto)
    {
        StringBuilder resultado = new StringBuilder();

        for (int i = 0; i < texto.Length; i++)
        {
            // Cifrar usando XOR con la clave
            char cifrado = (char)(texto[i] ^ clave[0]); // XOR con la clave 'K'
            resultado.Append(cifrado);
        }

        return resultado.ToString();
    }
}

public class ArchivoWriter
{
    private string rutaArchivo;

    public ArchivoWriter(string rutaArchivo)
    {
        this.rutaArchivo = rutaArchivo;
    }

    public void Escribir(string texto)
    {
        File.WriteAllText(rutaArchivo, texto);
        Console.WriteLine($"Texto escrito en {rutaArchivo}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        string textoOriginal = "Hola, este es un mensaje secreto!";

        // Cifrar el texto
        Cifrador cifrador = new Cifrador(textoOriginal);
        string textoCifrado = cifrador.TextoCifrado;
        Console.WriteLine($"Texto cifrado: {textoCifrado}");

        // Escribir el texto cifrado en un archivo
        ArchivoWriter archivoWriter = new ArchivoWriter("texto_cifrado.txt");
        archivoWriter.Escribir(textoCifrado);
    }
}
