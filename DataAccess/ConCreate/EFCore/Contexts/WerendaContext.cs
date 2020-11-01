using Entities.ConCreate;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.ConCreate.EFCore.Contexts
{
    public class WerendaContext : DbContext
    {
        private const string ConnectionString = @"Server=.\SQLEXPRESS;Database=test;Trusted_Connection=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<users> users { get; set; }
        public DbSet<user_address> user_address { get; set; }
        public DbSet<products> products { get; set; }

        public DbSet<product_photos> product_photos { get; set; }

        public DbSet<product_facilities> product_facilities { get; set; }

        public DbSet<user_credits> user_credits { get; set; }

        public DbSet<cities> cities { get; set; }

        public DbSet<districts> districts { get; set; }

        public DbSet<have_rooms> have_rooms { get; set; }

        public DbSet<heating> heating { get; set; }

        public DbSet<towns> towns { get; set; }

        public DbSet<rooms> rooms { get; set; }

        public DbSet<lexicons> lexicons { get; set; }

        public DbSet<cultures> cultures { get; set; }

        public DbSet<countries> countries { get; set; }
    }
}
