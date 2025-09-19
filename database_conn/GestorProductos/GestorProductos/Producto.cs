namespace GestorProductos
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Precio {  get; set; }
        public int Existencias { get; set; }
        public string Categoria { get; set; }

        public void Mostrar()
        {
            Console.WriteLine($"\n\t ==> Id: {Id} Nombre: {Nombre} Precio: ${Precio:F2} " +
                $"Existencias: {Existencias} Categoria: {Categoria}");
        }

    }
}
