using Microsoft.EntityFrameworkCore;
using scafold1.Data;
using scafold1.Models;

namespace scafold1.Repository
{
    public class PassageiroRepository : IPassageiroRepository
    {
        private readonly Scafold1Context _scafoldContext;
        public PassageiroRepository(Scafold1Context scafoldContext)
        {
            _scafoldContext = scafoldContext;
        }
        public async Task Create(Passageiro passageiro)
        {
            _scafoldContext.Passageiros.Add(passageiro);
            await _scafoldContext.SaveChangesAsync();
        }
        public async Task Delete(Passageiro passageiro)
        {
            _scafoldContext.Passageiros.Remove(passageiro);
            await _scafoldContext.SaveChangesAsync();
        }
        public async Task Update(Passageiro passageiro)
        {
            _scafoldContext.Passageiros.Update(passageiro);
            await _scafoldContext.SaveChangesAsync();
        }
        public async Task<Passageiro?> GetById(int id)
        {
            return await _scafoldContext.Passageiros
                .FirstOrDefaultAsync(p => p.IdPassageiro == id);
        }
        public async Task<List<Passageiro>> GetAll()
        {
            return await _scafoldContext.Passageiros.ToListAsync();
        }
    }
}
