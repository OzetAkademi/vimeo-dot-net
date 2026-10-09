using JetBrains.Annotations;
using Newtonsoft.Json;

namespace VimeoDotNet.Models;

/// <summary>
/// Privacy settings of a live event's streams.
/// </summary>
public class StreamPrivacy
{
    /// <summary>
    /// Who can view the stream. Maps to <c>view</c>.
    /// </summary>
    [PublicAPI]
    [JsonProperty("view")]
    public string View { get; set; }

    /// <summary>
    /// Where the stream can be embedded. Maps to <c>embed</c>.
    /// </summary>
    [PublicAPI]
    [JsonProperty("embed")]
    [CanBeNull]
    public string Embed { get; set; }

    /// <summary>
    /// The hash for unlisted streams. Maps to <c>unlisted_hash</c>.
    /// </summary>
    [PublicAPI]
    [JsonProperty("unlisted_hash")]
    [CanBeNull]
    public string UnlistedHash { get; set; }
}
