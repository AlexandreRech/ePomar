using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uniplac.ePomar.Infraestrutura.Dao.Common;
using Uniplac.ePomar.Infraestrutura.Dao.Repositories;
using Uniplac.ePomar.Modelo.FornecedorModule;

namespace Uniplac.ePomar.Aplicacao.FornecedorModule
{
    public class FornecedorService : IFornecedorService
    {
        private DatabaseFactory dbFactory;
        private UnitOfWork uow;
        private FornecedorRepository repository;

        public FornecedorService()
        {
            dbFactory = new DatabaseFactory();

            uow = new UnitOfWork(dbFactory);

            repository = new FornecedorRepository(dbFactory);
        }

        public Fornecedor Add(Fornecedor fornecedor)
        {                     
            repository.Add(fornecedor);

            uow.SaveChanges();

            return fornecedor;
        }

        public void Update(Fornecedor fornecedor)
        {
            repository.Update(fornecedor);

            uow.SaveChanges();
        }

        public void Delete(Fornecedor fornecedor)
        {
            repository.Delete(fornecedor);

            uow.SaveChanges();
        }

        public Fornecedor GetById(long id)
        {
            return repository.GetById(id);
        }

        public IEnumerable<Fornecedor> GetAll()
        {
            return repository.GetAll();
        }
    }
}