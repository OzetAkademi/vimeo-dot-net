using System.Collections.Generic;

namespace VimeoDotNet.Parameters;

/// <summary>
/// Class ParameterDictionary.
/// Implements the <see cref="System.Collections.Generic.Dictionary{System.String, System.String}" />
/// Implements the <see cref="VimeoDotNet.Parameters.IParameterProvider" />
/// </summary>
/// <seealso cref="System.Collections.Generic.Dictionary{System.String, System.String}" />
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