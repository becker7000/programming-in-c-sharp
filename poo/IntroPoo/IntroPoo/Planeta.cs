namespace IntroPoo
{
    public class Planeta
    {
        // Propiedades:
        private string nombre;
        private string color;
        private int posicion;

        // Método constructor:
        public Planeta(string nombre,string color,int posicion)
        {
            this.nombre = nombre;
            this.color = color;
            this.posicion = posicion;
        }

        // Accesores:

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public int Posicion
        {
            get { return posicion; }
            set { posicion = value; }
        }

        // Método personalizado:
        public void Mostrar()
        {
            Console.Write("\n\t +------------------------+");
            Console.Write($"\n\t | Nombre: {nombre}");
            Console.Write($"\n\t | Color: {color}");
            Console.Write($"\n\t | Posición: {posicion}");
            Console.Write("\n\t +------------------------+");
        }

    }
}
