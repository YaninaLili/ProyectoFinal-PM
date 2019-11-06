using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal_PM.Models
{
    public class Servicio
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Tipo { get; set; }

        [Required]
        public string Tiempo { get; set; }

        [Required]
        public float Precio { get; set; }

        public string Descripcion { get; set; }
    }
}