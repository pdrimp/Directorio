using Directorio.Data;
using Microsoft.EntityFrameworkCore;

namespace Directorio.Repositorios
{
    public class RepositorioClasificaciones : IRepositorioClasificaciones
    {
        private readonly BDContexto _context;
        public RepositorioClasificaciones(BDContexto context)
        {
            _context = context;
        }
        public async Task<List<Clasificacion>> GetAll()
        {
            return await _context.Clasificaciones.ToListAsync();
        }
        public async Task<Clasificacion> Get(int id)
        {
            return await _context.Clasificaciones.FindAsync(id);
        }
        public async Task Add(Clasificacion clasificacion)
        {
            await _context.Clasificaciones.AddAsync(clasificacion);
            await _context.SaveChangesAsync();
        }
        public async Task Update(Clasificacion clasificacion)
        {
            _context.Clasificaciones.Update(clasificacion);
            await _context.SaveChangesAsync();
        }
        public async Task Delete(int id)
        {
            var clasificacion = await Get(id);
            if (clasificacion != null)
            {
                _context.Clasificaciones.Remove(clasificacion);
                await _context.SaveChangesAsync();
            }
        }
    }
}
