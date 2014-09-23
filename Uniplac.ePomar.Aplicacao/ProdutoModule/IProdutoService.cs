using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uniplac.ePomar.Modelo.ProdutoModule;

namespace Uniplac.ePomar.Aplicacao.ProdutoModule
{
   public interface IProdutoService
    {
        Produto Add(Produto entity);

        void Update(Produto entity);

        void Delete(Produto entity);

        Produto GetById(long id);

        IEnumerable<Produto> GetAll();        
    }
}
