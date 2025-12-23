using VimeoDotNet.Enums;

namespace VimeoDotNet.Parameters;

/// <summary>
/// Live event privacy option
/// </summary>
public enum LiveEventPrivacyOption
{
    /// <summary>
    /// Anybody
    /// </summary>
    [ParameterValue("anybody")]
    Anybody,

    /// <summary>
    /// Password
    /// </summary>
    [ParameterValue("password")]
    Password,

    /// <summary>
    /// Specifies that the item is unlisted and not publicly discoverable.
    /// </summary>
    /// <remarks>Use this value to indicate that the item should not appear in public listings or
    /// search results. The item may still be accessible via a direct link.</remarks>
    [ParameterValue("unlisted")]
    Unlisted,

    /// <summary>
    /// Specifies that the parameter value is restricted to embedded content only.
    /// </summary>
    [ParameterValue("embed_only")]
    EmbedOnly,

    /// <summary>
    /// Only people I follow
    /// </summary>
    [ParameterValue("nobody")]
    Nobody
}