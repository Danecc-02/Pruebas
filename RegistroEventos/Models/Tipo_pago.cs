using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RegistroEventos.Models
{
    public class Tipo_pago
    {
        [Key]
        public int id_tipo_pago { get; set; }

        [Display(Name = "Tipo de pago")]
        public string tipo_pago { get; set; }

        public IEnumerable<Comprobante> Comprobantes { get; set; }
    }
}
