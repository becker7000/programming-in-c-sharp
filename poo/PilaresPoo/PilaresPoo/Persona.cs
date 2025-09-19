namespace PilaresPoo
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }

        public Persona(string nombre, string telefono)
        {
            Nombre = nombre;
            Telefono = telefono;
        }

        // Deberá ser implementado por las clase hijas
        public abstract void Mostrar();

    }
}
