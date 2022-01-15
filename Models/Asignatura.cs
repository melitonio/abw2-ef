using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppNetCore.Models
{
    [Table("Asignaturas")]
    public class Asignatura
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AsignaturaID { get; set; }

        [MaxLength(6)]
        public string? Codigo { get; set; }

        [Required]
        [MaxLength(70)]
        public string? Nombre { get; set; }

        [Required]
        public int? Creditos { get; set; }

        [ForeignKey("Carrera")]
        public int CarreraID { get; set; }
        public Carrera? Carrera { get; set; }

        [Range(1, 4)]
        [Required]
        public int? Curso { get; set; }

        [Range(1, 2)]
        public int? Semestre { get; set; }

        [Required]
        public Carracter? Carracter { get; set; }
    }
    public enum Carracter { Basica, Obligatoria, Optativa }
}
