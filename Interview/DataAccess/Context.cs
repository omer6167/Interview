using Interview.Entity;
using Microsoft.EntityFrameworkCore;

namespace Interview.DataAccess
{
    public class Context :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=SAMPLE;Integrated Security=True;");
        }

        public DbSet<Musteri> Musteris { get; set; }

        public DbSet<SepetUrun> SepetUruns { get; set; }

        public DbSet<Sepet> Sepets { get; set; }

    }
}
