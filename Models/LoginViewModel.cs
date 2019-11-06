using System.ComponentModel.DataAnnotations;
namespace ProyectoFinal_PM.Models
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name="Correo Electronico")]
        public string Correo{get;set;}

        [Required]
        [Display(Name="Contraseña")]
        [DataType(DataType.Password)]
        public string Password{get;set;}
    }
}