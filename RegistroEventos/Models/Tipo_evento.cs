using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RegistroEventos.Models
{
    public class Tipo_evento
    {

        [Key]
        public int id_tipo_evento { get; set; }

        [Display(Name = "Tipo evento")]
        public string nombre_tipo_evento { get; set; }

        public IEnumerable<Evento> Eventos { get; set; }
    }
}
