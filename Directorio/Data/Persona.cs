using System.ComponentModel.DataAnnotations;

namespace Directorio.Data
{
    public class Persona
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "El nombre no puede exceder los 50 caracteres")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El teléfono es obligatorio")]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "El teléfono debe contener 10 dígitos")]
        public string? Telefono { get; set; }
        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "El correo no es válido")]
        [StringLength(100, ErrorMessage = "El correo no puede exceder los 100 caracteres")]
        public string? Correo { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "La clasificación es obligatoria")]
        public int ClasificacionId { get; set; }
        virtual public Clasificacion? Clasificacion { get; set; }

        public List<Habito>? Habitos { get; set; }
    }
}
