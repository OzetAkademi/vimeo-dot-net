using System.Collections.Generic;

namespace VimeoDotNet.Parameters;

/// <summary>
/// Class ParameterDictionary.
/// Implements the <see cref="Dictionary{TKey, TValue}" />
/// Implements the <see cref="VimeoDotNet.Parameters.IParameterProvider" />
/// </summary>
/// <seealso cref="Dictionary{TKey, TValue}" />
/// <seealso cref="VimeoDotNet.Parameters.IParameterProvider" />
public class ParameterDictionary : Dictionary<string, string>, IParameterProvider
{
    /// <inheritdoc />
    public string ValidationError()
    {
        return null;
    }

    /// <inheritdoc />
    public IDictionary<string, string> GetParameterValues()
    {
        return this;
    }
}