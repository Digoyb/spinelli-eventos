using Microsoft.EntityFrameworkCore;
using SpinelliEventos.Domain;


namespace SpinelliEventos.Repository.data
{
    public class SpinelliEventosContext: DbContext
    {
        public SpinelliEventosContext(DbContextOptions<SpinelliEventosContext> options): base (options)
        {
            
        }

        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Palestrante> Palestrantes { get; set; }
        public DbSet<PalestranteEvento> PalestranteEventos { get; set; }
        public DbSet<Lote> Lotes { get; set; }
        public DbSet<RedeSocial> RedeSociais { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<PalestranteEvento>()
            .HasKey(PE => new { PE.EventoId, PE.PalestranteId});
        }
        
    }
}