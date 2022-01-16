using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppNetCore.Models
{
    [Table("Calificaciones")]
    public class Calificacion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CalificacionID { get; set; }

        [ForeignKey("Convocatoria")]
        public int ConvocatiriaID { get; set; }
        public Convocatoria? Convocatoria { get; set; }

        [ForeignKey("MatriculaAsignatura")]
        public int MatriculaAsignaturaID { get; set; }
        public MatriculaAsignatura? MatriculaAsignatura { get; set; }

        [Required]
        public int? NotaNumerica { get; set; }

        [Required]
        [MaxLength(20)]
        public string? NotaCategorica { get; set; }
    }
}
