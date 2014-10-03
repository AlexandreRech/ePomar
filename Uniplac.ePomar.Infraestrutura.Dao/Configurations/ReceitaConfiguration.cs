using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uniplac.ePomar.Modelo.ClienteModule;
using Uniplac.ePomar.Modelo.ReceitaModule;

namespace Uniplac.ePomar.Infraestrutura.Dao.Configurations
{
    internal class ReceitaConfiguration : EntityTypeConfiguration<Receita>
    {
        public ReceitaConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Valor);

            Property(x => x.Descricao);

            Property(x => x.DataRecebimento);

            Property(x => x.TipoPagamento);

            Property(x => x.Categoria);

            Property(x => x.ObservacoesCliente);



            HasRequired<Cliente>(x => x.Cliente);


        }
    }
}
