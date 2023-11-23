using StockLink.Infrastructure._6.Persistences.Contexts;
using StockLink.Infrastructure._6.Persistences.Interfaces;

namespace StockLink.Infrastructure._6.Persistences.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly USUARIOSContext _context;

        public IUsuarioRepository Usuario { get; private set; }
        public IRolRepository Rol {  get; private set; }

        public UnitOfWork(USUARIOSContext context)
        {
            _context = context;
            Usuario = new UsuarioRepository(_context);
            Rol = new RolRepository(_context); ;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
