using System.ComponentModel.DataAnnotations;

namespace Web_prueba.Models
{

    public enum TipoEstado
    {
        Activo,
        Inactivo
    }
    public enum TipoUnidad
    {
        Botella,
        Metro,
        Litro,
        Caja
    }
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]                                                   
        [Display(Name = "Product Name")]

        public string Nombre { get; set; }

        public decimal Precio { get; set; }

        [Required]

        public int Cantidad { get; set; }

        [Required]

        public TipoUnidad Unidad { get; set; }

        [Required]

        public TipoEstado Estado { get; set; }
        }
    }