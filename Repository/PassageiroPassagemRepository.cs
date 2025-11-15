using scafold1.Data;
using scafold1.Models;
using scafold1.Repository;
using Microsoft.EntityFrameworkCore;

namespace scafold1.Repository
{
    public class PassageiroPassagemRepository : IPassageiroPassagemRepository
    {
        private readonly Scafold1Context _scafold1Context;
        public PassageiroPassagemRepository(Scafold1Context scafold1Context)
        {
            _scafold1Context = scafold1Context;
        }

        public async Task Create(PassageiroPassagem passageiroPassagem)
        {
            _scafold1Context.Add(passageiroPassagem);
            await _scafold1Context.SaveChangesAsync();
        }

        public async Task Delete(PassageiroPassagem passageiroPassagem)
        {
            _scafold1Context.Remove(passageiroPassagem);
            await _scafold1Context.SaveChangesAsync();
        }

        public async Task<PassageiroPassagem?> Get(int idPassageiro, int idPassagem)
        {
            var data = await _scafold1Context.PassageiroPassagens
                .Include(pp => pp.passageiro)
                .Include(pp => pp.passagem).ToListAsync();

            return data;
        }


    }


}
