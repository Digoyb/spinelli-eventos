using Microsoft.EntityFrameworkCore;
using SpinelliEventos.webAPI.model;

namespace SpinelliEventos.webAPI.Controllers.data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base (options)
        {
            
        }

        public DbSet<Evento> Eventos { get; set; }
        
    }
}