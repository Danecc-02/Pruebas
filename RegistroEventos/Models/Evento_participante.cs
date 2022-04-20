using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroEventos.Models
{
    public class Evento_participante
    {
        [Key]
        public int id_evento_participante { get; set; }

        [Display(Name = "Evento")]
        public int id_evento { get; set; }

        [ForeignKey("id_evento")]
        public Evento Evento { get; set; }

        [Display(Name = "Participante")]
        public int id_participante { get; set; }

        [ForeignKey("id_participante")]
        public Participante Participantes { get; set; }

        [Display(Name = "Estadía")]
        public int id_estadia { get; set; }

        [ForeignKey("id_estadia")]
        public Estadia Estadia { get; set; }

        [Display(Name = "Comprobante")]
        public int id_comprobante { get; set; }

        [ForeignKey("id_comprobante")]
        public Comprobante Comprobante { get; set; }

    }
}
