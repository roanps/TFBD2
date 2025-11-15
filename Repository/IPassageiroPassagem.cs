using scafold1.Models;

namespace scafold1.Repository
{
    public interface IPassageiroPassagem
    {
        public Task Create(PassageiroPassagem passageiroPassagem);
        public Task Delete(PassageiroPassagem passageiroPassagem);
        public Task Update(PassageiroPassagem passageiroPassagem);
        public Task<PassageiroPassagem?> Get(int idPassageiro, int idPassagem);

        public Task<List<PassageiroPassagem>> GetAll();
        public Task<List<PassageiroPassagem>> GetByPassageiroId(int idPassageiro);
        public Task<List<PassageiroPassagem>> GetByPassagemId(int idPassagem);
        public Task<List<PassageiroPassagem>> GetByVoo(int idVoo);
        public Task<List<PassageiroPassagem>> GetByEmpresaAerea(int idEmpresaAerea);
        public Task<List<PassageiroPassagem>> GetByAeroportoOrigem(int idAeroportoOrigem);
        public Task<List<PassageiroPassagem>> GetByAeroportoDestino(int idAeroportoDestino);
        public Task<List<PassageiroPassagem>> GetByEscala(int idEscala);
    }
}
