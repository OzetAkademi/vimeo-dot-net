using JetBrains.Annotations;
using Newtonsoft.Json;
using System;

namespace VimeoDotNet.Models;

/// <summary>
/// Class ProgressiveItem.
/// </summary>
public class ProgressiveItem
{
    /// <summary>
    /// Gets or sets the type.
    /// </summary>
    /// <value>The type.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or sets the codec.
    /// </summary>
    /// <value>The codec.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "codec")]
    public string Codec { get; set; }

    /// <summary>
    /// Gets or sets the width.
    /// </summary>
    /// <value>The width.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "width")]
    public int Width { get; set; }

    /// <summary>
    /// Gets or sets the height.
    /// </summary>
    /// <value>The height.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "height")]
    public int Height { get; set; }

    /// <summary>
    /// Gets or sets the link expiration time.
    /// </summary>
    /// <value>The link expiration time.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "link_expiration_time")]
    public DateTime LinkExpirationTime { get; set; }

    /// <summary>
    /// Gets or sets the link.
    /// </summary>
    /// <value>The link.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "link")]
    public string Link { get; set; }

    /// <summary>
    /// Gets or sets the created time.
    /// </summary>
    /// <value>The created time.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "created_time")]
    public DateTime CreatedTime { get; set; }

    /// <summary>
    /// Gets or sets the FPS.
    /// </summary>
    /// <value>The FPS.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "fps")]
    public double Fps { get; set; }

    /// <summary>
    /// Gets or sets the size.
    /// </summary>
    /// <value>The size.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "size")]
    public long Size { get; set; }

    /// <summary>
    /// Gets or sets the MD5.
    /// </summary>
    /// <value>The MD5.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "md5")]
    public string Md5 { get; set; }

    /// <summary>
    /// Gets or sets the rendition.
    /// </summary>
    /// <value>The rendition.</value>
    [PublicAPI]
    [JsonProperty(PropertyName = "rendition")]
    public string Rendition { get; set; }
}