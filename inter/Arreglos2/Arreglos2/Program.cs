
int[] edades = new int[5];
double promedio = 0;
int edadBuscar;
bool fueEncontrada = false;

for(int i = 0; i < edades.Length; i++)
{
    Console.Write($"\n\t Edad #{i+1}: ");
    edades[i] =  int.Parse(Console.ReadLine());
    promedio += edades[i];
}

// Sin importar la longitud...
promedio/=edades.Length;

Console.WriteLine($"\n\t El promedio es: {promedio:F2}");
Console.Write("\n\t Escribe una edad para buscar: ");
edadBuscar = int.Parse(Console.ReadLine());

// Busqueda secuencial:
for(int i = 0;i<edades.Length;i++)
{
    if (edades[i] == edadBuscar)
    {
        Console.WriteLine($"\n\t La edad {edadBuscar} sí esta en la lista");
        fueEncontrada = true;
        break;
    }
}

if(!fueEncontrada)
{
    Console.WriteLine($"\n\t La edad {edadBuscar} NOOOO esta en la lista");
}

