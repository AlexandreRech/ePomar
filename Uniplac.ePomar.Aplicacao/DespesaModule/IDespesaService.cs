using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uniplac.ePomar.Modelo.DespesaModule;
using Uniplac.ePomar.Modelo.FornecedorModule;

namespace Uniplac.ePomar.Aplicacao.DespesaModule
{
    public interface IDespesaService
    {
        Despesa Add(Despesa entity);

        void Update(Despesa entity);

        void Delete(Despesa entity);

        Despesa GetById(long id);

        IEnumerable<Despesa> GetAll();
        
        List<Fornecedor> GetAllFornecedor(); 
    }
}
