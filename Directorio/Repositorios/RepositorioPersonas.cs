using Directorio.Data;
using Microsoft.EntityFrameworkCore;

namespace Directorio.Repositorios
{
    public class RepositorioPersonas : IRepositorioPersonas
    {
        private readonly BDContexto _context;
        public RepositorioPersonas(BDContexto context)
        {
            _context = context;
        }
        public async Task<List<Persona>> GetAll()
        {
            return await _context.Personas.Include(c => c.Clasificacion).Include(h => h.Habitos).AsNoTracking().ToListAsync();
        }
        public async Task<Persona> Get(int id)
        {
            return await _context.Personas.Include(h => h.Habitos).FirstAsync(r => r.Id == id);
        }
        public async Task Add(Persona persona)
        {
            await _context.Personas.AddAsync(persona);
            await _context.SaveChangesAsync();
        }
        public async Task Update(Persona persona)
        {
            _context.Personas.Update(persona);
            await _context.SaveChangesAsync();
        }
        public async Task Delete(int id)
        {
            var persona = await Get(id);
            if (persona != null)
            {
                _context.Personas.Remove(persona);
                await _context.SaveChangesAsync();
            }
        }
    }
}
