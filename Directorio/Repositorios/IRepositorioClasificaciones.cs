using Directorio.Data;

namespace Directorio.Repositorios
{
    public interface IRepositorioClasificaciones
    {
        Task<List<Clasificacion>> GetAll();
        Task<Clasificacion> Get(int id);
        Task Add(Clasificacion clasificacion);
        Task Update(Clasificacion clasificacion);
        Task Delete(int id);
    }
}
