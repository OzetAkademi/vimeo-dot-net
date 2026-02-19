using JetBrains.Annotations;
using Newtonsoft.Json;

namespace VimeoDotNet.Models;

/// <summary>
/// Video live embed colors
/// </summary>
public class VideoLiveEmbedColors
{
    /// <summary>
    /// Gets or sets color one.
    /// </summary>
    /// <value>Color one.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "color_one")]
    [CanBeNull]
    public string ColorOne { get; set; }

    /// <summary>
    /// Gets or sets color two.
    /// </summary>
    /// <value>Color two.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "color_two")]
    [CanBeNull]
    public string ColorTwo { get; set; }

    /// <summary>
    /// Gets or sets color three.
    /// </summary>
    /// <value>Color three.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "color_three")]
    [CanBeNull]
    public string ColorThree { get; set; }

    /// <summary>
    /// Gets or sets color four.
    /// </summary>
    /// <value>Color four.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "color_four")]
    [CanBeNull]
    public string ColorFour { get; set; }
}

