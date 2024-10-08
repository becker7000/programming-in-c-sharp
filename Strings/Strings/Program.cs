
// Datos sobre un usuario:

string nombre = "Juan López";
int edad = 21;
string telefono = "5501928374";
string pais = "México";
double estatura = 1.85;

string tarjeta =$"\n\t Nombre: {nombre}" +
                $"\n\t Edad: {edad}" +
                $"\n\t Teléfono: {telefono}" +
                $"\n\t País: {pais}" +
                $"\n\t Estatura: {estatura}";

string tarjeta2 = 
$@"
    Nombre: {nombre} 
    Edad: {edad}
    Teléfono: {telefono}
    País: {pais}
    Estatura: {estatura}
";

// Usando algunos métodos del tipo de dato string
Console.WriteLine(tarjeta2);
Console.WriteLine($"\n\t Tu nombre tiene {nombre.Length} letras");
Console.WriteLine($"\n\t Tu inicial es: {nombre[0]}");
Console.WriteLine($"\n\t Tu país en mayúsculas: {pais.ToUpper()}");
Console.WriteLine($"\n\t Los primeros 3 dígitos de tu teléfono: {telefono.Substring(0, 3)}");
Console.WriteLine($"\n\t Tu nombre sin espacios: {nombre.Trim()}");