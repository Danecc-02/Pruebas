using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroEventos.Models
{
    public class Evento
    {
        [Key]
        public int id_evento { get; set; }

        [StringLength(100, ErrorMessage = "No debe de tener mas de 100 Carateres.")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Nombre")]
        public string nombre_evento { get; set; }

        [StringLength(100, ErrorMessage = "No debe de tener mas de 100 Carateres.")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Lugar")]
        public string lugar_evento { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha")]
        public DateTime fecha_evento { get; set; }

        [StringLength(500, ErrorMessage = "No debe de tener mas de 500 Carateres.")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Display(Name = "Observaciones")]
        public string observaciones { get; set; }

        [Display(Name = "Tipo Evento")]
        public int id_tipo_evento { get; set; }

        [ForeignKey("id_tipo_evento")]
        public Tipo_evento Tipo_Evento { get; set; }

        public IEnumerable<Evento_participante> Evento_Participantes { get; set; }

    }
}
