using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uniplac.ePomar.Modelo.FornecedorModule;

namespace Uniplac.ePomar.Aplicacao.FornecedorModule
{
    public interface IFornecedorService
    {
        Fornecedor Add(Fornecedor entity);

        void Update(Fornecedor entity);

        void Delete(Fornecedor entity);

        Fornecedor GetById(long id);

        IEnumerable<Fornecedor> GetAll();        
    }
}
