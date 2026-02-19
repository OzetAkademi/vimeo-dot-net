using JetBrains.Annotations;
using Newtonsoft.Json;

namespace VimeoDotNet.Models;

/// <summary>
/// Video live embed logos
/// </summary>
public class VideoLiveEmbedLogos
{
    /// <summary>
    /// Gets or sets a value indicating whether Vimeo logo is shown.
    /// </summary>
    /// <value><c>true</c> if Vimeo logo is shown; otherwise, <c>false</c>.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "vimeo")]
    public bool Vimeo { get; set; }

    /// <summary>
    /// Gets or sets the custom logo settings.
    /// </summary>
    /// <value>The custom logo settings.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "custom")]
    [CanBeNull]
    public VideoLiveEmbedCustomLogo Custom { get; set; }
}

/// <summary>
/// Video live embed custom logo
/// </summary>
public class VideoLiveEmbedCustomLogo
{
    /// <summary>
    /// Gets or sets a value indicating whether the custom logo is active.
    /// </summary>
    /// <value><c>true</c> if the custom logo is active; otherwise, <c>false</c>.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "active")]
    public bool Active { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether to use link.
    /// </summary>
    /// <value><c>true</c> if link should be used; otherwise, <c>false</c>.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "use_link")]
    public bool UseLink { get; set; }

    /// <summary>
    /// Gets or sets the link.
    /// </summary>
    /// <value>The link.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "link")]
    [CanBeNull]
    public string Link { get; set; }

    /// <summary>
    /// Gets or sets the URL.
    /// </summary>
    /// <value>The URL.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "url")]
    [CanBeNull]
    public string Url { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the logo is sticky.
    /// </summary>
    /// <value><c>true</c> if the logo is sticky; otherwise, <c>false</c>.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "sticky")]
    public bool Sticky { get; set; }
}

