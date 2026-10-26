namespace GestionEscolar.Models
{
    public class Aula
    {
        public int Id { get; set; }
        public string Codigo { get; set; } = string.Empty;
        public int Capacidad { get; set; }
        public string Edificio { get; set; } = string.Empty;
        public bool TieneProyector { get; set; }
    }
}