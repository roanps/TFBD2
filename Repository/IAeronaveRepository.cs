using scafold1.Models;

namespace scafold1.Repository
{
    public interface IAeronaveRepository
    {
        public Task Create(Aeronave aeronave);
        public Task Update(Aeronave aeronave);
        public Task Delete(Aeronave aeronave);

        public Task<Aeronave?> GetById(int id);
        public Task<List<Aeronave>> GetAll();
        public Task<List<Aeronave>> GetByEmpresaAereaId(int empresaAereaId);
        public Task<List<Aeronave>> GetByModeloAeronave(string modelo);
        public Task<List<Aeronave>> GetByDataFabricacao(DateOnly dataFabricacao);
        public Task<List<Aeronave>> GetByNumeroPoltronas(int numeroPoltronas);
        public Task<List<Aeronave>> GetByNumeroMaximoTripulantes(int numeroMaximoTripulantes);
        public Task<List<Aeronave>> GetByCapacidadeMaximaCombustivel(int capacidadeMaximaCombustivel);
        public Task<List<Aeronave>> GetByCapacidadeMaximaVoo(int capacidadeMaximaVoo);
    }
}
