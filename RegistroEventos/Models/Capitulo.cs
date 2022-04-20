using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroEventos.Models
{
    public class Capitulo
    {
        [Key]
        public int id_capitulo { get; set; }

        [StringLength(60, ErrorMessage = "No debe de tener mas de 60 Carateres.")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Nombre")]
        public string nombre_capitulo { get; set; }

        [StringLength(80, ErrorMessage = "No debe de tener mas de 80 Carateres.")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Lugar")]
        public string lugar_capitulo { get; set; }


        [Display(Name = "Tipo Capítulo")]
        public int id_tipo_capitulo { get; set; }

        [ForeignKey("id_tipo_capitulo")]
        public Tipo_capitulo Tipo_capitulo { get; set; }

        public IEnumerable<Participante> Participantes { get; set; }
    }
}
