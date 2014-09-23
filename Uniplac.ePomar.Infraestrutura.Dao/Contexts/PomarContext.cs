using System.Data.Entity;
using Uniplac.ePomar.Infraestrutura.Dao.Configurations;
using Uniplac.ePomar.Modelo.ClienteModule;
using Uniplac.ePomar.Modelo.DespesaModule;
using Uniplac.ePomar.Modelo.FornecedorModule;
using Uniplac.ePomar.Modelo.ProdutoModule;
using Uniplac.ePomar.Modelo.ReceitaModule;

namespace Uniplac.ePomar.Infraestrutura.Dao.Contexts
{
    public class PomarContext : DbContext
    {
        public PomarContext()
            : base("ePomarConnectionString")
        {

        }

        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Receita> Receitas { get; set; }
        public DbSet<Despesa> Despesas { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new FornecedorConfiguration());

            modelBuilder.Configurations.Add(new ReceitaConfiguration());

            modelBuilder.Configurations.Add(new DespesaConfiguration());

            modelBuilder.Configurations.Add(new ProdutoConfiguration());

            modelBuilder.Configurations.Add(new ClienteConfiguration());
        }
    }

 
}