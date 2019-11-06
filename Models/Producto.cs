using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal_PM.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Marca { get; set; }

        [Required]
        public int Medida { get; set; }

        [Required]
        public float Precio { get; set; }

        public string Descripcion { get; set; }
    }
}