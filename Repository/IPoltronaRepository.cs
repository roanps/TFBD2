using scafold1.Models;

namespace scafold1.Repository
{
    public interface IPoltronaRepository
    {
        public Task Create(Poltrona poltrona);
        public Task Update(Poltrona poltrona);
        public Task Delete(Poltrona poltrona);
    }
}
