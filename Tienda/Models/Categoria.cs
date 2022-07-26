using System.ComponentModel.DataAnnotations;

namespace Tienda.Models
{
    public class Categoria
    {
        [Key]
        public long IdCategoria { get; set; }
        [Required(ErrorMessage ="Nombre Categoria es obligatorio")]
        public string? NombreCategoria { get; set; }
        
        
        [Required(ErrorMessage = "Numero de Orden es obligatorio")]
        [Range(1, int.MaxValue, ErrorMessage ="Numero de Orden debe ser mayor a 0")]
        public int NumeroOrden { get; set; }
    }
}
