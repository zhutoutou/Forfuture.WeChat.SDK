﻿namespace Forfuture.Core.Domain.Uow
{
    /// <summary>
    /// Used to get/set current <see cref="IUnitOfWork"/>. 
    /// </summary>
    public interface ICurrentUnitWorkProvider
    {
        /// <summary>
        /// Gets/sets current <see cref="IUnitOfWork"/>.
        /// Setting to null returns back to outer unit of work where possible.
        /// </summary>
        IUnitOfWork Current { get; set; }
    }
}