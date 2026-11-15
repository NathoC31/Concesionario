using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Concesionario.Models
{
    public class Vehiculo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Modelo { get; set; } = string.Empty;

        [Display(Name = "Año")]
        public int Anio { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Precio { get; set; }
    }
}