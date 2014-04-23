
using Uniplac.ePomar.Infraestrutura.Dao.Contexts;

namespace Uniplac.ePomar.Infraestrutura.Dao.Common
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private PomarContext dataContext;
        public PomarContext Get()
        {
            return dataContext ?? (dataContext = new PomarContext());
        }
        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }
}
