using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Concesionario.Models
{
    public class Vehiculo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El modelo es obligatorio")]
        [StringLength(100,ErrorMessage = "El modelo no puede tener más de 100 caracteres")]
        [Display(Name="Modelo")]
        public string Modelo { get; set; } = string.Empty;

        [Required(ErrorMessage = "El año de fabricación es obligatorio")]
        [Range(1950,2026,ErrorMessage = "El año debe estar entre 1950 y 2026")]
        [Display(Name = "Año")]
        public int Anio { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Required(ErrorMessage = "El campo precio es obligatorio")]
        [Range(typeof(decimal), "1", "1000000", ErrorMessage = "El precio debe estar entre 1 y 1000000")]
        [Display(Name = "Precio")]
        public decimal Precio { get; set; }
    }
}