using System.ComponentModel.DataAnnotations;

namespace Concesionario.Models
{
    public class Marca
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la marca es obligatorio")]
        [StringLength(100, ErrorMessage = "El nombre de la marca no puede tener más de 100 caracteres")]
        [Display(Name = "Nombre de la Marca")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "El país de origen es obligatorio")]
        [StringLength(50, ErrorMessage = "El país de origen no puede tener más de 50 caracteres")]
        [Display(Name = "País de Origen")]
        public string? PaisOrigen { get; set; }

        public ICollection<Vehiculo> Vehiculos { get; set; } = new List<Vehiculo>();
    }
}