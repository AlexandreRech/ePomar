using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uniplac.ePomar.Infraestrutura.Dao.Common;
using Uniplac.ePomar.Modelo.ReceitaModule;

namespace Uniplac.ePomar.Infraestrutura.Dao.Repositories
{
    public class ReceitaRepository : RepositoryBase<Receita>, IReceitaRepository
    {
        public ReceitaRepository(IDatabaseFactory dbFactory)
            : base(dbFactory)
        {

        }
    }
}