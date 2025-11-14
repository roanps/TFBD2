using scafold1.Models;

namespace scafold1.Repository
{
    public interface IPassageiroRepository
    {
        public Task Create(Passageiro passageiro);
        public Task Update(Passageiro passageiro);
        public Task Delete(Passageiro passageiro);
    }
}
