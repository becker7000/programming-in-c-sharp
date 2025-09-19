namespace IntroPoo
{
    public class Automovil
    {
        // Atributos:
        private string marca;
        private string modelo;
        private double precio;

        // Constructor:
        public Automovil(string marca, string modelo, double precio)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.precio = precio;
        }

        // Accesores:

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        // Método personalizado:
        public void Mostrar()
        {
            Console.Write("\n\t +------------------------------+");
            Console.Write($"\n\t | Marca: {marca}");
            Console.Write($"\n\t | Modelo: {modelo}");
            Console.Write($"\n\t | Precio: $ {precio:F2}");
            Console.Write("\n\t +------------------------------+");
        }
    }
}
