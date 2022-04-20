using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RegistroEventos.Models
{
    public class Estadia
    {

        [Key]
        public int id_estadia { get; set; }

        [Display(Name = "Estadia")]
        public string reservación_estadia { get; set; }

        public IEnumerable<Evento_participante> Evento_Participantes { get; set; }
    }
}
