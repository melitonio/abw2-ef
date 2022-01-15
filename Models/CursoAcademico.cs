using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppNetCore.Models
{
    [Table("CursosAcademicos")]
    public class CursoAcademico
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CursoAcademicoID { get; set; }

        [MaxLength(6)]
        public string? Codigo { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime? Inicio { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime? Final { get; set; }
        
        public IList<Convocatoria>? Convocatorias { get; set; }
    }
}