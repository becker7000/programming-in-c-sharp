
string password1 = "csharp1234";
string password2;

Console.Write("\n\t Escribe la contraseña: ");
password2 = Console.ReadLine();

Console.WriteLine("\n\t La contraseña es correcta? => "+password1.Equals(password2));
Console.WriteLine("\n\t La contraseña es vacía o nula? => "+string.IsNullOrEmpty(password2));
