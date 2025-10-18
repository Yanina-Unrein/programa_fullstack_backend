namespace WebApplication1.EjemploHerencia
{
    public class Cliente : Persona
    {
        public int NumeroCliente { get; set; }

        public Cliente(string nombre, string apellido, string dni, int numeroCliente)
            : base(nombre, apellido, dni)
        {
            NumeroCliente = numeroCliente;
        }
    }
}
