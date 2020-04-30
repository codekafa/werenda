using Entities.ConCreate;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.ConCreate.EFCore.Contexts
{
    public class WerendaContext : DbContext
    {
        private const string ConnectionString = @"server=.;database=test;trusted_connection=true;";
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
    }
}
