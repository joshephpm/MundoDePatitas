using System.ComponentModel.DataAnnotations;
namespace Patitas.ViewModels
{
    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        public string ContrasenaActual { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string ContrasenaNueva { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("ContrasenaNueva", ErrorMessage = "Las contraseñas no coinciden")]
        public string ContrasenaConfirmacion { get; set; }
    }
}