namespace SkLearn.Core
{
    /// <summary>
    /// A custom exception that indicates a feature has not been implemented yet.
    /// </summary>
    public class ScikitLearnFeatureNotImplementedException : Exception
    {
        /// <summary>
        /// Instantiate a new exception object.
        /// </summary>
        public ScikitLearnFeatureNotImplementedException() : base("This feature has not yet been implemented.")
        {
        }

        /// <summary>
        /// Instantiate a new exception object.
        /// <param name="message">The content of the error.</param>
        /// </summary>
        public ScikitLearnFeatureNotImplementedException(String message)
        {
        }
    }
}