

int niveles;
int i=1;

Console.Write("\n\t Cuantos niveles? => ");
niveles = int.Parse(Console.ReadLine());

while (i<=niveles)
{
    Console.WriteLine("\n");
    int j = 0;
    while(j<i)
    {
        Console.Write("\t #");
        j++;
    }
    i++;
}


Console.ReadKey();


/*
    Niveles: 3

    *
    
    *   *
    
    *   *    *

         *
       *   *
      *  *  *
       *   * 
         *
*/