using System.ComponentModel.DataAnnotations;

namespace Tienda.Models
{
    public class TipoAplication
    {
        [Key]
        public long IdTipoAplicacion { get; set; }
        [Required(ErrorMessage ="Nombre de la aplicacion es Requerida")]
        public string? NombreAplicacion { get; set; }
    }
}
