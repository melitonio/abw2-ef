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

        [ForeignKey("Matricula")]
        public int MatriculaID { get; set; }
        public Matricula? Matricula { get; set; }

        public int? NotaNumerica { get; set; }
        public string? NotaCategorica { get; set; }

    }
}
