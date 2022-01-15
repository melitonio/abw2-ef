using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppNetCore.Models
{
    [Table("Matriculas")]
    public class Matricula
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MatriculaID { get; set; }

        [Required]
        public DateTime? Fecha { get; set; }

        [ForeignKey("CursoAcademico")]
        public int CursoAcademicoID { get; set; }
        public CursoAcademico? CursoAcademico { get; set; }

        [ForeignKey("Alumno")]
        public int AlumnoID { get; set; }
        public Alumno? Alumno { get; set; }

        [ForeignKey("Carrera")]
        public int CarreraID { get; set; }
        public Carrera? Carrera { get; set; }

        public IList<MatriculaAsignatura>? MatriculaAsignaturas { get; set; }
    }
}
