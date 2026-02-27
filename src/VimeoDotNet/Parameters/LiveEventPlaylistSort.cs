using VimeoDotNet.Enums;

namespace VimeoDotNet.Parameters;

/// <summary>
/// The order in which the videos of the event appear within the event's playlist.
/// </summary>
public enum LiveEventPlaylistSort
{
    /// <summary>
    /// The most recently added videos appear first.
    /// </summary>
    [ParameterValue("added_first")]
    AddedFirst,

    /// <summary>
    /// The most recently added videos appear last.
    /// </summary>
    [ParameterValue("added_last")]
    AddedLast,

    /// <summary>
    /// The videos appear in alphabetical order.
    /// </summary>
    [ParameterValue("alphabetical")]
    Alphabetical,

    /// <summary>
    /// The videos appear in the order in which the user has arranged them.
    /// </summary>
    [ParameterValue("arranged")]
    Arranged,

    /// <summary>
    /// The videos appear in order of number of comments.
    /// </summary>
    [ParameterValue("comments")]
    Comments,

    /// <summary>
    /// The videos appear in order of duration.
    /// </summary>
    [ParameterValue("duration")]
    Duration,

    /// <summary>
    /// The videos appear in order of number of likes.
    /// </summary>
    [ParameterValue("likes")]
    Likes,

    /// <summary>
    /// The newest videos appear first.
    /// </summary>
    [ParameterValue("newest")]
    Newest,

    /// <summary>
    /// The oldest videos appear first.
    /// </summary>
    [ParameterValue("oldest")]
    Oldest,

    /// <summary>
    /// The videos appear in order of number of plays.
    /// </summary>
    [ParameterValue("plays")]
    Plays
}
