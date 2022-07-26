using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tienda.Models
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }
        [Required(ErrorMessage = "Nombre del Prodcuto es requerido")]
        public string NombreProducto { get; set; }
        [Required(ErrorMessage ="Descripcion es requirida")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Precio del Producto es requerido")]
        [Range(1, double.MaxValue, ErrorMessage ="El precio debe ser >0")]
        public string Precio { get; set; }

        public string ImgUrl { get; set; }

        //foreing Key relaciones

        public long IdCategoria { get; set; }
        [ForeignKey("IdCategoria")]
        public virtual Categoria Categoria { get; set; }

        public long IdTipoAplicacion { get; set; }
        [ForeignKey("IdTipoAplicacion")]
        public virtual TipoAplication TipoAplication { get; set; }

    }
}
