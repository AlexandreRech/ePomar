using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Uniplac.ePomar.Modelo.ClienteModule;
using Uniplac.ePomar.Modelo.ReceitaModule;

namespace Uniplac.ePomar.Aplicacao.ReceitaModule
{
    public interface IReceitaService
    {
        Receita Add(Receita entity);

        void Update(Receita entity);

        void Delete(Receita entity);

        Receita GetById(long id);

        IEnumerable<Receita> GetAll();

        List<Cliente> GetAllClientes(); 
    }
}
