using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uniplac.ePomar.Infraestrutura.Dao.Common;
using Uniplac.ePomar.Modelo.ProdutoModule;

namespace Uniplac.ePomar.Infraestrutura.Dao.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public ProdutoRepository(IDatabaseFactory dbFactory)
            : base(dbFactory)
        {

        }
    }
}
