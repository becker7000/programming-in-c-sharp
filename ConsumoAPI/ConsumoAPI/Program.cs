using System; // Importa el espacio de nombres System, que contiene clases fundamentales.
using System.Net.Http; // Importa las clases necesarias para realizar solicitudes HTTP.
using System.Threading.Tasks; // Importa las clases que permiten trabajar con tareas asíncronas.
using Newtonsoft.Json; // Importa la biblioteca Newtonsoft.Json para manejar JSON.

class Program
{
    // Clase para mapear la respuesta JSON de la API
    public class User
    {
        public string Gender { get; set; } // Propiedad para almacenar el género del usuario.
        public Name Name { get; set; } // Propiedad para almacenar el nombre del usuario (usando la clase Name).
        public Location Location { get; set; } // Propiedad para almacenar la ubicación del usuario (usando la clase Location).
        public string Email { get; set; } // Propiedad para almacenar el correo electrónico del usuario.
        public Login Login { get; set; } // Propiedad para almacenar los datos de inicio de sesión (usando la clase Login).
        public string Phone { get; set; } // Propiedad para almacenar el número de teléfono del usuario.
    }

    // Clase para mapear el nombre del usuario
    public class Name
    {
        public string Title { get; set; } // Propiedad para almacenar el título del nombre.
        public string First { get; set; } // Propiedad para almacenar el primer nombre.
        public string Last { get; set; } // Propiedad para almacenar el apellido.
    }

    // Clase para mapear la ubicación del usuario
    public class Location
    {
        public string City { get; set; } // Propiedad para almacenar la ciudad.
        public string Country { get; set; } // Propiedad para almacenar el país.
    }

    // Clase para mapear los datos de inicio de sesión
    public class Login
    {
        public string Username { get; set; } // Propiedad para almacenar el nombre de usuario.
    }

    // Clase para mapear la respuesta completa de la API
    public class ApiResponse
    {
        public User[] Results { get; set; } // Propiedad que almacena un array de usuarios devueltos por la API.
    }

    // Método principal, punto de entrada del programa
    static async Task Main(string[] args)
    {
        // Crea una instancia de HttpClient para realizar solicitudes HTTP
        using (HttpClient client = new HttpClient())
        {
            try
            {
                string url = "https://randomuser.me/api"; // URL de la API que se va a consultar.

                // Envía una solicitud GET de forma asíncrona a la URL especificada
                HttpResponseMessage response = await client.GetAsync(url);

                // Verifica si la respuesta fue exitosa (código de estado 200)
                if (response.IsSuccessStatusCode)
                {
                    // Lee el contenido de la respuesta como una cadena de texto JSON
                    string jsonData = await response.Content.ReadAsStringAsync();

                    // Deserializa la cadena JSON en un objeto ApiResponse
                    ApiResponse apiResponse = JsonConvert.DeserializeObject<ApiResponse>(jsonData);

                    // Verifica si se obtuvieron resultados
                    if (apiResponse.Results.Length > 0)
                    {
                        User user = apiResponse.Results[0]; // Toma el primer usuario del array de resultados.

                        // Muestra los datos del usuario en la consola
                        Console.WriteLine($"Nombre: {user.Name.Title} {user.Name.First} {user.Name.Last}");
                        Console.WriteLine($"Género: {user.Gender}");
                        Console.WriteLine($"Email: {user.Email}");
                        Console.WriteLine($"Usuario: {user.Login.Username}");
                        Console.WriteLine($"Teléfono: {user.Phone}");
                        Console.WriteLine($"Ubicación: {user.Location.City}, {user.Location.Country}");
                    }
                }
                else
                {
                    // Si la respuesta no fue exitosa, muestra el código de estado de la respuesta
                    Console.WriteLine("Error al acceder a la API: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones: muestra el mensaje de error en caso de que ocurra una excepción
                Console.WriteLine("Se produjo un error: " + ex.Message);
            }
        }
    }
}
