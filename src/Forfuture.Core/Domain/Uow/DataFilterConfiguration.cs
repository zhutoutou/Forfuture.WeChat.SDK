using System.Collections.Generic;

namespace Forfuture.Core.Domain.Uow
{
    public class DataFilterConfiguration
    {
        public DataFilterConfiguration(string filterName, bool isEnabled)
        {
            FilterName = filterName;
            IsEnabled = isEnabled;
            FilterParameters = new Dictionary<string, object>();
        }

        /// <summary>
        /// The name of filter.
        /// </summary>
        public string FilterName { get; }

        /// <summary>
        /// Is the Filter Enabled.
        /// </summary>
        public bool IsEnabled { get; }

        public IDictionary<string, object> FilterParameters { get; }

        internal DataFilterConfiguration(DataFilterConfiguration filterToClone, bool? isEnabled = null)
            : this(filterToClone.FilterName, isEnabled ?? filterToClone.IsEnabled)
        {
            foreach (var filterParameter in filterToClone.FilterParameters)
            {
                FilterParameters[filterParameter.Key] = filterParameter.Value;
            }
        }
    }
}