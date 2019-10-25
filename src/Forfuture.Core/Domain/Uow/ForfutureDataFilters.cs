using Forfuture.Core.Domain.Entities;

namespace Forfuture.Core.Domain.Uow
{
    public static class ForfutureDataFilters
    {
        /// <summary>
        /// "SoftDelete".
        /// Soft delete filter.
        /// Prevents getting deleted data from database.
        /// See <see cref="ISoftDelete"/> interface.
        /// </summary>
        public const string SoftDelete = "SoftDelete";
    }
}