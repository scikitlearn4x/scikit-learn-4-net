namespace SkLearn.Core
{
    /// <summary>
    /// A custom exception that provides information on what went wrong in the library general processing.
    /// </summary>
    public class ScikitLearnCoreException : Exception
    {
        /// <summary>
        /// Instantiate a new exception object.
        /// <param name="message">The content of the error.</param>
        /// </summary>
        public ScikitLearnCoreException(String message) : base(message)
        {
            
        }
    }
}