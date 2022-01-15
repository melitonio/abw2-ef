using Microsoft.EntityFrameworkCore;
using WebAppNetCore.Models;

namespace WebAppNetCore
{
    public class AppDbContext : DbContext
    {
        private readonly string _host = "localhost";
        private readonly string _database = "abw2-2021-2022";
        private readonly string _userName = "postgres";
        private const string _password = "malabo-2530";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = $"Host={_host}; Database={_database}; Username = {_userName}; Password={_password};";
            optionsBuilder.UseNpgsql(connectionString, op => op.EnableRetryOnFailure(10, TimeSpan.FromSeconds(30), null));
        }

        public DbSet<Alumno>? Alumnos { get; set; }
        public DbSet<Carrera>? Carreras { get; set; }
        public DbSet<Asignatura>? Asignaturas { get; set; }
        public DbSet<Convocatoria>? Convocatorias { get; set; }
        public DbSet<Matricula>? Matriculas { get; set; }
        public DbSet<Calificacion>? Calificaciones { get; set; }
    }
}
