using AspNetCoreIdentityMysql.API.Data.Config;
using AspNetCoreIdentityMysql.API.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreIdentityMysql.API.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            //modelBuilder.Configurations.Add(new UsuarioConfig());
            builder.ApplyConfiguration(new UsuarioConfig());

            base.OnModelCreating(builder);
        }
    }
}
