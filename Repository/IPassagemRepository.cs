using scafold1.Models;

namespace scafold1.Repository
{
    public interface IPassagemRepository
    {
        public Task Create(Passagem passagem);
        public Task Update(Passagem passagem);
        public Task Delete(Passagem passagem);
    }
}
