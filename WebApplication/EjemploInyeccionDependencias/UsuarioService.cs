namespace WebApplication1.EjemploInyeccionDependencias
{
    public class UsuarioService
    {
        private readonly IEmailService _emailService;

        public UsuarioService(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public void RegistrarUsuario(string nombre, string email)
        {
            Console.WriteLine($"Usuario {nombre} registrado correctamente.");
            _emailService.SendEmail(email, "Bienvenido", "Gracias por registrarte en nuestro sistema!");
        }

        public void NotificarUsuario(string email)
        {
            _emailService.SendEmail(email, "Notificación", "Tienes una nueva notificación.");
        }
    }
}
