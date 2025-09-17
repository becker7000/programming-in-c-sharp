// 4! = 4*3*2*1 = 24

int factorial = 1; // Las multiplicaciones se inician en 1
int n;

Console.Write("\n\t Calcular el factorial de: ");
n = int.Parse(Console.ReadLine());

for( int i=n; i>=1; i--)
{
    factorial *= i;
}

Console.WriteLine($"\n\t {n}! = {factorial}");