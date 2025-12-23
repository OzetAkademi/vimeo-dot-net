using VimeoDotNet.Enums;

namespace VimeoDotNet.Parameters;

/// <summary>
/// Live event content rating
/// </summary>
public enum LiveEventContentRating
{
    /// <summary>
    /// Safe for all audiences
    /// </summary>
    [ParameterValue("safe")]
    Safe,

    /// <summary>
    /// Unrated
    /// </summary>
    [ParameterValue("unrated")]
    Unrated,

    /// <summary>
    /// Nudity
    /// </summary>
    [ParameterValue("nudity")]
    Nudity,

    /// <summary>
    /// Language
    /// </summary>
    [ParameterValue("language")]
    Language,

    /// <summary>
    /// Violence
    /// </summary>
    [ParameterValue("violence")]
    Violence,

    /// <summary>
    /// Drugs
    /// </summary>
    [ParameterValue("drugs")]
    Drugs
}