﻿using System.ComponentModel.DataAnnotations;

namespace Directorio.Data
{
    public class Clasificacion
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(50, ErrorMessage = "El nombre no puede exceder los 50 caracteres")]
        public string? Nombre { get; set; }
    }
}
