using Classes;
using Microsoft.EntityFrameworkCore;
using System;

namespace AtendimentosSD
{
    public class Ticketcontext : DbContext

    {
        public Ticketcontext()
        {
        }

        public DbSet<Atendimento> Atendimentos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Integrated Security = true; Persist Security Info = False; Initial Catalog = DbAtendimentosServiceDesk; Data Source =ALBR-3WGPDQ2-L\LUCAS_DB_LOCAL");
            
        }

        
    }
}
