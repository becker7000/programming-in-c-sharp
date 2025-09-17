
char letra1;
char letra2;
int distancia;

Console.Write("\n\t Escribe un letra: ");
letra1 = char.Parse(Console.ReadLine());

Console.Write("\n\t Escribe otra letra: ");
letra2 = char.Parse(Console.ReadLine());

distancia  = Math.Abs(letra2-letra1);

Console.Write($"\n\t La distancia entre {letra1} y la {letra2} es: {distancia}");