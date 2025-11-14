using scafold1.Models;

namespace scafold1.Repository
{
    public interface IVooRepository
    {
        public Task Create(Voo voo);
        public Task Update(Voo voo);
        public Task Delete(Voo voo);
    }
}
