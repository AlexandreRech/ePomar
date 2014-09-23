using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uniplac.ePomar.Infraestrutura.Dao.Common;
using Uniplac.ePomar.Infraestrutura.Dao.Repositories;
using Uniplac.ePomar.Modelo.ClienteModule;

namespace Uniplac.ePomar.Aplicacao.ClienteModule
{
    public class ClienteService : IClienteService
    {
        private DatabaseFactory dbFactory;
        private UnitOfWork uow;
        private ClienteRepository repository;

        public ClienteService()
        {
            dbFactory = new DatabaseFactory();

            uow = new UnitOfWork(dbFactory);

            repository = new ClienteRepository(dbFactory);
        }

        public Cliente Add(Cliente cliente)
        {
            repository.Add(cliente);

            uow.SaveChanges();

            return cliente;
        }

        public void Update(Cliente cliente)
        {
            repository.Update(cliente);

            uow.SaveChanges();
        }

        public void Delete(Cliente cliente)
        {
            repository.Delete(cliente);

            uow.SaveChanges();
        }

        public Cliente GetById(long id)
        {
             return repository.GetById(id);
        }

        public IEnumerable<Cliente> GetAll()
        {
            return repository.GetAll();
        }
    }
}
