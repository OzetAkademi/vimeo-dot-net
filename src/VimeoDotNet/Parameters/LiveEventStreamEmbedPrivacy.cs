using VimeoDotNet.Enums;

namespace VimeoDotNet.Parameters;

/// <summary>
/// The embed permission level for the event stream.
/// </summary>
public enum LiveEventStreamEmbedPrivacy
{
    /// <summary>
    /// Only the user can embed the event.
    /// </summary>
    [ParameterValue("private")]
    Private,

    /// <summary>
    /// Anyone can embed the event.
    /// </summary>
    [ParameterValue("public")]
    Public,

    /// <summary>
    /// Only specified domains can embed the event.
    /// </summary>
    [ParameterValue("whitelist")]
    Whitelist
}
