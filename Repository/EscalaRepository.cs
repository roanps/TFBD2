using Microsoft.EntityFrameworkCore;
using scafold1.Data;
using scafold1.Models;

namespace scafold1.Repository
{
    public class EscalaRepository : IEscalaRepository
    {
        private readonly Scafold1Context _scafoldContext;
        public EscalaRepository(Scafold1Context scafoldContext)
        {
            _scafoldContext = scafoldContext;
        }
        public async Task Create(Escala escala)
        {
            _scafoldContext.Escalas.Add(escala);
            await _scafoldContext.SaveChangesAsync();
        }
        public async Task Delete(Escala escala)
        {
            _scafoldContext.Escalas.Remove(escala);
            await _scafoldContext.SaveChangesAsync();
        }
        public async Task Update(Escala escala)
        {
            _scafoldContext.Escalas.Update(escala);
            await _scafoldContext.SaveChangesAsync();
        }
        public async Task<Escala?> GetById(int id)
        {
            return await _scafoldContext.Escalas
                .FirstOrDefaultAsync(e => e.IdEscala == id);
        }
        public async Task<List<Escala>> GetAll()
        {
            return await _scafoldContext.Escalas.ToListAsync();
        }
    }
}
