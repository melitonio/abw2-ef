using WebAppNetCore.Models;
namespace WebAppNetCore
{
    public class DataService
    {
        public void Inicializar()
        {
            using AppDbContext db = new();
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            var carreras = new Carrera[] {
                    new Carrera {
                    CarreraID = 01,
                    Codigo ="IG",
                    Nombre= "Grado I en Informática de Gestión",
                    Cursos = 3,
                    CreditosTotales = 180,
                    CreditosBasicos = 60,
                    CreditosObligatorios = 110,
                    CreditosOptativos = 10
                },

                new Carrera {
                    CarreraID = 02,
                    Codigo ="EC",
                    Nombre= "Grado En Economía",
                    Cursos = 4,
                    CreditosTotales = 240,
                    CreditosBasicos = 60,
                    CreditosObligatorios = 168,
                    CreditosOptativos = 12
                },

                new Carrera {
                    CarreraID = 03,
                    Codigo = "DE",
                    Nombre= "Grado En Derecho",
                    Cursos = 4,
                    CreditosTotales = 240,
                    CreditosBasicos = 60,
                    CreditosObligatorios = 168,
                    CreditosOptativos = 12
                },
            };
            db.Carreras?.AddRange(carreras);
            db.SaveChanges();

            var asignaturas = new Asignatura[] {
                new Asignatura{
                    AsignaturaID = 1,
                    Nombre = "Fundamentos de Programación",
                    Creditos = 5,
                    Carracter = Carracter.Basica,
                    CarreraID = 01,
                    Codigo = "IG103",
                    Curso = 1,
                    Semestre = 1,
                },
                new Asignatura{
                    AsignaturaID = 2,
                    Nombre = "Aplicaciones Basadas en la Web II",
                    Creditos = 5,
                    Carracter = Carracter.Obligatoria,
                    CarreraID = 01,
                    Codigo = "IG302",
                    Curso = 3,
                    Semestre = 1,
                },

                new Asignatura{
                    AsignaturaID = 3,
                    Nombre = "Tecnología de la Programación",
                    Creditos = 5,
                    Carracter = Carracter.Obligatoria,
                    CarreraID = 01,
                    Codigo = "IG203",
                    Curso = 2,
                    Semestre = 1,
                },
                new Asignatura{
                    AsignaturaID = 4,
                    Nombre = "Programación Orientada a Objetos",
                    Creditos = 5,
                    Carracter = Carracter.Basica,
                    CarreraID = 01,
                    Codigo = "IG107",
                    Curso = 1,
                    Semestre = 2,
                }
            };

            db.Asignaturas?.AddRange(asignaturas);
            db.SaveChanges();

            var alumnos = new Alumno[]
            {
                new Alumno
                {
                    AlumnoID = 01,
                    Dip = "123123",
                    Nombre ="Ignacio",
                    Apellidos = "Ndong Nchama",
                    Sexo = TSexo.Hombre,
                    FechaNacimiento = new DateTime(1986, 7, 14,0,0,0,DateTimeKind.Utc),
                    Telefono = "222111111",
                    Email = "ignacio@unge.gq"
                }
            };
            db.Alumnos?.AddRange(alumnos);
            db.SaveChanges();
        }

        public void Add(Object item)
        {
            using AppDbContext dbContext = new();
            dbContext.Add(item);
            dbContext.SaveChanges();
        }

        public void Update(Object item)
        {
            using AppDbContext dbContext = new();
            dbContext.Update(item);
            dbContext.SaveChanges();
        }

        public void Remove(Object item)
        {
            using AppDbContext dbContext = new();
            dbContext.Remove(item);
            dbContext.SaveChanges();
        }
    }
}
