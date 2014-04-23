using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uniplac.ePomar.Infraestrutura.Dao.Contexts;

namespace Uniplac.ePomar.Infraestrutura.Dao.Common 
{
    public class UnitOfWork : IUnitOfWork
    {
        private PomarContext dbContext;
        private readonly IDatabaseFactory dbFactory;
        protected PomarContext DbContext
        {
            get
            {
                return dbContext ?? dbFactory.Get();
            }
        }

        public UnitOfWork(IDatabaseFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public void SaveChanges()
        {
            DbContext.SaveChanges();
        }
    }
}