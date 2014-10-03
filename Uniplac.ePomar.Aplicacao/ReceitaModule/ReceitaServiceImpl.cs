using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uniplac.ePomar.Infraestrutura.Dao.Common;
using Uniplac.ePomar.Infraestrutura.Dao.Repositories;
using Uniplac.ePomar.Modelo.ClienteModule;
using Uniplac.ePomar.Modelo.ReceitaModule;

namespace Uniplac.ePomar.Aplicacao.ReceitaModule
{
    public class ReceitaService : IReceitaService
    {
        private DatabaseFactory dbFactory;
        private UnitOfWork uow;
        private ReceitaRepository repository;
        private ClienteRepository repositoryCliente;

        public ReceitaService()
        {
            dbFactory = new DatabaseFactory();

            uow = new UnitOfWork(dbFactory);

            repositoryCliente = new ClienteRepository(dbFactory);
            repository = new ReceitaRepository(dbFactory);
        }



        public Receita Add(Receita receita)
        {
            repository.Add(receita);

            uow.SaveChanges();

            return receita;
        }

        public void Update(Receita receita)
        {
            repository.Update(receita);

            uow.SaveChanges();
        }

        public void Delete(Receita receita)
        {
            repository.Delete(receita);

            uow.SaveChanges();
        }

        public Receita GetById(long id)
        {
            return repository.GetById(id);
        }

        public IEnumerable<Receita> GetAll()
        {
            var receitas = repository.GetAllIncluding(x => x.Cliente).ToList();

            return receitas;
        }
                
        public List<Cliente> GetAllClientes()
        {
            return repositoryCliente.GetAllList();
        }

        public List<Receita> GetAllReceitas()
        {
            return repository.GetAllList();
        }
    }
}
