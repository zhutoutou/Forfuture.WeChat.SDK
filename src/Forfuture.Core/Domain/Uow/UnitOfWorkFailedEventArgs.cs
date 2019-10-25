using System;

namespace Forfuture.Core.Domain.Uow
{
    public class UnitOfWorkFailedEventArgs:EventArgs
    {
        public UnitOfWorkFailedEventArgs(Exception exception)
        {
            Exception = exception;
        }

        public  Exception Exception { get; }
    }
}