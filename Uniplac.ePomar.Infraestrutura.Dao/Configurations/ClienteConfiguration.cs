using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uniplac.ePomar.Modelo.ClienteModule;

namespace Uniplac.ePomar.Infraestrutura.Dao.Configurations
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Nome);

            Property(x => x.Contato);

            Property(x => x.Nota);

            
        }

    }
}
