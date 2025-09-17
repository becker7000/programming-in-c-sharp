
decimal kilogramos;
decimal gramos;

Console.Write("\n\t Escribe los kilogramos: ");
kilogramos = decimal.Parse(Console.ReadLine());

gramos = kilogramos * 1000;

Console.WriteLine($"\n\t {kilogramos:F3} kg son equivalentes a {gramos:F3} g");