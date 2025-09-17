
int nota;

Console.Write("\n\t Escribe tu calificación: ");
nota = int.Parse(Console.ReadLine());

string resultado = (nota>=90)? "Excelente": (nota>=75)? "Buena" : "Regular";

Console.WriteLine("\n\t Tu calificación es: "+resultado);