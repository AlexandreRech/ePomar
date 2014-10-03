using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uniplac.ePomar.Infraestrutura.Dao.Common;
using Uniplac.ePomar.Infraestrutura.Dao.Contexts;
using Uniplac.ePomar.Infraestrutura.Dao.Repositories;
using Uniplac.ePomar.Modelo.ClienteModule;
using Uniplac.ePomar.Modelo.FornecedorModule;
using Uniplac.ePomar.Modelo.ReceitaModule;

namespace Uniplac.ePomar.ConsoleApp
{
    class Program
    {   
        static void Main(string[] args)
        {
            //http://kazimnami.azurewebsites.net/techblog/2012/11/24/error-a-file-activation-error-occurred-create-database-failed/
            AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Directory.GetCurrentDirectory());

            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<PomarContext>());
            
            var dbFactory = new DatabaseFactory();
            
            var uow = new UnitOfWork(dbFactory);
            PomarContext pom = new PomarContext();

            var clienterepo = new ClienteRepository(dbFactory);

            var cliente = new Cliente();
            cliente.Nome = "TesteFK";
            cliente.Nota = "haha";
            cliente.Contato = "lhds";



            var receitaRepository = new ReceitaRepository(dbFactory);

            var receita = new Receita();
            receita.Categoria = "teste";
            receita.DataRecebimento = DateTime.Now;
            receita.Descricao = "teste";
            receita.TipoPagamento = "teset";
            receita.Valor = 10;
            //receita.NomeCliente = pom.Clientes.ToList().FirstOrDefault().Nome;

            receitaRepository.Add(receita);

            var repository = new FornecedorRepository(dbFactory);

            var fornecedor = new Fornecedor {Nome = "Filipe Andrade"};

            repository.Add(fornecedor);

            uow.SaveChanges();




        }
    }
}