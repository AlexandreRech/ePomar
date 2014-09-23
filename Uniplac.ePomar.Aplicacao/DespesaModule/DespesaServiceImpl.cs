using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uniplac.ePomar.Infraestrutura.Dao.Common;
using Uniplac.ePomar.Infraestrutura.Dao.Repositories;
using Uniplac.ePomar.Modelo.DespesaModule;
using Uniplac.ePomar.Modelo.FornecedorModule;

namespace Uniplac.ePomar.Aplicacao.DespesaModule
{
    public class DespesaService : IDespesaService
    {
        private DatabaseFactory dbFactory;
        private UnitOfWork uow;
        private DespesaRepository repository;
        private FornecedorRepository repositoryFornecedor;

        public DespesaService()
        {
            dbFactory = new DatabaseFactory();

            uow = new UnitOfWork(dbFactory);

            repository = new DespesaRepository(dbFactory);
            repositoryFornecedor = new FornecedorRepository(dbFactory);
        }

        public Despesa Add(Despesa despesa)
        {
            repository.Add(despesa);

            uow.SaveChanges();

            return despesa;
        }

        public void Update(Despesa despesa)
        {
            repository.Update(despesa);

            uow.SaveChanges();
        }

        public void Delete(Despesa despesa)
        {
            repository.Delete(despesa);

            uow.SaveChanges();
        }

        public Despesa GetById(long id)
        {
            return repository.GetById(id);
        }

        public IEnumerable<Despesa> GetAll()
        {
            return repository.GetAll();
        }


        public List<Fornecedor> GetAllFornecedor()
        {
            return repositoryFornecedor.GetAllList();
        }
    }
}
