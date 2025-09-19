using Newtonsoft.Json;

class Program
{
    // Clase para mapear todos los datos de la API
    public class User
    {
        public string Gender { get; set; }
        public Name Name { get; set; }
        public Location Location { get; set; }
        public string Email { get; set; }

        public Login Login { get; set; }
        public string Phone { get; set; }
        
    }

    public class Name
    {
        public string Title { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
    }

    public class Location
    {
        public string City { get; set; }
        public string Country { get; set; }
    }

    public class Login
    {
        public string Username { get; set; }
    }

    public class ApiResponse
    {
        public User[] Results { get; set; }
    }

    static async Task Main(string[] args)
    {
        // Creando una instancia de un objeto HttpClient
        using(HttpClient client = new HttpClient())
        {
            try
            {
                // URL de la API a consultar:
                string url = "https://randomuser.me/api";

                // Enviamos una solicitud con el método GET de forma asincronwa
                HttpResponseMessage response = await client.GetAsync(url);

                // Verificar si la respuesta es existosa (200)
                if(response.IsSuccessStatusCode)
                {
                    // Se lee el contenido de la cadena de texto JSON
                    string jsonData = await response.Content.ReadAsStringAsync();

                    // Deserealiza la cadena JSON
                    ApiResponse apiResponse = JsonConvert.DeserializeObject<ApiResponse>(jsonData);

                    // Verificamos si se obtuvieron los resultados deseados:
                    if(apiResponse.Results.Length>0)
                    {
                        User user = apiResponse.Results[0];

                        Console.Write($"\n\t Nombre: {user.Name.Title} {user.Name.First} {user.Name.Last}");
                        Console.Write($"\n\t Género: {user.Gender}");
                        Console.Write($"\n\t Email: {user.Email}");
                        Console.Write($"\n\t Usuario: {user.Login.Username}");
                        Console.Write($"\n\t Phone: {user.Phone}");
                        Console.Write($"\n\t Región: {user.Location.Country} {user.Location.City}");

                    }
                    else
                    {
                        Console.WriteLine("\n\t ERROR AL CONSULTA LA API: "+response.StatusCode);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("\n\t Error al consultar la API: "+ex.Message);
            }
        }
    }


}