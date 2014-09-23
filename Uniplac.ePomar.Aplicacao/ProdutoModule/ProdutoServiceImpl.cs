using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uniplac.ePomar.Infraestrutura.Dao.Common;
using Uniplac.ePomar.Infraestrutura.Dao.Repositories;
using Uniplac.ePomar.Modelo.ProdutoModule;

namespace Uniplac.ePomar.Aplicacao.ProdutoModule
{
    public class ProdutoService : IProdutoService
    {
        private DatabaseFactory dbFactory;
        private UnitOfWork uow;
        private ProdutoRepository repository;

        public ProdutoService()
        {
            dbFactory = new DatabaseFactory();

            uow = new UnitOfWork(dbFactory);

            repository = new ProdutoRepository(dbFactory);
        }

        public Produto Add(Produto produto)
        {
            repository.Add(produto);

            uow.SaveChanges();

            return produto;
        }

        public void Update(Produto produto)
        {
            repository.Update(produto);

            uow.SaveChanges();
        }

        public void Delete(Produto produto)
        {
            repository.Delete(produto);

            uow.SaveChanges();
        }

        public Produto GetById(long id)
        {
            return repository.GetById(id);
        }

        public IEnumerable<Produto> GetAll()
        {
            return repository.GetAll();
        }
    }
}
