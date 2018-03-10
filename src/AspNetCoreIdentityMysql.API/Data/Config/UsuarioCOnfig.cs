using AspNetCoreIdentityMysql.API.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace AspNetCoreIdentityMysql.API.Data.Config
{
    public class UsuarioConfig : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {

            builder.ToTable("Usuarios");
            builder.HasKey(x => x.Id);
            builder.Property(X => X.Nome).HasMaxLength(255);
            builder.Property(x => x.Email).HasMaxLength(55);

        }
    }
}
