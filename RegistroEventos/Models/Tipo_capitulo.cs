using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RegistroEventos.Models
{
    public class Tipo_capitulo
    {

        [Key]
        public int id_tipo_capitulo { get; set; }

        [StringLength(80, ErrorMessage = "No debe de tener mas de 80 Carateres.")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Tipo de capítulo")]
        public string nombre_tipo_capitulo { get; set; }

        public IEnumerable<Capitulo> Capitulos { get; set; }
    }
}
