using VimeoDotNet.Enums;

namespace VimeoDotNet.Parameters;

/// <summary>
/// The preferred streaming method for a live event.
/// </summary>
public enum LiveEventStreamMethod
{
    /// <summary>
    /// Stream in the browser.
    /// </summary>
    [ParameterValue("browser")]
    Browser,

    /// <summary>
    /// Stream by the encoder.
    /// </summary>
    [ParameterValue("encoder")]
    Encoder
}
