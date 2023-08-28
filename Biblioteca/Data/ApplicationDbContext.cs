using Biblioteca.Models;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //// Define tus DbSet y relaciones aquí
        //public DbSet<Libro> Libros { get; set; }
        //public DbSet<Usuario> Usuarios { get; set; }
        //public DbSet<Préstamo> Préstamos { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }
       
    }
}
