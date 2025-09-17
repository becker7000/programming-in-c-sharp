
int i = 1;

while (i <= 10)
{
    if( i==4 || i==9)
    {
        i++;
        continue;
    }
    Console.WriteLine($"\n\t i = {i}");
    i++;
}