using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RegistroEventos.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegistroEventos.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {   

        }
        public DbSet<Tipo_capitulo> tipo_Capitulos { get; set; }
        public DbSet<Capitulo> capitulos { get; set; }
        public DbSet<Participante> participantes { get; set; }
        public DbSet<Evento> eventos { get; set; }
        public DbSet<Tipo_evento> tipo_Eventos { get; set; }
        public DbSet<Comprobante> comprobantes { get; set; }
        public DbSet<Estadia> estadias { get; set; }
        public DbSet<Tipo_pago> tipo_Pagos { get; set; }
        public DbSet<Evento_participante> evento_Participantes { get; set; }
         

    }
}
