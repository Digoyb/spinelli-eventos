using Microsoft.EntityFrameworkCore;
using SpinelliEventos.Domain;


namespace SpinelliEventos.Repository.data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base (options)
        {
            
        }

        public DbSet<Evento> Eventos { get; set; }
        
    }
}