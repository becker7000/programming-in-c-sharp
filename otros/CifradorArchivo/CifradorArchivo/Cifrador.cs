using System.Text;

namespace CifradorArchivo
{
    public class Cifrador
    {
        private string clave = "K"; // Clave interna

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
                char cifrado = (char)(texto[i] ^ clave[0]);
                resultado.Append(cifrado);
            }
            return resultado.ToString();
        }
    }

}