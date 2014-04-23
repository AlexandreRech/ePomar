using System;
using Uniplac.ePomar.Infraestrutura.Dao.Contexts;

namespace Uniplac.ePomar.Infraestrutura.Dao.Common
{
    public interface IDatabaseFactory : IDisposable
    {
        PomarContext Get();
    }
}
