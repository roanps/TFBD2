using Microsoft.EntityFrameworkCore;
using scafold1.Data;
using scafold1.Models;

namespace scafold1.Repository
{
    public class PassagemRepository : IPassagemRepository
    {
        private readonly Scafold1Context _scafoldContext;
        public PassagemRepository(Scafold1Context scafoldContext)
        {
            _scafoldContext = scafoldContext;
        }
        public async Task Create(Passagem passagem)
        {
            _scafoldContext.Passagens.Add(passagem);
            await _scafoldContext.SaveChangesAsync();
        }
        public async Task Delete(Passagem passagem)
        {
            _scafoldContext.Passagens.Remove(passagem);
            await _scafoldContext.SaveChangesAsync();
        }
        public async Task Update(Passagem passagem)
        {
            _scafoldContext.Passagens.Update(passagem);
            await _scafoldContext.SaveChangesAsync();
        }
        public async Task<Passagem?> GetById(int id)
        {
            return await _scafoldContext.Passagens
                .FirstOrDefaultAsync(p => p.IdPassagem == id);
        }
        public async Task<List<Passagem>> GetAll()
        {
            return await _scafoldContext.Passagens.ToListAsync();
        }
    }
}
