using System;

namespace HolaMundo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int dia = 8;
            double temperatura = 17.5834;
            float horasDormidas = 7.5f; // Se debe indicar con 'f' al final
            string nombre = "Erick";
            char inicial = 'E';
            bool noMolestar = false;
            decimal tuImc = 23.3453m;

            Console.Write("\n\t Hola a todos desde C# \n");
            Console.WriteLine("\n\t Día del mes: "+dia);
            Console.WriteLine("\n\t Hoy es {0} de octubre",dia);
            Console.WriteLine($"\n\t Hoy es {dia} de octubre");
            Console.WriteLine($"\n\t Temperatura: {temperatura:F3} °C");
            Console.WriteLine($"\n\t Horas dormidas: {horasDormidas:F2}");
            Console.WriteLine($"\n\t Buenos días: {nombre}");
            Console.WriteLine($"\n\t Tu inicial es: {inicial}");
            Console.WriteLine($"\n\t ¿No molestar activado? -> {noMolestar}");
            Console.WriteLine($"\n\t Tu índice de masa corporal es: {tuImc}");



            Console.ReadKey();
        }
    }
}
