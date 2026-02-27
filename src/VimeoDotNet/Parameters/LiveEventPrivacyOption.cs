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
    /// The event doesn't appear on Vimeo, but it can be embedded on other sites.
    /// </summary>
    [ParameterValue("embed_only")]
    Disable,

    /// <summary>
    /// Just the video owner.
    /// </summary>
    [ParameterValue("nobody")]
    Nobody,

    /// <summary>
    /// Anyone on this team can access the event. Appears as "Anyone at Company" on the Vimeo front end.
    /// </summary>
    [ParameterValue("team")]
    Team
}