using System;

namespace SkLearn.Core.Libraries.Numpy
{
    /// <summary>
    /// INumpyArray provides an abstraction for NumpyArray to get the wrapper object without specifying the
    /// actual element type.
    /// </summary>
    public interface INumpyArray
    {
        /// <summary>
        /// Gets the underlying native Array object.
        /// </summary>
        /// <returns>The underlying native Array object.</returns>
        Array GetUnderlyingArray();
    }
}