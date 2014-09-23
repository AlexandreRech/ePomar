using System.Data.Entity.ModelConfiguration;

using Uniplac.ePomar.Modelo.FornecedorModule;

namespace Uniplac.ePomar.Infraestrutura.Dao.Configurations
{
    internal class FornecedorConfiguration : EntityTypeConfiguration<Fornecedor>
    {
        public FornecedorConfiguration()
        {            
            HasKey(x => x.Id);

            Property(x => x.Nome);

            Property(x => x.Contato);

            Property(x => x.Nota);
        }
    }
}
