using PilaresPoo;

internal class Program
{
    private static void Main(string[] args)
    {

        // Dynamic binding
        Persona[] personas = new Persona[4];
        personas[0] = new Medico("Dr. Eduardo", "77122334", "Cardiología");
        personas[1] = new Medico("Dra. Laura", "5601928374", "Pediatría");
        personas[2] = new Deportista("Zeus", "5788001208", "Natación");
        personas[3] = new Deportista("Daniela", "6781726354", "Atletísmo");

        // Usando un método polimorfico
        for(int i=0; i<personas.Length; i++ )
        {
            personas[i].Mostrar();
        }


    }
}