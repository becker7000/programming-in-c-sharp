
string[] planetas = {"Plutón","Venus","Tierra","Marte","Jupiter","Saturno","Urano","Neptuno"};

Console.WriteLine($"\n\t Tercer elemento: {planetas[2]}");
Console.WriteLine($"\n\t Cantidad de planetas: {planetas.Length}");
Console.WriteLine($"\n\t Primer elemento: {planetas[0]}");

planetas[0] = "Mercurio";

try
{
    Console.WriteLine($"\n\t Indice 20: {planetas[20]}");
}
catch (IndexOutOfRangeException exception)
{
    Console.WriteLine("\n\t Indice fuera de rango ");
    Console.WriteLine("\n\t "+exception.Message);
}

string planetas_cadena = String.Join(", ", planetas);
Console.WriteLine("\n\t Planetas sin bucle: "+planetas_cadena);

Console.Write("\n\t Planetas con bucle (for tradicional): ");
for(int i=0; i<planetas.Length;  i++)
{
    Console.Write($"\n\t planeta[{i}]: {planetas[i]}");
}

// Definiendo un arreglo de 100 strings
string[] satelites = new string[100];

Console.WriteLine("\n");