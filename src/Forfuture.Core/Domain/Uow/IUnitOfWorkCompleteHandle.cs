using System;
using System.Threading.Tasks;

namespace Forfuture.Core.Domain.Uow
{
    public interface IUnitOfWorkCompleteHandle:IDisposable
    {
        void Complete();

        Task CompleteAsync();
    }
}