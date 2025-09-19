namespace PilaresPoo
{
    public class Deportista : Persona
    {
        public string Deporte { get; set; }

        public Deportista(string nombre,string telefono,string deporte) : base(nombre,telefono)
        {
            Deporte = deporte;
        }

        public override void Mostrar()
        {
            Console.Write("\n\t +------ DEPORTISTA --------+");
            Console.Write($"\n\t | Nombre: {Nombre}");
            Console.Write($"\n\t | Teléfono: {Telefono}");
            Console.Write($"\n\t | Deporte: {Deporte}");
            Console.Write("\n\t +--------------------------+");
        }

    }
}
