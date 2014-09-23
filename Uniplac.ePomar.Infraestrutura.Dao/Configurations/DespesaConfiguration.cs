using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uniplac.ePomar.Modelo.DespesaModule;
using Uniplac.ePomar.Modelo.FornecedorModule;

namespace Uniplac.ePomar.Infraestrutura.Dao.Configurations
{
    public class DespesaConfiguration : EntityTypeConfiguration<Despesa>
    {
        public DespesaConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Valor);
            
            Property(x => x.Descricao);
            
            Property(x => x.DataPagamento);
            
            Property(x => x.TipoPagamento);
            
            Property(x => x.Categoria);

            Property(x => x.ObservaçõesFornecedor);

            HasRequired<Fornecedor>(x => x.Fornecedor);

        }
    }
    
}

