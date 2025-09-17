
int moneda;
Random aleatorio = new Random();

moneda = aleatorio.Next(0, 2);

if (moneda == 0)
{
    Console.WriteLine("\n\t SOOOOL!");
}
else
{
    Console.WriteLine("\n\t AGUILAA!");
}
