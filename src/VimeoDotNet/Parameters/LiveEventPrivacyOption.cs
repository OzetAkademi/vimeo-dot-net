using VimeoDotNet.Enums;

namespace VimeoDotNet.Parameters;

/// <summary>
/// Live event privacy option
/// </summary>
public enum LiveEventPrivacyOption
{
    /// <summary>
    /// Anyone
    /// </summary>
    [ParameterValue("anybody")]
    Anybody,

    /// <summary>
    /// Anyone with the video's password.
    /// </summary>
    [ParameterValue("password")]
    Password,

    /// <summary>
    /// Specifies that the item is unlisted and not publicly discoverable.
    /// </summary>
    /// <remarks>Use this value to indicate that the item should not appear in public listings or
    /// search results. The item may still be accessible via a direct link.
    /// Anyone with the video's URL.
    /// </remarks>
    [ParameterValue("unlisted")]
    Unlisted,

    /// <summary>
    /// Specifies that the parameter value is restricted to embedded content only.
    /// No one on Vimeo, but the video can still be embedded on external sites.
    /// <remarks>On frontend this is labeled as embed_only</remarks>
    /// </summary>
    [ParameterValue("disable")]
    Disable,

    /// <summary>
    /// Just the video owner.
    /// </summary>
    [ParameterValue("nobody")]
    Nobody
}