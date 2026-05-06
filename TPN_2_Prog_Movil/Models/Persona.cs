using System.ComponentModel.DataAnnotations;

namespace TPN_2_Prog_Movil.Models
{
    public class Persona
    {
        [Key]
        [Required]
        public int IdPersona { get; set; }
        [Required(ErrorMessage = "La persona debe tener un nombre")]
        [Length(4, 50)]
        public string Nombre { get; set; } = null!;
        [Required(ErrorMessage = "La persona debe tener un apellido")]
        [Length(4, 50)]
        public string Apellido { get; set; } = null!;
        [Required]
        [EmailAddress, Length(4,80)]
        public string Email { get; set; } = null!;
        [Required]
        [Length(6,100)]
        public string Domicilio { get; set; } = null!;
        [Required]
        public DateOnly FechaNacimiento { get; set; }
        public string RutaImagen { get; set; } = "Images/FalloutBoy.png";
    }
}