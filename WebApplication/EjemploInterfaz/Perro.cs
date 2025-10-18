namespace WebApplication1.EjemploInterfaz
{
    public class Perro : IAnimal
    {
        public string Nombre { get; set; }

        public Perro(string nombre)
        {
            Nombre = nombre;
        }

        public string HacerSonido()
        {
            return "Guau!";
        }
    }
}
