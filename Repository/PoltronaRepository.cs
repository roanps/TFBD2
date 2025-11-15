using Microsoft.EntityFrameworkCore;
using scafold1.Data;
using scafold1.Models;

namespace scafold1.Repository
{
    public class PoltronaRepository : IPoltronaRepository
    {
        private readonly Scafold1Context _scafoldContext;
        public PoltronaRepository(Scafold1Context scafoldContext)
        {
            _scafoldContext = scafoldContext;
        }
        public async Task Create(Poltrona poltrona)
        {
            _scafoldContext.Poltronas.Add(poltrona);
            await _scafoldContext.SaveChangesAsync();
        }
        public async Task Delete(Poltrona poltrona)
        {
            _scafoldContext.Poltronas.Remove(poltrona);
            await _scafoldContext.SaveChangesAsync();
        }
        public async Task Update(Poltrona poltrona)
        {
            _scafoldContext.Poltronas.Update(poltrona);
            await _scafoldContext.SaveChangesAsync();
        }
        public async Task<Poltrona?> GetById(string id)
        {
            return await _scafoldContext.Poltronas
                .FirstOrDefaultAsync(p => p.NumeroPoltrona == id);
        }
        public async Task<List<Poltrona>> GetAll()
        {
            return await _scafoldContext.Poltronas.ToListAsync();
        }
    }
}
