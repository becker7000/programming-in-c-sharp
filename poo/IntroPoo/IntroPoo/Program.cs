using IntroPoo;

internal class Program
{
    private static void Main(string[] args)
    {
        // Clase nombre_objeto = new Contructor(parametros)
        Planeta planeta1 = new Planeta("Mercurio", "Arena", 1);
        Planeta planeta2 = new Planeta("Venus", "Anaranjado", 2);
        Planeta planeta3 = new Planeta("Tierra", "Azul", 3);
        Planeta planeta4 = new Planeta("Marte", "Rojo", 4);

        planeta1.Color = "Amarillo";

        // Usando un método personalizado:
        planeta1.Mostrar();
        planeta2.Mostrar();
        planeta3.Mostrar();
        planeta4.Mostrar();

        Console.WriteLine($"\n\t El planeta {planeta1.Nombre} esta en la posición {planeta1.Posicion}");

        // Instancias de la clase Automovil
        Automovil auto1 = new Automovil("Toyota", "Corolla", 600000);
        Automovil auto2 = new Automovil("Chrevrolete", "Trax", 750000);
        Automovil auto3 = new Automovil("Subaru", "BRZ", 900000);
        Automovil auto4 = new Automovil("Mercedes-Benz", "CLA", 1500000);

        // Usando un método personalizado:
        auto1.Mostrar();
        auto2.Mostrar();
        auto3.Mostrar();
        auto4.Mostrar();
    
    }
}