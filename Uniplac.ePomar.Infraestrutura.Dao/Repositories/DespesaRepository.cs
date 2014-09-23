using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uniplac.ePomar.Infraestrutura.Dao.Common;
using Uniplac.ePomar.Modelo.DespesaModule;

namespace Uniplac.ePomar.Infraestrutura.Dao.Repositories
{
    public class DespesaRepository : RepositoryBase<Despesa>, IDespesaRepository
    {
        public DespesaRepository(IDatabaseFactory dbFactory)
            : base(dbFactory)
        {

        }
    }
}
