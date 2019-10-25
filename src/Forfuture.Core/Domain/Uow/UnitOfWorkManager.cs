using System;
using Microsoft.Extensions.DependencyInjection;
using System.Transactions;

namespace Forfuture.Core.Domain.Uow
{
    public class UnitOfWorkManager : IUnitOfWorkManager
    {
        private readonly ICurrentUnitWorkProvider _currentUnitWorkProvider;

        private readonly IUnitOfWorkDefaultOptions _defaultOptions;

        private readonly IServiceProvider _provider;
        /// <inheritdoc/>
        public IActiveUnitOfWork Current => _currentUnitWorkProvider.Current;

        public UnitOfWorkManager(
            ICurrentUnitWorkProvider currentUnitWorkProvider, 
            IUnitOfWorkDefaultOptions defaultOptions, 
            IServiceProvider provider)
        {
            _currentUnitWorkProvider = currentUnitWorkProvider;
            _defaultOptions = defaultOptions;
            _provider = provider;
        }



        public IUnitOfWorkCompleteHandle Begin()
        {
            retun
        }

        public IUnitOfWorkCompleteHandle Begin(TransactionScopeOption scope)
        {
            throw new System.NotImplementedException();
        }

        public IUnitOfWorkCompleteHandle Begin(UnitOfWorkOptions options)
        {
            options.FillDefaultsForNonProvidedOptions(_defaultOptions);

            var outerUow = _currentUnitWorkProvider.Current;

            if (options.Scope == TransactionScopeOption.Required && outerUow != null)
            {
                return new InnerUnitOfWorkCompleteHandle();
            }

            var uow = _provider.GetServices<IUnitOfWork>();
        }
    }
}