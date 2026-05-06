using System.ComponentModel.DataAnnotations;

namespace TPN_2_Prog_Movil.Models
{
    public class Usuario
    {
        [Required, Length(4, 50)]
        public string Nombre { get; set; } = null!;
        [Required, Length(4, 50)]
        public string Contraseña { get; set; } = null!;
    }
}
