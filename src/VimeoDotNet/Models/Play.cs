using JetBrains.Annotations;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VimeoDotNet.Models;

/// <summary>
/// Class Play.
/// </summary>
public class Play
{
    /// <summary>
    /// Gets or sets the progressive.
    /// </summary>
    /// <value>The progressive.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "progressive")]
    public List<ProgressiveItem> Progressive { get; set; }

    /// <summary>
    /// Gets or sets the HLS.
    /// </summary>
    /// <value>The HLS.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "hls")]
    public Hls Hls { get; set; }

    /// <summary>
    /// Gets or sets the dash.
    /// </summary>
    /// <value>The dash.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "dash")]
    public Dash Dash { get; set; }

    /// <summary>
    /// Gets or sets the status.
    /// </summary>
    /// <value>The status.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "status")]
    [CanBeNull]
    public string Status { get; set; }
}
