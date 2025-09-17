
int edad;

Console.Write("\n\t Escribe tu edad: ");
edad = int.Parse(Console.ReadLine());

Console.WriteLine("\n\t Eres {0} de edad",edad>=18?"MAYOR":"MENOR");