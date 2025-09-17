
float montoSinDesc;
float montoConDesc;

Console.Write("\n\t Escribe un monto: $");
montoSinDesc = float.Parse(Console.ReadLine());

montoConDesc = montoSinDesc * 0.8f;

Console.WriteLine($"\n\t El monto con el descuento aplicado es: ${montoConDesc:F2}");
