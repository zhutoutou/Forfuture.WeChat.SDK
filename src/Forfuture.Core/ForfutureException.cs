using System;
using System.Runtime.Serialization;

namespace Forfuture.Core
{
    /// <summary>
    /// Base exception type for those are thrown by FF system for FF specific exceptions.
    /// </summary>
    [Serializable]
    public class ForfutureException:Exception
    {
        /// <summary>
        /// Creates a new <see cref="ForfutureException"/> object.
        /// </summary>
        public ForfutureException()
        {

        }

        /// <summary>
        /// Creates a new <see cref="ForfutureException"/> object.
        /// </summary>
        public ForfutureException(SerializationInfo serializationInfo, StreamingContext context)
            : base(serializationInfo, context)
        {

        }

        /// <summary>
        /// Creates a new <see cref="ForfutureException"/> object.
        /// </summary>
        /// <param name="message">Exception message</param>
        public ForfutureException(string message)
            : base(message)
        {

        }

        /// <summary>
        /// Creates a new <see cref="ForfutureException"/> object.
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <param name="innerException">Inner exception</param>
        public ForfutureException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}