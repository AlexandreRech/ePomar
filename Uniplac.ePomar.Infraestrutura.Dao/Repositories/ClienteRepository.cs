using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uniplac.ePomar.Infraestrutura.Dao.Common;
using Uniplac.ePomar.Modelo.ClienteModule;

namespace Uniplac.ePomar.Infraestrutura.Dao.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        public ClienteRepository(IDatabaseFactory dbFactory)
            : base(dbFactory)
        {

        }
    }
}
