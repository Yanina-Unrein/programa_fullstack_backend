namespace WebApplication1.EjemploHerencia
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }

        public Persona(string nombre, string apellido, string dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
        }
    }
}
