namespace CEntidades.Models
{
    public class Usuarios
    {
        public int UserId { get; set; }
        public string EmpleadoId { get; set; }
        public string Username { get; set; }
        public string Passwords { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime UltimaSesion { get; set; }
        public int EstadoId { get; set; }
    }
}

