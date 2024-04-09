using System.ComponentModel.DataAnnotations;

namespace EstudiantesApp.Models
{
    public class Estudiante
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo nombre es requerido")]
        [StringLength(80, MinimumLength = 2, ErrorMessage = "El campo nombre debe tener un minimo de 2 y un maximo de 80 caracteres")]
        [RegularExpression(@"^[a-zA-ZáéíóúÁÉÍÓÚüÜñÑ\s]+$", ErrorMessage = "El nombre del estudiante debe contener solo letras y acentuaciones")]
        public string NombreCompleto { get; set; }

        [Required(ErrorMessage = "El campo Parcial 1 es requerido")]
        [Range(1, 5, ErrorMessage = "El valor de Parcial 1 debe estar entre 1 y 5")]
        public float Parcial1 { get; set; }

        [Required(ErrorMessage = "El campo Parcial 2 es requerido")]
        [Range(1, 5, ErrorMessage = "El valor de Parcial 2 debe estar entre 1 y 5")]
        public float Parcial2 { get; set; }

        [Required(ErrorMessage = "El campo Parcial 3 es requerido")]
        [Range(1, 5, ErrorMessage = "El valor de Parcial 3 debe estar entre 1 y 5")]
        public float Parcial3 { get; set; }
        public float Final { get; set; }

    }
}
