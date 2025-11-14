using Microsoft.EntityFrameworkCore;
using scafold1.Data;
using scafold1.Models;

namespace scafold1.Repository
{
    public class AeroportoRepository : IAeroportoRepository
    {
        public readonly Scafold1Context _scafoldContext;

        public AeroportoRepository(Scafold1Context scafoldContext)
        {
            _scafoldContext = scafoldContext;
        }

        public async Task<Aeroporto?> GetById(int id)
        {
            return await _scafoldContext.Aeroportos
                .FirstOrDefaultAsync(a => a.IdAeroporto == id);
        }
        public async Task<List<Aeroporto>> GetAll()
        {
            return await _scafoldContext.Aeroportos.ToListAsync();
        }
        public async Task Create(Aeroporto aeroporto)
        {
            _scafoldContext.Aeroportos.Add(aeroporto);
            await _scafoldContext.SaveChangesAsync();
        }
        public async Task Update(Aeroporto aeroporto)
        {
            _scafoldContext.Aeroportos.Update(aeroporto);
            await _scafoldContext.SaveChangesAsync();
        }
        public async Task Delete(Aeroporto aeroporto)
        {
            _scafoldContext.Aeroportos.Remove(aeroporto);
            await _scafoldContext.SaveChangesAsync();
        }
        public async Task<List<Aeroporto>> GetByNome(string nome)
        {
            return await _scafoldContext.Aeroportos
                .Where(a => a.Nome == nome)
                .ToListAsync();
        }
        public async Task<List<Aeroporto>> GetByCidade(string cidade)
        {
            return await _scafoldContext.Aeroportos
                .Where(a => a.Cidade == cidade)
                .ToListAsync();
        }
        public async Task<List<Aeroporto>> GetByEstado(string estado)
        {
            return await _scafoldContext.Aeroportos
                .Where(a => a.Estado == estado)
                .ToListAsync();
        }
        public async Task<List<Aeroporto>> GetByCidadeAndEstado(string cidade, string estado)
        {
            return await _scafoldContext.Aeroportos
                .Where(a => a.Cidade == cidade && a.Estado == estado)
                .ToListAsync();
        }

    }
}
