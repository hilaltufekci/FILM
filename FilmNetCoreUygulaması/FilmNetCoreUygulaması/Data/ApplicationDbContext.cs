using FilmNetCoreUygulaması.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmNetCoreUygulaması.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {
            
        }
        public virtual DbSet<Film> Films { get; set; }
        public virtual DbSet<Oyuncu> Oyuncus { get; set; }
        public virtual DbSet<Seyirci> Seyircis { get; set; }
        public virtual DbSet<Yönetmen> Yönetmens { get; set; }
    }
}
