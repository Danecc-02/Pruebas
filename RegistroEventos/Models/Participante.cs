using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroEventos.Models
{
    public class Participante
    {
        [Key]
        public int id_participante { get; set; }
        [StringLength(50, ErrorMessage = "No debe de tener mas de 50 Carateres.")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Nombre")]
        public string nombre_participante { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Apellido")]
        [StringLength(50, ErrorMessage = "No debe de tener mas de 50 Carateres.")]
        public string apellido_participante { get; set; }

        [StringLength(30, ErrorMessage = "No debe de tener mas de 30 Carateres.")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "D.N.I")]
        public string dni_participante { get; set; }

        [Display(Name = "Capítulo")]
        public int id_capitulo { get; set; }

        [ForeignKey("id_capitulo")]
        public Capitulo Capitulo { get; set; }


        [StringLength(30, ErrorMessage = "No debe de tener mas de 30 Carateres.")]
        [Display(Name = "Teléfono")]
        public string telefono { get; set; }

        public IEnumerable<Evento_participante> Evento_Participantes { get; set; }

    }
}
