using scafold1.Models;

namespace scafold1.Repository
{
    public interface IEscalaRepository
    {
        public Task Create(Escala escala);
        public Task Update(Escala escala);
        public Task Delete(Escala escala);
    }
}
