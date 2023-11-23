using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockLink.Domain._6.Entities;

namespace StockLink.Infrastructure._6.Persistences.Contexts.Configurations
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<TbUsuario>
    {
        public void Configure(EntityTypeBuilder<TbUsuario> builder) 
        {
            builder.ToTable("TB_USUARIO");

            builder.Property(e => e.Pass).IsUnicode(false);

            builder.Property(e => e.Username)
                .HasMaxLength(255)
                .IsUnicode(false);

            builder.HasOne(d => d.RolNavigation)
                .WithMany(p => p.TbUsuarios)
                .HasForeignKey(d => d.Rol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ROL_USUARIO");
        }
    }
}
