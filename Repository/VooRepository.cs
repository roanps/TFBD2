using Microsoft.EntityFrameworkCore;
using scafold1.Data;
using scafold1.Models;

namespace scafold1.Repository
{
    public class VooRepository : IVooRepository
    {
        private readonly Scafold1Context _scafoldContext;
        public VooRepository(Scafold1Context scafoldContext)
        {
            _scafoldContext = scafoldContext;
        }
        public async Task Create(Voo voo)
        {
            _scafoldContext.Voos.Add(voo);
            await _scafoldContext.SaveChangesAsync();
        }
        public async Task Delete(Voo voo)
        {
            _scafoldContext.Voos.Remove(voo);
            await _scafoldContext.SaveChangesAsync();
        }
        public async Task Update(Voo voo)
        {
            _scafoldContext.Voos.Update(voo);
            await _scafoldContext.SaveChangesAsync();
        }
        public async Task<Voo?> GetById(int id)
        {
            return await _scafoldContext.Voos
                .FirstOrDefaultAsync(v => v.IdVoo == id);
        }
        public async Task<List<Voo>> GetAll()
        {
            return await _scafoldContext.Voos.ToListAsync();
        }
        public async Task<List<Voo>> GetByDestino(int destino)
        {
            return await _scafoldContext.Voos
                .Where(v => v.IdAeroportoDestino == destino)
                .ToListAsync();
        }
        public async Task<List<Voo>> GetByOrigem(int origem)
        {
            return await _scafoldContext.Voos
                .Where(v => v.IdAeroportoOrigem == origem)
                .ToListAsync();
        }
        public async Task<List<Voo>> GetByData(DateTime data)
        {
            return await _scafoldContext.Voos
                .Where(v => v.Partida.Date == data.Date)
                .ToListAsync();
        }
        public async Task<List<Voo>> GetByAeronave(int idAeronave)
        {
            return await _scafoldContext.Voos
                .Where(v => v.IdAeronave == idAeronave)
                .ToListAsync();
        }
        public async Task<List<Voo>> GetByPartidaChegada(DateTime partida, DateTime chegada)
        {
            return await _scafoldContext.Voos
                .Where(v => v.Partida >= partida && v.Chegada <= chegada)
                .ToListAsync();
        }

    }
}
