using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppNetCore.Models
{
    [Table("MatriculaAsignaturas")]
    public class MatriculaAsignatura
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MatriculaAsignaturaID { get; set; }

        [ForeignKey("Matricula")]
        public int MatriculaID { get; set; }
        public Matricula? Matricula { get; set; }

        [ForeignKey("Asignatura")]
        public int AsignaturaID { get; set; }
        public Asignatura? Asignatura { get; set; }
    }
}
