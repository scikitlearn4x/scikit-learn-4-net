using System;

namespace SkLearn.Core.Libraries.Numpy
{
    /// <summary>
    /// A custom exception that provides information on what went wrong in numpy's processing.
    /// </summary>
    public class NumpyOperationException : Exception
    {
        /// <summary>
        /// Instantiate a new exception object.
        /// <param name="message">The content of the error.</param>
        /// </summary>
        public NumpyOperationException(String message) : base(message)
        {
        }
    }
}