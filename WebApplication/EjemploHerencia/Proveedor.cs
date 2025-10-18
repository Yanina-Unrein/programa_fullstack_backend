namespace WebApplication1.EjemploHerencia
{
    public class Proveedor : Persona
    {
        public string NumeroProveedor { get; set; }

        public Proveedor(string nombre, string apellido, string dni, string numeroProveedor)
            : base(nombre, apellido, dni)
        {
            NumeroProveedor = numeroProveedor;
        }
    }
}
