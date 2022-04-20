using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroEventos.Models
{
    public class Comprobante
    {
        [Key]
        public int id_comprobante { get; set; }

        [Display(Name = "Comprobante")]
        public string comprobante { get; set; }

        [ForeignKey("id_tipo_pago")]
        public Tipo_pago Tipo_pago { get; set; }

        [Display(Name = "Tipo de pago")]
        public int id_tipo_pago { get; set; }

       

    }
}
