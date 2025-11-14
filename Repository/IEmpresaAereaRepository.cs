using scafold1.Models;

namespace scafold1.Repository
{
    public interface IEmpresaAereaRepository
    {
            public Task Create(EmpresaAerea empresaAerea);
            public Task Update(EmpresaAerea empresaAerea);
            public Task Delete(EmpresaAerea empresaAerea);
    }
}
