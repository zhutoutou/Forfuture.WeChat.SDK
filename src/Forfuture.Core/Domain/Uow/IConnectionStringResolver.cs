using System.Collections.Generic;

namespace Forfuture.Core.Domain.Uow
{
    public interface IConnectionStringResolver
    {
        /// <summary>
        /// Gets a connection string name (in config file) or a valid connection string.
        /// </summary>
        /// <param name="args">Arguments that can be used while resolving connection string.</param>
        string GetNameOrConnectionString(Dictionary<string, object> args);
    }
}