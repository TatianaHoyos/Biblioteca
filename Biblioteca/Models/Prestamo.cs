namespace Biblioteca.Models
{
    public class Prestamo
    {

        public int Id { get; set; }
        public int LibroId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        public Libro? Libro { get; set; }
        public Usuario? Usuario { get; set; }
    }
}
