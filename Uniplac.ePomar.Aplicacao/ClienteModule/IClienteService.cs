using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uniplac.ePomar.Modelo.ClienteModule;

namespace Uniplac.ePomar.Aplicacao.ClienteModule
{
    public interface IClienteService
    {
        Cliente Add(Cliente entity);

        void Update(Cliente entity);

        void Delete(Cliente entity);

        Cliente GetById(long id);

        IEnumerable<Cliente> GetAll();  


    }
}
