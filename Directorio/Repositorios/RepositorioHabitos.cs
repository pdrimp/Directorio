using Directorio.Data;
using Microsoft.EntityFrameworkCore;

namespace Directorio.Repositorios
{
    public class RepositorioHabitos : IRepositorioHabitos
    {
        private readonly BDContexto _context;
        public RepositorioHabitos(BDContexto context)
        {
            _context = context;
        }
        public async Task<List<Habito>> GetAll()
        {
            return await _context.Habitos.ToListAsync();
        }
        public async Task<Habito> Get(int id)
        {
            return await _context.Habitos.FindAsync(id);
        }
        public async Task Add(Habito habito)
        {
            await _context.Habitos.AddAsync(habito);
            await _context.SaveChangesAsync();
        }
        public async Task Update(Habito habito)
        {
            _context.Habitos.Update(habito);
            await _context.SaveChangesAsync();
        }
        public async Task Delete(int id)
        {
            var clasificacion = await Get(id);
            if (clasificacion != null)
            {
                _context.Habitos.Remove(clasificacion);
                await _context.SaveChangesAsync();
            }
        }
    }
}
