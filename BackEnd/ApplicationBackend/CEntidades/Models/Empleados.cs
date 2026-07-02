namespace CEntidades.Models
{
    public class Empleados
    {
        public string EmpleadoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public int SexoId { get; set; }
        public int EstadoCivilId { get; set; }
        public int DepartamentoId { get; set; }
        public int CargoId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int EstadoId { get; set; }
    }
}

