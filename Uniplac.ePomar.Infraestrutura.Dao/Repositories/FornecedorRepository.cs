using Uniplac.ePomar.Infraestrutura.Dao.Common;
using Uniplac.ePomar.Modelo.FornecedorModule;

namespace Uniplac.ePomar.Infraestrutura.Dao.Repositories
{
    public class FornecedorRepository : RepositoryBase<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(IDatabaseFactory dbFactory)
            : base(dbFactory)
        {

        }
    }
}
