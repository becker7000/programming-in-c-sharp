namespace PilaresPoo
{
    public class Medico : Persona
    {
        // Atributo exclusivo de la clase Medico
        public string Especialidad {  get; set; }

        public Medico(string nombre,string telefono,string especialidad) : base(nombre,telefono)
        {
            Especialidad = especialidad;
        }

        // Implementando el método abstracto Mostrar
        public override void Mostrar()
        {
            Console.Write("\n\t +----------MEDICO----------+");
            Console.Write($"\n\t | Nombre {Nombre}");
            Console.Write($"\n\t | Teléfono {Telefono}");
            Console.Write($"\n\t | Especialidad {Especialidad}");
            Console.Write("\n\t +--------------------------+");
        }

    }
}
