using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uniplac.ePomar.Modelo.ProdutoModule;

namespace Uniplac.ePomar.Infraestrutura.Dao.Configurations
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
         public ProdutoConfiguration()
        {
            HasKey(x => x.Id);
            
            Property(x => x.Valor);
            
            Property(x => x.Descricao);
           
            Property(x => x.Nome);
            
            Property(x => x.Quantidade);
            
            Property(x => x.Validade);


        }
    }
}
