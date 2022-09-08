using Microsoft.EntityFrameworkCore;
using CuidadoBovino.App.Dominio;

namespace CuidadoBovino.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<DuenoBovino> DuenoBovinos { get; set; }
        public DbSet<Bovino> Bovinos { get; set; }
        public DbSet<Veterinario> Veterinarios {get;set;}
        public DbSet<HistoriaMedica> HistoriasMedicas {get;set;}
        public DbSet<RecomendaMedica> RecomendaMedicas {get;set;}


        protected  override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data source = (localdb)\\MSSQLLocalDB; Initial Catalog = CuidadoBovinoData");
            }
        }
    }
}