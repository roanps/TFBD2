using Microsoft.EntityFrameworkCore;
using scafold1.Data;
using scafold1.Models;

namespace scafold1.Repository
{
    public class EmpresaAereaRepository : IEmpresaAereaRepository
    {
        private readonly Scafold1Context _scafoldContext;
        public EmpresaAereaRepository(Scafold1Context scafoldContext)
        {
            _scafoldContext = scafoldContext;
        }

        public async Task Create(EmpresaAerea empresaAerea)
        {
            _scafoldContext.EmpresaAereas.Add(empresaAerea);
            await _scafoldContext.SaveChangesAsync();
        }
        public async Task Delete(EmpresaAerea empresaAerea)
        {
            _scafoldContext.EmpresaAereas.Remove(empresaAerea);
            await _scafoldContext.SaveChangesAsync();
        }
        public async Task Update(EmpresaAerea empresaAerea)
        {
            _scafoldContext.EmpresaAereas.Update(empresaAerea);
            await _scafoldContext.SaveChangesAsync();
        }
        public async Task<EmpresaAerea?> GetById(int id)
        {
            return await _scafoldContext.EmpresaAereas
                .FirstOrDefaultAsync(e => e.IdEmpresa == id);
        }
        public async Task<List<EmpresaAerea>> GetAll()
        {
            return await _scafoldContext.EmpresaAereas.ToListAsync();
        }
        public async Task<List<EmpresaAerea>> GetByNome(string nome)
        {
            return await _scafoldContext.EmpresaAereas
                .Where(e => e.Nome == nome)
                .ToListAsync();
        }
        public async Task<List<EmpresaAerea>> GetByCnpj(string cnpj)
        {
            return await _scafoldContext.EmpresaAereas
                .Where(e => e.Cnpj == cnpj)
                .ToListAsync();
        }
    }
}
