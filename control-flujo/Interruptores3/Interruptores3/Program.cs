
Random aletorio = new Random();
int opcion;

while(true)
{
    Console.WriteLine($"\n\t Aleatorio: {aletorio.Next(10,41)}");
    Console.Write("\n\t 1. Otro \n\t 2. Salir \n\t Opción: ");
    opcion = int.Parse( Console.ReadLine() );
    if (opcion == 2)
    {
        break;
    }
}