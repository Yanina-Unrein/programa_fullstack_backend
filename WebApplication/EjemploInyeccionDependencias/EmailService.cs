namespace WebApplication1.EjemploInyeccionDependencias
{
    public class EmailService : IEmailService
    {
        public void SendEmail(string to, string subject, string body)
        {
            Console.WriteLine($"[FAKE] Simulación de envío a {to}: {subject} - {body}");
        }
    }
}