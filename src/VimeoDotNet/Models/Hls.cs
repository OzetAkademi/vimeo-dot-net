using JetBrains.Annotations;
using Newtonsoft.Json;
using System;

namespace VimeoDotNet.Models;

/// <summary>
/// Class Hls.
/// </summary>
public class Hls
{
    /// <summary>
    /// Gets or sets the link expiration time.
    /// </summary>
    /// <value>The link expiration time.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "link_expiration_time")]
    [CanBeNull]
    public DateTime? LinkExpirationTime { get; set; }

    /// <summary>
    /// Gets or sets the link.
    /// </summary>
    /// <value>The link.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "link")]
    [CanBeNull]
    public string Link { get; set; }
}