using Microsoft.EntityFrameworkCore;
using StockLink.Domain._6.Entities;
using System.Reflection;

namespace StockLink.Infrastructure._6.Persistences.Contexts
{
    public partial class USUARIOSContext : DbContext
    {
        public USUARIOSContext()
        {
        }

        public USUARIOSContext(DbContextOptions<USUARIOSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbRol> TbRols { get; set; } = null!;
        public virtual DbSet<TbUsuario> TbUsuarios { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational.Collaction", "Modern_Spanish_CI_AS");

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
