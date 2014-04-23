using System.Data.Entity;
using Uniplac.ePomar.Infraestrutura.Dao.Configurations;
using Uniplac.ePomar.Modelo.FornecedorModule;

namespace Uniplac.ePomar.Infraestrutura.Dao.Contexts
{
    public class PomarContext : DbContext
    {
        public PomarContext()
            : base("ePomarConnectionString")
        {

        }

        public DbSet<Fornecedor> Fornecedores { get; set; }
       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new FornecedorConfiguration());
        }
    }

 
}