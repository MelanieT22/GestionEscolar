namespace GestionEscolar.Models
{
    public class Maestro
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Especialidad { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public decimal Salario { get; set; }
    }
}