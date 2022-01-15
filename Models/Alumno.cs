using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppNetCore.Models
{
    [Table("Alumnos")]
    public class Alumno
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AlumnoID { get; set; }

        [Required]
        [MaxLength(9)]
        public string? Dip { get; set; }

        [Required]
        [MaxLength(60)]
        public string? Nombre { get; set; }

        [Required]
        [MaxLength(60)]
        public string? Apellidos { get; set; }

        [Required]
        public TSexo? Sexo { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime? FechaNacimiento { get; set; }

        [Required]
        public string? Telefono { get; set; }

        [Required]
        public string? Email { get; set; }

        public int? Edad => DateTime.Now.Year - FechaNacimiento?.Year;

        public IList<Matricula>? Matriculas {get; set;}

    }

    public enum TSexo { Hombre, Mujer }
}
