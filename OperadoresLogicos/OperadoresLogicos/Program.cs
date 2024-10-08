
bool a = true;
bool b = true;
bool c = true;

bool resultado = a && b;

// Usando interpolación de cadenas:
Console.WriteLine($"\n\t Resultado 1: {resultado}");

resultado = a! || !b;
Console.WriteLine($"\n\t Resultado 2: {resultado}");

resultado = a ^ c;
Console.WriteLine($"\n\t Resultado 3: {resultado}");

