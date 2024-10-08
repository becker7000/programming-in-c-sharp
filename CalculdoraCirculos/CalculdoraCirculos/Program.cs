Console.WriteLine("Calculadora de círculos");
Console.WriteLine("Escribe el radio: ");
double radio = Convert.ToDouble(Console.ReadLine());
double area = Math.PI * radio * radio;

Console.WriteLine("El área del círculo es: {0:F2}",area);


