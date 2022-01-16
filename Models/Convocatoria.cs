using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppNetCore.Models
{
    [Table("Convocatoria")]
    public class Convocatoria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ConvocatoriaID { get; set; }

        [Required]
        public TipoConvocatoria? TipoConvocatoria { get; set; }

        [Required]
        public int? Mes { get; set; }

        [Required]
        public int? Year { get; set; }

        public bool? Cerrada { get; set; }

        [ForeignKey("CursoAcademico")]
        public int CursoAcademicoID { get; set; }        
        public CursoAcademico? CursoAcademico { get; set; }

        public string? Nombre => $"{Year}/{Mes}";
    }

    public enum TipoConvocatoria { Ordinaria, Extraordinaria }
}
