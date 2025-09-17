
int suma = 0;
int contador = 1;
int maximo;

Console.Write("\n\t Sumar del 1 al: ");
maximo = int.Parse(Console.ReadLine());

while(contador<=maximo)
{
    suma += contador;
    contador++;
}

Console.WriteLine($"\n\t La suma del 1 al {maximo} es: {suma}");