namespace CifradorArchivo
{
    public class EscritorArchivo
    {
        private string ruta;
        
        public EscritorArchivo(string ruta)
        {
            this.ruta = ruta;
        }

        public void Escribir(string texto)
        {
            File.WriteAllText(ruta, texto);
            Console.WriteLine("\n\t El archivo se ha escrito correctamente");
            Console.WriteLine($"\n\t Ruta: {ruta}");
        }

    }
}
