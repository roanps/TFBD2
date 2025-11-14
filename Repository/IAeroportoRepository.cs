using scafold1.Models;

namespace scafold1.Repository
{
    public interface IAeroportoRepository
    {

        public Task Create(Aeroporto aeroporto);
        public Task Update(Aeroporto aeroporto);
        public Task Delete(Aeroporto aeroporto);


    }
}