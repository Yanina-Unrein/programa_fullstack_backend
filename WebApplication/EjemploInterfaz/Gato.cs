namespace WebApplication1.EjemploInterfaz
{
    public class Gato : IAnimal
    {
        public string Nombre { get; set; }

        public Gato(string nombre)
        {
            Nombre = nombre;
        }

        public string HacerSonido()
        {
            return "Miau!";
        }
    }
}
