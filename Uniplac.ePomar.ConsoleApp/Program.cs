using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Uniplac.ePomar.Infraestrutura.Dao.Common;
using Uniplac.ePomar.Infraestrutura.Dao.Repositories;
using Uniplac.ePomar.Modelo.FornecedorModule;

namespace Uniplac.ePomar.ConsoleApp
{
    class Program
    {   
        static void Main(string[] args)
        {
            //http://kazimnami.azurewebsites.net/techblog/2012/11/24/error-a-file-activation-error-occurred-create-database-failed/
            AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Directory.GetCurrentDirectory());

            var dbFactory = new DatabaseFactory();

            var uow = new UnitOfWork(dbFactory);

            var repository = new FornecedorRepository(dbFactory);

            var fornecedor = new Fornecedor {Nome = "Alexandre Rech"};

            repository.Add(fornecedor);

            uow.SaveChanges();
        }
    }
}