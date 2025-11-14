using Microsoft.EntityFrameworkCore;
using scafold1.Data;
using scafold1.Models;


namespace scafold1.Repository
{
    public class AeronaveRepository : IAeronaveRepository
    {
        private readonly Scafold1Context _scafoldContext;

        public AeronaveRepository(Scafold1Context scafoldContext)
        {
            _scafoldContext = scafoldContext;
        }

        public async Task Create(Aeronave aeronave)
        {
            _scafoldContext.Aeronaves.Add(aeronave);
            await _scafoldContext.SaveChangesAsync();
        }

        public async Task Delete(Aeronave aeronave)
        {
            _scafoldContext.Aeronaves.Remove(aeronave);
            await _scafoldContext.SaveChangesAsync();
        }

        public async Task Update(Aeronave aeronave)
        {
            _scafoldContext.Aeronaves.Update(aeronave);
            await _scafoldContext.SaveChangesAsync();
        }

        public async Task<Aeronave?> GetById(int id)
        {
            return await _scafoldContext.Aeronaves
                .FirstOrDefaultAsync(a => a.IdAeronave == id);
        }

        public async Task<List<Aeronave>> GetAll()
        {
            return await _scafoldContext.Aeronaves.ToListAsync();
        }

        public async Task<List<Aeronave>> GetByEmpresaAereaId(int empresaAereaId)
        {
            return await _scafoldContext.Aeronaves
                .Where(a => a.IdEmpresa == empresaAereaId)
                .ToListAsync();
        }

        public async Task<List<Aeronave>> GetByModeloAeronave(string modelo)
        {
            return await _scafoldContext.Aeronaves
                .Where(a => a.ModeloAeronave == modelo)
                .ToListAsync();
        }

        public async Task<List<Aeronave>> GetByDataFabricacao(DateOnly dataFabricacao)
        {
            return await _scafoldContext.Aeronaves
                .Where(a => a.DataFabricacao == dataFabricacao)
                .ToListAsync();
        }

        public async Task<List<Aeronave>> GetByNumeroPoltronas(int numeroPoltronas)
        {
            return await _scafoldContext.Aeronaves
                .Where(a => a.NumeroPoltronas == numeroPoltronas)
                .ToListAsync();
        }

        public async Task<List<Aeronave>> GetByNumeroMaximoTripulantes(int numeroMaximoTripulantes)
        {
            return await _scafoldContext.Aeronaves
                .Where(a => a.NumeroMaximoTripulantes == numeroMaximoTripulantes)
                .ToListAsync();
        }

        public async Task<List<Aeronave>> GetByCapacidadeMaximaCombustivel(int capacidadeMaximaCombustivel)
        {
            return await _scafoldContext.Aeronaves
                .Where(a => a.CapacidadeMaximaCombustivel == capacidadeMaximaCombustivel)
                .ToListAsync();
        }

        public async Task<List<Aeronave>> GetByCapacidadeMaximaVoo(int capacidadeMaximaVoo)
        {
            return await _scafoldContext.Aeronaves
                .Where(a => a.CapacidadeMaximaVoo == capacidadeMaximaVoo)
                .ToListAsync();
        }

        public void Dispose()
        {
            _scafoldContext.Dispose();
        }


    }
}
