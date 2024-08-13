using Microsoft.EntityFrameworkCore;
using ProEventos.Models;

namespace ProEventos.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Evento> Eventos { get; set; }

        public DataContext(DbContextOptions<DataContext> option) : base(option){}
    }
}
