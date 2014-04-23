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

    /*
    public class ResourceManagerDbInitializer : DropCreateDatabaseIfModelChanges<PomarContext>
    {
        protected override void Seed(PomarContext context)
        {
            //context.Users.Add(new User {  Email = "rech@ndd.com", Password = "123" });
            //context.SaveChanges();           
        }
    }
    */
}