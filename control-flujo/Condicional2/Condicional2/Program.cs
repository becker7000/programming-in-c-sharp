
int a;
int b;

Console.Write("\n\t Escribe el valor de a: ");
a = int.Parse(Console.ReadLine());

Console.Write("\n\t Escribe el valor de b: ");
b = int.Parse(Console.ReadLine());

if( a % b == 0 )
{
    Console.WriteLine($"\n\t {a} es divisible por {b}");
}

if( b % a == 0 )
{
    Console.WriteLine($"\n\t {b} es divisible por {a}");
}