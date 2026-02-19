using JetBrains.Annotations;
using Newtonsoft.Json;

namespace VimeoDotNet.Models;

/// <summary>
/// Live event M3U8 playback response
/// </summary>
public class LiveEventM3U8Playback
{
    /// <summary>
    /// Gets or sets the M3U8 playback URL.
    /// </summary>
    /// <value>The M3U8 playback URL.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "m3u8_playback_url")]
    [CanBeNull]
    public string M3U8PlaybackUrl { get; set; }
}

