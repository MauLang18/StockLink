using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StockLink.Domain._6.Entities;

namespace StockLink.Infrastructure._6.Persistences.Contexts.Configurations
{
    public class RolConfiguration : IEntityTypeConfiguration<TbRol>
    {
        public void Configure(EntityTypeBuilder<TbRol> builder)
        {
            builder.ToTable("TB_ROL");

            builder.Property(e => e.Privilegios).IsUnicode(false);

            builder.Property(e => e.Rol)
                .HasMaxLength(255)
                .IsUnicode(false);
        }
    }
}
