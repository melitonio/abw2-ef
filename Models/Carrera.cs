using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppNetCore.Models
{
    [Table("Carreras")]
    public class Carrera
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CarreraID { get; set; }

        [MaxLength(6)]
        public string? Codigo { get; set; }

        [Required]
        [MaxLength(70)]
        public string? Nombre { get; set; }

        [Required]
        public int? CreditosTotales { get; set; }

        [Required]
        public int? CreditosBasicos { get; set; }

        [Required]
        public int? CreditosObligatorios { get; set; }

        [Required]
        public int? CreditosOptativos { get; set; }

        [Range(1, 4)]
        [Required]
        public int? Cursos { get; set; }

        public IList<Asignatura>? Asignaturas { get; set; }

        public IList<Alumno>? Alumnos { get; set; }
    }
}
